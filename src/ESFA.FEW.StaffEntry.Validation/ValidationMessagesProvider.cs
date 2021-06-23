using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using ESFA.DC.FEW.FileProcessingService.Reports.ValidationMessage.Model;
using ESFA.FEW.StaffEntry.Validation.Interfaces;

namespace ESFA.FEW.StaffEntry.Validation
{
    public class ValidationMessagesProvider : IValidationMessagesProvider
    {
        private ConcurrentBag<ValidationMessage> _validationMessages;

        public ValidationMessage GetValidationMessage(string ruleName)
        {
            if (_validationMessages == null)
            {
                _validationMessages = new ConcurrentBag<ValidationMessage>();

                var lines = File.ReadAllLines("ReferenceData/ValidationMessages.txt");

                foreach (var line in lines)
                {
                    string[] bits = line.Split('\t');
                    _validationMessages.Add(new ValidationMessage
                    {
                        RuleName = bits[0],
                        Severity = bits[1],
                        Message = bits[2],
                    });
                }
            }

            var message = _validationMessages.FirstOrDefault(x => x.RuleName.Equals(ruleName, StringComparison.OrdinalIgnoreCase));
            return message;
        }
    }
}