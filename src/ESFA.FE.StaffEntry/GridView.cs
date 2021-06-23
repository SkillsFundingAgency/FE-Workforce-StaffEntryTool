using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using ESFA.DC.FEW.FileProcessingService.Model.ValidationError.Model;
using ESFA.DC.Serialization.Xml;
using ESFA.FE.StaffEntry.Control;
using ESFA.FE.StaffEntry.Models;
using ESFA.FE.StaffEntry.Service;
using ESFA.FEW.StaffEntry.Validation.Interfaces;
using Message = ESFA.DC.FEW.FileProcessingService.Model.Loose.Message;

namespace ESFA.FE.StaffEntry
{
    public partial class GridView : Form
    {
        private const string Date_Message = "Please enter valid date in the format of dd/M/yyyy";

        private readonly IStaffValidationService _staffValidationService;

        private readonly ColumnToModelMapper _mapper;

        private readonly IValidationMessagesProvider _validationMessagesProvider;

        private DataGridViewRow _clonedRow;

        private volatile bool _canValidateCells = true;

        private readonly string[] _skippableStrings = { string.Empty, "N/A" };

        private HashSet<string> _numericColumnNames = new HashSet<string>()
        {
            "MessageStaffDataMainContract_WeekContractedHours",
            "MessageStaffDataMainContract_AnnualSalary",
        };

        private HashSet<string> _decimalColumnNames = new HashSet<string>()
        {
            "MessageStaffData_FTE",
            "MessageStaffDataMainContract_HourlyRate"
        };

        private CancellationTokenSource cancellationTokenSource;

        public GridView(
            IStaffValidationService staffValidationService,
            ColumnToModelMapper mapper,
            IValidationMessagesProvider validationMessagesProvider)
        {
            _staffValidationService = staffValidationService;
            InitializeComponent();
            _mapper = mapper;
            _validationMessagesProvider = validationMessagesProvider;
            PopulateComboColumnsBasedOnControlValueLists();
            ApplicationVersion.Text = $"Application Version: {Assembly.GetEntryAssembly().GetName().Version}";
        }

