
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
	public abstract class _OrderTypeCodes_ML : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _OrderTypeCodes_ML()
		{
			this.QuerySource = "OrderTypeCodes_ML";
			this.MappingName = "OrderTypeCodes_ML";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderTypeCodes_MLLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int RowID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.RowID, RowID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderTypeCodes_MLLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter RowID
			{
				get
				{
					return new SqlParameter("@RowID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter OrderTypeCodeID
			{
				get
				{
					return new SqlParameter("@OrderTypeCodeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter OrderTypeName
			{
				get
				{
					return new SqlParameter("@OrderTypeName", SqlDbType.NVarChar, 30);
				}
			}
			
			public static SqlParameter IsDebit
			{
				get
				{
					return new SqlParameter("@IsDebit", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string OrderTypeCodeID = "OrderTypeCodeID";
            public const string LanguageID = "LanguageID";
            public const string OrderTypeName = "OrderTypeName";
            public const string IsDebit = "isDebit";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _OrderTypeCodes_ML.PropertyNames.RowID;
					ht[OrderTypeCodeID] = _OrderTypeCodes_ML.PropertyNames.OrderTypeCodeID;
					ht[LanguageID] = _OrderTypeCodes_ML.PropertyNames.LanguageID;
					ht[OrderTypeName] = _OrderTypeCodes_ML.PropertyNames.OrderTypeName;
					ht[IsDebit] = _OrderTypeCodes_ML.PropertyNames.IsDebit;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string RowID = "RowID";
            public const string OrderTypeCodeID = "OrderTypeCodeID";
            public const string LanguageID = "LanguageID";
            public const string OrderTypeName = "OrderTypeName";
            public const string IsDebit = "IsDebit";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _OrderTypeCodes_ML.ColumnNames.RowID;
					ht[OrderTypeCodeID] = _OrderTypeCodes_ML.ColumnNames.OrderTypeCodeID;
					ht[LanguageID] = _OrderTypeCodes_ML.ColumnNames.LanguageID;
					ht[OrderTypeName] = _OrderTypeCodes_ML.ColumnNames.OrderTypeName;
					ht[IsDebit] = _OrderTypeCodes_ML.ColumnNames.IsDebit;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string RowID = "s_RowID";
            public const string OrderTypeCodeID = "s_OrderTypeCodeID";
            public const string LanguageID = "s_LanguageID";
            public const string OrderTypeName = "s_OrderTypeName";
            public const string IsDebit = "s_IsDebit";

		}
		#endregion		
		
		#region Properties
	
		public virtual int RowID
	    {
			get
	        {
				return base.Getint(ColumnNames.RowID);
			}
			set
	        {
				base.Setint(ColumnNames.RowID, value);
			}
		}

		public virtual int OrderTypeCodeID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderTypeCodeID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderTypeCodeID, value);
			}
		}

		public virtual int LanguageID
	    {
			get
	        {
				return base.Getint(ColumnNames.LanguageID);
			}
			set
	        {
				base.Setint(ColumnNames.LanguageID, value);
			}
		}

		public virtual string OrderTypeName
	    {
			get
	        {
				return base.Getstring(ColumnNames.OrderTypeName);
			}
			set
	        {
				base.Setstring(ColumnNames.OrderTypeName, value);
			}
		}

		public virtual bool IsDebit
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsDebit);
			}
			set
	        {
				base.Setbool(ColumnNames.IsDebit, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_RowID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RowID) ? string.Empty : base.GetintAsString(ColumnNames.RowID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RowID);
				else
					this.RowID = base.SetintAsString(ColumnNames.RowID, value);
			}
		}

		public virtual string s_OrderTypeCodeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderTypeCodeID) ? string.Empty : base.GetintAsString(ColumnNames.OrderTypeCodeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderTypeCodeID);
				else
					this.OrderTypeCodeID = base.SetintAsString(ColumnNames.OrderTypeCodeID, value);
			}
		}

		public virtual string s_LanguageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LanguageID) ? string.Empty : base.GetintAsString(ColumnNames.LanguageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LanguageID);
				else
					this.LanguageID = base.SetintAsString(ColumnNames.LanguageID, value);
			}
		}

		public virtual string s_OrderTypeName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderTypeName) ? string.Empty : base.GetstringAsString(ColumnNames.OrderTypeName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderTypeName);
				else
					this.OrderTypeName = base.SetstringAsString(ColumnNames.OrderTypeName, value);
			}
		}

		public virtual string s_IsDebit
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsDebit) ? string.Empty : base.GetboolAsString(ColumnNames.IsDebit);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsDebit);
				else
					this.IsDebit = base.SetboolAsString(ColumnNames.IsDebit, value);
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
				
				
				public WhereParameter RowID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RowID, Parameters.RowID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderTypeCodeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderTypeCodeID, Parameters.OrderTypeCodeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LanguageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LanguageID, Parameters.LanguageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderTypeName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderTypeName, Parameters.OrderTypeName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsDebit
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsDebit, Parameters.IsDebit);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter RowID
		    {
				get
		        {
					if(_RowID_W == null)
	        	    {
						_RowID_W = TearOff.RowID;
					}
					return _RowID_W;
				}
			}

			public WhereParameter OrderTypeCodeID
		    {
				get
		        {
					if(_OrderTypeCodeID_W == null)
	        	    {
						_OrderTypeCodeID_W = TearOff.OrderTypeCodeID;
					}
					return _OrderTypeCodeID_W;
				}
			}

			public WhereParameter LanguageID
		    {
				get
		        {
					if(_LanguageID_W == null)
	        	    {
						_LanguageID_W = TearOff.LanguageID;
					}
					return _LanguageID_W;
				}
			}

			public WhereParameter OrderTypeName
		    {
				get
		        {
					if(_OrderTypeName_W == null)
	        	    {
						_OrderTypeName_W = TearOff.OrderTypeName;
					}
					return _OrderTypeName_W;
				}
			}

			public WhereParameter IsDebit
		    {
				get
		        {
					if(_IsDebit_W == null)
	        	    {
						_IsDebit_W = TearOff.IsDebit;
					}
					return _IsDebit_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _OrderTypeCodeID_W = null;
			private WhereParameter _LanguageID_W = null;
			private WhereParameter _OrderTypeName_W = null;
			private WhereParameter _IsDebit_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_OrderTypeCodeID_W = null;
				_LanguageID_W = null;
				_OrderTypeName_W = null;
				_IsDebit_W = null;

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
				
				
				public AggregateParameter RowID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RowID, Parameters.RowID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderTypeCodeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderTypeCodeID, Parameters.OrderTypeCodeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LanguageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LanguageID, Parameters.LanguageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderTypeName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderTypeName, Parameters.OrderTypeName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsDebit
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsDebit, Parameters.IsDebit);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter RowID
		    {
				get
		        {
					if(_RowID_W == null)
	        	    {
						_RowID_W = TearOff.RowID;
					}
					return _RowID_W;
				}
			}

			public AggregateParameter OrderTypeCodeID
		    {
				get
		        {
					if(_OrderTypeCodeID_W == null)
	        	    {
						_OrderTypeCodeID_W = TearOff.OrderTypeCodeID;
					}
					return _OrderTypeCodeID_W;
				}
			}

			public AggregateParameter LanguageID
		    {
				get
		        {
					if(_LanguageID_W == null)
	        	    {
						_LanguageID_W = TearOff.LanguageID;
					}
					return _LanguageID_W;
				}
			}

			public AggregateParameter OrderTypeName
		    {
				get
		        {
					if(_OrderTypeName_W == null)
	        	    {
						_OrderTypeName_W = TearOff.OrderTypeName;
					}
					return _OrderTypeName_W;
				}
			}

			public AggregateParameter IsDebit
		    {
				get
		        {
					if(_IsDebit_W == null)
	        	    {
						_IsDebit_W = TearOff.IsDebit;
					}
					return _IsDebit_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _OrderTypeCodeID_W = null;
			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _OrderTypeName_W = null;
			private AggregateParameter _IsDebit_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_OrderTypeCodeID_W = null;
				_LanguageID_W = null;
				_OrderTypeName_W = null;
				_IsDebit_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeCodes_MLInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.RowID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeCodes_MLUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeCodes_MLDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.RowID);
			p.SourceColumn = ColumnNames.RowID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.RowID);
			p.SourceColumn = ColumnNames.RowID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderTypeCodeID);
			p.SourceColumn = ColumnNames.OrderTypeCodeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderTypeName);
			p.SourceColumn = ColumnNames.OrderTypeName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDebit);
			p.SourceColumn = ColumnNames.IsDebit;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}