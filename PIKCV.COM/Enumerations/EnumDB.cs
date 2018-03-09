using System;
using System.Collections.Generic;
using System.Text;

namespace PIKCV.COM
{
    public class EnumDB
    {
        public enum LanguageID
        {
            Turkish = 1,
            English = 2
        }

        public enum MemberTypes {
            Unknown = 0,
            Employee = 1,
            Company = 2,
            System = 3,
            Common = 4,
            TemporaryUser = 5
        }

        public enum EmployeeTypes { 
            Unknown = 0,
            Pikpool = 1,
            Goodpik = 2,
            Both = 3
        }

        public enum ErrorTypes
        {
            AsyncPostBackError = 0,
            AccessDenied = 1,
            ValidationEmail = 2,
            ValidationPassword = 3,
            OkSaveNoSendMail = 4,
            NoSave = 5,
            UserExist = 6,
            ValidationIdentity = 7,
            UserNotExist = 8,
            CVNoConfirmed = 9,
            InitialText = 10,
            OtherText = 11,
            NoticeActualCtrl = 12,
            NoticeTestCtrl = 13,
            NoticeCvActiveCtrl = 14,
            NoticeNOCV = 15,
            BuyContactInfo = 16,
            NoCredit = 17,
            NoticeSendFriend = 18,
            EmptyFilterName = 19,
            NoMessage = 21,
            NoApplicant = 22,
            NoJobSearch = 23,
            SecurityCodeIsNotTrue = 24,
            RemoveUser = 25,
            ForgotPassword = 26,
            SaveCompany = 27,
            SaveJob = 28,
            NoJob = 29,
            PleaseSelectFolder = 30,
            CopyToFolderSuccess = 31,
            CopyTofolderFailed = 32,
            SharedFolder = 33,
            SendFolder = 34,
            MessageSendSuccess = 35,
            NoEmployeeSearchResult = 36,
            SaveDraft = 37,
            JobsTitle = 38,
            NoJobForApplicant = 39,
            NoDraftJob = 40,
            NoArchiveJob = 41,
            DeleteFromFolderSuccsess = 42,
            DeleteFromFolderFailed = 43,
            SelectAtLeastOneUser = 44,
            BuyContactInfoFailed = 45,
            CutToFolderSuccess = 46,
            CutToFolderFailed = 47,
            SendToFolderSuccess = 48,
            SendToFolderFailed = 49,
            UsersWhichBoughtBefore = 50,
            UsersSelected = 51,
            UsersBought = 52,
            UsersBoughtBefore = 53,
            UsersWhichDidNotBoughtBefore = 54,
            UsersWhichBoughBeforeCount = 55,
            UsersWhichDinNotBoughtBedoreCount = 56,
            UsersWhichDidNotBoughtBeforeMessageWarning = 57,
            UsersWhichDidNotBoughtBeforeInterviewWarning = 58,
            SecretAnswerNoLimit = 59,
            NoticeTestCtrlForGoodPik = 60,
            AutomaticDisconnectMessage = 61,
            cRemoveMemberShip = 62,
            Error = 63,
            ExistLogin = 64,
            cDeleteMessage = 65,
            DeleteMessageSuccess = 66,
            cCancelApplicant = 67,
            CancelApplicantSuccess = 68,
            CancenApplicantBefore = 69,
            cDeleteFilter = 70,
            DeleteFilterSuccess = 71,
            cDeleteEducation = 72,
            DeleteEducationSuccess = 73,
            cDeleteEmployment = 74,
            DeleteEmploymentSuccess = 75,
            cDeleteForeignLanguages = 76,
            DeleteForeignLanguagesSuccess = 77,
            cDeleteReference = 78,
            DeleteReferenceSuccess = 79,
            EmailCouldNotFound = 80,
            cJobApplicantUnsuitabilitySet = 81,
            JobApplicantUnsuitabilitySetSuccess = 82,
            FilterSaveSuccess = 83,
            FilterAlreadyExist = 84,            
            UpdateCV = 85,
            NoUpdateCV = 86,
            PasswordSendFailed = 87,
            SecretQuestionAnswerWronge = 88,
            ApplicantCtrl = 89,
            ApplicantCtrLogin = 90
        }

        public enum Places { 
            CountriesParentID = 0,
            TurkeyPlaceID = 216,
            OtherPlaceID = 0
        }

        public enum PlaceTypes
        {
            Country = 0,
            TurkeyCity = 216
        }

