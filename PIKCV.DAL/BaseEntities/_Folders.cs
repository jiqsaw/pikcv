
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
	public abstract class _Folders : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Folders()
		{
			this.QuerySource = "Folders";
			this.MappingName = "Folders";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_FoldersLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int FolderID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.FolderID, FolderID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_FoldersLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter FolderID
			{
				get
				{
					return new SqlParameter("@FolderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CompanyID
			{
				get
				{
					return new SqlParameter("@CompanyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter FolderName
			{
				get
				{
					return new SqlParameter("@FolderName", SqlDbType.NVarChar, 64);
				}
			}
			
			public static SqlParameter IsDefault
			{
				get
				{
					return new SqlParameter("@IsDefault", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter FolderTypeID
			{
				get
				{
					return new SqlParameter("@FolderTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreateDate
			{
				get
				{
					return new SqlParameter("@CreateDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter LastUseDate
			{
				get
				{
					return new SqlParameter("@LastUseDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IsDeleted
			{
				get
				{
					return new SqlParameter("@IsDeleted", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string FolderID = "FolderID";
            public const string CompanyID = "CompanyID";
            public const string FolderName = "FolderName";
            public const string IsDefault = "IsDefault";
            public const string FolderTypeID = "FolderTypeID";
            public const string CreateDate = "CreateDate";
            public const string LastUseDate = "LastUseDate";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[FolderID] = _Folders.PropertyNames.FolderID;
					ht[CompanyID] = _Folders.PropertyNames.CompanyID;
					ht[FolderName] = _Folders.PropertyNames.FolderName;
					ht[IsDefault] = _Folders.PropertyNames.IsDefault;
					ht[FolderTypeID] = _Folders.PropertyNames.FolderTypeID;
					ht[CreateDate] = _Folders.PropertyNames.CreateDate;
					ht[LastUseDate] = _Folders.PropertyNames.LastUseDate;
					ht[IsDeleted] = _Folders.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string FolderID = "FolderID";
            public const string CompanyID = "CompanyID";
            public const string FolderName = "FolderName";
            public const string IsDefault = "IsDefault";
            public const string FolderTypeID = "FolderTypeID";
            public const string CreateDate = "CreateDate";
            public const string LastUseDate = "LastUseDate";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[FolderID] = _Folders.ColumnNames.FolderID;
					ht[CompanyID] = _Folders.ColumnNames.CompanyID;
					ht[FolderName] = _Folders.ColumnNames.FolderName;
					ht[IsDefault] = _Folders.ColumnNames.IsDefault;
					ht[FolderTypeID] = _Folders.ColumnNames.FolderTypeID;
					ht[CreateDate] = _Folders.ColumnNames.CreateDate;
					ht[LastUseDate] = _Folders.ColumnNames.LastUseDate;
					ht[IsDeleted] = _Folders.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string FolderID = "s_FolderID";
            public const string CompanyID = "s_CompanyID";
            public const string FolderName = "s_FolderName";
            public const string IsDefault = "s_IsDefault";
            public const string FolderTypeID = "s_FolderTypeID";
            public const string CreateDate = "s_CreateDate";
            public const string LastUseDate = "s_LastUseDate";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int FolderID
	    {
			get
	        {
				return base.Getint(ColumnNames.FolderID);
			}
			set
	        {
				base.Setint(ColumnNames.FolderID, value);
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

		public virtual string FolderName
	    {
			get
	        {
				return base.Getstring(ColumnNames.FolderName);
			}
			set
	        {
				base.Setstring(ColumnNames.FolderName, value);
			}
		}

		public virtual bool IsDefault
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsDefault);
			}
			set
	        {
				base.Setbool(ColumnNames.IsDefault, value);
			}
		}

		public virtual int FolderTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.FolderTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.FolderTypeID, value);
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

		public virtual DateTime LastUseDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LastUseDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LastUseDate, value);
			}
		}

		public virtual bool IsDeleted
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsDeleted);
			}
			set
	        {
				base.Setbool(ColumnNames.IsDeleted, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_FolderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FolderID) ? string.Empty : base.GetintAsString(ColumnNames.FolderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FolderID);
				else
					this.FolderID = base.SetintAsString(ColumnNames.FolderID, value);
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

		public virtual string s_FolderName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FolderName) ? string.Empty : base.GetstringAsString(ColumnNames.FolderName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FolderName);
				else
					this.FolderName = base.SetstringAsString(ColumnNames.FolderName, value);
			}
		}

		public virtual string s_IsDefault
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsDefault) ? string.Empty : base.GetboolAsString(ColumnNames.IsDefault);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsDefault);
				else
					this.IsDefault = base.SetboolAsString(ColumnNames.IsDefault, value);
			}
		}

		public virtual string s_FolderTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FolderTypeID) ? string.Empty : base.GetintAsString(ColumnNames.FolderTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FolderTypeID);
				else
					this.FolderTypeID = base.SetintAsString(ColumnNames.FolderTypeID, value);
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

		public virtual string s_LastUseDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastUseDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LastUseDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastUseDate);
				else
					this.LastUseDate = base.SetDateTimeAsString(ColumnNames.LastUseDate, value);
			}
		}

		public virtual string s_IsDeleted
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsDeleted) ? string.Empty : base.GetboolAsString(ColumnNames.IsDeleted);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsDeleted);
				else
					this.IsDeleted = base.SetboolAsString(ColumnNames.IsDeleted, value);
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
				
				
				public WhereParameter FolderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FolderID, Parameters.FolderID);
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

				public WhereParameter FolderName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FolderName, Parameters.FolderName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsDefault
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsDefault, Parameters.IsDefault);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FolderTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FolderTypeID, Parameters.FolderTypeID);
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

				public WhereParameter LastUseDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastUseDate, Parameters.LastUseDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsDeleted
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsDeleted, Parameters.IsDeleted);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter FolderID
		    {
				get
		        {
					if(_FolderID_W == null)
	        	    {
						_FolderID_W = TearOff.FolderID;
					}
					return _FolderID_W;
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

			public WhereParameter FolderName
		    {
				get
		        {
					if(_FolderName_W == null)
	        	    {
						_FolderName_W = TearOff.FolderName;
					}
					return _FolderName_W;
				}
			}

			public WhereParameter IsDefault
		    {
				get
		        {
					if(_IsDefault_W == null)
	        	    {
						_IsDefault_W = TearOff.IsDefault;
					}
					return _IsDefault_W;
				}
			}

			public WhereParameter FolderTypeID
		    {
				get
		        {
					if(_FolderTypeID_W == null)
	        	    {
						_FolderTypeID_W = TearOff.FolderTypeID;
					}
					return _FolderTypeID_W;
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

			public WhereParameter LastUseDate
		    {
				get
		        {
					if(_LastUseDate_W == null)
	        	    {
						_LastUseDate_W = TearOff.LastUseDate;
					}
					return _LastUseDate_W;
				}
			}

			public WhereParameter IsDeleted
		    {
				get
		        {
					if(_IsDeleted_W == null)
	        	    {
						_IsDeleted_W = TearOff.IsDeleted;
					}
					return _IsDeleted_W;
				}
			}

			private WhereParameter _FolderID_W = null;
			private WhereParameter _CompanyID_W = null;
			private WhereParameter _FolderName_W = null;
			private WhereParameter _IsDefault_W = null;
			private WhereParameter _FolderTypeID_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _LastUseDate_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_FolderID_W = null;
				_CompanyID_W = null;
				_FolderName_W = null;
				_IsDefault_W = null;
				_FolderTypeID_W = null;
				_CreateDate_W = null;
				_LastUseDate_W = null;
				_IsDeleted_W = null;

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
				
				
				public AggregateParameter FolderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FolderID, Parameters.FolderID);
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

				public AggregateParameter FolderName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FolderName, Parameters.FolderName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsDefault
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsDefault, Parameters.IsDefault);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FolderTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FolderTypeID, Parameters.FolderTypeID);
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

				public AggregateParameter LastUseDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastUseDate, Parameters.LastUseDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsDeleted
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsDeleted, Parameters.IsDeleted);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter FolderID
		    {
				get
		        {
					if(_FolderID_W == null)
	        	    {
						_FolderID_W = TearOff.FolderID;
					}
					return _FolderID_W;
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

			public AggregateParameter FolderName
		    {
				get
		        {
					if(_FolderName_W == null)
	        	    {
						_FolderName_W = TearOff.FolderName;
					}
					return _FolderName_W;
				}
			}

			public AggregateParameter IsDefault
		    {
				get
		        {
					if(_IsDefault_W == null)
	        	    {
						_IsDefault_W = TearOff.IsDefault;
					}
					return _IsDefault_W;
				}
			}

			public AggregateParameter FolderTypeID
		    {
				get
		        {
					if(_FolderTypeID_W == null)
	        	    {
						_FolderTypeID_W = TearOff.FolderTypeID;
					}
					return _FolderTypeID_W;
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

			public AggregateParameter LastUseDate
		    {
				get
		        {
					if(_LastUseDate_W == null)
	        	    {
						_LastUseDate_W = TearOff.LastUseDate;
					}
					return _LastUseDate_W;
				}
			}

			public AggregateParameter IsDeleted
		    {
				get
		        {
					if(_IsDeleted_W == null)
	        	    {
						_IsDeleted_W = TearOff.IsDeleted;
					}
					return _IsDeleted_W;
				}
			}

			private AggregateParameter _FolderID_W = null;
			private AggregateParameter _CompanyID_W = null;
			private AggregateParameter _FolderName_W = null;
			private AggregateParameter _IsDefault_W = null;
			private AggregateParameter _FolderTypeID_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _LastUseDate_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_FolderID_W = null;
				_CompanyID_W = null;
				_FolderName_W = null;
				_IsDefault_W = null;
				_FolderTypeID_W = null;
				_CreateDate_W = null;
				_LastUseDate_W = null;
				_IsDeleted_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FoldersInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.FolderID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FoldersUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FoldersDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.FolderID);
			p.SourceColumn = ColumnNames.FolderID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.FolderID);
			p.SourceColumn = ColumnNames.FolderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FolderName);
			p.SourceColumn = ColumnNames.FolderName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDefault);
			p.SourceColumn = ColumnNames.IsDefault;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FolderTypeID);
			p.SourceColumn = ColumnNames.FolderTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreateDate);
			p.SourceColumn = ColumnNames.CreateDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastUseDate);
			p.SourceColumn = ColumnNames.LastUseDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}