        private void PopulateComboColumnsBasedOnControlValueLists()
        {
            foreach (var column in grid.Columns)
            {
                Type ct = column.GetType();
                if (ct != typeof(DataGridViewComboBoxColumn))
                {
                    continue;
                }

                DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)column;
                int maxWidth = combo.Width;
                if (_mapper.ColumnHasCodes(combo.Name))
                {
                    combo.Items.Clear();
                    // use of add range and similar is problematic :)
                    foreach (var s in _mapper.ControlItems(combo.Name))
                    {
                        combo.Items.Add(s);
                        // the technique of adding 'WW' to the meqasurement string will allow for DPI changes and similar
                        // that a harcoded value (e.g. 20) would not
                        maxWidth = Math.Max(maxWidth, TextRenderer.MeasureText(s + "WW", Font).Width);
                    }
                }

                combo.Width = maxWidth;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        // copy/paste needs to take into account the target - we could even intercept this and 'string match'
        // or apply transforms (one of the UR findings suggested coudl we do that)
        // we're using 'string values' rather than 'code values' as our base for the users
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveWorkforceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData(string fileName = null)
        {
            if (string.IsNullOrEmpty(ukprn.Text))
            {
                MessageBox.Show("Please enter Ukprn", "Invalid Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ukprn.Focus();
                return;
            }

            var message = CreateDataFromGridWithoutReflection();

            if (!message.StaffData.Any())
            {
                MessageBox.Show(
                    "There is no staff data entered. Please enter at least one staff member before saving",
                    "Invalid Form",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var dlg = new SaveFileDialog
            {
                FileName = fileName,
                Filter = "XML|*.xml"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CreateHeader(message);

                using (var fileStream = File.Create(dlg.FileName))
                {
                    var xmlSerialization = new XmlSerializationService();
                    xmlSerialization.Serialize(message, fileStream);
                }
            }
        }

        private Message CreateDataFromGridWithoutReflection()
        {
            var result = new Message();
            List<MessageStaffData> staff = new List<MessageStaffData>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var data = CreateStaffObjectFromGrid(row);

                if (!string.IsNullOrEmpty(data.FirstName) || !string.IsNullOrEmpty(data.LastName))
                {
                    staff.Add(data);
                }
            }

            result.StaffData = staff.ToArray();
            return result;
        }

        private void SetValues(PropertyInfo prop, DataGridViewCell cell, object data)
        {
            if (prop == null)
            {
                return;
            }

            if (_mapper.ColumnHasCodes(cell.OwningColumn.Name))
            {
                var value = _mapper.MapFieldNameValueToCode(prop.Name, cell.Value.ToString());
                prop.SetValue(data, value);
            }
            else
            {
                object value = cell.Value;
                if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?) ||
                    prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(decimal?))
                {
                    value = Regex.Replace(
                        value.ToString()
                        .Replace(NumberFormatInfo.CurrentInfo.CurrencySymbol, string.Empty)
                        .Replace(NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator, string.Empty), @"\s+",
                        string.Empty);
                }

                _mapper.SetObjectProperty(value, data, prop.Name, prop);
            }
        }

        private MessageStaffData CreateStaffObjectFromGrid(DataGridViewRow row)
        {
            var data = new MessageStaffData();
            MessageStaffDataTeacherData teacherData = null;
            MessageStaffDataMainContract mainContract = null;
            List<MessageStaffDataRole> rolesList = new List<MessageStaffDataRole>();

            foreach (DataGridViewCell cell in row.Cells)
            {
                var propName = cell.OwningColumn.Name.Split('_')[1];
                PropertyInfo prop = null;

                if (cell.Value != null)
                {
                    if (cell.OwningColumn.Name.StartsWith("MessageStaffDataTeacherData_") && teacherData == null)
                    {
                        teacherData = new MessageStaffDataTeacherData();
                    }
                    else if (cell.OwningColumn.Name.StartsWith("MessageStaffDataMainContract_") && mainContract == null)
                    {
                        mainContract = new MessageStaffDataMainContract();
                    }

                    if (cell.Value != null && cell.OwningColumn.Name.StartsWith("MessageStaffData_"))
                    {
                        var type = typeof(MessageStaffData);
                        prop = type.GetProperty(propName);
                        SetValues(prop, cell, data);
                    }
                    else if (cell.Value != null && cell.OwningColumn.Name.StartsWith("MessageStaffDataRole_Role_"))
                    {
                        var role = new MessageStaffDataRole();
                        var type = typeof(MessageStaffDataRole);
                        var value = cell.Value;
                        if (value != null && bool.Parse(value.ToString()))
                        {
                            var roleValue = cell.OwningColumn.Name.Split('_')[2];
                            prop = type.GetProperty("Role");
                            prop.SetValue(role, int.Parse(roleValue));
                            rolesList.Add(role);
                        }
                    }
                    else if (cell.OwningColumn.Name.StartsWith("MessageStaffDataTeacherData_"))
                    {
                        var type = typeof(MessageStaffDataTeacherData);
                        prop = type.GetProperty(propName);
                        SetValues(prop, cell, teacherData);
                    }
                    else if (cell.Value != null && cell.OwningColumn.Name.StartsWith("MessageStaffDataMainContract_"))
                    {
                        var type = typeof(MessageStaffDataMainContract);
                        prop = type.GetProperty(propName);
                        SetValues(prop, cell, mainContract);
                    }
                }

                if (teacherData != null)
                {
                    data.TeacherData = new[] { teacherData };
                }

                if (mainContract != null)
                {
                    data.MainContract = new[] { mainContract };
                }
                else
                {
                    data.MainContract = new[] { new MessageStaffDataMainContract() };
                }

                if (rolesList.Any())
                {
                    data.Role = rolesList.ToArray();
                }
            }

            return data;
        }

        private void CreateHeader(Message message)
        {
            message.Header = new MessageHeader
            {
                CollectionDetails = new MessageHeaderCollectionDetails
                {
                    Collection = MessageHeaderCollectionDetailsCollection.FEW,
                    FilePreparationDate = DateTime.Now,
                    Year = MessageHeaderCollectionDetailsYear.Item2021,
                },
                Source = new MessageHeaderSource
                {
                    DateTime = DateTime.Now,
                    ProtectiveMarking = MessageHeaderSourceProtectiveMarking.OFFICIALSENSITIVEPersonal,
                    Release = "0.0.1",
                    SerialNo = "1",
                    SoftwarePackage = "ESFA FEW Data entry",
                    SoftwareSupplier = "ESFA",
                    UKPRN = int.Parse(ukprn.Text)
                },
            };
        }

        private void openWorkforceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void IsNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(GridColumn_KeyPress_Decimal);
            e.Control.KeyPress -= new KeyPressEventHandler(GridColumn_KeyPress_Numeric);

            if (e.Control is TextBox tb)
            {
                if (_decimalColumnNames.Contains(grid.CurrentCell.OwningColumn.Name))
                {
                    tb.KeyPress += new KeyPressEventHandler(GridColumn_KeyPress_Decimal);
                }
                else if (_numericColumnNames.Contains(grid.CurrentCell.OwningColumn.Name))
                {
                    tb.KeyPress += new KeyPressEventHandler(GridColumn_KeyPress_Numeric);
                }
            }
        }

