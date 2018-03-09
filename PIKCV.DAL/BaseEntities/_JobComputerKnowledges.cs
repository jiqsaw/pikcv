
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
	public abstract class _JobComputerKnowledges : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _JobComputerKnowledges()
		{
			this.QuerySource = "JobComputerKnowledges";
			this.MappingName = "JobComputerKnowledges";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_JobComputerKnowledgesLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_JobComputerKnowledgesLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter JobID
			{
				get
				{
					return new SqlParameter("@JobID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComputerKnowledgeTypeID
			{
				get
				{
					return new SqlParameter("@ComputerKnowledgeTypeID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string JobID = "JobID";
            public const string ComputerKnowledgeTypeID = "ComputerKnowledgeTypeID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _JobComputerKnowledges.PropertyNames.RowID;
					ht[JobID] = _JobComputerKnowledges.PropertyNames.JobID;
					ht[ComputerKnowledgeTypeID] = _JobComputerKnowledges.PropertyNames.ComputerKnowledgeTypeID;

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
            public const string JobID = "JobID";
            public const string ComputerKnowledgeTypeID = "ComputerKnowledgeTypeID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _JobComputerKnowledges.ColumnNames.RowID;
					ht[JobID] = _JobComputerKnowledges.ColumnNames.JobID;
					ht[ComputerKnowledgeTypeID] = _JobComputerKnowledges.ColumnNames.ComputerKnowledgeTypeID;

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
            public const string JobID = "s_JobID";
            public const string ComputerKnowledgeTypeID = "s_ComputerKnowledgeTypeID";

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

		public virtual int ComputerKnowledgeTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComputerKnowledgeTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.ComputerKnowledgeTypeID, value);
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

		public virtual string s_ComputerKnowledgeTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComputerKnowledgeTypeID) ? string.Empty : base.GetintAsString(ColumnNames.ComputerKnowledgeTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComputerKnowledgeTypeID);
				else
					this.ComputerKnowledgeTypeID = base.SetintAsString(ColumnNames.ComputerKnowledgeTypeID, value);
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

				public WhereParameter JobID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.JobID, Parameters.JobID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ComputerKnowledgeTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComputerKnowledgeTypeID, Parameters.ComputerKnowledgeTypeID);
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

			public WhereParameter ComputerKnowledgeTypeID
		    {
				get
		        {
					if(_ComputerKnowledgeTypeID_W == null)
	        	    {
						_ComputerKnowledgeTypeID_W = TearOff.ComputerKnowledgeTypeID;
					}
					return _ComputerKnowledgeTypeID_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _JobID_W = null;
			private WhereParameter _ComputerKnowledgeTypeID_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_JobID_W = null;
				_ComputerKnowledgeTypeID_W = null;

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

				public AggregateParameter JobID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.JobID, Parameters.JobID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ComputerKnowledgeTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComputerKnowledgeTypeID, Parameters.ComputerKnowledgeTypeID);
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

			public AggregateParameter ComputerKnowledgeTypeID
		    {
				get
		        {
					if(_ComputerKnowledgeTypeID_W == null)
	        	    {
						_ComputerKnowledgeTypeID_W = TearOff.ComputerKnowledgeTypeID;
					}
					return _ComputerKnowledgeTypeID_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _JobID_W = null;
			private AggregateParameter _ComputerKnowledgeTypeID_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_JobID_W = null;
				_ComputerKnowledgeTypeID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobComputerKnowledgesInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobComputerKnowledgesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobComputerKnowledgesDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.JobID);
			p.SourceColumn = ColumnNames.JobID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComputerKnowledgeTypeID);
			p.SourceColumn = ColumnNames.ComputerKnowledgeTypeID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}