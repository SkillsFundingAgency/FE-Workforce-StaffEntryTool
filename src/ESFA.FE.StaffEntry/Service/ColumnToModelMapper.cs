using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;
using ESFA.FE.StaffEntry.Models;

namespace ESFA.FE.StaffEntry.Service
{
    public class ColumnToModelMapper
    {
        private readonly IReferenceDataCache _referenceDataCache;

        public ColumnToModelMapper(IReferenceDataCache referenceDataCache)
        {
            _referenceDataCache = referenceDataCache;
        }

        public bool ColumnHasCodes(string columnName)
        {
            GetNamesFromColumnName(columnName, out string typeName, out string fieldName, out string indexValue);
            return _referenceDataCache.GetCachedItems(fieldName) != null;
        }

        public IEnumerable<ComboBoxItem> ControlItems(string columnName)
        {
            GetNamesFromColumnName(columnName, out string typeName, out string fieldName, out string indexValue);
            var items = _referenceDataCache.GetCachedItems(fieldName);
            return items.Select(s => new ComboBoxItem(s.Name.Trim(), s.Code));
        }

        public void SetObjectProperty(object invalue, object target, string fieldName, PropertyInfo propInfo)
        {
            if (FieldTypeNeedsACodeLookup(fieldName))
            {
                int code = MapFieldNameValueToCode(fieldName, invalue.ToString());
                propInfo.SetValue(target, code);
            }
            else if (propInfo.PropertyType == typeof(DateTime) || propInfo.PropertyType == typeof(DateTime?))
            {
                if (DateTime.TryParse(invalue.ToString(), out DateTime dateTime))
                {
                    propInfo.SetValue(target, dateTime);
                }
            }
            else if (propInfo.PropertyType == typeof(bool))
            {
                if (bool.TryParse(invalue.ToString(), out bool truefalse))
                {
                    propInfo.SetValue(target, truefalse);
                }
            }
            else if (propInfo.PropertyType == typeof(decimal) || propInfo.PropertyType == typeof(decimal?))
            {
                if (decimal.TryParse(invalue.ToString(), out decimal number))
                {
                    propInfo.SetValue(target, number);
                }
            }
            else if (propInfo.PropertyType == typeof(int) || propInfo.PropertyType == typeof(int?))
            {
                if (invalue is bool b)
                {
                    propInfo.SetValue(target, b ? 1 : 0);
                }
                else if (int.TryParse(invalue.ToString(), out int number))
                {
                    propInfo.SetValue(target, number);
                }
            }
            else
            {
                propInfo.SetValue(target, invalue);
            }
        }

        public int MapFieldNameValueToCode(string fieldName, string v)
        {
            var items = _referenceDataCache.GetCachedItems(fieldName);
            return items.First(x => x.Name == v).Code;
        }

        public bool FieldTypeNeedsACodeLookup(string fieldName)
        {
            var items = _referenceDataCache.GetCachedItems(fieldName);
            return items != null;
        }

        internal string MapFieldNameCodeToValue(string fieldName, int code)
        {
            var values = _referenceDataCache.GetCachedItems(fieldName);

            foreach (var pair in values)
            {
                if (pair.Code == code)
                {
                    return pair.Name;
                }
            }

            throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// Column names are formed as the ModelType_FieldName pairs. This is so we can use by convention
        /// constructs to map backwards and forwards between types and such like.
        /// This is a standard function that understands that convention.
        /// </summary>
        /// <param name="columnName">Composite name formed by type_field.</param>
        /// <param name="typeName">The type name.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="indexValue">The index value.</param>
        private void GetNamesFromColumnName(string columnName, out string typeName, out string fieldName, out string indexValue)
        {
            string[] t = columnName.Split('_');
            typeName = t[0];
            fieldName = t[1];
            indexValue = string.Empty;

            if (t.Length > 2)
            {
                indexValue = t[2];
            }
        }
    }
}
