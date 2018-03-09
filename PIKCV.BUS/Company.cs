using System;
using System.Collections.Generic;
using System.Text;
using CARETTA.COM;
using System.Data;
using System.Collections;

namespace PIKCV.BUS
{
    public class Company
    {
        public int InsertCompanyInfo(ArrayList arrSelectedSectors, string CompanyName, string CompanyDescription, int NumberOfWorkers,
                        string ContactName, string ContactLastName, string Phone, string Fax, string ContactEmail, string SecretQuestion,
                        string SecretAnswer)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();

                objCompany.AddNew();

                objCompany.RegisterDate = DateTime.Now;
                objCompany.ActivationNumber = " ";
                objCompany.CityID = 0;
                objCompany.CompanyName = Util.ReplaceStrForDB(CompanyName);
                objCompany.CompanyDescription = Util.ReplaceStrForDB(CompanyDescription);
                objCompany.ContactEmail = Util.ReplaceStrForDB(ContactEmail.Trim());
                objCompany.ContactLastName = Util.ReplaceStrForDB(ContactLastName);
                objCompany.ContactName = Util.ReplaceStrForDB(ContactName);
                objCompany.SecretQuestion = Util.ReplaceStrForDB(SecretQuestion);
                objCompany.SecretAnswer = Util.ReplaceStrForDB(SecretAnswer);
                objCompany.ContactTitle = PIKCV.COM.Util.ReturnEmptyString(String.Empty);
                objCompany.PhotoFileName = PIKCV.COM.Util.ReturnEmptyString(String.Empty);
                objCompany.CountryID = 0;
                objCompany.Credits = 0;
                objCompany.Fax = Util.ClearString(Fax);
                objCompany.FaxAreaCode = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.FaxCountryCode = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.IsActive = false;
                objCompany.IsDeleted = false;
                objCompany.IsFirstLogin = true;
                objCompany.IsEmailConfirmed = false;
                objCompany.LastLoginDate = DateTime.Now;
                objCompany.MaxLoan = 0;
                objCompany.NumberOfWorkers = NumberOfWorkers;
                objCompany.OtherCity = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.OtherTown = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.Password = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.Phone = Util.ClearString(Phone);
                objCompany.PhoneAreaCode = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.PhoneCountryCode = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.PostalCode = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.RepresentativeID = 0;
                objCompany.StreetAddress = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.TaxNumber = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.TaxOffice = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                objCompany.TownID = 0;
                objCompany.UserName = Util.ReplaceStrForDB(ContactEmail.Trim());
                objCompany.Save();
                for (int i = 0; i < arrSelectedSectors.Count; i++)
                {
                    SaveCompanySector(objCompany.CompanyID, Convert.ToInt32(arrSelectedSectors[i]));
                }
                return objCompany.CompanyID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool UpdateCompanyPhoto(int CompanyID, string PhotoFileName)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();

