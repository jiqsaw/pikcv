using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CARETTA.COM;

namespace PIKCV.BUS
{
    public class Credits
    {
        public DataTable GetCreditPackages()
        {
            PIKCV.DAL.CreditPackages obj = new PIKCV.DAL.CreditPackages();
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        public DataTable GetCreditDetail(int CreditPackageID)
        {
            PIKCV.DAL.CreditPackages obj = new PIKCV.DAL.CreditPackages();
            obj.Where.CreditPackageID.Value = CreditPackageID;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        public int InsertCreditOrders(int CompanyID, int CreditPackageID, int CreditQuantity, double ItemPrice, int OtherPackageQuantity
            , double OtherPackagePrice, PIKCV.COM.EnumDB.OrderTypeCode OrderTypeCode, PIKCV.COM.EnumDB.PaymentType PaymentType, bool IsOtherPackage)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();
            Tran.BeginTransaction();
            int TakenCredit = 0;
            try
            {
                if (PaymentType == PIKCV.COM.EnumDB.PaymentType.Loan)
                {
                    double TotalMoney = 0;
                    if (CreditPackageID > 0)
                    {
                        TotalMoney = CreditQuantity * ItemPrice;
                        TakenCredit = CreditQuantity;
                    }
                    else
                    {
                        TotalMoney = OtherPackageQuantity * OtherPackagePrice;
                        TakenCredit = OtherPackageQuantity;
                    }
                    PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
                    objCompany.LoadByPrimaryKey(CompanyID);
                    objCompany.MaxLoan = objCompany.MaxLoan - TotalMoney;
                    objCompany.Credits = objCompany.Credits + TakenCredit;
                    objCompany.Save();
                }
                PIKCV.DAL.CreditOrders objCreditOrders = new PIKCV.DAL.CreditOrders();
                objCreditOrders.AddNew();
                objCreditOrders.CompanyID = CompanyID;
                objCreditOrders.CreditPackageID = CreditPackageID;
                objCreditOrders.Quantity = CreditQuantity;
                objCreditOrders.ItemPrice = ItemPrice;
                objCreditOrders.OtherPackageQuantity = OtherPackageQuantity;
                objCreditOrders.OtherPackagePrice = OtherPackagePrice;
                objCreditOrders.OrderDate = DateTime.Now;
                objCreditOrders.OrderCode = Util.CreateRandomNumber(12);
                objCreditOrders.OrderTypeID = (int)OrderTypeCode;
                objCreditOrders.PaymentType = (int)PaymentType;
                objCreditOrders.Save();

                PIKCV.DAL.Orders objOrder = new PIKCV.DAL.Orders();
                objOrder.AddNew();
                objOrder.CompanyID = CompanyID;
                if (PaymentType == PIKCV.COM.EnumDB.PaymentType.Transfer)
                {
                    objOrder.IsConfirmed = false;
                    objOrder.ProcessTypeCode = (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.non_invoiced;
                }
                else
                { 
                    objOrder.IsConfirmed = true;
                    objOrder.ProcessTypeCode = (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.unpaid;
                }
                objOrder.OrderDate = DateTime.Now;
                objOrder.OrderTypeID = (int)OrderTypeCode;
                if (IsOtherPackage)
                {
                    objOrder.Price = OtherPackageQuantity * OtherPackagePrice;
                    objOrder.TotalCreditsUsed = OtherPackageQuantity;
                }
                else
                {
                    objOrder.Price = CreditQuantity * ItemPrice;
                    objOrder.TotalCreditsUsed = CreditQuantity;
                }
                objOrder.Save();

                Tran.CommitTransaction();

                return objCreditOrders.CreditOrderID;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;
            }

        }

        public DataTable GetCreditOrderDetail(int CreditOrderID)
        {
            PIKCV.DAL.CreditOrders obj = new PIKCV.DAL.CreditOrders();
            obj.Where.CreditOrderID.Value = CreditOrderID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public DataTable GetCompanyCreditSituation(int CompanyID)
        {
            PIKCV.DAL.Companies obj = new PIKCV.DAL.Companies();
            return obj.GetCompanyCreditSituation(CompanyID);
        }
    }
}
