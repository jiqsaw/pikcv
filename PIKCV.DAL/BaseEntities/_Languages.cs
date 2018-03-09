
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
	public abstract class _Languages : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Languages()
		{
			this.QuerySource = "Languages";
			this.MappingName = "Languages";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LanguagesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int LanguageID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.LanguageID, LanguageID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LanguagesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageName
			{
				get
				{
					return new SqlParameter("@LanguageName", SqlDbType.NVarChar, 16);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string LanguageID = "LanguageID";
            public const string LanguageName = "LanguageName";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LanguageID] = _Languages.PropertyNames.LanguageID;
					ht[LanguageName] = _Languages.PropertyNames.LanguageName;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string LanguageID = "LanguageID";
            public const string LanguageName = "LanguageName";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[LanguageID] = _Languages.ColumnNames.LanguageID;
					ht[LanguageName] = _Languages.ColumnNames.LanguageName;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string LanguageID = "s_LanguageID";
            public const string LanguageName = "s_LanguageName";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual string LanguageName
	    {
			get
	        {
				return base.Getstring(ColumnNames.LanguageName);
			}
			set
	        {
				base.Setstring(ColumnNames.LanguageName, value);
			}
		}


		#endregion
		
		#region String Properties
	
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

		public virtual string s_LanguageName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LanguageName) ? string.Empty : base.GetstringAsString(ColumnNames.LanguageName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LanguageName);
				else
					this.LanguageName = base.SetstringAsString(ColumnNames.LanguageName, value);
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
				
				
				public WhereParameter LanguageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LanguageID, Parameters.LanguageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LanguageName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LanguageName, Parameters.LanguageName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
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

			public WhereParameter LanguageName
		    {
				get
		        {
					if(_LanguageName_W == null)
	        	    {
						_LanguageName_W = TearOff.LanguageName;
					}
					return _LanguageName_W;
				}
			}

			private WhereParameter _LanguageID_W = null;
			private WhereParameter _LanguageName_W = null;

			public void WhereClauseReset()
			{
				_LanguageID_W = null;
				_LanguageName_W = null;

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
				
				
				public AggregateParameter LanguageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LanguageID, Parameters.LanguageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LanguageName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LanguageName, Parameters.LanguageName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
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

			public AggregateParameter LanguageName
		    {
				get
		        {
					if(_LanguageName_W == null)
	        	    {
						_LanguageName_W = TearOff.LanguageName;
					}
					return _LanguageName_W;
				}
			}

			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _LanguageName_W = null;

			public void AggregateClauseReset()
			{
				_LanguageID_W = null;
				_LanguageName_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LanguagesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.LanguageID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LanguagesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LanguagesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageName);
			p.SourceColumn = ColumnNames.LanguageName;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