        private void GridColumn_KeyPress_Numeric(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GridColumn_KeyPress_Decimal(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                                           && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex].Name.Equals("MessageStaffDataRole_Role_3"))
            {
                var value = bool.Parse(grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (value == false)
                {
                    foreach (DataGridViewCell cell in grid.Rows[e.RowIndex].Cells)
                    {
                        if (cell.OwningColumn.Name.StartsWith("MessageStaffDataTeacherData_"))
                        {
                            cell.Value = null;
                        }
                    }
                }
            }

            if (grid?.CurrentCell != null)
            {
                if (_decimalColumnNames.Contains(grid.CurrentCell.OwningColumn.Name)) //Desired Column
                {
                    var value = CleanseInputNumber(grid.CurrentCell.Value?.ToString());
                    if (!decimal.TryParse(value, out var decimalValue))
                    {
                        grid.CurrentCell.Value = null;
                    }
                    else
                    {
                        grid.CurrentCell.Value = Math.Round(decimalValue, 2);
                    }
                }
                else if (_numericColumnNames.Contains(grid.CurrentCell.OwningColumn.Name)) //Desired Column
                {
                    var value = CleanseInputNumber(grid.CurrentCell.Value?.ToString());
                    if (!int.TryParse(value, out var intValue))
                    {
                        grid.CurrentCell.Value = null;
                    }
                    else
                    {
                        grid.CurrentCell.Value = intValue;
                    }
                }
            }

            if (!_canValidateCells)
            {
                return;
            }

            cancellationTokenSource?.Cancel();
            cancellationTokenSource = new CancellationTokenSource();

            Thread validationThread = new Thread(IsValidRow);
            validationThread.Start(cancellationTokenSource.Token);
        }

        private string CleanseInputNumber(string value)
        {
            return value?.ToString()?.Replace("£", string.Empty).Replace(",", string.Empty);
        }

        private void IsValidRow(object cancellationTokenObj)
        {
            try
            {
                CancellationToken cancellationToken = CancellationToken.None;
                if (cancellationTokenObj != null)
                {
                    cancellationToken = (CancellationToken)cancellationTokenObj;
                }

                Message staffMessage = CreateDataFromGridWithoutReflection();
                cancellationToken.ThrowIfCancellationRequested();

                List<IValidationError> result = _staffValidationService.ValidateStaffList(staffMessage);
                cancellationToken.ThrowIfCancellationRequested();

                ParallelOptions parallelOptions = new ParallelOptions
                {
                    CancellationToken = cancellationToken,
                    MaxDegreeOfParallelism = Environment.ProcessorCount - 1
                };

                Parallel.ForEach(grid.Rows.Cast<DataGridViewRow>(), parallelOptions, row =>
                {
                    // Clear all cells of error
                    foreach (DataGridViewCell cell in row.Cells.Cast<DataGridViewCell>())
                    {
                        cell.ErrorText = string.Empty;
                    }

                    if (row.IsNewRow)
                    {
                        return;
                    }

                    var rowErrors = result.Where(x => IsSameRowAsEntity(row, x.FirstName, x.LastName, x.DateOfBirth))
                        .ToList();

                    DisplayError(row, rowErrors);
                });
            }
            catch (Exception)
            {
                // Just eat up the error.
            }
        }

