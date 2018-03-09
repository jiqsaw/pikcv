using System;
using System.Collections.Generic;
using System.Text;

namespace PIKCV.COM
{
    public class Enumerations
    {
        public enum PageType { 
            Entry = 0,
            Employee = 1,
            Company = 2
        }

        public enum CVTabs { 
            UserInfo = 0,
            CV = 1,
            Photo = 2,
            CVOutput = 3,
            Test = 4,
            PikInterview = 5,
            TestResults = 6
        }

        public enum JobsTabs{
            NewJobEntry = 0,
            PublicJobs = 1,
            Draft = 3,
            JobArchive = 4
        }

        public enum JobSaveType{
            NewJobEntry = 0,
            Update = 1,
            ArchiveOrDraft = 2
        }

        public enum ListTypes { 
            Message,
            UserJobApplicants,
            EnteredJobs,
            CompanyMessages,
            JobSearchResults,
            FolderDetail,
            CompanyJobApplicants,
            CompanySentMessages
        }

        public enum InterviewTabs
        {
            InterviewList = 0,
            MadeInterviews = 1,
            GeneralInterviews = 2
        }

        public enum ImageSaveType
        {
            EmployeeBig = 0,
            EmployeeSmall = 1,
            Company = 2
        }

        public enum BuyContactInfoResult{
            Success = 0,
            Failed = 1,
            NotEnoughPikCredi = 2
        }

        public enum BuyContactInfoResultPageType{
            BuyContactInfo = 1,
            SendMessage = 2,
            InsertInterview = 3,
            Unknown = 4
        }

        public enum JobDetailRefererUrl { 
            MainPage = 1,
            JobSearch = 2,
            JobApplicants = 3
        }
    }
}
