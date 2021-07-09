using ESFA.DC.FEW.FileProcessingService.Service.ReferenceData.Interface;

namespace ESFA.FEW.StaffEntry.Validation
{
    public class ReferenceDataKeys : IReferenceDataKeys
    {
        public string GenderFieldKey => "Gender";

        public string DisabilityFieldKey => "Disability";

        public string EthnicityFieldKey => "Ethnicity";

        public string MostSeniorLeaderFieldKey => "MostSeniorLeader";

        public string RoleFieldKey => "Role";

        public string MainSubjectTaught => "MainSubjectTaught";

        public string HighestQualificationTaught => "HighestQualificationTaught";

        public string HighestQualificationMaths => "HighestQualificationMaths";

        public string HighestQualificationEnglish => "HighestQualificationEnglish";

        public string HighestTeachingQualification => "HighestTeachingQualification";

        public string TeacherQualificationStudied => "TeacherQualificationStudied";

        public string TeacherQualificationFunding => "TeacherQualificationFunding";

        public string ProfessionalTeachingStatus => "ProfessionalTeachingStatus";

        public string IndustryExperienceDuration => "IndustryExperienceDuration";

        public string CurrentIndustryExperience => "CurrentIndustryExperience";

        public string NumberContracts => "NumberContracts";

        public string MainContractType => "ContractType";

        public string CurrentPositionDuration => "CurrentPositionDuration";

        public string FurtherEducationDuration => "FurtherEducationDuration";

        public string ReasonForLeaving => "ReasonForLeaving";

        public string MainRoleFieldKey => "MainRole";

        public string HasTeachingResponsibilities => throw new System.NotImplementedException();

        public string DoTheyStillWorkForTheOrganisation => throw new System.NotImplementedException();
    }
}
