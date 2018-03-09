using System;
using System.Collections.Generic;
using System.Text;

namespace PIKCV.COM
{
    public class EnumUtil
    {
        public enum Config {
            dbConnection,
            PageNameEntry,
            PageNameDefault,
            PageNameEmployee,
            PageNameCompany,
            EMailServer,
            MailFrom,
            MailTo,
            UserImagePath,
            UserImageWidth,
            UserImageHeight,
            UserImagePathSmall,
            UserImageWidthSmall,
            UserImageHeightSmall,
            ImageMaxLenght,
            CompanyImagePath,
            CompanyImageWidth,
            CompanyImageHeight,
            ListPageSize,
            MinAge,
            StartYear,
            MaxSector,
            MaxPosition,
            MaxJobSector,
            MaxJobPlace,
            MaxJobEducationLevel,
            MaxJobForeignLanguage,
            MaxJobComputerKnowledge,
            MaxCountry,
            MaxCity,
            MaxProhibitedCompanies,
            MaxJobPerfection,
            PageNameEmployeeLogon,
            PageNameCompanyLogon,
            PageNameEmployeeMembership,
            PageNameCompanyMembership,
            CVActualMonth,
            MaxJobSeekingQualitySectorAndPosition,
            RefreshTime
        }

        public enum Sess 
        {
            LanguageID,
            EmployeeType,
            IsLogin,
            UserID,
            Email,
            FirstName,
            LastName,
            LastLoginDate,
            IsCvActive,
            IsCvConfirmed,
            IsEmailConfirmed,
            CVFocus,
            EducationState,
            PhotoFileName,
            CompanyName,
            PikCredi,
            CompanyID,
            ListFilterTypes,
            JobFocus,
            JobID,
            MemberType,
            JobSearchQueries,
            EmployeeSearchQueries,
            InterviewUserIDs,
            MessageUserIDs,
            EmployeeSearchResultUserIDs,
            SecurityImage,
            RememberURL,
            IsFirstLogin,
            CompanyJobs,
            TemporaryUserID,
            JobSaveType,
            BuyContactInfoResultUserIDs,
            SecretAnswerCount,
            JobDetailRefererUrl
        }

        public enum CacheTypes {
            Errors = 1,
            Countries = 2,
            TurkeyCities = 3,
            Sectors = 4,
            Positions = 5,
            MaritalStates = 6,
            MilitaryStates = 7,
            EducationStates = 8,
            Schools = 9,
            DriverLicenceTypes = 10,
            LabouringTypes = 11,
            ComputerKnowledgeTypes = 12,
            ForeignLanguages = 13,
            ForeignLanguageExams = 14,
            Levels = 15,
            EducationLevels = 16,
            Companies = 17,
            Perfection = 18,
            MainJobs = 19,
            InterviewStatus = 20
        }

        public enum CachePeriods { 
            Errors = 100,
            Countries = 100,
            TurkeyCities = 100,
            Sectors = 100,
            Positions = 100,
            MaritalStates = 100,
            MilitaryStates = 100,
            EducationStates = 100,
            Schools = 100,
            DriverLicenceTypes = 100,
            LabouringTypes = 100,
            ComputerKnowledgeTypes = 100,
            ForeignLanguages = 100,
            ForeignLanguageExams = 100,
            Levels = 100,
            EducationLevels = 100,
            Companies = 100,
            Perfection = 100,
            MainJobs = 100,
            InterviewStatus = 100
        }

        public enum Cookies { 
            PageType = 120,
            UserIP = 2
        }
    }
}