        public enum SchoolTypes {
            UniversityNames = 1,
            DepartmentNames = 2,
            //TwoYearDepartmentNames = 2,
            //FourYearDepartmentNames = 3,
            HighSchoolTypes = 4
        }

        public enum ArticleTypes { 
            Article = 1
        }

        public enum SexCode { 
            Male = 0,
            Female = 1,
            Both = 2
        }

        public enum CVFocusCode {
            PersonalInfo = 1,
            ContactInfo = 2,
            
            Education = 3,
            EducationMiddleSchool = 4,
            EducationHighSchool = 5,
            EducationUniversity0 = 6,
            EducationUniversity1 = 7,
            EducationUniversity2 = 8,
            EducationDoktorate = 9,
            
            Employment = 10,
            
            DriverLicense = 11,
            ForeignLanguages = 12,
            ComputerKnowledge = 13,
            CourseAndCertificate = 14,
            Interests = 15, 
            Clubs = 16, 
            
            EmploymentChooices = 17,
            PlacementPreferences = 18,
            ProhibitedCompanies = 19,
            References = 20,
            OtherChoices = 21
        }

        public enum JobsFocusCode{
            JobType = 1,
            PositionDefinition = 2,
            EducationLevel = 3,
            SeekingQuality = 4,
            PreferencePriority = 5,
            Approval = 6
        }

        public enum EducationStates
        {
            Graduate = 1,
            Student = 2,
            Leaving = 3
        }

        public enum EducationTypes
        {
            Unknown = 0,
            MiddleSchool = 1,
            HighSchool = 2,
            University0 = 3,
            University1 = 4,
            University2 = 5,
            Doktorate = 6
        }

        public enum MaritalStates
        {
            Single = 2,
            Married = 8,
            None = 3
        }

        public enum MilitaryStates
        {
            Finished = 1,
            Postponement = 2,
            Exempt = 3
        }

        public enum JobListTypes
        {
            Main1 = 1,
            Main2 = 2,
            Standart = 4
        }

        public enum AgeRange { 
            age_All = 0,
            age_18_24 = 1,
            age_25_29 = 2,
            age_30_34 = 3,
            age_35_39 = 4,
            age_40_44 = 5,
            age_45_55 = 6,
            age_56over = 7
        }

        public enum WorkerNumberRange
        {
            number_1 = 1,
            number_2 = 2,
            number_3 = 3,
            number_3_5 = 4,
            number_5_10 = 5,
            number_10_20 = 6,
            number_20over = 7
        }

        public enum TestTypeCode { 
            General = 0,
            Perfection = 1
        }

        public enum JobStatus
        {
            All = -1,
            Passive = 0,
            Active = 1,
            Paused = 2,
            Draft = 3,
            Archive = 4,
            Deleted = 5
        }

        public enum LicenceTypes { 
            NoneID = 5,
            All = 6
        }

        public enum PerfectionLevels { 
            BA = 1,
            BD = 2,
            BU = 3
        }

        public enum Experience
        {
            experience_0_1 = 0,
            experience_2_5 = 1,
            experience_6_10 = 2,
            experience_10_over = 3
        }

        public enum FilterTypes { 
            JobSearch = 0,
            EmployeeSearch = 2
        }

        public enum JobApplicationStates { 
            NotExaminet = 1,
            Examinet = 2,
            GetInterview = 3,
            Unsuitability = 4,
            RecievedBack = 6
        }

        public enum SystemUserType
        {
            Admin = 1,
            Representative = 2
        }

        public enum OrderProcessTypeCode
        {
            non_invoiced=1,
            unpaid=2,
            paid=3,
            unknown = 4
        }
        public enum OrderTypeCode
        {
            FirstTen = 1,
            SecondTen = 2,
            EmployeeInfoAchieving = 3,
            NewJob=4,
            CreditBuy =5
        }

        public enum PaymentType{
            Loan = 1, //Borçlanarak ödeme
            Transfer = 2 //Havale
        }

        public enum SendFriendType { 
            Job = 1
        }

        public enum OtherComputerKnowledgeID { 
            Other = 49
        }

        public enum MessageTypeCode{
            StantdartMessage = 1,
            Interview = 2,
            Applicant = 3
        }

        public enum FolderTypeID
        {
            UsersWillBeBought = 1,
            UsersBough = 2,
            CompanyCreated = 3
        }
    }
}