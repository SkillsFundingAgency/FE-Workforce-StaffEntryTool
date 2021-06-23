using System;

namespace ESFA.FE.StaffEntry.Models
{
    public class ComboBoxItem
    {
        private string _displayValue;

        public ComboBoxItem(string displayValue, int code)
        {
            _displayValue = displayValue;
            Code = code;
        }

        public int Code { get; }

        public override string ToString()
        {
            return _displayValue;
        }

        public override bool Equals(object obj)
        {
            return string.Equals(obj?.ToString(), _displayValue, StringComparison.CurrentCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return _displayValue.GetHashCode();
        }
    }
}
