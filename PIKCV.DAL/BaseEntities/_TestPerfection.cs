
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
	public abstract class _TestPerfection : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _TestPerfection()
		{
			this.QuerySource = "TestPerfection";
			this.MappingName = "TestPerfection";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestPerfectionLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int TestPerfectionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.TestPerfectionID, TestPerfectionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestPerfectionLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter TestPerfectionID
			{
				get
				{
					return new SqlParameter("@TestPerfectionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter EmployeeTypeCode
			{
				get
				{
					return new SqlParameter("@EmployeeTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestGroupID
			{
				get
				{
					return new SqlParameter("@TestGroupID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestLevelID
			{
				get
				{
					return new SqlParameter("@TestLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Statement
			{
				get
				{
					return new SqlParameter("@Statement", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string TestPerfectionID = "TestPerfectionID";
            public const string EmployeeTypeCode = "EmployeeTypeCode";
            public const string TestGroupID = "TestGroupID";
            public const string TestLevelID = "TestLevelID";
            public const string Statement = "Statement";
            public const string IsActive = "isActive";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestPerfectionID] = _TestPerfection.PropertyNames.TestPerfectionID;
					ht[EmployeeTypeCode] = _TestPerfection.PropertyNames.EmployeeTypeCode;
					ht[TestGroupID] = _TestPerfection.PropertyNames.TestGroupID;
					ht[TestLevelID] = _TestPerfection.PropertyNames.TestLevelID;
					ht[Statement] = _TestPerfection.PropertyNames.Statement;
					ht[IsActive] = _TestPerfection.PropertyNames.IsActive;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string TestPerfectionID = "TestPerfectionID";
            public const string EmployeeTypeCode = "EmployeeTypeCode";
            public const string TestGroupID = "TestGroupID";
            public const string TestLevelID = "TestLevelID";
            public const string Statement = "Statement";
            public const string IsActive = "IsActive";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestPerfectionID] = _TestPerfection.ColumnNames.TestPerfectionID;
					ht[EmployeeTypeCode] = _TestPerfection.ColumnNames.EmployeeTypeCode;
					ht[TestGroupID] = _TestPerfection.ColumnNames.TestGroupID;
					ht[TestLevelID] = _TestPerfection.ColumnNames.TestLevelID;
					ht[Statement] = _TestPerfection.ColumnNames.Statement;
					ht[IsActive] = _TestPerfection.ColumnNames.IsActive;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string TestPerfectionID = "s_TestPerfectionID";
            public const string EmployeeTypeCode = "s_EmployeeTypeCode";
            public const string TestGroupID = "s_TestGroupID";
            public const string TestLevelID = "s_TestLevelID";
            public const string Statement = "s_Statement";
            public const string IsActive = "s_IsActive";

		}
		#endregion		
		
		#region Properties
	
		public virtual int TestPerfectionID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestPerfectionID);
			}
			set
	        {
				base.Setint(ColumnNames.TestPerfectionID, value);
			}
		}

		public virtual int EmployeeTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.EmployeeTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.EmployeeTypeCode, value);
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

		public virtual int TestLevelID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestLevelID);
			}
			set
	        {
				base.Setint(ColumnNames.TestLevelID, value);
			}
		}

		public virtual string Statement
	    {
			get
	        {
				return base.Getstring(ColumnNames.Statement);
			}
			set
	        {
				base.Setstring(ColumnNames.Statement, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_TestPerfectionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestPerfectionID) ? string.Empty : base.GetintAsString(ColumnNames.TestPerfectionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestPerfectionID);
				else
					this.TestPerfectionID = base.SetintAsString(ColumnNames.TestPerfectionID, value);
			}
		}

		public virtual string s_EmployeeTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EmployeeTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.EmployeeTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EmployeeTypeCode);
				else
					this.EmployeeTypeCode = base.SetintAsString(ColumnNames.EmployeeTypeCode, value);
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

		public virtual string s_TestLevelID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestLevelID) ? string.Empty : base.GetintAsString(ColumnNames.TestLevelID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestLevelID);
				else
					this.TestLevelID = base.SetintAsString(ColumnNames.TestLevelID, value);
			}
		}

		public virtual string s_Statement
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Statement) ? string.Empty : base.GetstringAsString(ColumnNames.Statement);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Statement);
				else
					this.Statement = base.SetstringAsString(ColumnNames.Statement, value);
			}
		}

		public virtual string s_IsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsActive);
				else
					this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
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
				
				
				public WhereParameter TestPerfectionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestPerfectionID, Parameters.TestPerfectionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EmployeeTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EmployeeTypeCode, Parameters.EmployeeTypeCode);
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

				public WhereParameter TestLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Statement
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Statement, Parameters.Statement);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter TestPerfectionID
		    {
				get
		        {
					if(_TestPerfectionID_W == null)
	        	    {
						_TestPerfectionID_W = TearOff.TestPerfectionID;
					}
					return _TestPerfectionID_W;
				}
			}

			public WhereParameter EmployeeTypeCode
		    {
				get
		        {
					if(_EmployeeTypeCode_W == null)
	        	    {
						_EmployeeTypeCode_W = TearOff.EmployeeTypeCode;
					}
					return _EmployeeTypeCode_W;
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

			public WhereParameter TestLevelID
		    {
				get
		        {
					if(_TestLevelID_W == null)
	        	    {
						_TestLevelID_W = TearOff.TestLevelID;
					}
					return _TestLevelID_W;
				}
			}

			public WhereParameter Statement
		    {
				get
		        {
					if(_Statement_W == null)
	        	    {
						_Statement_W = TearOff.Statement;
					}
					return _Statement_W;
				}
			}

			public WhereParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			private WhereParameter _TestPerfectionID_W = null;
			private WhereParameter _EmployeeTypeCode_W = null;
			private WhereParameter _TestGroupID_W = null;
			private WhereParameter _TestLevelID_W = null;
			private WhereParameter _Statement_W = null;
			private WhereParameter _IsActive_W = null;

			public void WhereClauseReset()
			{
				_TestPerfectionID_W = null;
				_EmployeeTypeCode_W = null;
				_TestGroupID_W = null;
				_TestLevelID_W = null;
				_Statement_W = null;
				_IsActive_W = null;

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
				
				
				public AggregateParameter TestPerfectionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestPerfectionID, Parameters.TestPerfectionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EmployeeTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EmployeeTypeCode, Parameters.EmployeeTypeCode);
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

				public AggregateParameter TestLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Statement
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Statement, Parameters.Statement);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter TestPerfectionID
		    {
				get
		        {
					if(_TestPerfectionID_W == null)
	        	    {
						_TestPerfectionID_W = TearOff.TestPerfectionID;
					}
					return _TestPerfectionID_W;
				}
			}

			public AggregateParameter EmployeeTypeCode
		    {
				get
		        {
					if(_EmployeeTypeCode_W == null)
	        	    {
						_EmployeeTypeCode_W = TearOff.EmployeeTypeCode;
					}
					return _EmployeeTypeCode_W;
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

			public AggregateParameter TestLevelID
		    {
				get
		        {
					if(_TestLevelID_W == null)
	        	    {
						_TestLevelID_W = TearOff.TestLevelID;
					}
					return _TestLevelID_W;
				}
			}

			public AggregateParameter Statement
		    {
				get
		        {
					if(_Statement_W == null)
	        	    {
						_Statement_W = TearOff.Statement;
					}
					return _Statement_W;
				}
			}

			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			private AggregateParameter _TestPerfectionID_W = null;
			private AggregateParameter _EmployeeTypeCode_W = null;
			private AggregateParameter _TestGroupID_W = null;
			private AggregateParameter _TestLevelID_W = null;
			private AggregateParameter _Statement_W = null;
			private AggregateParameter _IsActive_W = null;

			public void AggregateClauseReset()
			{
				_TestPerfectionID_W = null;
				_EmployeeTypeCode_W = null;
				_TestGroupID_W = null;
				_TestLevelID_W = null;
				_Statement_W = null;
				_IsActive_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.TestPerfectionID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.TestPerfectionID);
			p.SourceColumn = ColumnNames.TestPerfectionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.TestPerfectionID);
			p.SourceColumn = ColumnNames.TestPerfectionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EmployeeTypeCode);
			p.SourceColumn = ColumnNames.EmployeeTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestGroupID);
			p.SourceColumn = ColumnNames.TestGroupID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestLevelID);
			p.SourceColumn = ColumnNames.TestLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Statement);
			p.SourceColumn = ColumnNames.Statement;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}