using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ESFA.FE.StaffEntry.Control
{
    public sealed class DataGridViewMaskedTextCell : DataGridViewTextBoxCell
    {
        private string mask;

        private static readonly Type valueType = typeof(string);

        private static readonly Type editorType = typeof(DataGridViewMaskedTextEditingControl);

        public DataGridViewMaskedTextCell()
        {
            Mask = string.Empty;
        }

        public override Type EditType => editorType;

        public override Type ValueType => valueType;

        /// <summary>
        /// Input String that rules the possible input values in the current cell of the column.
        /// </summary>
        public string Mask
        {
            get => mask ?? string.Empty;
            set => mask = value;
        }

        /// <summary>
        /// Creates a copy of a DGV-MaskedTextCell containing the DGV-Cell properties.
        /// </summary>
        /// <returns>Instance of a DGV-MaskedTextCell using the Mask string.</returns>
        public override object Clone()
        {
            if (!(base.Clone() is DataGridViewMaskedTextCell cell))
            {
                return null;
            }

            cell.Mask = Mask;
            return cell;
        }

        /// <summary>
        /// Converting the current DGV-MaskedTextCell instance to a string value.
        /// </summary>
        /// <returns>String value of the instance containing the type name,
        /// column index, and row index.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(0x40);
            builder.Append("DataGridViewMaskedTextCell { ColumnIndex=");
            builder.Append(ColumnIndex.ToString());
            builder.Append(", RowIndex=");
            builder.Append(RowIndex.ToString());
            builder.Append(" }");
            return builder.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public override void DetachEditingControl()
        {
            DataGridView dataGridView = DataGridView;
            if (dataGridView?.EditingControl == null)
            {
                throw new InvalidOperationException();
            }

            if (dataGridView.EditingControl is MaskedTextBox editingControl)
            {
                editingControl.ClearUndo();
            }

            base.DetachEditingControl();
        }

        public override void InitializeEditingControl(
            int rowIndex,
            object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView.EditingControl is DataGridViewMaskedTextEditingControl editingControl)
            {
                if (Value == null || Value is DBNull)
                    editingControl.Text = (string)DefaultNewRowValue;
                else
                    editingControl.Text = (string)Value;
            }
        }
    }
}
