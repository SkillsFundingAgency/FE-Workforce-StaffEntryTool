using System;

namespace ESFA.FE.StaffEntry.Models
{
    public class ComboBoxItem
    {
        public ComboBoxItem(string displayValue, int code)
        {
            DisplayValue = displayValue;
            Code = code;
        }

        public string DisplayValue { get; }

        public int Code { get; }

        public override string ToString()
        {
            return DisplayValue;
        }

        public override bool Equals(object obj)
        {
            return string.Equals(obj?.ToString(), DisplayValue, StringComparison.CurrentCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return DisplayValue.GetHashCode();
        }
    }
}
