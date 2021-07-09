using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Model;

namespace ESFA.FEW.StaffEntry.Validation
{
    public class ReferenceDataCache : IReferenceDataCache
    {
        private readonly IReferenceDataKeys _referenceDataKeys;

        private ReferenceData _cache;

        public ReferenceDataCache(IReferenceDataKeys referenceDataKeys)
        {
            _referenceDataKeys = referenceDataKeys;
        }

        public void UpdateCache(ReferenceData data)
        {
            _cache = LoadCacheData();
        }

        public List<ReferenceDataItem> GetCachedItems(string key)
        {
            _cache.Items.TryGetValue(key, out List<ReferenceDataItem> value);
            return value;
        }

        public int? GetLookupIdFromCode(string key, int? code)
        {
            if (!code.HasValue)
            {
                return null;
            }

            var cache = GetCachedItems(key);
            return cache?.SingleOrDefault(x => x.Code == code)?.Id;
        }

        public ReferenceDataItem GetById(string key, int lookupItemId)
        {
            throw new System.NotImplementedException();
        }

        private ReferenceData LoadCacheData()
        {
            ReferenceData data = new ReferenceData
            {
                Items = new Dictionary<string, List<ReferenceDataItem>>()
            };

            List<ReferenceDataItem> lookupsList;
            var lines = File.ReadAllLines("ReferenceData/LookupValues.txt");
            foreach (var line in lines)
            {
                string[] bits = line.Split('\t');

                data.Items.TryGetValue(bits[0], out lookupsList);

                if (lookupsList == null)
                {
                    lookupsList = new List<ReferenceDataItem>();
                    lookupsList.Add(new ReferenceDataItem(-1, -1)
                    {
                        Name = string.Empty
                    });
                    data.Items.Add(bits[0], lookupsList);
                }

                lookupsList.Add(new ReferenceDataItem(int.Parse(bits[1]), int.Parse(bits[1]))
                {
                    Name = bits[2].Trim()
                });
            }

            return data;
        }
    }
}
