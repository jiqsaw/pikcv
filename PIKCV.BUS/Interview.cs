using System;
using System.Collections.Generic;
using System.Text;
using CARETTA.COM;
using System.Data;
using System.Collections;

namespace PIKCV.BUS
{
    public class Interview
    {
        public bool InsertInterview(int CompanyID, int CompanyAdvisorID, DateTime InterviewDate, DateTime InterviewEndTime,
            PIKCV.COM.EnumDB.MemberTypes InterviewerTypeCode, string InterviewPlace, DateTime InterviewStartTime, int PositionID,
            int UpdatedBy, ArrayList arrSelectedUsers, string CompanyAdvisorName)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.Interviews objInterview = new PIKCV.DAL.Interviews();
                PIKCV.DAL.Messages objMessage = new PIKCV.DAL.Messages();
                PIKCV.DAL.User objUser = new PIKCV.DAL.User();
                PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
                string MessageBody = "";

                Tran.BeginTransaction();
                for (int i = 0; i < arrSelectedUsers.Count; i++)
                {
                    objInterview.AddNew();
                    objInterview.CompanyAdvisorID = CompanyAdvisorID;
                    objInterview.CreateDate = DateTime.Now;
                    objInterview.InterviewDate = InterviewDate;
                    objInterview.InterviewEndTime = InterviewEndTime;
                    objInterview.InterviewerID = CompanyID;
                    objInterview.InterviewerTypeCode = (int)InterviewerTypeCode;
                    objInterview.InterviewNotes = PIKCV.COM.Util.ReturnEmptyString(String.Empty);
                    objInterview.InterviewPlace = InterviewPlace;
                    objInterview.InterviewRating = 0;
                    objInterview.InterviewStartTime = InterviewStartTime;
                    objInterview.InterviewStatusID = 1;
                    objInterview.JobID = 0;
                    objInterview.PositionID = PositionID;
                    objInterview.ModifyDate = DateTime.Now;
                    objInterview.UpdatedBy = UpdatedBy;
                    objInterview.UserID = Convert.ToInt32(arrSelectedUsers[i]);
                    objInterview.Save();

                    objUser.LoadByPrimaryKey(Convert.ToInt32(arrSelectedUsers[i]));
                    objCompany.LoadByPrimaryKey(CompanyID);

                    MessageBody = objCompany.CompanyName + " þirketi tarafýndan mülakata çaðrýldýnýz" +
                                  "<br><br>Tarih: " + InterviewDate.ToShortDateString() +
                                  "<br><br>Saat: " + InterviewStartTime.Hour.ToString() + ":" + InterviewStartTime.Minute.ToString() + "-" +
                                  InterviewEndTime.Hour.ToString() + ":" + InterviewEndTime.Minute.ToString() +
                                  "<br><br>Yer: " + InterviewPlace +
                                  "<br><br>Danýþman: " + CompanyAdvisorName;

                    objMessage.AddNew();
                    objMessage.CreateDate = DateTime.Now;
                    objMessage.IsDeleted = false;
                    objMessage.IsRead = false;
                    objMessage.JobID = 0;
                    objMessage.MessageOwnerID = Convert.ToInt32(arrSelectedUsers[i]);
                    objMessage.MessageOwnerTypeCode = (int)PIKCV.COM.EnumDB.MemberTypes.Employee;
                    objMessage.MessageTitle = "Mülakat Daveti";
                    objMessage.MessageBody = MessageBody;
                    objMessage.MessageTypeCode = (int)PIKCV.COM.EnumDB.MessageTypeCode.Interview;
                    objMessage.SenderID = CompanyID;
                    objMessage.SenderTypeCode = (int)PIKCV.COM.EnumDB.MemberTypes.Company;
                    objMessage.Save();
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
    }
}