        private void ValidateGridRows()
        {
            IsValidRow(null);
        }

        private void DisplayError(DataGridViewRow row, List<IValidationError> errors)
        {
            if (errors.Any())
            {
                var stringBuilder = new StringBuilder();
                foreach (var validationMessage in errors.OrderBy(x => x.Severity))
                {
                    var messageText = _validationMessagesProvider.GetValidationMessage(validationMessage.RuleName)?
                        .Message;
                    var formattedMessageText = $"{validationMessage.Severity} - ({validationMessage.RuleName}) {messageText}";

                    stringBuilder.Append(formattedMessageText);
                    stringBuilder.Append(Environment.NewLine);

                    DisplayCellError(row, validationMessage.RuleName, formattedMessageText);
                }

                row.ErrorText = stringBuilder.ToString();
            }
            else
            {
                row.ErrorText = null;
            }
        }

        private void DisplayCellError(DataGridViewRow row, string ruleName, string message)
        {
            var fieldNames = MapColumnNames(ruleName);

            foreach (var fieldName in fieldNames)
            {
                DataGridViewCell cell = row.Cells
                    .Cast<DataGridViewCell>()
                    .FirstOrDefault(r => r.OwningColumn.Name.EndsWith(fieldName, StringComparison.OrdinalIgnoreCase));

                if (cell != null && string.IsNullOrEmpty(cell.ErrorText))
                {
                    cell.ErrorText = message;
                }
            }
        }

