using System;
using System.Windows.Forms;

namespace ESFA.FE.StaffEntry.Control
{
    public sealed class DataGridViewMaskedTextEditingControl : MaskedTextBox, IDataGridViewEditingControl
    {
        private DataGridView dataGridView;

        public DataGridViewMaskedTextEditingControl()
        {
            Mask = string.Empty;
        }

        public DataGridView EditingControlDataGridView
        {
            get => dataGridView;
            set => dataGridView = value;
        }

        public object EditingControlFormattedValue
        {
            get => Text;
            set
            {
                if (value is string v)
                {
                    Text = v;
                }
            }
        }

        public int EditingControlRowIndex { get; set; }

        public bool EditingControlValueChanged { get; set; }

        public Cursor EditingPanelCursor => Cursor;

        public bool RepositionEditingControlOnValueChange => false;

        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            //  get the current cell to use the specific mask string
            if (dataGridView.CurrentCell is DataGridViewMaskedTextCell cell)
            {
                Mask = cell.Mask;
            }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            //  Note: In a DataGridView, one could prefer to change the row using
            //  the up/down keys.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                    return true;
                default:
                    return false;
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            if (selectAll)
            {
                SelectAll();
            }
            else
            {
                SelectionStart = 0;
                SelectionLength = 0;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            EditingControlValueChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            if (EditingControlDataGridView != null)
            {
                EditingControlDataGridView.CurrentCell.Value = Text;
            }
        }
    }
}
