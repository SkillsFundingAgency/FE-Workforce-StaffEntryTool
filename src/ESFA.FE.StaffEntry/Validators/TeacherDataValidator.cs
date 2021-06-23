using System.Windows.Forms;

namespace ESFA.FE.StaffEntry.Validators
{
    public sealed class TeacherDataValidator
    {
        private readonly DataGridView _grid;

        public TeacherDataValidator(DataGridView grid)
        {
            _grid = grid;
        }

        internal void ValidateRowFromCellChange(int columnIndex, int rowIndex)
        {
            switch (_grid.Columns[columnIndex].HeaderText)
            {
                case "MainRole":
                case "IsTeacher":
                    CheckTeacherRoleAndTeacherDataTogether(rowIndex);
                    break;
            }

            if (IsATeacherDataColumn(_grid.Columns[columnIndex]))
            {
                CheckTeacherRoleAndTeacherDataTogether(rowIndex);
            }
        }

        private static bool IsATeacherDataColumn(DataGridViewColumn column)
        {
            return column.Name.StartsWith("MessageStaffDataTeacherData_");
        }

        private void CheckTeacherRoleAndTeacherDataTogether(int rowIndex)
        {
            bool mainRoleSetToTeacher = GridSimpleHelper.SafeValueString(MainRoleCell(rowIndex)) == "Teacher";
            bool isTeacherSelected = IsTeacherSelected(rowIndex);
            bool allTeacherDataColumnsHaveValues = AllTeacherDataSupplied(rowIndex);
            bool anyTeacherDataColumnsHaveValues = AnyTeacherDataSupplied(rowIndex);

            // now use a three way truth table
            // MR | Is Teach | TeachData|
            // ---|----------|----------|
            //  Y |   Y Ok   | Y        |
            //  Y |   N Error| Y        |
            //  Y |   N Error| N Error  |
            //  N |   N Ok   | N Ok     |
            //  N |   N Error| Y        |
            //  N |   Y      | N Error  |
            IsTeacherCell(rowIndex).ErrorText = null;
            CheckToSeeTeacherDataProvided(mainRoleSetToTeacher || isTeacherSelected, rowIndex);

            if (mainRoleSetToTeacher)
            {
                if (!isTeacherSelected)
                {
                    var c = IsTeacherCell(rowIndex);
                    c.ErrorText = "'Is teacher' must be selected if main role is also teacher";
                }

                if (!allTeacherDataColumnsHaveValues)
                {
                    CheckToSeeTeacherDataProvided(true, rowIndex);
                }
            }
            else
            {
                if (isTeacherSelected)
                {
                    if (!allTeacherDataColumnsHaveValues)
                    {
                        CheckToSeeTeacherDataProvided(true, rowIndex);
                    }
                }
                else if (anyTeacherDataColumnsHaveValues)
                {
                    var c = IsTeacherCell(rowIndex);
                    c.ErrorText = "'Is teacher' must be selected if teacher data supplied";
                    CheckToSeeTeacherDataProvided(false, rowIndex);
                }
            }
        }

        private void ClearErrorAllTeacherColumns(int rowIndex)
        {
            var c = IsTeacherCell(rowIndex);
            c.ErrorText = null;
            foreach (DataGridViewColumn column in _grid.Columns)
            {
                if (column.Name.StartsWith("MessageStaffDataTeacherData_"))
                {
                    var cell = _grid[column.Index, rowIndex];
                    cell.ErrorText = null;
                }
            }
        }

        private bool AllTeacherDataSupplied(int rowIndex)
        {
            bool result = true;

            // find all appropriate columns
            foreach (DataGridViewColumn column in _grid.Columns)
            {
                if (column.Name.StartsWith("MessageStaffDataTeacherData_"))
                {
                    var cell = _grid[column.Index, rowIndex];
                    if (cell.Value == null)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private bool AnyTeacherDataSupplied(int rowIndex)
        {
            bool result = false;

            // find all appropriate columns
            foreach (DataGridViewColumn column in _grid.Columns)
            {
                if (column.Name.StartsWith("MessageStaffDataTeacherData_"))
                {
                    var cell = _grid[column.Index, rowIndex];
                    if (cell.Value != null)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        private void CheckToSeeTeacherDataProvided(bool required, int rowIndex)
        {
            // find all appropriate columns
            foreach (DataGridViewColumn column in _grid.Columns)
            {
                if (!IsATeacherDataColumn(column))
                {
                    continue;
                }

                var cell = _grid[column.Index, rowIndex];
                if (required && cell.Value == null)
                {
                    cell.ErrorText = "Value required for teachers";
                }
                else if (!required && cell.Value != null)
                {
                    cell.ErrorText = "Value not required for non-teachers";
                }
                else
                {
                    cell.ErrorText = null;
                }
            }
        }

        /// <summary>
        ///  The IsTeacher Column should be checked.
        /// </summary>
        /// <param name="required">Flag indicating whether it is required.</param>
        /// <param name="rowIndex">The row index to check.</param>
        private void CheckToSeeIfTeacherRoleSelected(bool required, int rowIndex)
        {
            if (IsTeacherSelected(rowIndex) != required)
            {
                var c = IsTeacherCell(rowIndex);
                c.ErrorText = "Is teacher must be selected";
            }
        }

        private bool IsTeacherSelected(int rowIndex)
        {
            var v = IsTeacherCell(rowIndex).Value;
            if (v == null)
            {
                return false;
            }

            if (bool.TryParse(v.ToString(), out bool result))
            {
                return result;
            }

            return false;
        }

        private DataGridViewCell IsTeacherCell(int rowIndex)
        {
            return _grid["MessageStaffDataRole_Role_3", rowIndex];
        }

        private DataGridViewCell MainRoleCell(int rowIndex)
        {
            return _grid["MessageStaffData_MainRole", rowIndex];
        }
    }
}
