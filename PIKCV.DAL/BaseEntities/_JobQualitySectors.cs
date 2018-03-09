
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
	public abstract class _JobQualitySectors : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _JobQualitySectors()
		{
			this.QuerySource = "JobQualitySectors";
			this.MappingName = "JobQualitySectors";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_JobQualitySectorsLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_JobQualitySectorsLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter SectorID
			{
				get
				{
					return new SqlParameter("@SectorID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string JobID = "JobID";
            public const string SectorID = "SectorID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _JobQualitySectors.PropertyNames.RowID;
					ht[JobID] = _JobQualitySectors.PropertyNames.JobID;
					ht[SectorID] = _JobQualitySectors.PropertyNames.SectorID;

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
            public const string SectorID = "SectorID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _JobQualitySectors.ColumnNames.RowID;
					ht[JobID] = _JobQualitySectors.ColumnNames.JobID;
					ht[SectorID] = _JobQualitySectors.ColumnNames.SectorID;

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
            public const string SectorID = "s_SectorID";

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

		public virtual int SectorID
	    {
			get
	        {
				return base.Getint(ColumnNames.SectorID);
			}
			set
	        {
				base.Setint(ColumnNames.SectorID, value);
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

		public virtual string s_SectorID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SectorID) ? string.Empty : base.GetintAsString(ColumnNames.SectorID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SectorID);
				else
					this.SectorID = base.SetintAsString(ColumnNames.SectorID, value);
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

				public WhereParameter SectorID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SectorID, Parameters.SectorID);
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

			public WhereParameter SectorID
		    {
				get
		        {
					if(_SectorID_W == null)
	        	    {
						_SectorID_W = TearOff.SectorID;
					}
					return _SectorID_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _JobID_W = null;
			private WhereParameter _SectorID_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_JobID_W = null;
				_SectorID_W = null;

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

				public AggregateParameter SectorID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SectorID, Parameters.SectorID);
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

			public AggregateParameter SectorID
		    {
				get
		        {
					if(_SectorID_W == null)
	        	    {
						_SectorID_W = TearOff.SectorID;
					}
					return _SectorID_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _JobID_W = null;
			private AggregateParameter _SectorID_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_JobID_W = null;
				_SectorID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobQualitySectorsInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobQualitySectorsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_JobQualitySectorsDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.SectorID);
			p.SourceColumn = ColumnNames.SectorID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
