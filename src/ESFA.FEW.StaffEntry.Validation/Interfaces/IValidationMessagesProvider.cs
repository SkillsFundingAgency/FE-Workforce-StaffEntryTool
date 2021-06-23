using ESFA.DC.FEW.FileProcessingService.Reports.ValidationMessage.Model;

namespace ESFA.FEW.StaffEntry.Validation.Interfaces
{
    public interface IValidationMessagesProvider
    {
        ValidationMessage GetValidationMessage(string ruleName);
    }
}
