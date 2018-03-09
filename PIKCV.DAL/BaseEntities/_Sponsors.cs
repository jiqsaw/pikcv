
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
	public abstract class _Sponsors : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Sponsors()
		{
			this.QuerySource = "Sponsors";
			this.MappingName = "Sponsors";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SponsorsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int SponsorID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.SponsorID, SponsorID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SponsorsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter SponsorID
			{
				get
				{
					return new SqlParameter("@SponsorID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SponsorTitle
			{
				get
				{
					return new SqlParameter("@SponsorTitle", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter SponsorDescription
			{
				get
				{
					return new SqlParameter("@SponsorDescription", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter SponsorFile
			{
				get
				{
					return new SqlParameter("@SponsorFile", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter SponsorFileTypeCode
			{
				get
				{
					return new SqlParameter("@SponsorFileTypeCode", SqlDbType.Int, 0);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string SponsorID = "SponsorID";
            public const string SponsorTitle = "SponsorTitle";
            public const string SponsorDescription = "SponsorDescription";
            public const string SponsorFile = "SponsorFile";
            public const string SponsorFileTypeCode = "SponsorFileTypeCode";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SponsorID] = _Sponsors.PropertyNames.SponsorID;
					ht[SponsorTitle] = _Sponsors.PropertyNames.SponsorTitle;
					ht[SponsorDescription] = _Sponsors.PropertyNames.SponsorDescription;
					ht[SponsorFile] = _Sponsors.PropertyNames.SponsorFile;
					ht[SponsorFileTypeCode] = _Sponsors.PropertyNames.SponsorFileTypeCode;
					ht[StartDate] = _Sponsors.PropertyNames.StartDate;
					ht[EndDate] = _Sponsors.PropertyNames.EndDate;
					ht[CreateDate] = _Sponsors.PropertyNames.CreateDate;
					ht[ModifyDate] = _Sponsors.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _Sponsors.PropertyNames.UpdatedBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string SponsorID = "SponsorID";
            public const string SponsorTitle = "SponsorTitle";
            public const string SponsorDescription = "SponsorDescription";
            public const string SponsorFile = "SponsorFile";
            public const string SponsorFileTypeCode = "SponsorFileTypeCode";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SponsorID] = _Sponsors.ColumnNames.SponsorID;
					ht[SponsorTitle] = _Sponsors.ColumnNames.SponsorTitle;
					ht[SponsorDescription] = _Sponsors.ColumnNames.SponsorDescription;
					ht[SponsorFile] = _Sponsors.ColumnNames.SponsorFile;
					ht[SponsorFileTypeCode] = _Sponsors.ColumnNames.SponsorFileTypeCode;
					ht[StartDate] = _Sponsors.ColumnNames.StartDate;
					ht[EndDate] = _Sponsors.ColumnNames.EndDate;
					ht[CreateDate] = _Sponsors.ColumnNames.CreateDate;
					ht[ModifyDate] = _Sponsors.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _Sponsors.ColumnNames.UpdatedBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string SponsorID = "s_SponsorID";
            public const string SponsorTitle = "s_SponsorTitle";
            public const string SponsorDescription = "s_SponsorDescription";
            public const string SponsorFile = "s_SponsorFile";
            public const string SponsorFileTypeCode = "s_SponsorFileTypeCode";
            public const string StartDate = "s_StartDate";
            public const string EndDate = "s_EndDate";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";

		}
		#endregion		
		
		#region Properties
	
		public virtual int SponsorID
	    {
			get
	        {
				return base.Getint(ColumnNames.SponsorID);
			}
			set
	        {
				base.Setint(ColumnNames.SponsorID, value);
			}
		}

		public virtual string SponsorTitle
	    {
			get
	        {
				return base.Getstring(ColumnNames.SponsorTitle);
			}
			set
	        {
				base.Setstring(ColumnNames.SponsorTitle, value);
			}
		}

		public virtual string SponsorDescription
	    {
			get
	        {
				return base.Getstring(ColumnNames.SponsorDescription);
			}
			set
	        {
				base.Setstring(ColumnNames.SponsorDescription, value);
			}
		}

		public virtual string SponsorFile
	    {
			get
	        {
				return base.Getstring(ColumnNames.SponsorFile);
			}
			set
	        {
				base.Setstring(ColumnNames.SponsorFile, value);
			}
		}

		public virtual int SponsorFileTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.SponsorFileTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.SponsorFileTypeCode, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_SponsorID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SponsorID) ? string.Empty : base.GetintAsString(ColumnNames.SponsorID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SponsorID);
				else
					this.SponsorID = base.SetintAsString(ColumnNames.SponsorID, value);
			}
		}

		public virtual string s_SponsorTitle
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SponsorTitle) ? string.Empty : base.GetstringAsString(ColumnNames.SponsorTitle);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SponsorTitle);
				else
					this.SponsorTitle = base.SetstringAsString(ColumnNames.SponsorTitle, value);
			}
		}

		public virtual string s_SponsorDescription
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SponsorDescription) ? string.Empty : base.GetstringAsString(ColumnNames.SponsorDescription);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SponsorDescription);
				else
					this.SponsorDescription = base.SetstringAsString(ColumnNames.SponsorDescription, value);
			}
		}

		public virtual string s_SponsorFile
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SponsorFile) ? string.Empty : base.GetstringAsString(ColumnNames.SponsorFile);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SponsorFile);
				else
					this.SponsorFile = base.SetstringAsString(ColumnNames.SponsorFile, value);
			}
		}

		public virtual string s_SponsorFileTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SponsorFileTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.SponsorFileTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SponsorFileTypeCode);
				else
					this.SponsorFileTypeCode = base.SetintAsString(ColumnNames.SponsorFileTypeCode, value);
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
				
				
				public WhereParameter SponsorID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SponsorID, Parameters.SponsorID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SponsorTitle
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SponsorTitle, Parameters.SponsorTitle);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SponsorDescription
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SponsorDescription, Parameters.SponsorDescription);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SponsorFile
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SponsorFile, Parameters.SponsorFile);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SponsorFileTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SponsorFileTypeCode, Parameters.SponsorFileTypeCode);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter SponsorID
		    {
				get
		        {
					if(_SponsorID_W == null)
	        	    {
						_SponsorID_W = TearOff.SponsorID;
					}
					return _SponsorID_W;
				}
			}

			public WhereParameter SponsorTitle
		    {
				get
		        {
					if(_SponsorTitle_W == null)
	        	    {
						_SponsorTitle_W = TearOff.SponsorTitle;
					}
					return _SponsorTitle_W;
				}
			}

			public WhereParameter SponsorDescription
		    {
				get
		        {
					if(_SponsorDescription_W == null)
	        	    {
						_SponsorDescription_W = TearOff.SponsorDescription;
					}
					return _SponsorDescription_W;
				}
			}

			public WhereParameter SponsorFile
		    {
				get
		        {
					if(_SponsorFile_W == null)
	        	    {
						_SponsorFile_W = TearOff.SponsorFile;
					}
					return _SponsorFile_W;
				}
			}

			public WhereParameter SponsorFileTypeCode
		    {
				get
		        {
					if(_SponsorFileTypeCode_W == null)
	        	    {
						_SponsorFileTypeCode_W = TearOff.SponsorFileTypeCode;
					}
					return _SponsorFileTypeCode_W;
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

			private WhereParameter _SponsorID_W = null;
			private WhereParameter _SponsorTitle_W = null;
			private WhereParameter _SponsorDescription_W = null;
			private WhereParameter _SponsorFile_W = null;
			private WhereParameter _SponsorFileTypeCode_W = null;
			private WhereParameter _StartDate_W = null;
			private WhereParameter _EndDate_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;

			public void WhereClauseReset()
			{
				_SponsorID_W = null;
				_SponsorTitle_W = null;
				_SponsorDescription_W = null;
				_SponsorFile_W = null;
				_SponsorFileTypeCode_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
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
				
				
				public AggregateParameter SponsorID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SponsorID, Parameters.SponsorID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SponsorTitle
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SponsorTitle, Parameters.SponsorTitle);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SponsorDescription
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SponsorDescription, Parameters.SponsorDescription);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SponsorFile
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SponsorFile, Parameters.SponsorFile);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SponsorFileTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SponsorFileTypeCode, Parameters.SponsorFileTypeCode);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter SponsorID
		    {
				get
		        {
					if(_SponsorID_W == null)
	        	    {
						_SponsorID_W = TearOff.SponsorID;
					}
					return _SponsorID_W;
				}
			}

			public AggregateParameter SponsorTitle
		    {
				get
		        {
					if(_SponsorTitle_W == null)
	        	    {
						_SponsorTitle_W = TearOff.SponsorTitle;
					}
					return _SponsorTitle_W;
				}
			}

			public AggregateParameter SponsorDescription
		    {
				get
		        {
					if(_SponsorDescription_W == null)
	        	    {
						_SponsorDescription_W = TearOff.SponsorDescription;
					}
					return _SponsorDescription_W;
				}
			}

			public AggregateParameter SponsorFile
		    {
				get
		        {
					if(_SponsorFile_W == null)
	        	    {
						_SponsorFile_W = TearOff.SponsorFile;
					}
					return _SponsorFile_W;
				}
			}

			public AggregateParameter SponsorFileTypeCode
		    {
				get
		        {
					if(_SponsorFileTypeCode_W == null)
	        	    {
						_SponsorFileTypeCode_W = TearOff.SponsorFileTypeCode;
					}
					return _SponsorFileTypeCode_W;
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

			private AggregateParameter _SponsorID_W = null;
			private AggregateParameter _SponsorTitle_W = null;
			private AggregateParameter _SponsorDescription_W = null;
			private AggregateParameter _SponsorFile_W = null;
			private AggregateParameter _SponsorFileTypeCode_W = null;
			private AggregateParameter _StartDate_W = null;
			private AggregateParameter _EndDate_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;

			public void AggregateClauseReset()
			{
				_SponsorID_W = null;
				_SponsorTitle_W = null;
				_SponsorDescription_W = null;
				_SponsorFile_W = null;
				_SponsorFileTypeCode_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SponsorsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.SponsorID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SponsorsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SponsorsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.SponsorID);
			p.SourceColumn = ColumnNames.SponsorID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.SponsorID);
			p.SourceColumn = ColumnNames.SponsorID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SponsorTitle);
			p.SourceColumn = ColumnNames.SponsorTitle;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SponsorDescription);
			p.SourceColumn = ColumnNames.SponsorDescription;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SponsorFile);
			p.SourceColumn = ColumnNames.SponsorFile;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SponsorFileTypeCode);
			p.SourceColumn = ColumnNames.SponsorFileTypeCode;
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


			return cmd;
		}
	}
}