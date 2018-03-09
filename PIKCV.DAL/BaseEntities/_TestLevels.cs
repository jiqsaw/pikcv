
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
	public abstract class _TestLevels : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _TestLevels()
		{
			this.QuerySource = "TestLevels";
			this.MappingName = "TestLevels";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestLevelsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int TestLevelID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.TestLevelID, TestLevelID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestLevelsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter TestLevelID
			{
				get
				{
					return new SqlParameter("@TestLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LevelCode
			{
				get
				{
					return new SqlParameter("@LevelCode", SqlDbType.NVarChar, 10);
				}
			}
			
			public static SqlParameter LevelDescription
			{
				get
				{
					return new SqlParameter("@LevelDescription", SqlDbType.NVarChar, 512);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string TestLevelID = "TestLevelID";
            public const string LanguageID = "LanguageID";
            public const string LevelCode = "LevelCode";
            public const string LevelDescription = "LevelDescription";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestLevelID] = _TestLevels.PropertyNames.TestLevelID;
					ht[LanguageID] = _TestLevels.PropertyNames.LanguageID;
					ht[LevelCode] = _TestLevels.PropertyNames.LevelCode;
					ht[LevelDescription] = _TestLevels.PropertyNames.LevelDescription;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string TestLevelID = "TestLevelID";
            public const string LanguageID = "LanguageID";
            public const string LevelCode = "LevelCode";
            public const string LevelDescription = "LevelDescription";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestLevelID] = _TestLevels.ColumnNames.TestLevelID;
					ht[LanguageID] = _TestLevels.ColumnNames.LanguageID;
					ht[LevelCode] = _TestLevels.ColumnNames.LevelCode;
					ht[LevelDescription] = _TestLevels.ColumnNames.LevelDescription;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string TestLevelID = "s_TestLevelID";
            public const string LanguageID = "s_LanguageID";
            public const string LevelCode = "s_LevelCode";
            public const string LevelDescription = "s_LevelDescription";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual string LevelCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.LevelCode);
			}
			set
	        {
				base.Setstring(ColumnNames.LevelCode, value);
			}
		}

		public virtual string LevelDescription
	    {
			get
	        {
				return base.Getstring(ColumnNames.LevelDescription);
			}
			set
	        {
				base.Setstring(ColumnNames.LevelDescription, value);
			}
		}


		#endregion
		
		#region String Properties
	
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

		public virtual string s_LevelCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LevelCode) ? string.Empty : base.GetstringAsString(ColumnNames.LevelCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LevelCode);
				else
					this.LevelCode = base.SetstringAsString(ColumnNames.LevelCode, value);
			}
		}

		public virtual string s_LevelDescription
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LevelDescription) ? string.Empty : base.GetstringAsString(ColumnNames.LevelDescription);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LevelDescription);
				else
					this.LevelDescription = base.SetstringAsString(ColumnNames.LevelDescription, value);
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
				
				
				public WhereParameter TestLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
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

				public WhereParameter LevelCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LevelCode, Parameters.LevelCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LevelDescription
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LevelDescription, Parameters.LevelDescription);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
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

			public WhereParameter LevelCode
		    {
				get
		        {
					if(_LevelCode_W == null)
	        	    {
						_LevelCode_W = TearOff.LevelCode;
					}
					return _LevelCode_W;
				}
			}

			public WhereParameter LevelDescription
		    {
				get
		        {
					if(_LevelDescription_W == null)
	        	    {
						_LevelDescription_W = TearOff.LevelDescription;
					}
					return _LevelDescription_W;
				}
			}

			private WhereParameter _TestLevelID_W = null;
			private WhereParameter _LanguageID_W = null;
			private WhereParameter _LevelCode_W = null;
			private WhereParameter _LevelDescription_W = null;

			public void WhereClauseReset()
			{
				_TestLevelID_W = null;
				_LanguageID_W = null;
				_LevelCode_W = null;
				_LevelDescription_W = null;

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
				
				
				public AggregateParameter TestLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
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

				public AggregateParameter LevelCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LevelCode, Parameters.LevelCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LevelDescription
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LevelDescription, Parameters.LevelDescription);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
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

			public AggregateParameter LevelCode
		    {
				get
		        {
					if(_LevelCode_W == null)
	        	    {
						_LevelCode_W = TearOff.LevelCode;
					}
					return _LevelCode_W;
				}
			}

			public AggregateParameter LevelDescription
		    {
				get
		        {
					if(_LevelDescription_W == null)
	        	    {
						_LevelDescription_W = TearOff.LevelDescription;
					}
					return _LevelDescription_W;
				}
			}

			private AggregateParameter _TestLevelID_W = null;
			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _LevelCode_W = null;
			private AggregateParameter _LevelDescription_W = null;

			public void AggregateClauseReset()
			{
				_TestLevelID_W = null;
				_LanguageID_W = null;
				_LevelCode_W = null;
				_LevelDescription_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestLevelsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.TestLevelID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestLevelsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestLevelsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.TestLevelID);
			p.SourceColumn = ColumnNames.TestLevelID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.TestLevelID);
			p.SourceColumn = ColumnNames.TestLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LevelCode);
			p.SourceColumn = ColumnNames.LevelCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LevelDescription);
			p.SourceColumn = ColumnNames.LevelDescription;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
