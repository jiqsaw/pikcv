
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
	public abstract class _TestQuestions : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _TestQuestions()
		{
			this.QuerySource = "TestQuestions";
			this.MappingName = "TestQuestions";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestQuestionsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int TestQuestionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.TestQuestionID, TestQuestionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestQuestionsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter TestQuestionID
			{
				get
				{
					return new SqlParameter("@TestQuestionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestTypeCode
			{
				get
				{
					return new SqlParameter("@TestTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestGroupID
			{
				get
				{
					return new SqlParameter("@TestGroupID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SubGroupNo
			{
				get
				{
					return new SqlParameter("@SubGroupNo", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Question
			{
				get
				{
					return new SqlParameter("@Question", SqlDbType.NVarChar, 4000);
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
            public const string TestQuestionID = "TestQuestionID";
            public const string TestTypeCode = "TestTypeCode";
            public const string TestGroupID = "TestGroupID";
            public const string SubGroupNo = "SubGroupNo";
            public const string Question = "Question";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestQuestionID] = _TestQuestions.PropertyNames.TestQuestionID;
					ht[TestTypeCode] = _TestQuestions.PropertyNames.TestTypeCode;
					ht[TestGroupID] = _TestQuestions.PropertyNames.TestGroupID;
					ht[SubGroupNo] = _TestQuestions.PropertyNames.SubGroupNo;
					ht[Question] = _TestQuestions.PropertyNames.Question;
					ht[CreateDate] = _TestQuestions.PropertyNames.CreateDate;
					ht[ModifyDate] = _TestQuestions.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _TestQuestions.PropertyNames.UpdatedBy;
					ht[IsDeleted] = _TestQuestions.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string TestQuestionID = "TestQuestionID";
            public const string TestTypeCode = "TestTypeCode";
            public const string TestGroupID = "TestGroupID";
            public const string SubGroupNo = "SubGroupNo";
            public const string Question = "Question";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestQuestionID] = _TestQuestions.ColumnNames.TestQuestionID;
					ht[TestTypeCode] = _TestQuestions.ColumnNames.TestTypeCode;
					ht[TestGroupID] = _TestQuestions.ColumnNames.TestGroupID;
					ht[SubGroupNo] = _TestQuestions.ColumnNames.SubGroupNo;
					ht[Question] = _TestQuestions.ColumnNames.Question;
					ht[CreateDate] = _TestQuestions.ColumnNames.CreateDate;
					ht[ModifyDate] = _TestQuestions.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _TestQuestions.ColumnNames.UpdatedBy;
					ht[IsDeleted] = _TestQuestions.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string TestQuestionID = "s_TestQuestionID";
            public const string TestTypeCode = "s_TestTypeCode";
            public const string TestGroupID = "s_TestGroupID";
            public const string SubGroupNo = "s_SubGroupNo";
            public const string Question = "s_Question";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int TestQuestionID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestQuestionID);
			}
			set
	        {
				base.Setint(ColumnNames.TestQuestionID, value);
			}
		}

		public virtual int TestTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.TestTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.TestTypeCode, value);
			}
		}

		public virtual int TestGroupID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestGroupID);
			}
			set
	        {
				base.Setint(ColumnNames.TestGroupID, value);
			}
		}

		public virtual int SubGroupNo
	    {
			get
	        {
				return base.Getint(ColumnNames.SubGroupNo);
			}
			set
	        {
				base.Setint(ColumnNames.SubGroupNo, value);
			}
		}

		public virtual string Question
	    {
			get
	        {
				return base.Getstring(ColumnNames.Question);
			}
			set
	        {
				base.Setstring(ColumnNames.Question, value);
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
	
		public virtual string s_TestQuestionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestQuestionID) ? string.Empty : base.GetintAsString(ColumnNames.TestQuestionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestQuestionID);
				else
					this.TestQuestionID = base.SetintAsString(ColumnNames.TestQuestionID, value);
			}
		}

		public virtual string s_TestTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.TestTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestTypeCode);
				else
					this.TestTypeCode = base.SetintAsString(ColumnNames.TestTypeCode, value);
			}
		}

		public virtual string s_TestGroupID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestGroupID) ? string.Empty : base.GetintAsString(ColumnNames.TestGroupID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestGroupID);
				else
					this.TestGroupID = base.SetintAsString(ColumnNames.TestGroupID, value);
			}
		}

		public virtual string s_SubGroupNo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SubGroupNo) ? string.Empty : base.GetintAsString(ColumnNames.SubGroupNo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SubGroupNo);
				else
					this.SubGroupNo = base.SetintAsString(ColumnNames.SubGroupNo, value);
			}
		}

		public virtual string s_Question
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Question) ? string.Empty : base.GetstringAsString(ColumnNames.Question);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Question);
				else
					this.Question = base.SetstringAsString(ColumnNames.Question, value);
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
				
				
				public WhereParameter TestQuestionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestQuestionID, Parameters.TestQuestionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TestTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestTypeCode, Parameters.TestTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TestGroupID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestGroupID, Parameters.TestGroupID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SubGroupNo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SubGroupNo, Parameters.SubGroupNo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Question
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Question, Parameters.Question);
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
		
			public WhereParameter TestQuestionID
		    {
				get
		        {
					if(_TestQuestionID_W == null)
	        	    {
						_TestQuestionID_W = TearOff.TestQuestionID;
					}
					return _TestQuestionID_W;
				}
			}

			public WhereParameter TestTypeCode
		    {
				get
		        {
					if(_TestTypeCode_W == null)
	        	    {
						_TestTypeCode_W = TearOff.TestTypeCode;
					}
					return _TestTypeCode_W;
				}
			}

			public WhereParameter TestGroupID
		    {
				get
		        {
					if(_TestGroupID_W == null)
	        	    {
						_TestGroupID_W = TearOff.TestGroupID;
					}
					return _TestGroupID_W;
				}
			}

			public WhereParameter SubGroupNo
		    {
				get
		        {
					if(_SubGroupNo_W == null)
	        	    {
						_SubGroupNo_W = TearOff.SubGroupNo;
					}
					return _SubGroupNo_W;
				}
			}

			public WhereParameter Question
		    {
				get
		        {
					if(_Question_W == null)
	        	    {
						_Question_W = TearOff.Question;
					}
					return _Question_W;
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

			private WhereParameter _TestQuestionID_W = null;
			private WhereParameter _TestTypeCode_W = null;
			private WhereParameter _TestGroupID_W = null;
			private WhereParameter _SubGroupNo_W = null;
			private WhereParameter _Question_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_TestQuestionID_W = null;
				_TestTypeCode_W = null;
				_TestGroupID_W = null;
				_SubGroupNo_W = null;
				_Question_W = null;
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
				
				
				public AggregateParameter TestQuestionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestQuestionID, Parameters.TestQuestionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TestTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestTypeCode, Parameters.TestTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TestGroupID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestGroupID, Parameters.TestGroupID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SubGroupNo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SubGroupNo, Parameters.SubGroupNo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Question
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Question, Parameters.Question);
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
		
			public AggregateParameter TestQuestionID
		    {
				get
		        {
					if(_TestQuestionID_W == null)
	        	    {
						_TestQuestionID_W = TearOff.TestQuestionID;
					}
					return _TestQuestionID_W;
				}
			}

			public AggregateParameter TestTypeCode
		    {
				get
		        {
					if(_TestTypeCode_W == null)
	        	    {
						_TestTypeCode_W = TearOff.TestTypeCode;
					}
					return _TestTypeCode_W;
				}
			}

			public AggregateParameter TestGroupID
		    {
				get
		        {
					if(_TestGroupID_W == null)
	        	    {
						_TestGroupID_W = TearOff.TestGroupID;
					}
					return _TestGroupID_W;
				}
			}

			public AggregateParameter SubGroupNo
		    {
				get
		        {
					if(_SubGroupNo_W == null)
	        	    {
						_SubGroupNo_W = TearOff.SubGroupNo;
					}
					return _SubGroupNo_W;
				}
			}

			public AggregateParameter Question
		    {
				get
		        {
					if(_Question_W == null)
	        	    {
						_Question_W = TearOff.Question;
					}
					return _Question_W;
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

			private AggregateParameter _TestQuestionID_W = null;
			private AggregateParameter _TestTypeCode_W = null;
			private AggregateParameter _TestGroupID_W = null;
			private AggregateParameter _SubGroupNo_W = null;
			private AggregateParameter _Question_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_TestQuestionID_W = null;
				_TestTypeCode_W = null;
				_TestGroupID_W = null;
				_SubGroupNo_W = null;
				_Question_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestQuestionsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.TestQuestionID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestQuestionsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestQuestionsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.TestQuestionID);
			p.SourceColumn = ColumnNames.TestQuestionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.TestQuestionID);
			p.SourceColumn = ColumnNames.TestQuestionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestTypeCode);
			p.SourceColumn = ColumnNames.TestTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestGroupID);
			p.SourceColumn = ColumnNames.TestGroupID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SubGroupNo);
			p.SourceColumn = ColumnNames.SubGroupNo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Question);
			p.SourceColumn = ColumnNames.Question;
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
