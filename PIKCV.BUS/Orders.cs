using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PIKCV.COM;

namespace PIKCV.BUS
{
    public class Orders
    {
        public static DataTable GetOrders(PIKCV.COM.EnumDB.OrderProcessTypeCode OrderProcessTypeCode)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Orders objOrders = new PIKCV.DAL.Orders();
                objOrders.Where.ProcessTypeCode.Value = OrderProcessTypeCode;
                objOrders.Query.Load();
                dt = objOrders.DefaultView.ToTable();
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Insert CompanyOwnedUser
        public int InsertOrder(int CompanyID, int OrderTypeID, int ProcessType, int TotalCreditUsed, float Price, bool IsConfirmed, ref PIKCV.DAO.TransactionMgr Tran)
        {
            try
            {
                PIKCV.DAL.Orders objOrder = new PIKCV.DAL.Orders();
                objOrder.AddNew();
                objOrder.CompanyID = CompanyID;
                objOrder.OrderTypeID = OrderTypeID;
                objOrder.ProcessTypeCode = ProcessType ;
                objOrder.TotalCreditsUsed = TotalCreditUsed;
                objOrder.Price = Price;
                objOrder.IsConfirmed = IsConfirmed;
                objOrder.OrderDate = DateTime.Now;
                objOrder.Save();
                return objOrder.OrderID;
            }
            catch (Exception)
            {
                //Tran.RollbackTransaction();
                //PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;   
            }
        }

        //Insert CompanyOwnedUser
        public int InsertOrderLineItem(int OrderID, int UserID, int JobID, int CreditUsed, float Price, ref PIKCV.DAO.TransactionMgr Tran)
        {
            try
            {
                PIKCV.DAL.OrderLineItems objOrderLineItem = new PIKCV.DAL.OrderLineItems();
                objOrderLineItem.AddNew();
                objOrderLineItem.OrderID = OrderID;
                objOrderLineItem.UserID = UserID;
                objOrderLineItem.JobID = JobID;
                objOrderLineItem.CreditUsed = CreditUsed;
                objOrderLineItem.Price = Price;
                objOrderLineItem.Save();
                return objOrderLineItem.OrderLineItemID;
            }
            catch (Exception)
            {
                //Tran.RollbackTransaction();
                //PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;
            }
        }

        public static DataRow GetOrderTypesDetails(int OrderTypeID)
        {
            try
            {
                PIKCV.DAL.OrderTypes obj = new PIKCV.DAL.OrderTypes();
                obj.Where.OrderTypeID.Value = OrderTypeID;
                obj.Query.Load();
                return obj.DefaultView.ToTable().Rows[0];
            }
            catch (Exception)
            {
                return null;
            }

        }

        //Ýþlemler
        public DataTable GetTransactions(int CompanyID, PIKCV.COM.EnumDB.OrderProcessTypeCode ProcessTypeCode, PIKCV.COM.EnumDB.LanguageID LanguageID, PIKCV.COM.EnumDB.OrderTypeCode OrderTypeCode)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Orders obj = new PIKCV.DAL.Orders();
                dt = obj.GetTransactions(CompanyID, (int)ProcessTypeCode, (int)LanguageID, (int)OrderTypeCode);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Ýþlem Raporlarý
        public DataTable GetTransactionReport(int CompanyID, PIKCV.COM.EnumDB.OrderTypeCode OrderType_CV, PIKCV.COM.EnumDB.OrderTypeCode OrderType_BuyCredit, PIKCV.COM.EnumDB.OrderProcessTypeCode GetTransactionReport, bool IsConfirmed,
                PIKCV.COM.EnumDB.LanguageID LanguageID, DateTime OrderStartDate, DateTime OrderEndDate)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Orders obj = new PIKCV.DAL.Orders();
                dt = obj.GetTransactionReport(CompanyID, (int)OrderType_CV, (int)OrderType_BuyCredit, (int)GetTransactionReport, IsConfirmed, (int)LanguageID, OrderStartDate, OrderEndDate);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }    

    }
}
