
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
	public abstract class _CustomProjects : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _CustomProjects()
		{
			this.QuerySource = "CustomProjects";
			this.MappingName = "CustomProjects";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CustomProjectsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CustomProjectID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CustomProjectID, CustomProjectID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CustomProjectsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CustomProjectID
			{
				get
				{
					return new SqlParameter("@CustomProjectID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CompanyID
			{
				get
				{
					return new SqlParameter("@CompanyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ProjectRequest
			{
				get
				{
					return new SqlParameter("@ProjectRequest", SqlDbType.NVarChar, 2000);
				}
			}
			
			public static SqlParameter ProjectName
			{
				get
				{
					return new SqlParameter("@ProjectName", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter CustomProjectStatusID
			{
				get
				{
					return new SqlParameter("@CustomProjectStatusID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter WantedEmployeeCount
			{
				get
				{
					return new SqlParameter("@WantedEmployeeCount", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Price
			{
				get
				{
					return new SqlParameter("@Price", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Notes
			{
				get
				{
					return new SqlParameter("@Notes", SqlDbType.NVarChar, 2000);
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
            public const string CustomProjectID = "CustomProjectID";
            public const string CompanyID = "CompanyID";
            public const string ProjectRequest = "ProjectRequest";
            public const string ProjectName = "ProjectName";
            public const string CustomProjectStatusID = "CustomProjectStatusID";
            public const string WantedEmployeeCount = "WantedEmployeeCount";
            public const string Price = "Price";
            public const string Notes = "Notes";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CustomProjectID] = _CustomProjects.PropertyNames.CustomProjectID;
					ht[CompanyID] = _CustomProjects.PropertyNames.CompanyID;
					ht[ProjectRequest] = _CustomProjects.PropertyNames.ProjectRequest;
					ht[ProjectName] = _CustomProjects.PropertyNames.ProjectName;
					ht[CustomProjectStatusID] = _CustomProjects.PropertyNames.CustomProjectStatusID;
					ht[WantedEmployeeCount] = _CustomProjects.PropertyNames.WantedEmployeeCount;
					ht[Price] = _CustomProjects.PropertyNames.Price;
					ht[Notes] = _CustomProjects.PropertyNames.Notes;
					ht[CreateDate] = _CustomProjects.PropertyNames.CreateDate;
					ht[ModifyDate] = _CustomProjects.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _CustomProjects.PropertyNames.UpdatedBy;
					ht[IsDeleted] = _CustomProjects.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CustomProjectID = "CustomProjectID";
            public const string CompanyID = "CompanyID";
            public const string ProjectRequest = "ProjectRequest";
            public const string ProjectName = "ProjectName";
            public const string CustomProjectStatusID = "CustomProjectStatusID";
            public const string WantedEmployeeCount = "WantedEmployeeCount";
            public const string Price = "Price";
            public const string Notes = "Notes";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CustomProjectID] = _CustomProjects.ColumnNames.CustomProjectID;
					ht[CompanyID] = _CustomProjects.ColumnNames.CompanyID;
					ht[ProjectRequest] = _CustomProjects.ColumnNames.ProjectRequest;
					ht[ProjectName] = _CustomProjects.ColumnNames.ProjectName;
					ht[CustomProjectStatusID] = _CustomProjects.ColumnNames.CustomProjectStatusID;
					ht[WantedEmployeeCount] = _CustomProjects.ColumnNames.WantedEmployeeCount;
					ht[Price] = _CustomProjects.ColumnNames.Price;
					ht[Notes] = _CustomProjects.ColumnNames.Notes;
					ht[CreateDate] = _CustomProjects.ColumnNames.CreateDate;
					ht[ModifyDate] = _CustomProjects.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _CustomProjects.ColumnNames.UpdatedBy;
					ht[IsDeleted] = _CustomProjects.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CustomProjectID = "s_CustomProjectID";
            public const string CompanyID = "s_CompanyID";
            public const string ProjectRequest = "s_ProjectRequest";
            public const string ProjectName = "s_ProjectName";
            public const string CustomProjectStatusID = "s_CustomProjectStatusID";
            public const string WantedEmployeeCount = "s_WantedEmployeeCount";
            public const string Price = "s_Price";
            public const string Notes = "s_Notes";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CustomProjectID
	    {
			get
	        {
				return base.Getint(ColumnNames.CustomProjectID);
			}
			set
	        {
				base.Setint(ColumnNames.CustomProjectID, value);
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

		public virtual string ProjectRequest
	    {
			get
	        {
				return base.Getstring(ColumnNames.ProjectRequest);
			}
			set
	        {
				base.Setstring(ColumnNames.ProjectRequest, value);
			}
		}

		public virtual string ProjectName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ProjectName);
			}
			set
	        {
				base.Setstring(ColumnNames.ProjectName, value);
			}
		}

		public virtual int CustomProjectStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.CustomProjectStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.CustomProjectStatusID, value);
			}
		}

		public virtual int WantedEmployeeCount
	    {
			get
	        {
				return base.Getint(ColumnNames.WantedEmployeeCount);
			}
			set
	        {
				base.Setint(ColumnNames.WantedEmployeeCount, value);
			}
		}

		public virtual double Price
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Price);
			}
			set
	        {
				base.Setdouble(ColumnNames.Price, value);
			}
		}

		public virtual string Notes
	    {
			get
	        {
				return base.Getstring(ColumnNames.Notes);
			}
			set
	        {
				base.Setstring(ColumnNames.Notes, value);
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
	
		public virtual string s_CustomProjectID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CustomProjectID) ? string.Empty : base.GetintAsString(ColumnNames.CustomProjectID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CustomProjectID);
				else
					this.CustomProjectID = base.SetintAsString(ColumnNames.CustomProjectID, value);
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

		public virtual string s_ProjectRequest
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProjectRequest) ? string.Empty : base.GetstringAsString(ColumnNames.ProjectRequest);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectRequest);
				else
					this.ProjectRequest = base.SetstringAsString(ColumnNames.ProjectRequest, value);
			}
		}

		public virtual string s_ProjectName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProjectName) ? string.Empty : base.GetstringAsString(ColumnNames.ProjectName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectName);
				else
					this.ProjectName = base.SetstringAsString(ColumnNames.ProjectName, value);
			}
		}

		public virtual string s_CustomProjectStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CustomProjectStatusID) ? string.Empty : base.GetintAsString(ColumnNames.CustomProjectStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CustomProjectStatusID);
				else
					this.CustomProjectStatusID = base.SetintAsString(ColumnNames.CustomProjectStatusID, value);
			}
		}

		public virtual string s_WantedEmployeeCount
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.WantedEmployeeCount) ? string.Empty : base.GetintAsString(ColumnNames.WantedEmployeeCount);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.WantedEmployeeCount);
				else
					this.WantedEmployeeCount = base.SetintAsString(ColumnNames.WantedEmployeeCount, value);
			}
		}

		public virtual string s_Price
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Price) ? string.Empty : base.GetdoubleAsString(ColumnNames.Price);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Price);
				else
					this.Price = base.SetdoubleAsString(ColumnNames.Price, value);
			}
		}

		public virtual string s_Notes
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Notes) ? string.Empty : base.GetstringAsString(ColumnNames.Notes);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Notes);
				else
					this.Notes = base.SetstringAsString(ColumnNames.Notes, value);
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
				
				
				public WhereParameter CustomProjectID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CustomProjectID, Parameters.CustomProjectID);
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

				public WhereParameter ProjectRequest
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ProjectRequest, Parameters.ProjectRequest);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ProjectName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ProjectName, Parameters.ProjectName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CustomProjectStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CustomProjectStatusID, Parameters.CustomProjectStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter WantedEmployeeCount
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.WantedEmployeeCount, Parameters.WantedEmployeeCount);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Price
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Price, Parameters.Price);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Notes
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Notes, Parameters.Notes);
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
		
			public WhereParameter CustomProjectID
		    {
				get
		        {
					if(_CustomProjectID_W == null)
	        	    {
						_CustomProjectID_W = TearOff.CustomProjectID;
					}
					return _CustomProjectID_W;
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

			public WhereParameter ProjectRequest
		    {
				get
		        {
					if(_ProjectRequest_W == null)
	        	    {
						_ProjectRequest_W = TearOff.ProjectRequest;
					}
					return _ProjectRequest_W;
				}
			}

			public WhereParameter ProjectName
		    {
				get
		        {
					if(_ProjectName_W == null)
	        	    {
						_ProjectName_W = TearOff.ProjectName;
					}
					return _ProjectName_W;
				}
			}

			public WhereParameter CustomProjectStatusID
		    {
				get
		        {
					if(_CustomProjectStatusID_W == null)
	        	    {
						_CustomProjectStatusID_W = TearOff.CustomProjectStatusID;
					}
					return _CustomProjectStatusID_W;
				}
			}

			public WhereParameter WantedEmployeeCount
		    {
				get
		        {
					if(_WantedEmployeeCount_W == null)
	        	    {
						_WantedEmployeeCount_W = TearOff.WantedEmployeeCount;
					}
					return _WantedEmployeeCount_W;
				}
			}

			public WhereParameter Price
		    {
				get
		        {
					if(_Price_W == null)
	        	    {
						_Price_W = TearOff.Price;
					}
					return _Price_W;
				}
			}

			public WhereParameter Notes
		    {
				get
		        {
					if(_Notes_W == null)
	        	    {
						_Notes_W = TearOff.Notes;
					}
					return _Notes_W;
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

			private WhereParameter _CustomProjectID_W = null;
			private WhereParameter _CompanyID_W = null;
			private WhereParameter _ProjectRequest_W = null;
			private WhereParameter _ProjectName_W = null;
			private WhereParameter _CustomProjectStatusID_W = null;
			private WhereParameter _WantedEmployeeCount_W = null;
			private WhereParameter _Price_W = null;
			private WhereParameter _Notes_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_CustomProjectID_W = null;
				_CompanyID_W = null;
				_ProjectRequest_W = null;
				_ProjectName_W = null;
				_CustomProjectStatusID_W = null;
				_WantedEmployeeCount_W = null;
				_Price_W = null;
				_Notes_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;
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
				
				
				public AggregateParameter CustomProjectID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CustomProjectID, Parameters.CustomProjectID);
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

				public AggregateParameter ProjectRequest
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectRequest, Parameters.ProjectRequest);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ProjectName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectName, Parameters.ProjectName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CustomProjectStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CustomProjectStatusID, Parameters.CustomProjectStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter WantedEmployeeCount
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.WantedEmployeeCount, Parameters.WantedEmployeeCount);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Price
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Price, Parameters.Price);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Notes
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Notes, Parameters.Notes);
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
		
			public AggregateParameter CustomProjectID
		    {
				get
		        {
					if(_CustomProjectID_W == null)
	        	    {
						_CustomProjectID_W = TearOff.CustomProjectID;
					}
					return _CustomProjectID_W;
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

			public AggregateParameter ProjectRequest
		    {
				get
		        {
					if(_ProjectRequest_W == null)
	        	    {
						_ProjectRequest_W = TearOff.ProjectRequest;
					}
					return _ProjectRequest_W;
				}
			}

			public AggregateParameter ProjectName
		    {
				get
		        {
					if(_ProjectName_W == null)
	        	    {
						_ProjectName_W = TearOff.ProjectName;
					}
					return _ProjectName_W;
				}
			}

			public AggregateParameter CustomProjectStatusID
		    {
				get
		        {
					if(_CustomProjectStatusID_W == null)
	        	    {
						_CustomProjectStatusID_W = TearOff.CustomProjectStatusID;
					}
					return _CustomProjectStatusID_W;
				}
			}

			public AggregateParameter WantedEmployeeCount
		    {
				get
		        {
					if(_WantedEmployeeCount_W == null)
	        	    {
						_WantedEmployeeCount_W = TearOff.WantedEmployeeCount;
					}
					return _WantedEmployeeCount_W;
				}
			}

			public AggregateParameter Price
		    {
				get
		        {
					if(_Price_W == null)
	        	    {
						_Price_W = TearOff.Price;
					}
					return _Price_W;
				}
			}

			public AggregateParameter Notes
		    {
				get
		        {
					if(_Notes_W == null)
	        	    {
						_Notes_W = TearOff.Notes;
					}
					return _Notes_W;
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

			private AggregateParameter _CustomProjectID_W = null;
			private AggregateParameter _CompanyID_W = null;
			private AggregateParameter _ProjectRequest_W = null;
			private AggregateParameter _ProjectName_W = null;
			private AggregateParameter _CustomProjectStatusID_W = null;
			private AggregateParameter _WantedEmployeeCount_W = null;
			private AggregateParameter _Price_W = null;
			private AggregateParameter _Notes_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_CustomProjectID_W = null;
				_CompanyID_W = null;
				_ProjectRequest_W = null;
				_ProjectName_W = null;
				_CustomProjectStatusID_W = null;
				_WantedEmployeeCount_W = null;
				_Price_W = null;
				_Notes_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CustomProjectsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CustomProjectID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CustomProjectsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CustomProjectsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CustomProjectID);
			p.SourceColumn = ColumnNames.CustomProjectID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CustomProjectID);
			p.SourceColumn = ColumnNames.CustomProjectID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectRequest);
			p.SourceColumn = ColumnNames.ProjectRequest;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectName);
			p.SourceColumn = ColumnNames.ProjectName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CustomProjectStatusID);
			p.SourceColumn = ColumnNames.CustomProjectStatusID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.WantedEmployeeCount);
			p.SourceColumn = ColumnNames.WantedEmployeeCount;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Price);
			p.SourceColumn = ColumnNames.Price;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Notes);
			p.SourceColumn = ColumnNames.Notes;
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

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
