
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
	public abstract class _HelpContent : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _HelpContent()
		{
			this.QuerySource = "HelpContent";
			this.MappingName = "HelpContent";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_HelpContentLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int HelpContentID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.HelpContentID, HelpContentID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_HelpContentLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter HelpContentID
			{
				get
				{
					return new SqlParameter("@HelpContentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PageTypeCode
			{
				get
				{
					return new SqlParameter("@PageTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ParentID
			{
				get
				{
					return new SqlParameter("@ParentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreateDate
			{
				get
				{
					return new SqlParameter("@CreateDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifyDate
			{
				get
				{
					return new SqlParameter("@ModifyDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter UpdatedBy
			{
				get
				{
					return new SqlParameter("@UpdatedBy", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string HelpContentID = "HelpContentID";
            public const string PageTypeCode = "PageTypeCode";
            public const string ParentID = "ParentID";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[HelpContentID] = _HelpContent.PropertyNames.HelpContentID;
					ht[PageTypeCode] = _HelpContent.PropertyNames.PageTypeCode;
					ht[ParentID] = _HelpContent.PropertyNames.ParentID;
					ht[CreateDate] = _HelpContent.PropertyNames.CreateDate;
					ht[ModifyDate] = _HelpContent.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _HelpContent.PropertyNames.UpdatedBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string HelpContentID = "HelpContentID";
            public const string PageTypeCode = "PageTypeCode";
            public const string ParentID = "ParentID";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[HelpContentID] = _HelpContent.ColumnNames.HelpContentID;
					ht[PageTypeCode] = _HelpContent.ColumnNames.PageTypeCode;
					ht[ParentID] = _HelpContent.ColumnNames.ParentID;
					ht[CreateDate] = _HelpContent.ColumnNames.CreateDate;
					ht[ModifyDate] = _HelpContent.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _HelpContent.ColumnNames.UpdatedBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string HelpContentID = "s_HelpContentID";
            public const string PageTypeCode = "s_PageTypeCode";
            public const string ParentID = "s_ParentID";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";

		}
		#endregion		
		
		#region Properties
	
		public virtual int HelpContentID
	    {
			get
	        {
				return base.Getint(ColumnNames.HelpContentID);
			}
			set
	        {
				base.Setint(ColumnNames.HelpContentID, value);
			}
		}

		public virtual int PageTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.PageTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.PageTypeCode, value);
			}
		}

		public virtual int ParentID
	    {
			get
	        {
				return base.Getint(ColumnNames.ParentID);
			}
			set
	        {
				base.Setint(ColumnNames.ParentID, value);
			}
		}

		public virtual DateTime CreateDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreateDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreateDate, value);
			}
		}

		public virtual DateTime ModifyDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ModifyDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ModifyDate, value);
			}
		}

		public virtual int UpdatedBy
	    {
			get
	        {
				return base.Getint(ColumnNames.UpdatedBy);
			}
			set
	        {
				base.Setint(ColumnNames.UpdatedBy, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_HelpContentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HelpContentID) ? string.Empty : base.GetintAsString(ColumnNames.HelpContentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HelpContentID);
				else
					this.HelpContentID = base.SetintAsString(ColumnNames.HelpContentID, value);
			}
		}

		public virtual string s_PageTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PageTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.PageTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PageTypeCode);
				else
					this.PageTypeCode = base.SetintAsString(ColumnNames.PageTypeCode, value);
			}
		}

		public virtual string s_ParentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ParentID) ? string.Empty : base.GetintAsString(ColumnNames.ParentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ParentID);
				else
					this.ParentID = base.SetintAsString(ColumnNames.ParentID, value);
			}
		}

		public virtual string s_CreateDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreateDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreateDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreateDate);
				else
					this.CreateDate = base.SetDateTimeAsString(ColumnNames.CreateDate, value);
			}
		}

		public virtual string s_ModifyDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifyDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ModifyDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifyDate);
				else
					this.ModifyDate = base.SetDateTimeAsString(ColumnNames.ModifyDate, value);
			}
		}

		public virtual string s_UpdatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UpdatedBy) ? string.Empty : base.GetintAsString(ColumnNames.UpdatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UpdatedBy);
				else
					this.UpdatedBy = base.SetintAsString(ColumnNames.UpdatedBy, value);
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
				
				
				public WhereParameter HelpContentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HelpContentID, Parameters.HelpContentID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PageTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PageTypeCode, Parameters.PageTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ParentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ParentID, Parameters.ParentID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreateDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreateDate, Parameters.CreateDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifyDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifyDate, Parameters.ModifyDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UpdatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter HelpContentID
		    {
				get
		        {
					if(_HelpContentID_W == null)
	        	    {
						_HelpContentID_W = TearOff.HelpContentID;
					}
					return _HelpContentID_W;
				}
			}

			public WhereParameter PageTypeCode
		    {
				get
		        {
					if(_PageTypeCode_W == null)
	        	    {
						_PageTypeCode_W = TearOff.PageTypeCode;
					}
					return _PageTypeCode_W;
				}
			}

			public WhereParameter ParentID
		    {
				get
		        {
					if(_ParentID_W == null)
	        	    {
						_ParentID_W = TearOff.ParentID;
					}
					return _ParentID_W;
				}
			}

			public WhereParameter CreateDate
		    {
				get
		        {
					if(_CreateDate_W == null)
	        	    {
						_CreateDate_W = TearOff.CreateDate;
					}
					return _CreateDate_W;
				}
			}

			public WhereParameter ModifyDate
		    {
				get
		        {
					if(_ModifyDate_W == null)
	        	    {
						_ModifyDate_W = TearOff.ModifyDate;
					}
					return _ModifyDate_W;
				}
			}

			public WhereParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
				}
			}

			private WhereParameter _HelpContentID_W = null;
			private WhereParameter _PageTypeCode_W = null;
			private WhereParameter _ParentID_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;

			public void WhereClauseReset()
			{
				_HelpContentID_W = null;
				_PageTypeCode_W = null;
				_ParentID_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;

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
				
				
				public AggregateParameter HelpContentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HelpContentID, Parameters.HelpContentID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PageTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PageTypeCode, Parameters.PageTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ParentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ParentID, Parameters.ParentID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreateDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreateDate, Parameters.CreateDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifyDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifyDate, Parameters.ModifyDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UpdatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter HelpContentID
		    {
				get
		        {
					if(_HelpContentID_W == null)
	        	    {
						_HelpContentID_W = TearOff.HelpContentID;
					}
					return _HelpContentID_W;
				}
			}

			public AggregateParameter PageTypeCode
		    {
				get
		        {
					if(_PageTypeCode_W == null)
	        	    {
						_PageTypeCode_W = TearOff.PageTypeCode;
					}
					return _PageTypeCode_W;
				}
			}

			public AggregateParameter ParentID
		    {
				get
		        {
					if(_ParentID_W == null)
	        	    {
						_ParentID_W = TearOff.ParentID;
					}
					return _ParentID_W;
				}
			}

			public AggregateParameter CreateDate
		    {
				get
		        {
					if(_CreateDate_W == null)
	        	    {
						_CreateDate_W = TearOff.CreateDate;
					}
					return _CreateDate_W;
				}
			}

			public AggregateParameter ModifyDate
		    {
				get
		        {
					if(_ModifyDate_W == null)
	        	    {
						_ModifyDate_W = TearOff.ModifyDate;
					}
					return _ModifyDate_W;
				}
			}

			public AggregateParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
				}
			}

			private AggregateParameter _HelpContentID_W = null;
			private AggregateParameter _PageTypeCode_W = null;
			private AggregateParameter _ParentID_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;

			public void AggregateClauseReset()
			{
				_HelpContentID_W = null;
				_PageTypeCode_W = null;
				_ParentID_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContentInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.HelpContentID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContentUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContentDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.HelpContentID);
			p.SourceColumn = ColumnNames.HelpContentID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.HelpContentID);
			p.SourceColumn = ColumnNames.HelpContentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PageTypeCode);
			p.SourceColumn = ColumnNames.PageTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ParentID);
			p.SourceColumn = ColumnNames.ParentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreateDate);
			p.SourceColumn = ColumnNames.CreateDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifyDate);
			p.SourceColumn = ColumnNames.ModifyDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UpdatedBy);
			p.SourceColumn = ColumnNames.UpdatedBy;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
