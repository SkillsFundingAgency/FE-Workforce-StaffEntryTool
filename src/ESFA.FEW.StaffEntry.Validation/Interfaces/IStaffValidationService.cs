using System.Collections.Generic;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using ESFA.DC.FEW.FileProcessingService.Model.ValidationError.Model;

namespace ESFA.FEW.StaffEntry.Validation.Interfaces
{
    public interface IStaffValidationService
    {
        List<IValidationError> ValidateStaff(MessageStaffData staffData);

        List<IValidationError> ValidateStaffList(Message message);
    }
}
