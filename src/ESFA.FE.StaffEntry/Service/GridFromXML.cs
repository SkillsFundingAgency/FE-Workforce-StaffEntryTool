using System;
using System.Linq;
using System.Windows.Forms;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using Message = ESFA.DC.FEW.FileProcessingService.Model.Loose.Message;

namespace ESFA.FE.StaffEntry.Service
{
    public class GridFromXML
    {
        private readonly DataGridView _grid;

        private readonly ColumnToModelMapper _mapper;

        internal GridFromXML(DataGridView grid, ColumnToModelMapper mapper)
        {
            _grid = grid;
            _mapper = mapper;
        }

        public void CreateGridFromData(Message message)
        {
            _grid.Rows.Clear();
            foreach (var staff in message.StaffData)
            {
                int rowIndex = _grid.Rows.Add();

                foreach (DataGridViewCell cell in _grid.Rows[rowIndex].Cells)
                {
                    if (cell.OwningColumn.Name.StartsWith("MessageStaffData_"))
                    {
                        var name = cell.OwningColumn.Name.Replace("MessageStaffData_", string.Empty);
                        SetValueInGrid(typeof(MessageStaffData), staff, name, cell);
                    }
                    else if (cell.OwningColumn.Name.StartsWith("MessageStaffDataRole_Role"))
                    {
                        var names = cell.OwningColumn.Name.Split('_')[2];
                        cell.Value = staff.Role?.Any(x => x.Role == int.Parse(names));
                    }
                    else if (cell.OwningColumn.Name.StartsWith("MessageStaffDataTeacherData_"))
                    {
                        MessageStaffDataTeacherData teacher = null;
                        if (staff.TeacherData != null)
                        {
                            teacher = staff.TeacherData.First();
                        }

                        if (teacher != null)
                        {
                            var name = cell.OwningColumn.Name.Replace("MessageStaffDataTeacherData_", string.Empty);
                            SetValueInGrid(typeof(MessageStaffDataTeacherData), teacher, name, cell);
                        }
                    }
                    else if (cell.OwningColumn.Name.StartsWith("MessageStaffDataMainContract_"))
                    {
                        MessageStaffDataMainContract contract = null;
                        if (staff.MainContract != null)
                        {
                            contract = staff.MainContract.First();
                        }

                        if (contract != null)
                        {
                            var name = cell.OwningColumn.Name.Replace("MessageStaffDataMainContract_", string.Empty);
                            SetValueInGrid(typeof(MessageStaffDataMainContract), contract, name, cell);
                        }
                    }
                }
            }
        }

        private void SetValueInGrid(Type type, object instance, string propName, DataGridViewCell cell)
        {
            var propValue = type.GetProperty(propName)?.GetValue(instance);

            if (propValue == null)
            {
                return;
            }

            if (_mapper.FieldTypeNeedsACodeLookup(propName))
            {
                cell.Value = _mapper.MapFieldNameCodeToValue(propName, int.Parse(propValue.ToString()));
            }
            else
            {
                if (propValue is DateTime propValueDt)
                {
                    propValue = propValueDt.ToString("d");
                }

                cell.Value = propValue;
            }
        }
    }
}