        private bool IsSameRowAsEntity(DataGridViewRow row, string firstName, string lastName, DateTime? dob)
        {
            DateTime.TryParseExact(row.Cells["MessageStaffData_DateOfBirth"].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var cellDob);

            if (string.Equals(row.Cells["MessageStaffData_FirstName"].Value?.ToString(), firstName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(row.Cells["MessageStaffData_LastName"].Value?.ToString(), lastName, StringComparison.OrdinalIgnoreCase) &&
                (cellDob.Date == dob?.Date || !dob.HasValue))
            {
                return true;
            }

            return false;
        }

        private List<string> MapColumnNames(string ruleName)
        {
            var fieldName = ruleName.Split('_')[1];
            var result = new List<string>();

            switch (fieldName.ToLowerInvariant())
            {
                case "maincontract":
                    result.Add("ContractType");
                    break;
                case "weeklycontractedhours":
                    result.Add("WeekContractedHours");
                    break;
                case "uniquestaffmember":
                    result.Add("FirstName");
                    result.Add("LastNameName");
                    result.Add("DateofBirth");
                    break;
                case "teacherdata":
                    result.Add("MainSubjectTaught");
                    result.Add("HighestQualificationTaught");
                    result.Add("HighestQualificationEnglish");
                    result.Add("HighestQualificationMaths");
                    result.Add("HighestTeachingQualification");
                    result.Add("TeacherQualificationStudied");
                    result.Add("TeacherQualificationStudied");
                    result.Add("TeacherQualificationFunding");
                    result.Add("TeacherQualificationFunding");
                    result.Add("ProfessionalTeachingStatus");
                    result.Add("IndustryExperienceDuration");
                    result.Add("CurrentIndustryExperience");
                    break;
                case "campid":
                    result.Add("CampusID");
                    break;
                default:
                    result.Add(fieldName);
                    break;
            }

            return result;
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((grid.Columns[e.ColumnIndex].Name == "MessageStaffData_DateOfBirth" ||
                 grid.Columns[e.ColumnIndex].Name == "MessageStaffData_EmploymentStartDate" ||
                 grid.Columns[e.ColumnIndex].Name == "MessageStaffData_EmploymentEndDate")
                && e.RowIndex > -1 && e.RowIndex != grid.NewRowIndex)
            {
                var cellValue = grid.CurrentCell.Value;
                if (cellValue == null || cellValue.Equals("  /  /"))
                {
                    return;
                }

                //check whether this can be parsed as a date.
                string enteredVal = cellValue.ToString();
                if (DateTime.TryParse(enteredVal, out var dt))
                {
                    grid.CurrentCell.Value = dt.ToString("dd/MM/yyyy");
                    //grid.CurrentCell.ErrorText = null;
                    grid.CurrentCell.OwningRow.ErrorText = null;
                }
                else
                {
                    grid.CurrentCell.ErrorText = Date_Message;
                    grid.CurrentCell.OwningRow.ErrorText = Date_Message;
                }
            }
        }

        private void PasteFromClipBoard()
        {
            try
            {
                grid.SuspendLayout();
                _canValidateCells = false;
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n').Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();

                foreach (string line in lines)
                {
                    int iRow = grid.Rows.Add();

                    string[] sCells = line.Split('\t');
                    for (int i = 0; i < sCells.GetLength(0); ++i)
                    {
                        if (i == grid.ColumnCount)
                        {
                            break;
                        }

                        sCells[i] = sCells[i].Replace("\r", string.Empty);

                        if (_skippableStrings.Contains(sCells[i], StringComparer.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        var oCell = grid[i, iRow];

                        if (oCell.ReadOnly || (oCell.Value != null && oCell.Value.ToString() == sCells[i]))
                        {
                            continue;
                        }

                        if (oCell.EditType == typeof(DataGridViewTextBoxEditingControl))
                        {
                            oCell.Value = Convert.ChangeType(sCells[i], oCell.ValueType);
                        }
                        else if (oCell.EditType == typeof(DataGridViewMaskedTextEditingControl))
                        {
                            var con = Convert.ChangeType(sCells[i], oCell.ValueType);
                            oCell.Value = con;
                        }
                        else if (oCell.EditType == typeof(DataGridViewComboBoxEditingControl))
                        {
                            DataGridViewComboBoxCell comboBoxCell = oCell as DataGridViewComboBoxCell;
                            var items = GetComboBoxItems(comboBoxCell.Items).ToList();
                            var convertedValue = Convert.ChangeType(sCells[i], oCell.ValueType);

                            if (int.TryParse(convertedValue.ToString(), out var code))
                            {
                                if (items.Any(x => x.Code == code))
                                {
                                    comboBoxCell.Value = items.First(x => x.Code == code).ToString();
                                }
                            }
                            else if (convertedValue is string str)
                            {
                                if (items.Any(x => string.Equals(x.ToString(), str, StringComparison.CurrentCultureIgnoreCase)))
                                {
                                    comboBoxCell.Value = items.First(x =>
                                        string.Equals(x.ToString(), str, StringComparison.CurrentCultureIgnoreCase));
                                }
                            }
                        }
                        else if (oCell.OwningColumn.GetType() == typeof(DataGridViewCheckBoxColumn))
                        {
                            DataGridViewCheckBoxCell checkCell = oCell as DataGridViewCheckBoxCell;
                            if (!Enum.TryParse<BooleanAliases>(sCells[i], true, out _))
                            {
                                continue;
                            }

                            var convertedValue = Convert.ChangeType(
                                Enum.Parse(typeof(BooleanAliases), sCells[i]), oCell.ValueType);

                            checkCell.Value = convertedValue;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
            }
            finally
            {
                grid.ResumeLayout();
                _canValidateCells = true;
                ValidateGridRows();
            }
        }

        private IEnumerable<ComboBoxItem> GetComboBoxItems(DataGridViewComboBoxCell.ObjectCollection items)
        {
            return (from ComboBoxItem item in items select new ComboBoxItem(item.ToString(), item.Code)).ToList();
        }

        private void exportForUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void grid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (!(sender is DataGridView dataGridView))
            {
                return;
            }

            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
            if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
            {
                if (dataGridView.CurrentCell != dataGridView[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex])
                {
                    dataGridView.EndEdit();
                    dataGridView.CurrentCell = dataGridView[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex];
                }

                dataGridView.BeginEdit(true);
                if (dataGridView.EditingControl is ComboBox comboBox)
                {
                    comboBox.DroppedDown = true;
                }
            }
            else
            {
                dataGridView.EndEdit();
            }
        }

        private void deleteAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "XML|*.xml";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string content = File.ReadAllText(dlg.FileName);
                XmlSerializationService xmlSerialization =
                    new XmlSerializationService();
                var message =
                    xmlSerialization.Deserialize<Message>(content);

                // turn model into grid
                GridFromXML gridFrom = new GridFromXML(grid, _mapper);

                _canValidateCells = false;
                gridFrom.CreateGridFromData(message);
                ukprn.Text = message.Header.Source.UKPRN.ToString();
                ValidateGridRows();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to open the file. Please check the file and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _canValidateCells = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Export()
        {
            SaveData($"FEW-{ukprn.Text}-2021-{DateTime.Now:yyyyMMdd-HHmmss}-01.XML");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteAllData();
        }

        private void DeleteAllData()
        {
            if (MessageBox.Show(
                "Are you sure all data in the grid should be deleted?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            grid.Rows.Clear();
        }

        private void copyToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteItemToolStripMenuPasteItem_Click(object sender, EventArgs e)
        {
            PasteSimple();
        }

        private void toolStripButtonPasteItem_Click(object sender, EventArgs e)
        {
            PasteSimple();
        }

        private void pasteAsnewRowsToolStripMenuPasteAsNewRows_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void toolStripButtonPasteNewRows_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void Copy()
        {
            try
            {
                _clonedRow = grid.SelectedRows.Cast<DataGridViewRow>()
                    .OrderBy(r => r.Index)
                    .Select(r =>
                    {
                        var clone = r.Clone() as DataGridViewRow;
                        for (int i = 0; i < r.Cells.Count; i++)
                        {
                            clone.Cells[i].Value = r.Cells[i].Value;
                        }

                        return clone;
                    }).FirstOrDefault();

                var allSelectedRows = grid.SelectedRows.Cast<DataGridViewRow>()
                    .OrderBy(r => r.Index)
                    .Select(r =>
                    {
                        var clone = r.Clone() as DataGridViewRow;
                        for (var i = 0; i < r.Cells.Count; i++)
                        {
                            clone.Cells[i].Value = r.Cells[i].Value;
                        }

                        clone.Cells.Add(new DataGridViewButtonCell { Value = '\n' });

                        return clone;
                    });

                Clipboard.Clear();
                var sb = new StringBuilder();
                foreach (var row in allSelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);

                        if (cell.Value?.ToString() != "\n")
                        {
                            sb.Append('\t');
                        }
                    }
                }

                var str = sb.ToString();
                var clipText = str.Replace("\t\n", "\n");

                if (string.IsNullOrEmpty(clipText))
                {
                    sb.Clear();
                    foreach (DataGridViewCell gridSelectedCell in grid.SelectedCells)
                    {
                        sb.Append(gridSelectedCell.Value);
                    }

                    clipText = sb.ToString();
                }

                if (string.IsNullOrEmpty(clipText))
                {
                    return;
                }

                Clipboard.SetText(clipText);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Paste()
        {
            try
            {
                if (_clonedRow == null)
                {
                    PasteFromClipBoard();
                    return;
                }

                grid.Rows.Insert(grid.CurrentCell.RowIndex, _clonedRow);
                _clonedRow = null;
            }
            catch (Exception)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
            }
        }

        private void PasteSimple()
        {
            try
            {
                foreach (DataGridViewCell gridSelectedCell in grid.SelectedCells)
                {
                    gridSelectedCell.Value = Clipboard.GetText();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to paste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonDeleteRow_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }

        private void deleteSelectedRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }

        private void DeleteSelectedRows()
        {
            try
            {
                grid.SuspendLayout();
                while (grid.SelectedRows.Count > 0)
                {
                    grid.Rows.RemoveAt(grid.SelectedRows[0].Index);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete selected rows", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                grid.ResumeLayout();
            }
        }
    }
}
