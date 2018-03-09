using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using CARETTA.COM;
using PIKCV.COM;

namespace PIKCV.BUS
{
    public class Messages
    {

        public static DataTable GetAllMessages(int UserID, bool IsDeleted, EnumDB.MemberTypes MessageOwnerTypeCode) {
            return GetAllMessages(UserID, IsDeleted, MessageOwnerTypeCode, "%", "%");
        }

        //T�m Mesajlar� Getir 
        public static DataTable GetAllMessages(int UserID, bool IsDeleted, EnumDB.MemberTypes MessageOwnerTypeCode, string CompanyID, string JobID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.LoadAllMessages(UserID, IsDeleted, (int)MessageOwnerTypeCode, CompanyID, JobID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Firma Mesajlar� Getir 
        public static DataTable GetCompanyMessages(int CompanyID, bool IsDeleted, EnumDB.MemberTypes MessageOwnerTypeCode)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.GetCompanyMessages(CompanyID, IsDeleted, (int)MessageOwnerTypeCode);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        
        //Firman�n G�nderilen Mesajlar�n� Getir 
        public static DataTable GetCompanySentMessages(int CompanyID, bool IsDeleted, string UserID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.GetCompanySentMessages(CompanyID, IsDeleted, UserID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        
        //
        //Tek Bir Mesaj�n Detay�n� Getir 
        public static DataTable GetMessageByMessageID(int MessageID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.LoadMessageByMessageID(MessageID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Firman�n Tek Bir Mesaj�n Detay�n� Getir 
        public static DataTable GetCompanyMessageByID(int MessageID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.GetCompanyMessageByID(MessageID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Firman�n G�nderilen Mesaj Detay�n� Getir
        public static DataTable GetCompanySendMessageDetail(int MessageID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.GetCompanySendMessageDetail(MessageID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }


        //Kullan�c�n�n Mesaj Say�s�n� Getirir
        public static DataTable GetUserMessageCount(int UserID, int MessageOwnerTypeCode, bool IsRead)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();
                dt = objMessages.GetUserMessageCount(UserID, MessageOwnerTypeCode, IsRead);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Mesaj taslaklar�n getir
        public static DataTable GetMessageDrafts(int CompanyID)
        {
            try
            {
                PIKCV.DAL.MessageDrafts objMessages = new PIKCV.DAL.MessageDrafts();
                objMessages.Where.CompanyID.Value = CompanyID;
                objMessages.Where.IsDeleted.Value = false;
                objMessages.Query.Load();
                return objMessages.DefaultView.ToTable();
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        //Kay�tl� mesaj� sil
        public static void RemoveMessageDraft(int MessageDraftID) {
            PIKCV.DAL.MessageDrafts obj = new PIKCV.DAL.MessageDrafts();
            obj.LoadByPrimaryKey(MessageDraftID);
            obj.DeleteAll();
            obj.Save();
        }

        //Kay�tl� Mesaj�n Detay�n� Getir 
        public static DataTable GetMessageDraftDetail(int MessageDraftID)
        {
            try
            {
                PIKCV.DAL.MessageDrafts objMessages = new PIKCV.DAL.MessageDrafts();
                 objMessages.LoadByPrimaryKey(MessageDraftID);
                return objMessages.DefaultView.ToTable();
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        //Kay�tl� Mesaj� Update Et
        public bool SaveMessageDraft(int MessageDraftID, int CompanyID, string Subject, string Message, string MessageName)
        {
            try
            {
                PIKCV.DAL.MessageDrafts objMessages = new PIKCV.DAL.MessageDrafts();
                if (MessageDraftID < 1)
                {
                    objMessages.AddNew();
                    objMessages.CreateDate = DateTime.Now;
                    objMessages.IsDeleted = false;
                }
                else {
                    objMessages.LoadByPrimaryKey(MessageDraftID);
                }

                objMessages.CompanyID = CompanyID;
                objMessages.Subject = Subject;
                objMessages.Message = Message;
                objMessages.MessageName = MessageName;
                objMessages.ModifyDate = DateTime.Now;
                objMessages.Save();
                return true;
            }
            catch (Exception)
            {                
                throw;
            }
            return false;
        }

        //Mesaj� okunmu�lar stat�s�ne koyar
        public static void MakeMessageReaded(int MessageID)
        {
            try
            {
                PIKCV.DAL.Messages objMessages = new PIKCV.DAL.Messages();

                objMessages.LoadByPrimaryKey(MessageID);
                objMessages.IsRead = true;
                objMessages.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertMessages(int CompanyID, string MessageBody, string MessageTitle, EnumDB.MemberTypes MessageOwnerType, EnumDB.MemberTypes MessageSenderType, ArrayList arrUsers)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                for (int i = 0; i < arrUsers.Count; i++)
                {
                    PIKCV.DAL.Messages obj = new PIKCV.DAL.Messages();

                    obj.AddNew();
                    obj.CreateDate = DateTime.Now;
                    obj.IsDeleted = false;
                    obj.IsRead = false;
                    obj.JobID = 0;
                    obj.MessageBody = CARETTA.COM.Util.ReplaceStrForDB(MessageBody);
                    obj.MessageOwnerID = Convert.ToInt32(arrUsers[i]);
                    obj.MessageOwnerTypeCode = (int)MessageOwnerType;
                    obj.MessageTitle = CARETTA.COM.Util.ReplaceStrForDB(MessageTitle);
                    obj.MessageTypeCode = 1;
                    obj.SenderID = CompanyID;
                    obj.SenderTypeCode = (int)MessageSenderType;
                    obj.Save();
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

        //B�t�n Sistem Mesajlar�n� Getir
        public static DataTable GetSystemDraftMessages(bool IsDeleted)
        {
            try
            {
                PIKCV.DAL.SystemDraftMessages obj = new PIKCV.DAL.SystemDraftMessages();
                obj.Where.IsDeleted.Value = IsDeleted;
                obj.Query.Load();
                return obj.DefaultView.ToTable();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }


        //Kay�tl� Sistem Mesaj�n Detay�n� Getir 
        public static DataTable GetSystemDraftMessageDetail(int SystemMessageDraftID)
        {
            try
            {
                PIKCV.DAL.SystemDraftMessages obj = new PIKCV.DAL.SystemDraftMessages();
                obj.LoadByPrimaryKey(SystemMessageDraftID);
                return obj.DefaultView.ToTable();
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static bool DeleteMesssage(int MessageID)
        {
            try
            {
                PIKCV.DAL.Messages obj = new PIKCV.DAL.Messages();
                obj.LoadByPrimaryKey(MessageID);
                obj.IsDeleted = true;
                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}