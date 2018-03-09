
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
	public abstract class _Banners : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Banners()
		{
			this.QuerySource = "Banners";
			this.MappingName = "Banners";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_BannersLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int BannerID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.BannerID, BannerID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_BannersLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter BannerID
			{
				get
				{
					return new SqlParameter("@BannerID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter BannerTitle
			{
				get
				{
					return new SqlParameter("@BannerTitle", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter BannerDescription
			{
				get
				{
					return new SqlParameter("@BannerDescription", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter BannerFile
			{
				get
				{
					return new SqlParameter("@BannerFile", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter BannerFileTypeCode
			{
				get
				{
					return new SqlParameter("@BannerFileTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter BannerLink
			{
				get
				{
					return new SqlParameter("@BannerLink", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter PublishTime
			{
				get
				{
					return new SqlParameter("@PublishTime", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter StartDate
			{
				get
				{
					return new SqlParameter("@StartDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EndDate
			{
				get
				{
					return new SqlParameter("@EndDate", SqlDbType.DateTime, 0);
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
            public const string BannerID = "BannerID";
            public const string BannerTitle = "BannerTitle";
            public const string BannerDescription = "BannerDescription";
            public const string BannerFile = "BannerFile";
            public const string BannerFileTypeCode = "BannerFileTypeCode";
            public const string BannerLink = "BannerLink";
            public const string PublishTime = "PublishTime";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BannerID] = _Banners.PropertyNames.BannerID;
					ht[BannerTitle] = _Banners.PropertyNames.BannerTitle;
					ht[BannerDescription] = _Banners.PropertyNames.BannerDescription;
					ht[BannerFile] = _Banners.PropertyNames.BannerFile;
					ht[BannerFileTypeCode] = _Banners.PropertyNames.BannerFileTypeCode;
					ht[BannerLink] = _Banners.PropertyNames.BannerLink;
					ht[PublishTime] = _Banners.PropertyNames.PublishTime;
					ht[StartDate] = _Banners.PropertyNames.StartDate;
					ht[EndDate] = _Banners.PropertyNames.EndDate;
					ht[CreateDate] = _Banners.PropertyNames.CreateDate;
					ht[ModifyDate] = _Banners.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _Banners.PropertyNames.UpdatedBy;
					ht[IsDeleted] = _Banners.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string BannerID = "BannerID";
            public const string BannerTitle = "BannerTitle";
            public const string BannerDescription = "BannerDescription";
            public const string BannerFile = "BannerFile";
            public const string BannerFileTypeCode = "BannerFileTypeCode";
            public const string BannerLink = "BannerLink";
            public const string PublishTime = "PublishTime";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BannerID] = _Banners.ColumnNames.BannerID;
					ht[BannerTitle] = _Banners.ColumnNames.BannerTitle;
					ht[BannerDescription] = _Banners.ColumnNames.BannerDescription;
					ht[BannerFile] = _Banners.ColumnNames.BannerFile;
					ht[BannerFileTypeCode] = _Banners.ColumnNames.BannerFileTypeCode;
					ht[BannerLink] = _Banners.ColumnNames.BannerLink;
					ht[PublishTime] = _Banners.ColumnNames.PublishTime;
					ht[StartDate] = _Banners.ColumnNames.StartDate;
					ht[EndDate] = _Banners.ColumnNames.EndDate;
					ht[CreateDate] = _Banners.ColumnNames.CreateDate;
					ht[ModifyDate] = _Banners.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _Banners.ColumnNames.UpdatedBy;
					ht[IsDeleted] = _Banners.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string BannerID = "s_BannerID";
            public const string BannerTitle = "s_BannerTitle";
            public const string BannerDescription = "s_BannerDescription";
            public const string BannerFile = "s_BannerFile";
            public const string BannerFileTypeCode = "s_BannerFileTypeCode";
            public const string BannerLink = "s_BannerLink";
            public const string PublishTime = "s_PublishTime";
            public const string StartDate = "s_StartDate";
            public const string EndDate = "s_EndDate";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int BannerID
	    {
			get
	        {
				return base.Getint(ColumnNames.BannerID);
			}
			set
	        {
				base.Setint(ColumnNames.BannerID, value);
			}
		}

		public virtual string BannerTitle
	    {
			get
	        {
				return base.Getstring(ColumnNames.BannerTitle);
			}
			set
	        {
				base.Setstring(ColumnNames.BannerTitle, value);
			}
		}

		public virtual string BannerDescription
	    {
			get
	        {
				return base.Getstring(ColumnNames.BannerDescription);
			}
			set
	        {
				base.Setstring(ColumnNames.BannerDescription, value);
			}
		}

		public virtual string BannerFile
	    {
			get
	        {
				return base.Getstring(ColumnNames.BannerFile);
			}
			set
	        {
				base.Setstring(ColumnNames.BannerFile, value);
			}
		}

		public virtual int BannerFileTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.BannerFileTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.BannerFileTypeCode, value);
			}
		}

		public virtual string BannerLink
	    {
			get
	        {
				return base.Getstring(ColumnNames.BannerLink);
			}
			set
	        {
				base.Setstring(ColumnNames.BannerLink, value);
			}
		}

		public virtual int PublishTime
	    {
			get
	        {
				return base.Getint(ColumnNames.PublishTime);
			}
			set
	        {
				base.Setint(ColumnNames.PublishTime, value);
			}
		}

		public virtual DateTime StartDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.StartDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.StartDate, value);
			}
		}

		public virtual DateTime EndDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EndDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EndDate, value);
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
	
		public virtual string s_BannerID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerID) ? string.Empty : base.GetintAsString(ColumnNames.BannerID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerID);
				else
					this.BannerID = base.SetintAsString(ColumnNames.BannerID, value);
			}
		}

		public virtual string s_BannerTitle
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerTitle) ? string.Empty : base.GetstringAsString(ColumnNames.BannerTitle);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerTitle);
				else
					this.BannerTitle = base.SetstringAsString(ColumnNames.BannerTitle, value);
			}
		}

		public virtual string s_BannerDescription
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerDescription) ? string.Empty : base.GetstringAsString(ColumnNames.BannerDescription);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerDescription);
				else
					this.BannerDescription = base.SetstringAsString(ColumnNames.BannerDescription, value);
			}
		}

		public virtual string s_BannerFile
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerFile) ? string.Empty : base.GetstringAsString(ColumnNames.BannerFile);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerFile);
				else
					this.BannerFile = base.SetstringAsString(ColumnNames.BannerFile, value);
			}
		}

		public virtual string s_BannerFileTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerFileTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.BannerFileTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerFileTypeCode);
				else
					this.BannerFileTypeCode = base.SetintAsString(ColumnNames.BannerFileTypeCode, value);
			}
		}

		public virtual string s_BannerLink
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BannerLink) ? string.Empty : base.GetstringAsString(ColumnNames.BannerLink);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BannerLink);
				else
					this.BannerLink = base.SetstringAsString(ColumnNames.BannerLink, value);
			}
		}

		public virtual string s_PublishTime
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PublishTime) ? string.Empty : base.GetintAsString(ColumnNames.PublishTime);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PublishTime);
				else
					this.PublishTime = base.SetintAsString(ColumnNames.PublishTime, value);
			}
		}

		public virtual string s_StartDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StartDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.StartDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StartDate);
				else
					this.StartDate = base.SetDateTimeAsString(ColumnNames.StartDate, value);
			}
		}

		public virtual string s_EndDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EndDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EndDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EndDate);
				else
					this.EndDate = base.SetDateTimeAsString(ColumnNames.EndDate, value);
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
				
				
				public WhereParameter BannerID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerID, Parameters.BannerID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BannerTitle
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerTitle, Parameters.BannerTitle);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BannerDescription
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerDescription, Parameters.BannerDescription);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BannerFile
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerFile, Parameters.BannerFile);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BannerFileTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerFileTypeCode, Parameters.BannerFileTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BannerLink
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BannerLink, Parameters.BannerLink);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PublishTime
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PublishTime, Parameters.PublishTime);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StartDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EndDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EndDate, Parameters.EndDate);
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
		
			public WhereParameter BannerID
		    {
				get
		        {
					if(_BannerID_W == null)
	        	    {
						_BannerID_W = TearOff.BannerID;
					}
					return _BannerID_W;
				}
			}

			public WhereParameter BannerTitle
		    {
				get
		        {
					if(_BannerTitle_W == null)
	        	    {
						_BannerTitle_W = TearOff.BannerTitle;
					}
					return _BannerTitle_W;
				}
			}

			public WhereParameter BannerDescription
		    {
				get
		        {
					if(_BannerDescription_W == null)
	        	    {
						_BannerDescription_W = TearOff.BannerDescription;
					}
					return _BannerDescription_W;
				}
			}

			public WhereParameter BannerFile
		    {
				get
		        {
					if(_BannerFile_W == null)
	        	    {
						_BannerFile_W = TearOff.BannerFile;
					}
					return _BannerFile_W;
				}
			}

			public WhereParameter BannerFileTypeCode
		    {
				get
		        {
					if(_BannerFileTypeCode_W == null)
	        	    {
						_BannerFileTypeCode_W = TearOff.BannerFileTypeCode;
					}
					return _BannerFileTypeCode_W;
				}
			}

			public WhereParameter BannerLink
		    {
				get
		        {
					if(_BannerLink_W == null)
	        	    {
						_BannerLink_W = TearOff.BannerLink;
					}
					return _BannerLink_W;
				}
			}

			public WhereParameter PublishTime
		    {
				get
		        {
					if(_PublishTime_W == null)
	        	    {
						_PublishTime_W = TearOff.PublishTime;
					}
					return _PublishTime_W;
				}
			}

			public WhereParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public WhereParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
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

			private WhereParameter _BannerID_W = null;
			private WhereParameter _BannerTitle_W = null;
			private WhereParameter _BannerDescription_W = null;
			private WhereParameter _BannerFile_W = null;
			private WhereParameter _BannerFileTypeCode_W = null;
			private WhereParameter _BannerLink_W = null;
			private WhereParameter _PublishTime_W = null;
			private WhereParameter _StartDate_W = null;
			private WhereParameter _EndDate_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_BannerID_W = null;
				_BannerTitle_W = null;
				_BannerDescription_W = null;
				_BannerFile_W = null;
				_BannerFileTypeCode_W = null;
				_BannerLink_W = null;
				_PublishTime_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
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
				
				
				public AggregateParameter BannerID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerID, Parameters.BannerID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BannerTitle
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerTitle, Parameters.BannerTitle);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BannerDescription
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerDescription, Parameters.BannerDescription);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BannerFile
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerFile, Parameters.BannerFile);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BannerFileTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerFileTypeCode, Parameters.BannerFileTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BannerLink
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BannerLink, Parameters.BannerLink);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PublishTime
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PublishTime, Parameters.PublishTime);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StartDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EndDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EndDate, Parameters.EndDate);
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
		
			public AggregateParameter BannerID
		    {
				get
		        {
					if(_BannerID_W == null)
	        	    {
						_BannerID_W = TearOff.BannerID;
					}
					return _BannerID_W;
				}
			}

			public AggregateParameter BannerTitle
		    {
				get
		        {
					if(_BannerTitle_W == null)
	        	    {
						_BannerTitle_W = TearOff.BannerTitle;
					}
					return _BannerTitle_W;
				}
			}

			public AggregateParameter BannerDescription
		    {
				get
		        {
					if(_BannerDescription_W == null)
	        	    {
						_BannerDescription_W = TearOff.BannerDescription;
					}
					return _BannerDescription_W;
				}
			}

			public AggregateParameter BannerFile
		    {
				get
		        {
					if(_BannerFile_W == null)
	        	    {
						_BannerFile_W = TearOff.BannerFile;
					}
					return _BannerFile_W;
				}
			}

			public AggregateParameter BannerFileTypeCode
		    {
				get
		        {
					if(_BannerFileTypeCode_W == null)
	        	    {
						_BannerFileTypeCode_W = TearOff.BannerFileTypeCode;
					}
					return _BannerFileTypeCode_W;
				}
			}

			public AggregateParameter BannerLink
		    {
				get
		        {
					if(_BannerLink_W == null)
	        	    {
						_BannerLink_W = TearOff.BannerLink;
					}
					return _BannerLink_W;
				}
			}

			public AggregateParameter PublishTime
		    {
				get
		        {
					if(_PublishTime_W == null)
	        	    {
						_PublishTime_W = TearOff.PublishTime;
					}
					return _PublishTime_W;
				}
			}

			public AggregateParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public AggregateParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
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

			private AggregateParameter _BannerID_W = null;
			private AggregateParameter _BannerTitle_W = null;
			private AggregateParameter _BannerDescription_W = null;
			private AggregateParameter _BannerFile_W = null;
			private AggregateParameter _BannerFileTypeCode_W = null;
			private AggregateParameter _BannerLink_W = null;
			private AggregateParameter _PublishTime_W = null;
			private AggregateParameter _StartDate_W = null;
			private AggregateParameter _EndDate_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_BannerID_W = null;
				_BannerTitle_W = null;
				_BannerDescription_W = null;
				_BannerFile_W = null;
				_BannerFileTypeCode_W = null;
				_BannerLink_W = null;
				_PublishTime_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BannersInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.BannerID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BannersUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BannersDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.BannerID);
			p.SourceColumn = ColumnNames.BannerID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.BannerID);
			p.SourceColumn = ColumnNames.BannerID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BannerTitle);
			p.SourceColumn = ColumnNames.BannerTitle;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BannerDescription);
			p.SourceColumn = ColumnNames.BannerDescription;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BannerFile);
			p.SourceColumn = ColumnNames.BannerFile;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BannerFileTypeCode);
			p.SourceColumn = ColumnNames.BannerFileTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BannerLink);
			p.SourceColumn = ColumnNames.BannerLink;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PublishTime);
			p.SourceColumn = ColumnNames.PublishTime;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StartDate);
			p.SourceColumn = ColumnNames.StartDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndDate);
			p.SourceColumn = ColumnNames.EndDate;
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
