using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ESFA.FE.StaffEntry.Control
{
    [ToolboxBitmap(typeof(MaskedTextBox))]
    public class DataGridViewMaskedTextColumn : DataGridViewColumn
    {
        public DataGridViewMaskedTextColumn()
            : this(string.Empty)
        {
        }

        private DataGridViewMaskedTextColumn(string maskString)
            : base(new DataGridViewMaskedTextCell())
        {
            SortMode = DataGridViewColumnSortMode.Automatic;
            Mask = maskString;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !(value is DataGridViewMaskedTextCell))
                {
                    throw new InvalidCastException("DataGridView: WrongCellTemplateType, must be DataGridViewMaskedTextCell");
                }

                base.CellTemplate = value;
            }
        }

        [DefaultValue(1)]
        public new DataGridViewColumnSortMode SortMode
        {
            get => base.SortMode;
            set => base.SortMode = value;
        }

        public DataGridViewMaskedTextCell MaskedTextCellTemplate => (DataGridViewMaskedTextCell)CellTemplate;

        [Category("Masking")]
        [Description("Mask")]
        public string Mask
        {
            get
            {
                if (MaskedTextCellTemplate == null)
                {
                    throw new InvalidOperationException("DataGridViewColumn: CellTemplate required");
                }

                return MaskedTextCellTemplate.Mask;
            }

            set
            {
                if (Mask == value)
                {
                    return;
                }

                MaskedTextCellTemplate.Mask = value;

                if (DataGridView == null)
                {
                    return;
                }

                DataGridViewRowCollection rows = DataGridView.Rows;
                int count = rows.Count;
                for (int i = 0; i < count; i++)
                {
                    if (rows.SharedRow(i).Cells[Index] is DataGridViewMaskedTextCell cell)
                    {
                        cell.Mask = value;
                    }
                }
            }
        }

        public override object Clone()
        {
            DataGridViewMaskedTextColumn col = (DataGridViewMaskedTextColumn)base.Clone();
            if (col == null)
            {
                return null;
            }

            col.Mask = Mask;
            col.CellTemplate = (DataGridViewMaskedTextCell)CellTemplate.Clone();
            return col;
        }
    }
}
