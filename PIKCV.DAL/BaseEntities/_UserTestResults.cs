
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
	public abstract class _UserTestResults : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _UserTestResults()
		{
			this.QuerySource = "UserTestResults";
			this.MappingName = "UserTestResults";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserTestResultsLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserTestResultsLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter TestTypeCode
			{
				get
				{
					return new SqlParameter("@TestTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter QuestionNo
			{
				get
				{
					return new SqlParameter("@QuestionNo", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestQuestionID
			{
				get
				{
					return new SqlParameter("@TestQuestionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestAnswerID
			{
				get
				{
					return new SqlParameter("@TestAnswerID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string TestTypeCode = "TestTypeCode";
            public const string UserID = "UserID";
            public const string QuestionNo = "QuestionNo";
            public const string TestQuestionID = "TestQuestionID";
            public const string TestAnswerID = "TestAnswerID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _UserTestResults.PropertyNames.RowID;
					ht[TestTypeCode] = _UserTestResults.PropertyNames.TestTypeCode;
					ht[UserID] = _UserTestResults.PropertyNames.UserID;
					ht[QuestionNo] = _UserTestResults.PropertyNames.QuestionNo;
					ht[TestQuestionID] = _UserTestResults.PropertyNames.TestQuestionID;
					ht[TestAnswerID] = _UserTestResults.PropertyNames.TestAnswerID;

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
            public const string TestTypeCode = "TestTypeCode";
            public const string UserID = "UserID";
            public const string QuestionNo = "QuestionNo";
            public const string TestQuestionID = "TestQuestionID";
            public const string TestAnswerID = "TestAnswerID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _UserTestResults.ColumnNames.RowID;
					ht[TestTypeCode] = _UserTestResults.ColumnNames.TestTypeCode;
					ht[UserID] = _UserTestResults.ColumnNames.UserID;
					ht[QuestionNo] = _UserTestResults.ColumnNames.QuestionNo;
					ht[TestQuestionID] = _UserTestResults.ColumnNames.TestQuestionID;
					ht[TestAnswerID] = _UserTestResults.ColumnNames.TestAnswerID;

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
            public const string TestTypeCode = "s_TestTypeCode";
            public const string UserID = "s_UserID";
            public const string QuestionNo = "s_QuestionNo";
            public const string TestQuestionID = "s_TestQuestionID";
            public const string TestAnswerID = "s_TestAnswerID";

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

		public virtual int UserID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserID);
			}
			set
	        {
				base.Setint(ColumnNames.UserID, value);
			}
		}

		public virtual int QuestionNo
	    {
			get
	        {
				return base.Getint(ColumnNames.QuestionNo);
			}
			set
	        {
				base.Setint(ColumnNames.QuestionNo, value);
			}
		}

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

		public virtual int TestAnswerID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestAnswerID);
			}
			set
	        {
				base.Setint(ColumnNames.TestAnswerID, value);
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

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetintAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetintAsString(ColumnNames.UserID, value);
			}
		}

		public virtual string s_QuestionNo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.QuestionNo) ? string.Empty : base.GetintAsString(ColumnNames.QuestionNo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.QuestionNo);
				else
					this.QuestionNo = base.SetintAsString(ColumnNames.QuestionNo, value);
			}
		}

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

		public virtual string s_TestAnswerID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestAnswerID) ? string.Empty : base.GetintAsString(ColumnNames.TestAnswerID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestAnswerID);
				else
					this.TestAnswerID = base.SetintAsString(ColumnNames.TestAnswerID, value);
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

				public WhereParameter TestTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestTypeCode, Parameters.TestTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter QuestionNo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.QuestionNo, Parameters.QuestionNo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter TestAnswerID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestAnswerID, Parameters.TestAnswerID);
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

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public WhereParameter QuestionNo
		    {
				get
		        {
					if(_QuestionNo_W == null)
	        	    {
						_QuestionNo_W = TearOff.QuestionNo;
					}
					return _QuestionNo_W;
				}
			}

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

			public WhereParameter TestAnswerID
		    {
				get
		        {
					if(_TestAnswerID_W == null)
	        	    {
						_TestAnswerID_W = TearOff.TestAnswerID;
					}
					return _TestAnswerID_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _TestTypeCode_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _QuestionNo_W = null;
			private WhereParameter _TestQuestionID_W = null;
			private WhereParameter _TestAnswerID_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_TestTypeCode_W = null;
				_UserID_W = null;
				_QuestionNo_W = null;
				_TestQuestionID_W = null;
				_TestAnswerID_W = null;

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

				public AggregateParameter TestTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestTypeCode, Parameters.TestTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter QuestionNo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.QuestionNo, Parameters.QuestionNo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter TestAnswerID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestAnswerID, Parameters.TestAnswerID);
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

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public AggregateParameter QuestionNo
		    {
				get
		        {
					if(_QuestionNo_W == null)
	        	    {
						_QuestionNo_W = TearOff.QuestionNo;
					}
					return _QuestionNo_W;
				}
			}

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

			public AggregateParameter TestAnswerID
		    {
				get
		        {
					if(_TestAnswerID_W == null)
	        	    {
						_TestAnswerID_W = TearOff.TestAnswerID;
					}
					return _TestAnswerID_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _TestTypeCode_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _QuestionNo_W = null;
			private AggregateParameter _TestQuestionID_W = null;
			private AggregateParameter _TestAnswerID_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_TestTypeCode_W = null;
				_UserID_W = null;
				_QuestionNo_W = null;
				_TestQuestionID_W = null;
				_TestAnswerID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserTestResultsInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserTestResultsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserTestResultsDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.TestTypeCode);
			p.SourceColumn = ColumnNames.TestTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.QuestionNo);
			p.SourceColumn = ColumnNames.QuestionNo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestQuestionID);
			p.SourceColumn = ColumnNames.TestQuestionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestAnswerID);
			p.SourceColumn = ColumnNames.TestAnswerID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
