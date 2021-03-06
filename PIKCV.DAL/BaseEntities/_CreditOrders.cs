
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using PIKCV.DAO;

namespace PIKCV.DAL
{
	public abstract class _CreditOrders : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _CreditOrders()
		{
			this.QuerySource = "CreditOrders";
			this.MappingName = "CreditOrders";

		this.SchemaStoredProcedure = m_SchemaStoredProcedure;
		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CreditOrdersLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CreditOrderID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CreditOrderID, CreditOrderID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CreditOrdersLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CreditOrderID
			{
				get
				{
					return new SqlParameter("@CreditOrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CompanyID
			{
				get
				{
					return new SqlParameter("@CompanyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreditPackageID
			{
				get
				{
					return new SqlParameter("@CreditPackageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Quantity
			{
				get
				{
					return new SqlParameter("@Quantity", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ItemPrice
			{
				get
				{
					return new SqlParameter("@ItemPrice", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter OtherPackageQuantity
			{
				get
				{
					return new SqlParameter("@OtherPackageQuantity", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter OtherPackagePrice
			{
				get
				{
					return new SqlParameter("@OtherPackagePrice", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter OrderDate
			{
				get
				{
					return new SqlParameter("@OrderDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter OrderCode
			{
				get
				{
					return new SqlParameter("@OrderCode", SqlDbType.NVarChar, 12);
				}
			}
			
			public static SqlParameter OrderTypeID
			{
				get
				{
					return new SqlParameter("@OrderTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PaymentType
			{
				get
				{
					return new SqlParameter("@PaymentType", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CreditOrderID = "CreditOrderID";
            public const string CompanyID = "CompanyID";
            public const string CreditPackageID = "CreditPackageID";
            public const string Quantity = "Quantity";
            public const string ItemPrice = "ItemPrice";
            public const string OtherPackageQuantity = "OtherPackageQuantity";
            public const string OtherPackagePrice = "OtherPackagePrice";
            public const string OrderDate = "OrderDate";
            public const string OrderCode = "OrderCode";
            public const string OrderTypeID = "OrderTypeID";
            public const string PaymentType = "PaymentType";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CreditOrderID] = _CreditOrders.PropertyNames.CreditOrderID;
					ht[CompanyID] = _CreditOrders.PropertyNames.CompanyID;
					ht[CreditPackageID] = _CreditOrders.PropertyNames.CreditPackageID;
					ht[Quantity] = _CreditOrders.PropertyNames.Quantity;
					ht[ItemPrice] = _CreditOrders.PropertyNames.ItemPrice;
					ht[OtherPackageQuantity] = _CreditOrders.PropertyNames.OtherPackageQuantity;
					ht[OtherPackagePrice] = _CreditOrders.PropertyNames.OtherPackagePrice;
					ht[OrderDate] = _CreditOrders.PropertyNames.OrderDate;
					ht[OrderCode] = _CreditOrders.PropertyNames.OrderCode;
					ht[OrderTypeID] = _CreditOrders.PropertyNames.OrderTypeID;
					ht[PaymentType] = _CreditOrders.PropertyNames.PaymentType;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CreditOrderID = "CreditOrderID";
            public const string CompanyID = "CompanyID";
            public const string CreditPackageID = "CreditPackageID";
            public const string Quantity = "Quantity";
            public const string ItemPrice = "ItemPrice";
            public const string OtherPackageQuantity = "OtherPackageQuantity";
            public const string OtherPackagePrice = "OtherPackagePrice";
            public const string OrderDate = "OrderDate";
            public const string OrderCode = "OrderCode";
            public const string OrderTypeID = "OrderTypeID";
            public const string PaymentType = "PaymentType";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CreditOrderID] = _CreditOrders.ColumnNames.CreditOrderID;
					ht[CompanyID] = _CreditOrders.ColumnNames.CompanyID;
					ht[CreditPackageID] = _CreditOrders.ColumnNames.CreditPackageID;
					ht[Quantity] = _CreditOrders.ColumnNames.Quantity;
					ht[ItemPrice] = _CreditOrders.ColumnNames.ItemPrice;
					ht[OtherPackageQuantity] = _CreditOrders.ColumnNames.OtherPackageQuantity;
					ht[OtherPackagePrice] = _CreditOrders.ColumnNames.OtherPackagePrice;
					ht[OrderDate] = _CreditOrders.ColumnNames.OrderDate;
					ht[OrderCode] = _CreditOrders.ColumnNames.OrderCode;
					ht[OrderTypeID] = _CreditOrders.ColumnNames.OrderTypeID;
					ht[PaymentType] = _CreditOrders.ColumnNames.PaymentType;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CreditOrderID = "s_CreditOrderID";
            public const string CompanyID = "s_CompanyID";
            public const string CreditPackageID = "s_CreditPackageID";
            public const string Quantity = "s_Quantity";
            public const string ItemPrice = "s_ItemPrice";
            public const string OtherPackageQuantity = "s_OtherPackageQuantity";
            public const string OtherPackagePrice = "s_OtherPackagePrice";
            public const string OrderDate = "s_OrderDate";
            public const string OrderCode = "s_OrderCode";
            public const string OrderTypeID = "s_OrderTypeID";
            public const string PaymentType = "s_PaymentType";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CreditOrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.CreditOrderID);
			}
			set
	        {
				base.Setint(ColumnNames.CreditOrderID, value);
			}
		}

		public virtual int CompanyID
	    {
			get
	        {
				return base.Getint(ColumnNames.CompanyID);
			}
			set
	        {
				base.Setint(ColumnNames.CompanyID, value);
			}
		}

		public virtual int CreditPackageID
	    {
			get
	        {
				return base.Getint(ColumnNames.CreditPackageID);
			}
			set
	        {
				base.Setint(ColumnNames.CreditPackageID, value);
			}
		}

		public virtual int Quantity
	    {
			get
	        {
				return base.Getint(ColumnNames.Quantity);
			}
			set
	        {
				base.Setint(ColumnNames.Quantity, value);
			}
		}

		public virtual double ItemPrice
	    {
			get
	        {
				return base.Getdouble(ColumnNames.ItemPrice);
			}
			set
	        {
				base.Setdouble(ColumnNames.ItemPrice, value);
			}
		}

		public virtual int OtherPackageQuantity
	    {
			get
	        {
				return base.Getint(ColumnNames.OtherPackageQuantity);
			}
			set
	        {
				base.Setint(ColumnNames.OtherPackageQuantity, value);
			}
		}

		public virtual double OtherPackagePrice
	    {
			get
	        {
				return base.Getdouble(ColumnNames.OtherPackagePrice);
			}
			set
	        {
				base.Setdouble(ColumnNames.OtherPackagePrice, value);
			}
		}

		public virtual DateTime OrderDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.OrderDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.OrderDate, value);
			}
		}

		public virtual string OrderCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.OrderCode);
			}
			set
	        {
				base.Setstring(ColumnNames.OrderCode, value);
			}
		}

		public virtual int OrderTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderTypeID, value);
			}
		}

		public virtual int PaymentType
	    {
			get
	        {
				return base.Getint(ColumnNames.PaymentType);
			}
			set
	        {
				base.Setint(ColumnNames.PaymentType, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CreditOrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreditOrderID) ? string.Empty : base.GetintAsString(ColumnNames.CreditOrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreditOrderID);
				else
					this.CreditOrderID = base.SetintAsString(ColumnNames.CreditOrderID, value);
			}
		}

		public virtual string s_CompanyID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompanyID) ? string.Empty : base.GetintAsString(ColumnNames.CompanyID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompanyID);
				else
					this.CompanyID = base.SetintAsString(ColumnNames.CompanyID, value);
			}
		}

		public virtual string s_CreditPackageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreditPackageID) ? string.Empty : base.GetintAsString(ColumnNames.CreditPackageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreditPackageID);
				else
					this.CreditPackageID = base.SetintAsString(ColumnNames.CreditPackageID, value);
			}
		}

		public virtual string s_Quantity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Quantity) ? string.Empty : base.GetintAsString(ColumnNames.Quantity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Quantity);
				else
					this.Quantity = base.SetintAsString(ColumnNames.Quantity, value);
			}
		}

		public virtual string s_ItemPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ItemPrice) ? string.Empty : base.GetdoubleAsString(ColumnNames.ItemPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ItemPrice);
				else
					this.ItemPrice = base.SetdoubleAsString(ColumnNames.ItemPrice, value);
			}
		}

		public virtual string s_OtherPackageQuantity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OtherPackageQuantity) ? string.Empty : base.GetintAsString(ColumnNames.OtherPackageQuantity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OtherPackageQuantity);
				else
					this.OtherPackageQuantity = base.SetintAsString(ColumnNames.OtherPackageQuantity, value);
			}
		}

		public virtual string s_OtherPackagePrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OtherPackagePrice) ? string.Empty : base.GetdoubleAsString(ColumnNames.OtherPackagePrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OtherPackagePrice);
				else
					this.OtherPackagePrice = base.SetdoubleAsString(ColumnNames.OtherPackagePrice, value);
			}
		}

		public virtual string s_OrderDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.OrderDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderDate);
				else
					this.OrderDate = base.SetDateTimeAsString(ColumnNames.OrderDate, value);
			}
		}

		public virtual string s_OrderCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderCode) ? string.Empty : base.GetstringAsString(ColumnNames.OrderCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderCode);
				else
					this.OrderCode = base.SetstringAsString(ColumnNames.OrderCode, value);
			}
		}

		public virtual string s_OrderTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderTypeID) ? string.Empty : base.GetintAsString(ColumnNames.OrderTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderTypeID);
				else
					this.OrderTypeID = base.SetintAsString(ColumnNames.OrderTypeID, value);
			}
		}

		public virtual string s_PaymentType
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PaymentType) ? string.Empty : base.GetintAsString(ColumnNames.PaymentType);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PaymentType);
				else
					this.PaymentType = base.SetintAsString(ColumnNames.PaymentType, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter CreditOrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreditOrderID, Parameters.CreditOrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CompanyID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompanyID, Parameters.CompanyID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreditPackageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreditPackageID, Parameters.CreditPackageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Quantity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Quantity, Parameters.Quantity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ItemPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ItemPrice, Parameters.ItemPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OtherPackageQuantity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OtherPackageQuantity, Parameters.OtherPackageQuantity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OtherPackagePrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OtherPackagePrice, Parameters.OtherPackagePrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderDate, Parameters.OrderDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderCode, Parameters.OrderCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderTypeID, Parameters.OrderTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PaymentType
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PaymentType, Parameters.PaymentType);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CreditOrderID
		    {
				get
		        {
					if(_CreditOrderID_W == null)
	        	    {
						_CreditOrderID_W = TearOff.CreditOrderID;
					}
					return _CreditOrderID_W;
				}
			}

			public WhereParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
				}
			}

			public WhereParameter CreditPackageID
		    {
				get
		        {
					if(_CreditPackageID_W == null)
	        	    {
						_CreditPackageID_W = TearOff.CreditPackageID;
					}
					return _CreditPackageID_W;
				}
			}

			public WhereParameter Quantity
		    {
				get
		        {
					if(_Quantity_W == null)
	        	    {
						_Quantity_W = TearOff.Quantity;
					}
					return _Quantity_W;
				}
			}

			public WhereParameter ItemPrice
		    {
				get
		        {
					if(_ItemPrice_W == null)
	        	    {
						_ItemPrice_W = TearOff.ItemPrice;
					}
					return _ItemPrice_W;
				}
			}

			public WhereParameter OtherPackageQuantity
		    {
				get
		        {
					if(_OtherPackageQuantity_W == null)
	        	    {
						_OtherPackageQuantity_W = TearOff.OtherPackageQuantity;
					}
					return _OtherPackageQuantity_W;
				}
			}

			public WhereParameter OtherPackagePrice
		    {
				get
		        {
					if(_OtherPackagePrice_W == null)
	        	    {
						_OtherPackagePrice_W = TearOff.OtherPackagePrice;
					}
					return _OtherPackagePrice_W;
				}
			}

			public WhereParameter OrderDate
		    {
				get
		        {
					if(_OrderDate_W == null)
	        	    {
						_OrderDate_W = TearOff.OrderDate;
					}
					return _OrderDate_W;
				}
			}

			public WhereParameter OrderCode
		    {
				get
		        {
					if(_OrderCode_W == null)
	        	    {
						_OrderCode_W = TearOff.OrderCode;
					}
					return _OrderCode_W;
				}
			}

			public WhereParameter OrderTypeID
		    {
				get
		        {
					if(_OrderTypeID_W == null)
	        	    {
						_OrderTypeID_W = TearOff.OrderTypeID;
					}
					return _OrderTypeID_W;
				}
			}

			public WhereParameter PaymentType
		    {
				get
		        {
					if(_PaymentType_W == null)
	        	    {
						_PaymentType_W = TearOff.PaymentType;
					}
					return _PaymentType_W;
				}
			}

			private WhereParameter _CreditOrderID_W = null;
			private WhereParameter _CompanyID_W = null;
			private WhereParameter _CreditPackageID_W = null;
			private WhereParameter _Quantity_W = null;
			private WhereParameter _ItemPrice_W = null;
			private WhereParameter _OtherPackageQuantity_W = null;
			private WhereParameter _OtherPackagePrice_W = null;
			private WhereParameter _OrderDate_W = null;
			private WhereParameter _OrderCode_W = null;
			private WhereParameter _OrderTypeID_W = null;
			private WhereParameter _PaymentType_W = null;

			public void WhereClauseReset()
			{
				_CreditOrderID_W = null;
				_CompanyID_W = null;
				_CreditPackageID_W = null;
				_Quantity_W = null;
				_ItemPrice_W = null;
				_OtherPackageQuantity_W = null;
				_OtherPackagePrice_W = null;
				_OrderDate_W = null;
				_OrderCode_W = null;
				_OrderTypeID_W = null;
				_PaymentType_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter CreditOrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreditOrderID, Parameters.CreditOrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CompanyID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompanyID, Parameters.CompanyID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreditPackageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreditPackageID, Parameters.CreditPackageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Quantity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Quantity, Parameters.Quantity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ItemPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ItemPrice, Parameters.ItemPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OtherPackageQuantity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OtherPackageQuantity, Parameters.OtherPackageQuantity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OtherPackagePrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OtherPackagePrice, Parameters.OtherPackagePrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderDate, Parameters.OrderDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderCode, Parameters.OrderCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderTypeID, Parameters.OrderTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PaymentType
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PaymentType, Parameters.PaymentType);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CreditOrderID
		    {
				get
		        {
					if(_CreditOrderID_W == null)
	        	    {
						_CreditOrderID_W = TearOff.CreditOrderID;
					}
					return _CreditOrderID_W;
				}
			}

			public AggregateParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
				}
			}

			public AggregateParameter CreditPackageID
		    {
				get
		        {
					if(_CreditPackageID_W == null)
	        	    {
						_CreditPackageID_W = TearOff.CreditPackageID;
					}
					return _CreditPackageID_W;
				}
			}

			public AggregateParameter Quantity
		    {
				get
		        {
					if(_Quantity_W == null)
	        	    {
						_Quantity_W = TearOff.Quantity;
					}
					return _Quantity_W;
				}
			}

			public AggregateParameter ItemPrice
		    {
				get
		        {
					if(_ItemPrice_W == null)
	        	    {
						_ItemPrice_W = TearOff.ItemPrice;
					}
					return _ItemPrice_W;
				}
			}

			public AggregateParameter OtherPackageQuantity
		    {
				get
		        {
					if(_OtherPackageQuantity_W == null)
	        	    {
						_OtherPackageQuantity_W = TearOff.OtherPackageQuantity;
					}
					return _OtherPackageQuantity_W;
				}
			}

			public AggregateParameter OtherPackagePrice
		    {
				get
		        {
					if(_OtherPackagePrice_W == null)
	        	    {
						_OtherPackagePrice_W = TearOff.OtherPackagePrice;
					}
					return _OtherPackagePrice_W;
				}
			}

			public AggregateParameter OrderDate
		    {
				get
		        {
					if(_OrderDate_W == null)
	        	    {
						_OrderDate_W = TearOff.OrderDate;
					}
					return _OrderDate_W;
				}
			}

			public AggregateParameter OrderCode
		    {
				get
		        {
					if(_OrderCode_W == null)
	        	    {
						_OrderCode_W = TearOff.OrderCode;
					}
					return _OrderCode_W;
				}
			}

			public AggregateParameter OrderTypeID
		    {
				get
		        {
					if(_OrderTypeID_W == null)
	        	    {
						_OrderTypeID_W = TearOff.OrderTypeID;
					}
					return _OrderTypeID_W;
				}
			}

			public AggregateParameter PaymentType
		    {
				get
		        {
					if(_PaymentType_W == null)
	        	    {
						_PaymentType_W = TearOff.PaymentType;
					}
					return _PaymentType_W;
				}
			}

			private AggregateParameter _CreditOrderID_W = null;
			private AggregateParameter _CompanyID_W = null;
			private AggregateParameter _CreditPackageID_W = null;
			private AggregateParameter _Quantity_W = null;
			private AggregateParameter _ItemPrice_W = null;
			private AggregateParameter _OtherPackageQuantity_W = null;
			private AggregateParameter _OtherPackagePrice_W = null;
			private AggregateParameter _OrderDate_W = null;
			private AggregateParameter _OrderCode_W = null;
			private AggregateParameter _OrderTypeID_W = null;
			private AggregateParameter _PaymentType_W = null;

			public void AggregateClauseReset()
			{
				_CreditOrderID_W = null;
				_CompanyID_W = null;
				_CreditPackageID_W = null;
				_Quantity_W = null;
				_ItemPrice_W = null;
				_OtherPackageQuantity_W = null;
				_OtherPackagePrice_W = null;
				_OrderDate_W = null;
				_OrderCode_W = null;
				_OrderTypeID_W = null;
				_PaymentType_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrdersInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CreditOrderID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrdersUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrdersDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CreditOrderID);
			p.SourceColumn = ColumnNames.CreditOrderID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CreditOrderID);
			p.SourceColumn = ColumnNames.CreditOrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreditPackageID);
			p.SourceColumn = ColumnNames.CreditPackageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Quantity);
			p.SourceColumn = ColumnNames.Quantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ItemPrice);
			p.SourceColumn = ColumnNames.ItemPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OtherPackageQuantity);
			p.SourceColumn = ColumnNames.OtherPackageQuantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OtherPackagePrice);
			p.SourceColumn = ColumnNames.OtherPackagePrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderDate);
			p.SourceColumn = ColumnNames.OrderDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderCode);
			p.SourceColumn = ColumnNames.OrderCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderTypeID);
			p.SourceColumn = ColumnNames.OrderTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PaymentType);
			p.SourceColumn = ColumnNames.PaymentType;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
