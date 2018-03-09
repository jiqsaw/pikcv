
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
	public abstract class _CreditOrderLineItem : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _CreditOrderLineItem()
		{
			this.QuerySource = "CreditOrderLineItem";
			this.MappingName = "CreditOrderLineItem";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CreditOrderLineItemLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CreditOrderLineItemID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CreditOrderLineItemID, CreditOrderLineItemID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CreditOrderLineItemLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CreditOrderLineItemID
			{
				get
				{
					return new SqlParameter("@CreditOrderLineItemID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreditOrderID
			{
				get
				{
					return new SqlParameter("@CreditOrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreditPackageID
			{
				get
				{
					return new SqlParameter("@CreditPackageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter OtherPackageCredits
			{
				get
				{
					return new SqlParameter("@OtherPackageCredits", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter OtherPackagePrice
			{
				get
				{
					return new SqlParameter("@OtherPackagePrice", SqlDbType.Float, 0);
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
			
			public static SqlParameter SubTotal
			{
				get
				{
					return new SqlParameter("@SubTotal", SqlDbType.Float, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CreditOrderLineItemID = "CreditOrderLineItemID";
            public const string CreditOrderID = "CreditOrderID";
            public const string CreditPackageID = "CreditPackageID";
            public const string OtherPackageCredits = "OtherPackageCredits";
            public const string OtherPackagePrice = "OtherPackagePrice";
            public const string Quantity = "Quantity";
            public const string ItemPrice = "ItemPrice";
            public const string SubTotal = "SubTotal";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CreditOrderLineItemID] = _CreditOrderLineItem.PropertyNames.CreditOrderLineItemID;
					ht[CreditOrderID] = _CreditOrderLineItem.PropertyNames.CreditOrderID;
					ht[CreditPackageID] = _CreditOrderLineItem.PropertyNames.CreditPackageID;
					ht[OtherPackageCredits] = _CreditOrderLineItem.PropertyNames.OtherPackageCredits;
					ht[OtherPackagePrice] = _CreditOrderLineItem.PropertyNames.OtherPackagePrice;
					ht[Quantity] = _CreditOrderLineItem.PropertyNames.Quantity;
					ht[ItemPrice] = _CreditOrderLineItem.PropertyNames.ItemPrice;
					ht[SubTotal] = _CreditOrderLineItem.PropertyNames.SubTotal;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CreditOrderLineItemID = "CreditOrderLineItemID";
            public const string CreditOrderID = "CreditOrderID";
            public const string CreditPackageID = "CreditPackageID";
            public const string OtherPackageCredits = "OtherPackageCredits";
            public const string OtherPackagePrice = "OtherPackagePrice";
            public const string Quantity = "Quantity";
            public const string ItemPrice = "ItemPrice";
            public const string SubTotal = "SubTotal";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CreditOrderLineItemID] = _CreditOrderLineItem.ColumnNames.CreditOrderLineItemID;
					ht[CreditOrderID] = _CreditOrderLineItem.ColumnNames.CreditOrderID;
					ht[CreditPackageID] = _CreditOrderLineItem.ColumnNames.CreditPackageID;
					ht[OtherPackageCredits] = _CreditOrderLineItem.ColumnNames.OtherPackageCredits;
					ht[OtherPackagePrice] = _CreditOrderLineItem.ColumnNames.OtherPackagePrice;
					ht[Quantity] = _CreditOrderLineItem.ColumnNames.Quantity;
					ht[ItemPrice] = _CreditOrderLineItem.ColumnNames.ItemPrice;
					ht[SubTotal] = _CreditOrderLineItem.ColumnNames.SubTotal;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CreditOrderLineItemID = "s_CreditOrderLineItemID";
            public const string CreditOrderID = "s_CreditOrderID";
            public const string CreditPackageID = "s_CreditPackageID";
            public const string OtherPackageCredits = "s_OtherPackageCredits";
            public const string OtherPackagePrice = "s_OtherPackagePrice";
            public const string Quantity = "s_Quantity";
            public const string ItemPrice = "s_ItemPrice";
            public const string SubTotal = "s_SubTotal";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CreditOrderLineItemID
	    {
			get
	        {
				return base.Getint(ColumnNames.CreditOrderLineItemID);
			}
			set
	        {
				base.Setint(ColumnNames.CreditOrderLineItemID, value);
			}
		}

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

		public virtual int OtherPackageCredits
	    {
			get
	        {
				return base.Getint(ColumnNames.OtherPackageCredits);
			}
			set
	        {
				base.Setint(ColumnNames.OtherPackageCredits, value);
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

		public virtual double SubTotal
	    {
			get
	        {
				return base.Getdouble(ColumnNames.SubTotal);
			}
			set
	        {
				base.Setdouble(ColumnNames.SubTotal, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CreditOrderLineItemID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreditOrderLineItemID) ? string.Empty : base.GetintAsString(ColumnNames.CreditOrderLineItemID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreditOrderLineItemID);
				else
					this.CreditOrderLineItemID = base.SetintAsString(ColumnNames.CreditOrderLineItemID, value);
			}
		}

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

		public virtual string s_OtherPackageCredits
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OtherPackageCredits) ? string.Empty : base.GetintAsString(ColumnNames.OtherPackageCredits);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OtherPackageCredits);
				else
					this.OtherPackageCredits = base.SetintAsString(ColumnNames.OtherPackageCredits, value);
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

		public virtual string s_SubTotal
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SubTotal) ? string.Empty : base.GetdoubleAsString(ColumnNames.SubTotal);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SubTotal);
				else
					this.SubTotal = base.SetdoubleAsString(ColumnNames.SubTotal, value);
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
				
				
				public WhereParameter CreditOrderLineItemID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreditOrderLineItemID, Parameters.CreditOrderLineItemID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter CreditPackageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreditPackageID, Parameters.CreditPackageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OtherPackageCredits
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OtherPackageCredits, Parameters.OtherPackageCredits);
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

				public WhereParameter SubTotal
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SubTotal, Parameters.SubTotal);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CreditOrderLineItemID
		    {
				get
		        {
					if(_CreditOrderLineItemID_W == null)
	        	    {
						_CreditOrderLineItemID_W = TearOff.CreditOrderLineItemID;
					}
					return _CreditOrderLineItemID_W;
				}
			}

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

			public WhereParameter OtherPackageCredits
		    {
				get
		        {
					if(_OtherPackageCredits_W == null)
	        	    {
						_OtherPackageCredits_W = TearOff.OtherPackageCredits;
					}
					return _OtherPackageCredits_W;
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

			public WhereParameter SubTotal
		    {
				get
		        {
					if(_SubTotal_W == null)
	        	    {
						_SubTotal_W = TearOff.SubTotal;
					}
					return _SubTotal_W;
				}
			}

			private WhereParameter _CreditOrderLineItemID_W = null;
			private WhereParameter _CreditOrderID_W = null;
			private WhereParameter _CreditPackageID_W = null;
			private WhereParameter _OtherPackageCredits_W = null;
			private WhereParameter _OtherPackagePrice_W = null;
			private WhereParameter _Quantity_W = null;
			private WhereParameter _ItemPrice_W = null;
			private WhereParameter _SubTotal_W = null;

			public void WhereClauseReset()
			{
				_CreditOrderLineItemID_W = null;
				_CreditOrderID_W = null;
				_CreditPackageID_W = null;
				_OtherPackageCredits_W = null;
				_OtherPackagePrice_W = null;
				_Quantity_W = null;
				_ItemPrice_W = null;
				_SubTotal_W = null;

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
				
				
				public AggregateParameter CreditOrderLineItemID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreditOrderLineItemID, Parameters.CreditOrderLineItemID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter CreditPackageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreditPackageID, Parameters.CreditPackageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OtherPackageCredits
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OtherPackageCredits, Parameters.OtherPackageCredits);
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

				public AggregateParameter SubTotal
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SubTotal, Parameters.SubTotal);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CreditOrderLineItemID
		    {
				get
		        {
					if(_CreditOrderLineItemID_W == null)
	        	    {
						_CreditOrderLineItemID_W = TearOff.CreditOrderLineItemID;
					}
					return _CreditOrderLineItemID_W;
				}
			}

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

			public AggregateParameter OtherPackageCredits
		    {
				get
		        {
					if(_OtherPackageCredits_W == null)
	        	    {
						_OtherPackageCredits_W = TearOff.OtherPackageCredits;
					}
					return _OtherPackageCredits_W;
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

			public AggregateParameter SubTotal
		    {
				get
		        {
					if(_SubTotal_W == null)
	        	    {
						_SubTotal_W = TearOff.SubTotal;
					}
					return _SubTotal_W;
				}
			}

			private AggregateParameter _CreditOrderLineItemID_W = null;
			private AggregateParameter _CreditOrderID_W = null;
			private AggregateParameter _CreditPackageID_W = null;
			private AggregateParameter _OtherPackageCredits_W = null;
			private AggregateParameter _OtherPackagePrice_W = null;
			private AggregateParameter _Quantity_W = null;
			private AggregateParameter _ItemPrice_W = null;
			private AggregateParameter _SubTotal_W = null;

			public void AggregateClauseReset()
			{
				_CreditOrderLineItemID_W = null;
				_CreditOrderID_W = null;
				_CreditPackageID_W = null;
				_OtherPackageCredits_W = null;
				_OtherPackagePrice_W = null;
				_Quantity_W = null;
				_ItemPrice_W = null;
				_SubTotal_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrderLineItemInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CreditOrderLineItemID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrderLineItemUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CreditOrderLineItemDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CreditOrderLineItemID);
			p.SourceColumn = ColumnNames.CreditOrderLineItemID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CreditOrderLineItemID);
			p.SourceColumn = ColumnNames.CreditOrderLineItemID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreditOrderID);
			p.SourceColumn = ColumnNames.CreditOrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreditPackageID);
			p.SourceColumn = ColumnNames.CreditPackageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OtherPackageCredits);
			p.SourceColumn = ColumnNames.OtherPackageCredits;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OtherPackagePrice);
			p.SourceColumn = ColumnNames.OtherPackagePrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Quantity);
			p.SourceColumn = ColumnNames.Quantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ItemPrice);
			p.SourceColumn = ColumnNames.ItemPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SubTotal);
			p.SourceColumn = ColumnNames.SubTotal;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
