
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
	public abstract class _InterviewPikcvProperties : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _InterviewPikcvProperties()
		{
			this.QuerySource = "InterviewPikcvProperties";
			this.MappingName = "InterviewPikcvProperties";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InterviewPikcvPropertiesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int InterviewPikcvPropertiesID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.InterviewPikcvPropertiesID, InterviewPikcvPropertiesID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InterviewPikcvPropertiesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter InterviewPikcvPropertiesID
			{
				get
				{
					return new SqlParameter("@InterviewPikcvPropertiesID", SqlDbType.Int, 0);
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
            public const string InterviewPikcvPropertiesID = "InterviewPikcvPropertiesID";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[InterviewPikcvPropertiesID] = _InterviewPikcvProperties.PropertyNames.InterviewPikcvPropertiesID;
					ht[IsDeleted] = _InterviewPikcvProperties.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string InterviewPikcvPropertiesID = "InterviewPikcvPropertiesID";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[InterviewPikcvPropertiesID] = _InterviewPikcvProperties.ColumnNames.InterviewPikcvPropertiesID;
					ht[IsDeleted] = _InterviewPikcvProperties.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string InterviewPikcvPropertiesID = "s_InterviewPikcvPropertiesID";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int InterviewPikcvPropertiesID
	    {
			get
	        {
				return base.Getint(ColumnNames.InterviewPikcvPropertiesID);
			}
			set
	        {
				base.Setint(ColumnNames.InterviewPikcvPropertiesID, value);
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
	
		public virtual string s_InterviewPikcvPropertiesID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.InterviewPikcvPropertiesID) ? string.Empty : base.GetintAsString(ColumnNames.InterviewPikcvPropertiesID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.InterviewPikcvPropertiesID);
				else
					this.InterviewPikcvPropertiesID = base.SetintAsString(ColumnNames.InterviewPikcvPropertiesID, value);
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
				
				
				public WhereParameter InterviewPikcvPropertiesID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InterviewPikcvPropertiesID, Parameters.InterviewPikcvPropertiesID);
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
		
			public WhereParameter InterviewPikcvPropertiesID
		    {
				get
		        {
					if(_InterviewPikcvPropertiesID_W == null)
	        	    {
						_InterviewPikcvPropertiesID_W = TearOff.InterviewPikcvPropertiesID;
					}
					return _InterviewPikcvPropertiesID_W;
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

			private WhereParameter _InterviewPikcvPropertiesID_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_InterviewPikcvPropertiesID_W = null;
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
				
				
				public AggregateParameter InterviewPikcvPropertiesID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InterviewPikcvPropertiesID, Parameters.InterviewPikcvPropertiesID);
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
		
			public AggregateParameter InterviewPikcvPropertiesID
		    {
				get
		        {
					if(_InterviewPikcvPropertiesID_W == null)
	        	    {
						_InterviewPikcvPropertiesID_W = TearOff.InterviewPikcvPropertiesID;
					}
					return _InterviewPikcvPropertiesID_W;
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

			private AggregateParameter _InterviewPikcvPropertiesID_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_InterviewPikcvPropertiesID_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvPropertiesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.InterviewPikcvPropertiesID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvPropertiesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvPropertiesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.InterviewPikcvPropertiesID);
			p.SourceColumn = ColumnNames.InterviewPikcvPropertiesID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.InterviewPikcvPropertiesID);
			p.SourceColumn = ColumnNames.InterviewPikcvPropertiesID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