                objCompany.LoadByPrimaryKey(CompanyID);
                objCompany.PhotoFileName = PhotoFileName;
                objCompany.Save();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public int CompanyExistanceControlForEmail(string Email)
        {
            try
            {
                PIKCV.DAL.Companies obj = new PIKCV.DAL.Companies();
                obj.Where.UserName.Value = Util.ReplaceStrForDB(Email.Trim());
                obj.Query.Load();
                return obj.RowCount;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int UpdateCompanyInfo(int CompanyID, ArrayList arrSelectedSectors, string CompanyName, string CompanyDescription, int NumberOfWorkers,
                string ContactName, string ContactLastName, string Phone, string Fax, string ContactEmail, string PhotoFileName, string SecretQuestion,
                string SecretAnswer)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();

                objCompany.LoadByPrimaryKey(CompanyID);

                objCompany.CompanyName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(CompanyName));
                objCompany.CompanyDescription = CompanyDescription;
                objCompany.ContactEmail = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ContactEmail));
                objCompany.ContactLastName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ContactLastName));
                objCompany.ContactName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ContactName));
                objCompany.Fax = Util.ClearString(Fax);
                objCompany.SecretQuestion = Util.ReplaceStrForDB(SecretQuestion);
                objCompany.SecretAnswer = Util.ReplaceStrForDB(SecretAnswer);
                objCompany.NumberOfWorkers = NumberOfWorkers;
                objCompany.Phone = Util.ClearString(Phone);
                //objCompany.PhotoFileName = PhotoFileName;
                objCompany.Save();

                PIKCV.DAL.CompanySectors objCompanySector = new PIKCV.DAL.CompanySectors();
                objCompanySector.DeleteAllCompanySectors(CompanyID);

                for (int i = 0; i < arrSelectedSectors.Count; i++)
                {
                    SaveCompanySector(objCompany.CompanyID, Convert.ToInt32(arrSelectedSectors[i]));
                }
                return objCompany.CompanyID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool UpdateCompanyPassword(int CompanyID, string Password, bool IsFirstLogin)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();

                objCompany.LoadByPrimaryKey(CompanyID);
                objCompany.Password = Encryption.Encrypt(Util.ReplaceStrForDB(Password.Trim()));
                objCompany.IsFirstLogin = IsFirstLogin;
                objCompany.Save();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveCompanySector(int CompanyID, int SectorID)
        {
            try
            {
                PIKCV.DAL.CompanySectors objCompanySectors = new PIKCV.DAL.CompanySectors();

                objCompanySectors.AddNew();
                objCompanySectors.CompanyID = CompanyID;
                objCompanySectors.SectorID = SectorID;
                objCompanySectors.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool SaveActivation(int CompanyID, string ActivationNumber)
        {
            try
            {
                PIKCV.DAL.Companies objUser = new PIKCV.DAL.Companies();
                objUser.LoadByPrimaryKey(CompanyID);
                objUser.ActivationNumber = ActivationNumber;
                objUser.Save();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool ActivateMember(int MemberID, string ActivationNumber)
        {
            PIKCV.DAL.Companies objUser = new PIKCV.DAL.Companies();
            objUser.Where.CompanyID.Value = MemberID;
            objUser.Where.ActivationNumber.Value = ActivationNumber;
            objUser.Query.Load();
            if (objUser.RowCount > 0)
            {
                objUser.IsEmailConfirmed = true;
                objUser.Save();
                return true;
            }
            return false;
        }

        public DataTable GetCompanySector(int CompanyID)
        {
            PIKCV.DAL.CompanySectors objCompanySector = new PIKCV.DAL.CompanySectors();
            objCompanySector.Where.CompanyID.Value = CompanyID;
            objCompanySector.Query.Load();
            return objCompanySector.DefaultView.Table;
        }

        public DataTable GetCompanySectorNames(int CompanyID)
        {
            PIKCV.DAL.CompanySectors objCompanySector = new PIKCV.DAL.CompanySectors();
            return objCompanySector.GetCompanySectors(CompanyID);
        }

        public DataTable LoginControl(string UserName, string Password)
        {
            DataTable dt = null;
            UserName = Util.ClearString(UserName.Trim());
            Password = Encryption.Encrypt(CARETTA.COM.Util.ClearString(Password.Trim()));
            PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
            objCompany.Where.UserName.Value = UserName;
            objCompany.Where.Password.Value = Password;
            objCompany.Where.IsEmailConfirmed.Value = true;
            objCompany.Where.IsActive.Value = true;
            objCompany.Where.IsDeleted.Value = false;
            objCompany.Query.Load();
            dt = objCompany.DefaultView.Table;
            if (dt.Rows.Count > 0)
            {
                UpdateLastLoginDate(Convert.ToInt32(dt.Rows[0]["CompanyID"]));
            }
            return dt;
        }

        public void UpdateLastLoginDate(int CompanyID)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
                objCompany.LoadByPrimaryKey(CompanyID);
                objCompany.LastLoginDate = DateTime.Now; ;
                objCompany.Save();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetCompanyInfo(int CompanyID)
        {
            PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
            objCompany.LoadByPrimaryKey(CompanyID);
            return objCompany.DefaultView.ToTable();
        }

        public DataRow GetCompanyByEmail(string Email)
        {
            string m_Email = Util.ClearString(Email.Trim());
            PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
            objCompany.Where.UserName.Value = m_Email;
            objCompany.Query.Load();
            if (objCompany.RowCount > 0) { return objCompany.DefaultView.ToTable().Rows[0]; }
            else return null;
        }

        public static DataTable GetAllCompanies(bool isDeleted, bool isActive, bool IsEmailConfirmed)
        {
            PIKCV.DAL.Companies objCompanies = new PIKCV.DAL.Companies();
            objCompanies.Where.IsDeleted.Value = isDeleted;
            objCompanies.Where.IsActive.Value = isActive;
            objCompanies.Where.IsEmailConfirmed.Value = IsEmailConfirmed;
            objCompanies.Query.Load();
            return objCompanies.DefaultView.ToTable();
        }

        public DataTable GetCompanyInterviews(int CompanyID, string InterviewStatus, PIKCV.COM.EnumDB.MemberTypes MemberType, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            return obj.GetCompanyInterviews(CompanyID, int.Parse(InterviewStatus), (int)MemberType, (int)LanguageID);
        }

        public DataTable GetCompanyMadeInterviews(int CompanyID, PIKCV.COM.EnumDB.MemberTypes MemberType, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            return obj.GetCompanyMadeInterviews(CompanyID, (int)MemberType, (int)LanguageID, DateTime.Now);
        }

        public DataTable GetCompanyInterviewsGroupByPosition(int CompanyID, PIKCV.COM.EnumDB.MemberTypes MemberType, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            return obj.GetCompanyInterviewsGroupByPosition(CompanyID, (int)MemberType, (int)LanguageID, DateTime.Now);
        }

        public DataTable GetCompanyInterviewsGroupByAdvisorAndTime(int CompanyID, PIKCV.COM.EnumDB.MemberTypes MemberType, int PositionID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            return obj.GetCompanyInterviewsGroupByAdvisorAndTime(CompanyID, (int)MemberType, DateTime.Now, PositionID);
        }

        public void DeleteInterview(int InterviewID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            obj.LoadByPrimaryKey(InterviewID);
            obj.MarkAsDeleted();
            obj.Save();
        }

        public DataTable GetInterviewInfo(int InterviewID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            obj.Where.InterviewID.Value = InterviewID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public void UpdateInterviewStatus(int InterviewID, int InterviewStatusID)
        {
            PIKCV.DAL.Interviews obj = new PIKCV.DAL.Interviews();
            obj.LoadByPrimaryKey(InterviewID);
            obj.InterviewStatusID = InterviewStatusID;
            obj.Save();
        }

        public int InsertCompanyAdvisor(int CompanyID, string FirstName, string LastName)
        {
            try
            {
                PIKCV.DAL.CompanyAdvisor objCompanyAdvisor = new PIKCV.DAL.CompanyAdvisor();
                PIKCV.DAL.CompanyAdvisor objCompanyAdvisor2 = new PIKCV.DAL.CompanyAdvisor();

                objCompanyAdvisor.Where.FirstName.Value = FirstName;
                objCompanyAdvisor.Where.LastName.Value = LastName;
                objCompanyAdvisor.Where.CompanyID.Value = CompanyID;
                objCompanyAdvisor.Query.Load();
                if (objCompanyAdvisor.RowCount > 0)
                    return objCompanyAdvisor.CompanyAdvisorID;

                objCompanyAdvisor.AddNew();
                objCompanyAdvisor.CompanyID = CompanyID;
                objCompanyAdvisor.FirstName = FirstName;
                objCompanyAdvisor.LastName = LastName;
                objCompanyAdvisor.Save();
                return objCompanyAdvisor.CompanyAdvisorID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable GetCompanyAdvisor(int CompanyID)
        {
            PIKCV.DAL.CompanyAdvisor obj = new PIKCV.DAL.CompanyAdvisor();
            obj.Where.CompanyID.Value = CompanyID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public DataTable GetCompanyFolders(int CompanyID, bool IsDefault, bool IsDeleted)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            return obj.GetCompanyFolders(CompanyID, IsDefault, IsDeleted);
        }

        public DataTable GetCompanyFolders(int CompanyID, bool IsDeleted)
        {
            try
            {
                PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
                obj.Where.CompanyID.Value = CompanyID;
                obj.Where.IsDeleted.Value = IsDeleted;
                obj.Query.Load();
                return obj.DefaultView.Table;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public DataTable GetCompanyFolderByFolderType(int CompanyID, PIKCV.COM.EnumDB.FolderTypeID FolderType, bool IsDeleted)
        {
            try
            {
                PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
                obj.Where.CompanyID.Value = CompanyID;
                obj.Where.FolderTypeID.Value = (int)FolderType;
                obj.Where.IsDeleted.Value = IsDeleted;
                obj.Query.Load();
                return obj.DefaultView.Table;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void DeleteCompanyFolder(int FolderID)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            obj.LoadByPrimaryKey(FolderID);
            obj.IsDeleted = true;
            obj.Save();
        }

        public DataTable GetCompanyFolderDetail(int FolderID)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            obj.Where.FolderID.Value = FolderID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public DataTable GetCompanyFolderDetail(int FolderID, PIKCV.COM.EnumDB.LanguageID LanguageID, bool IsDeleted)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            return obj.GetCompanyFolderDetail(FolderID, (int)LanguageID, IsDeleted);
        }

        public DataTable GetCompanyDefaultFolderSituation(int CompanyID, bool IsDefault, bool IsDeleted)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            return obj.GetCompanyDefaultFolderSituation(CompanyID, IsDefault, IsDeleted);
        }

        public DataTable GetCompanyFolderDetailByUserID(int UserID, int CompanyID)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            return obj.GetFolderDetailByUser(UserID, CompanyID);
        }


        public int SaveCompanyFolder(int CompanyID, int FolderID, string FolderName)
        {
            try
            {
                PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
                if (FolderID == 0)
                {
                    obj.AddNew();
                    obj.CompanyID = CompanyID;
                    obj.CreateDate = DateTime.Now;
                    obj.FolderTypeID = (int)PIKCV.COM.EnumDB.FolderTypeID.CompanyCreated;
                    obj.IsDefault = false;
                    obj.IsDeleted = false;
                    obj.LastUseDate = DateTime.Now;
                }
                else
                {
                    obj.LoadByPrimaryKey(FolderID);
                }
                obj.FolderName = FolderName;
                obj.Save();
                return obj.FolderID;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        //User Klasöre Ekle
        public bool InsertUsersToFolder(int FolderID, ArrayList arrUsers)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            PIKCV.DAL.FolderContent obj = new PIKCV.DAL.FolderContent();
            PIKCV.DAL.FolderContent objUserExist = new PIKCV.DAL.FolderContent();
            try
            {
                Tran.BeginTransaction();
                for (int i = 0; i < arrUsers.Count; i++)
                {
                    if (UserExistance(Convert.ToInt32(arrUsers[i]), FolderID) == 0)
                    {
                        obj.AddNew();
                        obj.FolderID = FolderID;
                        obj.UserID = Convert.ToInt32(arrUsers[i]);
                        obj.TemporaryUserID = 0;
                        obj.DateAdded = DateTime.Now;
                        obj.IsDeleted = false;
                        obj.Save();
                    }
                }

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }
        }

        //User Klasörünü Deðiþtir
        public bool UpdateUsersFolders(int FolderIDOld, int FolderIDNew, ArrayList arrUsers)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();
                for (int i = 0; i < arrUsers.Count; i++)
                {
                    PIKCV.DAL.FolderContent obj = new PIKCV.DAL.FolderContent();
                    obj.Where.FolderID.Value = FolderIDOld;
                    obj.Where.UserID.Value = Convert.ToInt32(arrUsers[i]);
                    obj.Query.Load();
                    DataRow dr = obj.DefaultView.ToTable().Rows[0];

                    PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                    objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                    if (UserExistance(Convert.ToInt32(arrUsers[i]), FolderIDNew) == 0)
                    {
                        objFolder.FolderID = FolderIDNew;
                    }
                    else
                    {
                        objFolder.IsDeleted = true;
                    }
                    objFolder.Save();
                }

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }
        }

        //User Klasörünü Deðiþtir Geçici Kullanýcý Ýçin
        public bool UpdateUsersFolders(int FolderIDOld, int FolderIDNew, ArrayList arrUsers, int TemporaryUserID)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();
                for (int i = 0; i < arrUsers.Count; i++)
                {
                    PIKCV.DAL.FolderContent obj = new PIKCV.DAL.FolderContent();
                    obj.Where.FolderID.Value = FolderIDOld;
                    obj.Where.UserID.Value = Convert.ToInt32(arrUsers[i]);
                    obj.Where.IsDeleted.Value = false;
                    obj.Query.Load();
                    DataRow dr = obj.DefaultView.ToTable().Rows[0];

                    PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                    objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                    objFolder.IsDeleted = true;
                    objFolder.Save();

                    PIKCV.DAL.FolderContent objFolderIDToAdd = new PIKCV.DAL.FolderContent();
                    objFolderIDToAdd.AddNew();

                    objFolderIDToAdd.FolderID = FolderIDNew;
                    objFolderIDToAdd.UserID = Convert.ToInt32(arrUsers[i]);
                    objFolderIDToAdd.DateAdded = DateTime.Now;
                    objFolderIDToAdd.IsDeleted = false;
                    objFolderIDToAdd.TemporaryUserID = TemporaryUserID;

                    objFolderIDToAdd.Save();
                }

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }
        }

        public int UserExistance(int UserID, int FolderID)
        {
            PIKCV.DAL.FolderContent objUserExist = new PIKCV.DAL.FolderContent();
            objUserExist.Where.FolderID.Value = FolderID;
            objUserExist.Where.UserID.Value = UserID;
            objUserExist.Where.IsDeleted.Value = false;
            objUserExist.Query.Load();
            DataTable dt = objUserExist.DefaultView.ToTable();
            return dt.Rows.Count;
        }


        public int FolderExistance(int CompanyID, string FolderName, bool IsDeleted)
        {
            PIKCV.DAL.Folders obj = new PIKCV.DAL.Folders();
            obj.Where.CompanyID.Value = CompanyID;
            obj.Where.FolderName.Value = FolderName;
            obj.Where.IsDeleted.Value = IsDeleted;
            obj.Query.Load();
            return obj.RowCount;
        }

        public bool DeleteUserFromFolder(int FolderID, ArrayList arrUsers)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();
                for (int i = 0; i < arrUsers.Count; i++)
                {
                    //PIKCV.DAL.FolderContent obj = new PIKCV.DAL.FolderContent();
                    //obj.Where.FolderID.Value = FolderID;
                    //obj.Where.UserID.Value = Convert.ToInt32(arrUsers[i]);
                    //obj.Query.Load();
                    //DataRow dr = obj.DefaultView.ToTable().Rows[0];

                    //PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                    //objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                    //objFolder.IsDeleted = true;
                    //objFolder.Save();

                    PIKCV.DAL.FolderContent obj = new PIKCV.DAL.FolderContent();
                    obj.Where.FolderID.Value = FolderID;
                    obj.Where.UserID.Value = Convert.ToInt32(arrUsers[i]);
                    obj.Query.Load();
                    DataTable dt = obj.DefaultView.ToTable();
                    foreach (DataRow dr in dt.Rows)
                    {
                        PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                        objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                        objFolder.IsDeleted = true;
                        objFolder.Save();
                    }
                }

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }

        }

        public int SaveCompanyTemporaryUser(int CompanyID, string Email, int FolderID, string UserName, string Password, string Notes)
        {
            try
            {
                PIKCV.DAL.TemporaryUsers obj = new PIKCV.DAL.TemporaryUsers();
                obj.AddNew();
                obj.CreateDate = DateTime.Now;
                obj.Email = Email;
                obj.EndDate = DateTime.Now.AddDays(5);
                obj.FolderID = FolderID;
                obj.Password = Encryption.Encrypt(Password);
                obj.UserCode = UserName;
                obj.Notes = Util.ReplaceStrForDB(Notes);
                obj.Save();
                return obj.TemporaryUserID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Get CompanyOwnedUsers By CompanyID
        public DataTable GetCompanyOwnedUsers(int CompanyID)
        {
            PIKCV.DAL.CompanyOwnedUsers obj = new PIKCV.DAL.CompanyOwnedUsers();
            obj.Where.CompanyID.Value = CompanyID;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        // Kullanýcý alýnmýþmý kontrol
        public bool CheckBuyContactInfo(int CompanyID, int UserID)
        {
            PIKCV.DAL.CompanyOwnedUsers obj = new PIKCV.DAL.CompanyOwnedUsers();
            obj.Where.CompanyID.Value = CompanyID;
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            return (obj.RowCount > 0);
        }
        //Insert

        //Insert CompanyOwnedUser
        public int InsertCompanyOwnedUser(int CompanyID, int UserID, ref PIKCV.DAO.TransactionMgr Tran)
        {
            try
            {
                PIKCV.DAL.CompanyOwnedUsers objCOmpanyOwnedUser = new PIKCV.DAL.CompanyOwnedUsers();
                objCOmpanyOwnedUser.AddNew();
                objCOmpanyOwnedUser.CompanyID = CompanyID;
                objCOmpanyOwnedUser.UserID = UserID;
                objCOmpanyOwnedUser.DateOwned = DateTime.Now;
                objCOmpanyOwnedUser.EndDate = DateTime.Now.AddYears(1);
                objCOmpanyOwnedUser.Save();
                return objCOmpanyOwnedUser.RowID;
            }
            catch (Exception)
            {
                //Tran.RollbackTransaction();
                //PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;
            }
        }
        
        // Update Company Credit
        public void UpdateCompanyCredit(int CompanyID, int Credit, ref PIKCV.DAO.TransactionMgr Tran)
        {
            try
            {
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();

                objCompany.LoadByPrimaryKey(CompanyID);
                objCompany.Credits = Credit;
                objCompany.Save();
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
            }
        }

        public PIKCV.COM.Enumerations.BuyContactInfoResult BuyContactInfo(int CompanyID, ArrayList arrUserID, int OldFolderID)
        {
            int Credit = 0;
            int LastCredit = 0;

            DataTable dtCompanyInfo = new DataTable();
            dtCompanyInfo = GetCompanyInfo(CompanyID);
            if (dtCompanyInfo.Rows.Count > 0)
            {
                LastCredit = Convert.ToInt32(dtCompanyInfo.Rows[0]["Credits"]);
            }
            else
            {
                return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
            }

            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();
            Tran.BeginTransaction();

            for (int i = 0; i < arrUserID.Count; i++)
            {
                if (dtCompanyInfo.Rows.Count > 0)
                {
                    if (!(CheckBuyContactInfo(CompanyID, Convert.ToInt32(arrUserID[i]))))
                    {
                        PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = PIKCV.COM.EnumDB.EmployeeTypes.Unknown;
                        PIKCV.BUS.User objUser = new PIKCV.BUS.User();
                        DataTable dt = objUser.GetUserDetail(Convert.ToInt32(arrUserID[i]));
                        if (dt.Rows.Count > 0)
                        {
                            EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(dt.Rows[0]["EmployeeTypeCode"]));
                        }
                        else
                        {
                            //User Detaylarýný alýrken patladý
                            Tran.RollbackTransaction();
                            PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                            return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                        }

                        DataRow drCVCredtis = PIKCV.BUS.Orders.GetOrderTypesDetails((int)PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving);
                        if (drCVCredtis != null)
                        {
                            if (EmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik)
                                Credit = Convert.ToInt32(drCVCredtis["GoodPikCredit"]);
                            else if (EmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool)
                                Credit = Convert.ToInt32(drCVCredtis["PikPoolCredit"]);
                        }
                        else
                        {
                            //Credi miktarlarýný alýrken patladý
                            Tran.RollbackTransaction();
                            PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                            return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                        }

                        int Result = 0;
                        if (LastCredit < Credit)
                        {
                            // Yeterli kredi yok
                            Tran.RollbackTransaction();
                            PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                            return PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi;
                        }
                        else
                        {

                            try
                            {
                                LastCredit = LastCredit - Credit;
                                UpdateCompanyCredit(Convert.ToInt32(dtCompanyInfo.Rows[0]["CompanyID"]), LastCredit, ref Tran);

                                PIKCV.BUS.Orders Order = new PIKCV.BUS.Orders();
                                Result = Order.InsertOrder(CompanyID, (int)PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving, (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.non_invoiced, Credit, 0, true, ref Tran);

                                if (Result == 0)
                                {
                                    // Order'a atýþta patladý
                                    Tran.RollbackTransaction();
                                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                }
                                else
                                {
                                    Result = Order.InsertOrderLineItem(Result, Convert.ToInt32(arrUserID[i]), 0, Credit, 0, ref Tran);
                                    if (Result == 0)
                                    {
                                        // OrderLineItem'a atýþta patladý
                                        Tran.RollbackTransaction();
                                        PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                        return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                    }
                                    else
                                    {
                                        PIKCV.DAL.CompanyOwnedUsers objCOmpanyOwnedUser = new PIKCV.DAL.CompanyOwnedUsers();
                                        objCOmpanyOwnedUser.AddNew();
                                        objCOmpanyOwnedUser.CompanyID = CompanyID;
                                        objCOmpanyOwnedUser.UserID = Convert.ToInt32(arrUserID[i]);
                                        objCOmpanyOwnedUser.DateOwned = DateTime.Now;
                                        objCOmpanyOwnedUser.EndDate = DateTime.Now.AddYears(1);
                                        objCOmpanyOwnedUser.Save();
                                        
                                        if (objCOmpanyOwnedUser.RowID == 0)
                                        {
                                            // CompanyOwnedUser'a atýþta patladý
                                            Tran.RollbackTransaction();
                                            PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                            return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                        }
                                        else
                                        {
                                            ////TODO: Folder Type Geldiðinde Deðiþmesi Gerekecek
                                            //int FolderIDToGo = 0;
                                            //DataTable dtCompanyFolders = GetCompanyFolders(CompanyID, false);
                                            //foreach (DataRow drCompanyFolder in dtCompanyFolders.Rows)
                                            //{
                                            //    if (drCompanyFolder["FolderName"].ToString() == "Satýn Alýnanlar")
                                            //    {
                                            //        FolderIDToGo = Convert.ToInt32(drCompanyFolder["FolderID"]);
                                            //        break;
                                            //    }
                                            //}

                                            ///////////////////////////////////////////////////////
                                            int FolderIDToGo = 0;
                                            DataTable dtCompanyFolderType = GetCompanyFolderByFolderType(CompanyID, PIKCV.COM.EnumDB.FolderTypeID.UsersBough, false);
                                            if (dt.Rows.Count > 0)
                                            {
                                                FolderIDToGo = Convert.ToInt32(dtCompanyFolderType.Rows[0]["FolderID"]);
                                            }
                                            else
                                            {
                                                Tran.RollbackTransaction();
                                                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                                return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                            }


                                            ArrayList arr = new ArrayList(1);
                                            arr.Insert(0, Convert.ToInt32(arrUserID[i]));
                                            if (OldFolderID == 0)
                                            {

                                                PIKCV.DAL.FolderContent objFolderContent = new PIKCV.DAL.FolderContent();
                                                PIKCV.DAL.FolderContent objUserExist = new PIKCV.DAL.FolderContent();

                                                if (UserExistance(Convert.ToInt32(arrUserID[i]), FolderIDToGo) == 0)
                                                {
                                                    objFolderContent.AddNew();
                                                    objFolderContent.FolderID = FolderIDToGo;
                                                    objFolderContent.UserID = Convert.ToInt32(arrUserID[i]);
                                                    objFolderContent.DateAdded = DateTime.Now;
                                                    objFolderContent.IsDeleted = false;
                                                    objFolderContent.TemporaryUserID = 0;
                                                    objFolderContent.Save();
                                                }
                                            }
                                            else
                                            {
                                                PIKCV.DAL.FolderContent objFolderContentCut = new PIKCV.DAL.FolderContent();
                                                objFolderContentCut.Where.FolderID.Value = OldFolderID;
                                                objFolderContentCut.Where.UserID.Value = Convert.ToInt32(arrUserID[i]);
                                                objFolderContentCut.Query.Load();
                                                DataRow dr = objFolderContentCut.DefaultView.ToTable().Rows[0];

                                                PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                                                objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                                                if (UserExistance(Convert.ToInt32(arrUserID[i]), FolderIDToGo) == 0)
                                                {
                                                    objFolder.FolderID = FolderIDToGo;
                                                }
                                                else
                                                {
                                                    objFolder.IsDeleted = true;
                                                }
                                                objFolder.Save();
                                                if (objFolder.RowCount > 0)
                                                {

                                                }
                                                else
                                                {
                                                    // User klasörünü deðiþtirirken patladý
                                                    Tran.RollbackTransaction();
                                                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                // En sonda commit kýsmýnda patlarsa
                                if (Tran != null)
                                {
                                    Tran.RollbackTransaction();
                                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Tran.RollbackTransaction();
                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                }
            }
            Tran.CommitTransaction();
            return PIKCV.COM.Enumerations.BuyContactInfoResult.Success;
        }

        public PIKCV.COM.Enumerations.BuyContactInfoResult BuyContactInfo(int CompanyID, ArrayList arrUserID, int OldFolderID, ref int UsersSuccessfullBoughts)
        {
            int Credit = 0;
            int LastCredit = 0;
            int InsertedOrderID = 0;
            int TotalCreditsUsed = 0;
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();
            Tran.BeginTransaction();
            try
            {
                

                DataTable dtCompanyInfo = new DataTable();
                dtCompanyInfo = GetCompanyInfo(CompanyID);
                if (dtCompanyInfo.Rows.Count > 0)
                {
                    LastCredit = Convert.ToInt32(dtCompanyInfo.Rows[0]["Credits"]);
                }
                else
                {
                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                }

                

                for (int i = 0; i < arrUserID.Count; i++)
                {
                    if (dtCompanyInfo.Rows.Count > 0)
                    {
                        if (!(CheckBuyContactInfo(CompanyID, Convert.ToInt32(arrUserID[i]))))
                        {
                            PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = PIKCV.COM.EnumDB.EmployeeTypes.Unknown;
                            PIKCV.BUS.User objUser = new PIKCV.BUS.User();
                            DataTable dt = objUser.GetUserDetail(Convert.ToInt32(arrUserID[i]));
                            if (dt.Rows.Count > 0)
                            {
                                EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(dt.Rows[0]["EmployeeTypeCode"]));
                            }
                            else
                            {
                                //User Detaylarýný alýrken patladý
                                Tran.RollbackTransaction();
                                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                            }

                            DataRow drCVCredtis = PIKCV.BUS.Orders.GetOrderTypesDetails((int)PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving);
                            if (drCVCredtis != null)
                            {
                                if (EmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik)
                                    Credit = Convert.ToInt32(drCVCredtis["GoodPikCredit"]);
                                else if (EmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool)
                                    Credit = Convert.ToInt32(drCVCredtis["PikPoolCredit"]);
                            }
                            else
                            {
                                //Credi miktarlarýný alýrken patladý
                                Tran.RollbackTransaction();
                                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                            }

                            int Result = 0;
                            if (LastCredit < Credit)
                            {
                                // Yeterli kredi yok
                                Tran.RollbackTransaction();
                                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                return PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi;
                            }
                            else
                            {


                                LastCredit = LastCredit - Credit;
                                UpdateCompanyCredit(Convert.ToInt32(dtCompanyInfo.Rows[0]["CompanyID"]), LastCredit, ref Tran);

                                PIKCV.BUS.Orders Order = new PIKCV.BUS.Orders();

                                if (i == 0)
                                {
                                    InsertedOrderID = Order.InsertOrder(CompanyID, (int)PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving, (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.paid, Credit, 0, true, ref Tran);
                                    TotalCreditsUsed = Credit;
                                }
                                else
                                {
                                    TotalCreditsUsed = TotalCreditsUsed + Credit;
                                }
                                if (InsertedOrderID == 0)
                                {
                                    // Order'a atýþta patladý
                                    Tran.RollbackTransaction();
                                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                }
                                else
                                {
                                    Result = Order.InsertOrderLineItem(InsertedOrderID, Convert.ToInt32(arrUserID[i]), 0, Credit, 0, ref Tran);
                                    if (Result == 0)
                                    {
                                        // OrderLineItem'a atýþta patladý
                                        Tran.RollbackTransaction();
                                        PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                        return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                    }
                                    else
                                    {
                                        PIKCV.DAL.CompanyOwnedUsers objCOmpanyOwnedUser = new PIKCV.DAL.CompanyOwnedUsers();
                                        objCOmpanyOwnedUser.AddNew();
                                        objCOmpanyOwnedUser.CompanyID = CompanyID;
                                        objCOmpanyOwnedUser.UserID = Convert.ToInt32(arrUserID[i]);
                                        objCOmpanyOwnedUser.DateOwned = DateTime.Now;
                                        objCOmpanyOwnedUser.EndDate = DateTime.Now.AddYears(1);
                                        objCOmpanyOwnedUser.Save();
                                        UsersSuccessfullBoughts = UsersSuccessfullBoughts + 1;

                                        if (objCOmpanyOwnedUser.RowID == 0)
                                        {
                                            // CompanyOwnedUser'a atýþta patladý
                                            Tran.RollbackTransaction();
                                            PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                            return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                        }
                                        else
                                        {
                                            //TODO: Folder Type Geldiðinde Deðiþmesi Gerekecek
                                            int FolderIDToGo = 0;
                                            DataTable dtCompanyFolders = GetCompanyFolderByFolderType(CompanyID, PIKCV.COM.EnumDB.FolderTypeID.UsersBough, false);
                                            if (dtCompanyFolders.Rows.Count > 0)
                                            {
                                                FolderIDToGo = Convert.ToInt32(dtCompanyFolders.Rows[0]["FolderID"]);
                                            }
                                            //}
                                            //foreach (DataRow drCompanyFolder in dtCompanyFolders.Rows)
                                            //{
                                            //    if (drCompanyFolder["FolderName"].ToString() == "Satýn Alýnanlar")
                                            //    {
                                            //        FolderIDToGo = Convert.ToInt32(drCompanyFolder["FolderID"]);
                                            //        break;
                                            //    }
                                            //}

                                            ///////////////////////////////////////////////////////
                                            ArrayList arr = new ArrayList(1);
                                            arr.Insert(0, Convert.ToInt32(arrUserID[i]));
                                            if (OldFolderID == 0)
                                            {

                                                PIKCV.DAL.FolderContent objFolderContent = new PIKCV.DAL.FolderContent();
                                                PIKCV.DAL.FolderContent objUserExist = new PIKCV.DAL.FolderContent();

                                                if (UserExistance(Convert.ToInt32(arrUserID[i]), FolderIDToGo) == 0)
                                                {
                                                    objFolderContent.AddNew();
                                                    objFolderContent.FolderID = FolderIDToGo;
                                                    objFolderContent.UserID = Convert.ToInt32(arrUserID[i]);
                                                    objFolderContent.DateAdded = DateTime.Now;
                                                    objFolderContent.IsDeleted = false;
                                                    objFolderContent.TemporaryUserID = 0;
                                                    objFolderContent.Save();
                                                }
                                                //if (objFolderContent.RowID > 0)
                                                //{

                                                //}
                                                //else
                                                //{
                                                //    // Userý klasöre eklerken patladý
                                                //    Tran.RollbackTransaction();
                                                //    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                                //    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                                //}
                                            }
                                            else
                                            {
                                                PIKCV.DAL.FolderContent objFolderContentCut = new PIKCV.DAL.FolderContent();
                                                objFolderContentCut.Where.FolderID.Value = OldFolderID;
                                                objFolderContentCut.Where.UserID.Value = Convert.ToInt32(arrUserID[i]);
                                                objFolderContentCut.Query.Load();
                                                DataRow dr = objFolderContentCut.DefaultView.ToTable().Rows[0];

                                                PIKCV.DAL.FolderContent objFolder = new PIKCV.DAL.FolderContent();
                                                objFolder.LoadByPrimaryKey(Convert.ToInt32(dr["RowID"]));
                                                if (UserExistance(Convert.ToInt32(arrUserID[i]), FolderIDToGo) == 0)
                                                {
                                                    objFolder.FolderID = FolderIDToGo;
                                                }
                                                else
                                                {
                                                    objFolder.IsDeleted = true;
                                                }
                                                objFolder.Save();
                                                if (objFolder.RowCount > 0)
                                                {

                                                }
                                                else
                                                {
                                                    // User klasörünü deðiþtirirken patladý
                                                    Tran.RollbackTransaction();
                                                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                                                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                        else if (i == 0)
                        {
                            PIKCV.BUS.Orders OrderAdd = new PIKCV.BUS.Orders();
                            InsertedOrderID = OrderAdd.InsertOrder(CompanyID, (int)PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving, (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.paid, Credit, 0, true, ref Tran);
                            TotalCreditsUsed = Credit;
                        }
                    }
                    else
                    {
                        Tran.RollbackTransaction();
                        PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                        return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                    }
                }

                PIKCV.DAL.Orders objOrders = new PIKCV.DAL.Orders();
                objOrders.LoadByPrimaryKey(InsertedOrderID);
                objOrders.TotalCreditsUsed = TotalCreditsUsed;
                objOrders.Save();

                Tran.CommitTransaction();
                return PIKCV.COM.Enumerations.BuyContactInfoResult.Success;
            }
            catch (Exception)
            {
                // En sonda commit kýsmýnda patlarsa
                if (Tran != null)
                {
                    Tran.RollbackTransaction();
                    PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                    return PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;
                }
            }
            return PIKCV.COM.Enumerations.BuyContactInfoResult.Success;
        }
    }
}
