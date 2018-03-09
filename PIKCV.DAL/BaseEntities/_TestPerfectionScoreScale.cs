
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
	public abstract class _TestPerfectionScoreScale : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _TestPerfectionScoreScale()
		{
			this.QuerySource = "TestPerfectionScoreScale";
			this.MappingName = "TestPerfectionScoreScale";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestPerfectionScoreScaleLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int TestPerfectionScoreScaleID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.TestPerfectionScoreScaleID, TestPerfectionScoreScaleID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TestPerfectionScoreScaleLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter TestPerfectionScoreScaleID
			{
				get
				{
					return new SqlParameter("@TestPerfectionScoreScaleID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PerfectionID
			{
				get
				{
					return new SqlParameter("@PerfectionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter EmployeeTypeCode
			{
				get
				{
					return new SqlParameter("@EmployeeTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TestLevelID
			{
				get
				{
					return new SqlParameter("@TestLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsCapable
			{
				get
				{
					return new SqlParameter("@IsCapable", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string TestPerfectionScoreScaleID = "TestPerfectionScoreScaleID";
            public const string PerfectionID = "PerfectionID";
            public const string EmployeeTypeCode = "EmployeeTypeCode";
            public const string TestLevelID = "TestLevelID";
            public const string IsCapable = "IsCapable";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestPerfectionScoreScaleID] = _TestPerfectionScoreScale.PropertyNames.TestPerfectionScoreScaleID;
					ht[PerfectionID] = _TestPerfectionScoreScale.PropertyNames.PerfectionID;
					ht[EmployeeTypeCode] = _TestPerfectionScoreScale.PropertyNames.EmployeeTypeCode;
					ht[TestLevelID] = _TestPerfectionScoreScale.PropertyNames.TestLevelID;
					ht[IsCapable] = _TestPerfectionScoreScale.PropertyNames.IsCapable;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string TestPerfectionScoreScaleID = "TestPerfectionScoreScaleID";
            public const string PerfectionID = "PerfectionID";
            public const string EmployeeTypeCode = "EmployeeTypeCode";
            public const string TestLevelID = "TestLevelID";
            public const string IsCapable = "IsCapable";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TestPerfectionScoreScaleID] = _TestPerfectionScoreScale.ColumnNames.TestPerfectionScoreScaleID;
					ht[PerfectionID] = _TestPerfectionScoreScale.ColumnNames.PerfectionID;
					ht[EmployeeTypeCode] = _TestPerfectionScoreScale.ColumnNames.EmployeeTypeCode;
					ht[TestLevelID] = _TestPerfectionScoreScale.ColumnNames.TestLevelID;
					ht[IsCapable] = _TestPerfectionScoreScale.ColumnNames.IsCapable;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string TestPerfectionScoreScaleID = "s_TestPerfectionScoreScaleID";
            public const string PerfectionID = "s_PerfectionID";
            public const string EmployeeTypeCode = "s_EmployeeTypeCode";
            public const string TestLevelID = "s_TestLevelID";
            public const string IsCapable = "s_IsCapable";

		}
		#endregion		
		
		#region Properties
	
		public virtual int TestPerfectionScoreScaleID
	    {
			get
	        {
				return base.Getint(ColumnNames.TestPerfectionScoreScaleID);
			}
			set
	        {
				base.Setint(ColumnNames.TestPerfectionScoreScaleID, value);
			}
		}

		public virtual int PerfectionID
	    {
			get
	        {
				return base.Getint(ColumnNames.PerfectionID);
			}
			set
	        {
				base.Setint(ColumnNames.PerfectionID, value);
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

		public virtual bool IsCapable
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsCapable);
			}
			set
	        {
				base.Setbool(ColumnNames.IsCapable, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_TestPerfectionScoreScaleID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TestPerfectionScoreScaleID) ? string.Empty : base.GetintAsString(ColumnNames.TestPerfectionScoreScaleID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TestPerfectionScoreScaleID);
				else
					this.TestPerfectionScoreScaleID = base.SetintAsString(ColumnNames.TestPerfectionScoreScaleID, value);
			}
		}

		public virtual string s_PerfectionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PerfectionID) ? string.Empty : base.GetintAsString(ColumnNames.PerfectionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PerfectionID);
				else
					this.PerfectionID = base.SetintAsString(ColumnNames.PerfectionID, value);
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

		public virtual string s_IsCapable
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsCapable) ? string.Empty : base.GetboolAsString(ColumnNames.IsCapable);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsCapable);
				else
					this.IsCapable = base.SetboolAsString(ColumnNames.IsCapable, value);
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
				
				
				public WhereParameter TestPerfectionScoreScaleID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestPerfectionScoreScaleID, Parameters.TestPerfectionScoreScaleID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PerfectionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PerfectionID, Parameters.PerfectionID);
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

				public WhereParameter TestLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsCapable
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsCapable, Parameters.IsCapable);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter TestPerfectionScoreScaleID
		    {
				get
		        {
					if(_TestPerfectionScoreScaleID_W == null)
	        	    {
						_TestPerfectionScoreScaleID_W = TearOff.TestPerfectionScoreScaleID;
					}
					return _TestPerfectionScoreScaleID_W;
				}
			}

			public WhereParameter PerfectionID
		    {
				get
		        {
					if(_PerfectionID_W == null)
	        	    {
						_PerfectionID_W = TearOff.PerfectionID;
					}
					return _PerfectionID_W;
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

			public WhereParameter IsCapable
		    {
				get
		        {
					if(_IsCapable_W == null)
	        	    {
						_IsCapable_W = TearOff.IsCapable;
					}
					return _IsCapable_W;
				}
			}

			private WhereParameter _TestPerfectionScoreScaleID_W = null;
			private WhereParameter _PerfectionID_W = null;
			private WhereParameter _EmployeeTypeCode_W = null;
			private WhereParameter _TestLevelID_W = null;
			private WhereParameter _IsCapable_W = null;

			public void WhereClauseReset()
			{
				_TestPerfectionScoreScaleID_W = null;
				_PerfectionID_W = null;
				_EmployeeTypeCode_W = null;
				_TestLevelID_W = null;
				_IsCapable_W = null;

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
				
				
				public AggregateParameter TestPerfectionScoreScaleID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestPerfectionScoreScaleID, Parameters.TestPerfectionScoreScaleID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PerfectionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PerfectionID, Parameters.PerfectionID);
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

				public AggregateParameter TestLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TestLevelID, Parameters.TestLevelID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsCapable
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsCapable, Parameters.IsCapable);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter TestPerfectionScoreScaleID
		    {
				get
		        {
					if(_TestPerfectionScoreScaleID_W == null)
	        	    {
						_TestPerfectionScoreScaleID_W = TearOff.TestPerfectionScoreScaleID;
					}
					return _TestPerfectionScoreScaleID_W;
				}
			}

			public AggregateParameter PerfectionID
		    {
				get
		        {
					if(_PerfectionID_W == null)
	        	    {
						_PerfectionID_W = TearOff.PerfectionID;
					}
					return _PerfectionID_W;
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

			public AggregateParameter IsCapable
		    {
				get
		        {
					if(_IsCapable_W == null)
	        	    {
						_IsCapable_W = TearOff.IsCapable;
					}
					return _IsCapable_W;
				}
			}

			private AggregateParameter _TestPerfectionScoreScaleID_W = null;
			private AggregateParameter _PerfectionID_W = null;
			private AggregateParameter _EmployeeTypeCode_W = null;
			private AggregateParameter _TestLevelID_W = null;
			private AggregateParameter _IsCapable_W = null;

			public void AggregateClauseReset()
			{
				_TestPerfectionScoreScaleID_W = null;
				_PerfectionID_W = null;
				_EmployeeTypeCode_W = null;
				_TestLevelID_W = null;
				_IsCapable_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionScoreScaleInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.TestPerfectionScoreScaleID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionScoreScaleUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TestPerfectionScoreScaleDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.TestPerfectionScoreScaleID);
			p.SourceColumn = ColumnNames.TestPerfectionScoreScaleID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.TestPerfectionScoreScaleID);
			p.SourceColumn = ColumnNames.TestPerfectionScoreScaleID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PerfectionID);
			p.SourceColumn = ColumnNames.PerfectionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EmployeeTypeCode);
			p.SourceColumn = ColumnNames.EmployeeTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TestLevelID);
			p.SourceColumn = ColumnNames.TestLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsCapable);
			p.SourceColumn = ColumnNames.IsCapable;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}