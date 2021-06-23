using System;
using System.Collections.Generic;
using System.Linq;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using ESFA.DC.FEW.FileProcessingService.Model.ValidationError.Model;
using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;
using ESFA.FEW.StaffEntry.Validation.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Severity = ESFA.DC.FEW.FileProcessingService.Model.ValidationError.Enum.Severity;

namespace ESFA.FEW.StaffEntry.Validation
{
    public class StaffValidationService : IStaffValidationService
    {
        private readonly IEnumerable<IValidator<MessageStaffData>> _staffValidators;
        private readonly IValidator<MessageStaffData[]> _staffListValidator;

        public StaffValidationService(
            IEnumerable<IValidator<MessageStaffData>> staffValidators,
            IValidator<MessageStaffData[]> staffListValidator,
            IReferenceDataCache referenceDataCache)
        {
            _staffValidators = staffValidators;
            _staffListValidator = staffListValidator;
            referenceDataCache.UpdateCache(null);
        }

        public List<IValidationError> ValidateStaff(MessageStaffData staff)
        {
            var result = new List<IValidationError>();
            foreach (var staffValidator in _staffValidators)
            {
                var validationResult = staffValidator.Validate(staff, ruleSet: "*");
                result.AddRange(BuildValidationErrorsFromValidationResult(
                    validationResult,
                    staff.FirstName,
                    staff.LastName,
                    staff.DateOfBirth));
            }

            return result;
        }

        public List<IValidationError> ValidateStaffList(Message message)
        {
            var errorsList = new List<IValidationError>();

            var staffListValidatorResult = _staffListValidator.Validate(new ValidationContext(message?.StaffData));

            if (!staffListValidatorResult.IsValid)
            {
                foreach (var validationFailure in staffListValidatorResult.Errors)
                {
                    var staff = (MessageStaffData)validationFailure.AttemptedValue;

                    errorsList.Add(new ValidationError
                    {
                        LastName = staff.LastName,
                        FirstName = staff.FirstName,
                        DateOfBirth = staff.DateOfBirth,
                        Severity = MapSeverity(validationFailure.Severity),
                        RuleName = validationFailure.ErrorCode
                    });
                }
            }

            foreach (var staffData in message.StaffData)
            {
                errorsList.AddRange(ValidateStaff(staffData));
            }

            return errorsList;
        }

        protected IEnumerable<IValidationError> BuildValidationErrorsFromValidationResult(
            ValidationResult validationResult, string firstName = null, string lastName = null, DateTime? dateOfBirth = null)
        {
            return validationResult.Errors.Select(e => new ValidationError(
                e.ErrorCode,
                firstName,
                lastName,
                dateOfBirth,
                MapSeverity(e.Severity),
                e.CustomState as IEnumerable<IErrorMessageParameter>));
        }

        private Severity MapSeverity(FluentValidation.Severity severity)
        {
            switch (severity)
            {
                case FluentValidation.Severity.Error:
                    return Severity.Error;
                case FluentValidation.Severity.Warning:
                    return Severity.Warning;
                default:
                    return Severity.Fail;
            }
        }
    }
}
