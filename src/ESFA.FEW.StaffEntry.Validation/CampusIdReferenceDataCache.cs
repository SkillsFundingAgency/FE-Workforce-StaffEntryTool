using System;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;

namespace ESFA.FEW.StaffEntry.Validation
{
    public class CampusIdReferenceDataCache : ICampusIdReferenceDataCache
    {
        public bool IsValidCampusId(string campusId, DateTime academicYearStart)
        {
            return true;
        }

        public async Task PopulateDataAsync(long ukprn, CancellationToken cancellationToken)
        {
        }
    }
}
