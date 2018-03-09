
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
	public abstract class _Messages : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Messages()
		{
			this.QuerySource = "Messages";
			this.MappingName = "Messages";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_MessagesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int MessageID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.MessageID, MessageID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_MessagesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter MessageID
			{
				get
				{
					return new SqlParameter("@MessageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MessageTypeCode
			{
				get
				{
					return new SqlParameter("@MessageTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MessageTitle
			{
				get
				{
					return new SqlParameter("@MessageTitle", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter MessageBody
			{
				get
				{
					return new SqlParameter("@MessageBody", SqlDbType.NVarChar, 4000);
				}
			}
			
			public static SqlParameter MessageOwnerTypeCode
			{
				get
				{
					return new SqlParameter("@MessageOwnerTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MessageOwnerID
			{
				get
				{
					return new SqlParameter("@MessageOwnerID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SenderTypeCode
			{
				get
				{
					return new SqlParameter("@SenderTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SenderID
			{
				get
				{
					return new SqlParameter("@SenderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter JobID
			{
				get
				{
					return new SqlParameter("@JobID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreateDate
			{
				get
				{
					return new SqlParameter("@CreateDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IsRead
			{
				get
				{
					return new SqlParameter("@IsRead", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter ReadDate
			{
				get
				{
					return new SqlParameter("@ReadDate", SqlDbType.DateTime, 0);
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
            public const string MessageID = "MessageID";
            public const string MessageTypeCode = "MessageTypeCode";
            public const string MessageTitle = "MessageTitle";
            public const string MessageBody = "MessageBody";
            public const string MessageOwnerTypeCode = "MessageOwnerTypeCode";
            public const string MessageOwnerID = "MessageOwnerID";
            public const string SenderTypeCode = "SenderTypeCode";
            public const string SenderID = "SenderID";
            public const string JobID = "JobID";
            public const string CreateDate = "CreateDate";
            public const string IsRead = "IsRead";
            public const string ReadDate = "ReadDate";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[MessageID] = _Messages.PropertyNames.MessageID;
					ht[MessageTypeCode] = _Messages.PropertyNames.MessageTypeCode;
					ht[MessageTitle] = _Messages.PropertyNames.MessageTitle;
					ht[MessageBody] = _Messages.PropertyNames.MessageBody;
					ht[MessageOwnerTypeCode] = _Messages.PropertyNames.MessageOwnerTypeCode;
					ht[MessageOwnerID] = _Messages.PropertyNames.MessageOwnerID;
					ht[SenderTypeCode] = _Messages.PropertyNames.SenderTypeCode;
					ht[SenderID] = _Messages.PropertyNames.SenderID;
					ht[JobID] = _Messages.PropertyNames.JobID;
					ht[CreateDate] = _Messages.PropertyNames.CreateDate;
					ht[IsRead] = _Messages.PropertyNames.IsRead;
					ht[ReadDate] = _Messages.PropertyNames.ReadDate;
					ht[IsDeleted] = _Messages.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string MessageID = "MessageID";
            public const string MessageTypeCode = "MessageTypeCode";
            public const string MessageTitle = "MessageTitle";
            public const string MessageBody = "MessageBody";
            public const string MessageOwnerTypeCode = "MessageOwnerTypeCode";
            public const string MessageOwnerID = "MessageOwnerID";
            public const string SenderTypeCode = "SenderTypeCode";
            public const string SenderID = "SenderID";
            public const string JobID = "JobID";
            public const string CreateDate = "CreateDate";
            public const string IsRead = "IsRead";
            public const string ReadDate = "ReadDate";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[MessageID] = _Messages.ColumnNames.MessageID;
					ht[MessageTypeCode] = _Messages.ColumnNames.MessageTypeCode;
					ht[MessageTitle] = _Messages.ColumnNames.MessageTitle;
					ht[MessageBody] = _Messages.ColumnNames.MessageBody;
					ht[MessageOwnerTypeCode] = _Messages.ColumnNames.MessageOwnerTypeCode;
					ht[MessageOwnerID] = _Messages.ColumnNames.MessageOwnerID;
					ht[SenderTypeCode] = _Messages.ColumnNames.SenderTypeCode;
					ht[SenderID] = _Messages.ColumnNames.SenderID;
					ht[JobID] = _Messages.ColumnNames.JobID;
					ht[CreateDate] = _Messages.ColumnNames.CreateDate;
					ht[IsRead] = _Messages.ColumnNames.IsRead;
					ht[ReadDate] = _Messages.ColumnNames.ReadDate;
					ht[IsDeleted] = _Messages.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string MessageID = "s_MessageID";
            public const string MessageTypeCode = "s_MessageTypeCode";
            public const string MessageTitle = "s_MessageTitle";
            public const string MessageBody = "s_MessageBody";
            public const string MessageOwnerTypeCode = "s_MessageOwnerTypeCode";
            public const string MessageOwnerID = "s_MessageOwnerID";
            public const string SenderTypeCode = "s_SenderTypeCode";
            public const string SenderID = "s_SenderID";
            public const string JobID = "s_JobID";
            public const string CreateDate = "s_CreateDate";
            public const string IsRead = "s_IsRead";
            public const string ReadDate = "s_ReadDate";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int MessageID
	    {
			get
	        {
				return base.Getint(ColumnNames.MessageID);
			}
			set
	        {
				base.Setint(ColumnNames.MessageID, value);
			}
		}

		public virtual int MessageTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.MessageTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.MessageTypeCode, value);
			}
		}

		public virtual string MessageTitle
	    {
			get
	        {
				return base.Getstring(ColumnNames.MessageTitle);
			}
			set
	        {
				base.Setstring(ColumnNames.MessageTitle, value);
			}
		}

		public virtual string MessageBody
	    {
			get
	        {
				return base.Getstring(ColumnNames.MessageBody);
			}
			set
	        {
				base.Setstring(ColumnNames.MessageBody, value);
			}
		}

		public virtual int MessageOwnerTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.MessageOwnerTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.MessageOwnerTypeCode, value);
			}
		}

		public virtual int MessageOwnerID
	    {
			get
	        {
				return base.Getint(ColumnNames.MessageOwnerID);
			}
			set
	        {
				base.Setint(ColumnNames.MessageOwnerID, value);
			}
		}

		public virtual int SenderTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.SenderTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.SenderTypeCode, value);
			}
		}

		public virtual int SenderID
	    {
			get
	        {
				return base.Getint(ColumnNames.SenderID);
			}
			set
	        {
				base.Setint(ColumnNames.SenderID, value);
			}
		}

		public virtual int JobID
	    {
			get
	        {
				return base.Getint(ColumnNames.JobID);
			}
			set
	        {
				base.Setint(ColumnNames.JobID, value);
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

		public virtual bool IsRead
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsRead);
			}
			set
	        {
				base.Setbool(ColumnNames.IsRead, value);
			}
		}

		public virtual DateTime ReadDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ReadDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ReadDate, value);
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
	
		public virtual string s_MessageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageID) ? string.Empty : base.GetintAsString(ColumnNames.MessageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageID);
				else
					this.MessageID = base.SetintAsString(ColumnNames.MessageID, value);
			}
		}

		public virtual string s_MessageTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.MessageTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageTypeCode);
				else
					this.MessageTypeCode = base.SetintAsString(ColumnNames.MessageTypeCode, value);
			}
		}

		public virtual string s_MessageTitle
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageTitle) ? string.Empty : base.GetstringAsString(ColumnNames.MessageTitle);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageTitle);
				else
					this.MessageTitle = base.SetstringAsString(ColumnNames.MessageTitle, value);
			}
		}

		public virtual string s_MessageBody
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageBody) ? string.Empty : base.GetstringAsString(ColumnNames.MessageBody);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageBody);
				else
					this.MessageBody = base.SetstringAsString(ColumnNames.MessageBody, value);
			}
		}

		public virtual string s_MessageOwnerTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageOwnerTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.MessageOwnerTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageOwnerTypeCode);
				else
					this.MessageOwnerTypeCode = base.SetintAsString(ColumnNames.MessageOwnerTypeCode, value);
			}
		}

		public virtual string s_MessageOwnerID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MessageOwnerID) ? string.Empty : base.GetintAsString(ColumnNames.MessageOwnerID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MessageOwnerID);
				else
					this.MessageOwnerID = base.SetintAsString(ColumnNames.MessageOwnerID, value);
			}
		}

		public virtual string s_SenderTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SenderTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.SenderTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SenderTypeCode);
				else
					this.SenderTypeCode = base.SetintAsString(ColumnNames.SenderTypeCode, value);
			}
		}

		public virtual string s_SenderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SenderID) ? string.Empty : base.GetintAsString(ColumnNames.SenderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SenderID);
				else
					this.SenderID = base.SetintAsString(ColumnNames.SenderID, value);
			}
		}

		public virtual string s_JobID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.JobID) ? string.Empty : base.GetintAsString(ColumnNames.JobID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.JobID);
				else
					this.JobID = base.SetintAsString(ColumnNames.JobID, value);
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

		public virtual string s_IsRead
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsRead) ? string.Empty : base.GetboolAsString(ColumnNames.IsRead);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsRead);
				else
					this.IsRead = base.SetboolAsString(ColumnNames.IsRead, value);
			}
		}

		public virtual string s_ReadDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReadDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ReadDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReadDate);
				else
					this.ReadDate = base.SetDateTimeAsString(ColumnNames.ReadDate, value);
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
				
				
				public WhereParameter MessageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageID, Parameters.MessageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MessageTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageTypeCode, Parameters.MessageTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MessageTitle
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageTitle, Parameters.MessageTitle);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MessageBody
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageBody, Parameters.MessageBody);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MessageOwnerTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageOwnerTypeCode, Parameters.MessageOwnerTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MessageOwnerID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MessageOwnerID, Parameters.MessageOwnerID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SenderTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SenderTypeCode, Parameters.SenderTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SenderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SenderID, Parameters.SenderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter JobID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.JobID, Parameters.JobID);
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

				public WhereParameter IsRead
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsRead, Parameters.IsRead);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReadDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReadDate, Parameters.ReadDate);
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
		
			public WhereParameter MessageID
		    {
				get
		        {
					if(_MessageID_W == null)
	        	    {
						_MessageID_W = TearOff.MessageID;
					}
					return _MessageID_W;
				}
			}

			public WhereParameter MessageTypeCode
		    {
				get
		        {
					if(_MessageTypeCode_W == null)
	        	    {
						_MessageTypeCode_W = TearOff.MessageTypeCode;
					}
					return _MessageTypeCode_W;
				}
			}

			public WhereParameter MessageTitle
		    {
				get
		        {
					if(_MessageTitle_W == null)
	        	    {
						_MessageTitle_W = TearOff.MessageTitle;
					}
					return _MessageTitle_W;
				}
			}

			public WhereParameter MessageBody
		    {
				get
		        {
					if(_MessageBody_W == null)
	        	    {
						_MessageBody_W = TearOff.MessageBody;
					}
					return _MessageBody_W;
				}
			}

			public WhereParameter MessageOwnerTypeCode
		    {
				get
		        {
					if(_MessageOwnerTypeCode_W == null)
	        	    {
						_MessageOwnerTypeCode_W = TearOff.MessageOwnerTypeCode;
					}
					return _MessageOwnerTypeCode_W;
				}
			}

			public WhereParameter MessageOwnerID
		    {
				get
		        {
					if(_MessageOwnerID_W == null)
	        	    {
						_MessageOwnerID_W = TearOff.MessageOwnerID;
					}
					return _MessageOwnerID_W;
				}
			}

			public WhereParameter SenderTypeCode
		    {
				get
		        {
					if(_SenderTypeCode_W == null)
	        	    {
						_SenderTypeCode_W = TearOff.SenderTypeCode;
					}
					return _SenderTypeCode_W;
				}
			}

			public WhereParameter SenderID
		    {
				get
		        {
					if(_SenderID_W == null)
	        	    {
						_SenderID_W = TearOff.SenderID;
					}
					return _SenderID_W;
				}
			}

			public WhereParameter JobID
		    {
				get
		        {
					if(_JobID_W == null)
	        	    {
						_JobID_W = TearOff.JobID;
					}
					return _JobID_W;
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

			public WhereParameter IsRead
		    {
				get
		        {
					if(_IsRead_W == null)
	        	    {
						_IsRead_W = TearOff.IsRead;
					}
					return _IsRead_W;
				}
			}

			public WhereParameter ReadDate
		    {
				get
		        {
					if(_ReadDate_W == null)
	        	    {
						_ReadDate_W = TearOff.ReadDate;
					}
					return _ReadDate_W;
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

			private WhereParameter _MessageID_W = null;
			private WhereParameter _MessageTypeCode_W = null;
			private WhereParameter _MessageTitle_W = null;
			private WhereParameter _MessageBody_W = null;
			private WhereParameter _MessageOwnerTypeCode_W = null;
			private WhereParameter _MessageOwnerID_W = null;
			private WhereParameter _SenderTypeCode_W = null;
			private WhereParameter _SenderID_W = null;
			private WhereParameter _JobID_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _IsRead_W = null;
			private WhereParameter _ReadDate_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_MessageID_W = null;
				_MessageTypeCode_W = null;
				_MessageTitle_W = null;
				_MessageBody_W = null;
				_MessageOwnerTypeCode_W = null;
				_MessageOwnerID_W = null;
				_SenderTypeCode_W = null;
				_SenderID_W = null;
				_JobID_W = null;
				_CreateDate_W = null;
				_IsRead_W = null;
				_ReadDate_W = null;
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
				
				
				public AggregateParameter MessageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageID, Parameters.MessageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MessageTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageTypeCode, Parameters.MessageTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MessageTitle
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageTitle, Parameters.MessageTitle);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MessageBody
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageBody, Parameters.MessageBody);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MessageOwnerTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageOwnerTypeCode, Parameters.MessageOwnerTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MessageOwnerID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MessageOwnerID, Parameters.MessageOwnerID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SenderTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SenderTypeCode, Parameters.SenderTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SenderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SenderID, Parameters.SenderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter JobID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.JobID, Parameters.JobID);
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

				public AggregateParameter IsRead
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsRead, Parameters.IsRead);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReadDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReadDate, Parameters.ReadDate);
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
		
			public AggregateParameter MessageID
		    {
				get
		        {
					if(_MessageID_W == null)
	        	    {
						_MessageID_W = TearOff.MessageID;
					}
					return _MessageID_W;
				}
			}

			public AggregateParameter MessageTypeCode
		    {
				get
		        {
					if(_MessageTypeCode_W == null)
	        	    {
						_MessageTypeCode_W = TearOff.MessageTypeCode;
					}
					return _MessageTypeCode_W;
				}
			}

			public AggregateParameter MessageTitle
		    {
				get
		        {
					if(_MessageTitle_W == null)
	        	    {
						_MessageTitle_W = TearOff.MessageTitle;
					}
					return _MessageTitle_W;
				}
			}

			public AggregateParameter MessageBody
		    {
				get
		        {
					if(_MessageBody_W == null)
	        	    {
						_MessageBody_W = TearOff.MessageBody;
					}
					return _MessageBody_W;
				}
			}

			public AggregateParameter MessageOwnerTypeCode
		    {
				get
		        {
					if(_MessageOwnerTypeCode_W == null)
	        	    {
						_MessageOwnerTypeCode_W = TearOff.MessageOwnerTypeCode;
					}
					return _MessageOwnerTypeCode_W;
				}
			}

			public AggregateParameter MessageOwnerID
		    {
				get
		        {
					if(_MessageOwnerID_W == null)
	        	    {
						_MessageOwnerID_W = TearOff.MessageOwnerID;
					}
					return _MessageOwnerID_W;
				}
			}

			public AggregateParameter SenderTypeCode
		    {
				get
		        {
					if(_SenderTypeCode_W == null)
	        	    {
						_SenderTypeCode_W = TearOff.SenderTypeCode;
					}
					return _SenderTypeCode_W;
				}
			}

			public AggregateParameter SenderID
		    {
				get
		        {
					if(_SenderID_W == null)
	        	    {
						_SenderID_W = TearOff.SenderID;
					}
					return _SenderID_W;
				}
			}

			public AggregateParameter JobID
		    {
				get
		        {
					if(_JobID_W == null)
	        	    {
						_JobID_W = TearOff.JobID;
					}
					return _JobID_W;
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

			public AggregateParameter IsRead
		    {
				get
		        {
					if(_IsRead_W == null)
	        	    {
						_IsRead_W = TearOff.IsRead;
					}
					return _IsRead_W;
				}
			}

			public AggregateParameter ReadDate
		    {
				get
		        {
					if(_ReadDate_W == null)
	        	    {
						_ReadDate_W = TearOff.ReadDate;
					}
					return _ReadDate_W;
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

			private AggregateParameter _MessageID_W = null;
			private AggregateParameter _MessageTypeCode_W = null;
			private AggregateParameter _MessageTitle_W = null;
			private AggregateParameter _MessageBody_W = null;
			private AggregateParameter _MessageOwnerTypeCode_W = null;
			private AggregateParameter _MessageOwnerID_W = null;
			private AggregateParameter _SenderTypeCode_W = null;
			private AggregateParameter _SenderID_W = null;
			private AggregateParameter _JobID_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _IsRead_W = null;
			private AggregateParameter _ReadDate_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_MessageID_W = null;
				_MessageTypeCode_W = null;
				_MessageTitle_W = null;
				_MessageBody_W = null;
				_MessageOwnerTypeCode_W = null;
				_MessageOwnerID_W = null;
				_SenderTypeCode_W = null;
				_SenderID_W = null;
				_JobID_W = null;
				_CreateDate_W = null;
				_IsRead_W = null;
				_ReadDate_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MessagesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.MessageID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MessagesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MessagesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.MessageID);
			p.SourceColumn = ColumnNames.MessageID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.MessageID);
			p.SourceColumn = ColumnNames.MessageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MessageTypeCode);
			p.SourceColumn = ColumnNames.MessageTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MessageTitle);
			p.SourceColumn = ColumnNames.MessageTitle;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MessageBody);
			p.SourceColumn = ColumnNames.MessageBody;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MessageOwnerTypeCode);
			p.SourceColumn = ColumnNames.MessageOwnerTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MessageOwnerID);
			p.SourceColumn = ColumnNames.MessageOwnerID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SenderTypeCode);
			p.SourceColumn = ColumnNames.SenderTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SenderID);
			p.SourceColumn = ColumnNames.SenderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.JobID);
			p.SourceColumn = ColumnNames.JobID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreateDate);
			p.SourceColumn = ColumnNames.CreateDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsRead);
			p.SourceColumn = ColumnNames.IsRead;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReadDate);
			p.SourceColumn = ColumnNames.ReadDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
