
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
	public abstract class _InterviewPikcvProperties_ML : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _InterviewPikcvProperties_ML()
		{
			this.QuerySource = "InterviewPikcvProperties_ML";
			this.MappingName = "InterviewPikcvProperties_ML";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InterviewPikcvProperties_MLLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InterviewPikcvProperties_MLLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter InterviewPikcvPropertiesID
			{
				get
				{
					return new SqlParameter("@InterviewPikcvPropertiesID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter InterviewPikcvPropertiesNames
			{
				get
				{
					return new SqlParameter("@InterviewPikcvPropertiesNames", SqlDbType.NVarChar, 256);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string InterviewPikcvPropertiesID = "InterviewPikcvPropertiesID";
            public const string LanguageID = "LanguageID";
            public const string InterviewPikcvPropertiesNames = "InterviewPikcvPropertiesNames";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _InterviewPikcvProperties_ML.PropertyNames.RowID;
					ht[InterviewPikcvPropertiesID] = _InterviewPikcvProperties_ML.PropertyNames.InterviewPikcvPropertiesID;
					ht[LanguageID] = _InterviewPikcvProperties_ML.PropertyNames.LanguageID;
					ht[InterviewPikcvPropertiesNames] = _InterviewPikcvProperties_ML.PropertyNames.InterviewPikcvPropertiesNames;

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
            public const string InterviewPikcvPropertiesID = "InterviewPikcvPropertiesID";
            public const string LanguageID = "LanguageID";
            public const string InterviewPikcvPropertiesNames = "InterviewPikcvPropertiesNames";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _InterviewPikcvProperties_ML.ColumnNames.RowID;
					ht[InterviewPikcvPropertiesID] = _InterviewPikcvProperties_ML.ColumnNames.InterviewPikcvPropertiesID;
					ht[LanguageID] = _InterviewPikcvProperties_ML.ColumnNames.LanguageID;
					ht[InterviewPikcvPropertiesNames] = _InterviewPikcvProperties_ML.ColumnNames.InterviewPikcvPropertiesNames;

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
            public const string InterviewPikcvPropertiesID = "s_InterviewPikcvPropertiesID";
            public const string LanguageID = "s_LanguageID";
            public const string InterviewPikcvPropertiesNames = "s_InterviewPikcvPropertiesNames";

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

		public virtual string InterviewPikcvPropertiesNames
	    {
			get
	        {
				return base.Getstring(ColumnNames.InterviewPikcvPropertiesNames);
			}
			set
	        {
				base.Setstring(ColumnNames.InterviewPikcvPropertiesNames, value);
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

		public virtual string s_InterviewPikcvPropertiesNames
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.InterviewPikcvPropertiesNames) ? string.Empty : base.GetstringAsString(ColumnNames.InterviewPikcvPropertiesNames);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.InterviewPikcvPropertiesNames);
				else
					this.InterviewPikcvPropertiesNames = base.SetstringAsString(ColumnNames.InterviewPikcvPropertiesNames, value);
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

				public WhereParameter InterviewPikcvPropertiesID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InterviewPikcvPropertiesID, Parameters.InterviewPikcvPropertiesID);
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

				public WhereParameter InterviewPikcvPropertiesNames
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InterviewPikcvPropertiesNames, Parameters.InterviewPikcvPropertiesNames);
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

			public WhereParameter InterviewPikcvPropertiesNames
		    {
				get
		        {
					if(_InterviewPikcvPropertiesNames_W == null)
	        	    {
						_InterviewPikcvPropertiesNames_W = TearOff.InterviewPikcvPropertiesNames;
					}
					return _InterviewPikcvPropertiesNames_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _InterviewPikcvPropertiesID_W = null;
			private WhereParameter _LanguageID_W = null;
			private WhereParameter _InterviewPikcvPropertiesNames_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_InterviewPikcvPropertiesID_W = null;
				_LanguageID_W = null;
				_InterviewPikcvPropertiesNames_W = null;

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

				public AggregateParameter InterviewPikcvPropertiesID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InterviewPikcvPropertiesID, Parameters.InterviewPikcvPropertiesID);
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

				public AggregateParameter InterviewPikcvPropertiesNames
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InterviewPikcvPropertiesNames, Parameters.InterviewPikcvPropertiesNames);
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

			public AggregateParameter InterviewPikcvPropertiesNames
		    {
				get
		        {
					if(_InterviewPikcvPropertiesNames_W == null)
	        	    {
						_InterviewPikcvPropertiesNames_W = TearOff.InterviewPikcvPropertiesNames;
					}
					return _InterviewPikcvPropertiesNames_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _InterviewPikcvPropertiesID_W = null;
			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _InterviewPikcvPropertiesNames_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_InterviewPikcvPropertiesID_W = null;
				_LanguageID_W = null;
				_InterviewPikcvPropertiesNames_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvProperties_MLInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvProperties_MLUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InterviewPikcvProperties_MLDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.InterviewPikcvPropertiesID);
			p.SourceColumn = ColumnNames.InterviewPikcvPropertiesID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.InterviewPikcvPropertiesNames);
			p.SourceColumn = ColumnNames.InterviewPikcvPropertiesNames;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}