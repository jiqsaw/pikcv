
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
	public abstract class _Schools_ML : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Schools_ML()
		{
			this.QuerySource = "Schools_ML";
			this.MappingName = "Schools_ML";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Schools_MLLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Schools_MLLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter SchoolID
			{
				get
				{
					return new SqlParameter("@SchoolID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SchoolName
			{
				get
				{
					return new SqlParameter("@SchoolName", SqlDbType.NVarChar, 64);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string SchoolID = "SchoolID";
            public const string LanguageID = "LanguageID";
            public const string SchoolName = "SchoolName";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _Schools_ML.PropertyNames.RowID;
					ht[SchoolID] = _Schools_ML.PropertyNames.SchoolID;
					ht[LanguageID] = _Schools_ML.PropertyNames.LanguageID;
					ht[SchoolName] = _Schools_ML.PropertyNames.SchoolName;

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
            public const string SchoolID = "SchoolID";
            public const string LanguageID = "LanguageID";
            public const string SchoolName = "SchoolName";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _Schools_ML.ColumnNames.RowID;
					ht[SchoolID] = _Schools_ML.ColumnNames.SchoolID;
					ht[LanguageID] = _Schools_ML.ColumnNames.LanguageID;
					ht[SchoolName] = _Schools_ML.ColumnNames.SchoolName;

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
            public const string SchoolID = "s_SchoolID";
            public const string LanguageID = "s_LanguageID";
            public const string SchoolName = "s_SchoolName";

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

		public virtual int SchoolID
	    {
			get
	        {
				return base.Getint(ColumnNames.SchoolID);
			}
			set
	        {
				base.Setint(ColumnNames.SchoolID, value);
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

		public virtual string SchoolName
	    {
			get
	        {
				return base.Getstring(ColumnNames.SchoolName);
			}
			set
	        {
				base.Setstring(ColumnNames.SchoolName, value);
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

		public virtual string s_SchoolID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SchoolID) ? string.Empty : base.GetintAsString(ColumnNames.SchoolID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SchoolID);
				else
					this.SchoolID = base.SetintAsString(ColumnNames.SchoolID, value);
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

		public virtual string s_SchoolName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SchoolName) ? string.Empty : base.GetstringAsString(ColumnNames.SchoolName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SchoolName);
				else
					this.SchoolName = base.SetstringAsString(ColumnNames.SchoolName, value);
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

				public WhereParameter SchoolID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SchoolID, Parameters.SchoolID);
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

				public WhereParameter SchoolName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SchoolName, Parameters.SchoolName);
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

			public WhereParameter SchoolID
		    {
				get
		        {
					if(_SchoolID_W == null)
	        	    {
						_SchoolID_W = TearOff.SchoolID;
					}
					return _SchoolID_W;
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

			public WhereParameter SchoolName
		    {
				get
		        {
					if(_SchoolName_W == null)
	        	    {
						_SchoolName_W = TearOff.SchoolName;
					}
					return _SchoolName_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _SchoolID_W = null;
			private WhereParameter _LanguageID_W = null;
			private WhereParameter _SchoolName_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_SchoolID_W = null;
				_LanguageID_W = null;
				_SchoolName_W = null;

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

				public AggregateParameter SchoolID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SchoolID, Parameters.SchoolID);
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

				public AggregateParameter SchoolName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SchoolName, Parameters.SchoolName);
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

			public AggregateParameter SchoolID
		    {
				get
		        {
					if(_SchoolID_W == null)
	        	    {
						_SchoolID_W = TearOff.SchoolID;
					}
					return _SchoolID_W;
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

			public AggregateParameter SchoolName
		    {
				get
		        {
					if(_SchoolName_W == null)
	        	    {
						_SchoolName_W = TearOff.SchoolName;
					}
					return _SchoolName_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _SchoolID_W = null;
			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _SchoolName_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_SchoolID_W = null;
				_LanguageID_W = null;
				_SchoolName_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Schools_MLInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Schools_MLUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Schools_MLDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.SchoolID);
			p.SourceColumn = ColumnNames.SchoolID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SchoolName);
			p.SourceColumn = ColumnNames.SchoolName;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}