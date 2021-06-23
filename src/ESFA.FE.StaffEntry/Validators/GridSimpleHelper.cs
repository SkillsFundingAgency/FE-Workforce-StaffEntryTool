using System.Windows.Forms;

namespace ESFA.FE.StaffEntry.Validators
{
    class GridSimpleHelper
    {
        public static string SafeValueString(DataGridViewCell dataGridViewCell)
        {
            if (dataGridViewCell.Value == null)
                return string.Empty;
            return dataGridViewCell.Value.ToString();
        }
    }
}
