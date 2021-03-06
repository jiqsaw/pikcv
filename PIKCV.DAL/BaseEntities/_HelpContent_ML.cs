
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
	public abstract class _HelpContent_ML : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _HelpContent_ML()
		{
			this.QuerySource = "HelpContent_ML";
			this.MappingName = "HelpContent_ML";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_HelpContent_MLLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_HelpContent_MLLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter HelpContentID
			{
				get
				{
					return new SqlParameter("@HelpContentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LanguageID
			{
				get
				{
					return new SqlParameter("@LanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter HelpTitle
			{
				get
				{
					return new SqlParameter("@HelpTitle", SqlDbType.NVarChar, 128);
				}
			}
			
			public static SqlParameter HelpContent
			{
				get
				{
					return new SqlParameter("@HelpContent", SqlDbType.NVarChar, 4000);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string HelpContentID = "HelpContentID";
            public const string LanguageID = "LanguageID";
            public const string HelpTitle = "HelpTitle";
            public const string HelpContent = "HelpContent";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _HelpContent_ML.PropertyNames.RowID;
					ht[HelpContentID] = _HelpContent_ML.PropertyNames.HelpContentID;
					ht[LanguageID] = _HelpContent_ML.PropertyNames.LanguageID;
					ht[HelpTitle] = _HelpContent_ML.PropertyNames.HelpTitle;
					ht[HelpContent] = _HelpContent_ML.PropertyNames.HelpContent;

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
            public const string HelpContentID = "HelpContentID";
            public const string LanguageID = "LanguageID";
            public const string HelpTitle = "HelpTitle";
            public const string HelpContent = "HelpContent";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _HelpContent_ML.ColumnNames.RowID;
					ht[HelpContentID] = _HelpContent_ML.ColumnNames.HelpContentID;
					ht[LanguageID] = _HelpContent_ML.ColumnNames.LanguageID;
					ht[HelpTitle] = _HelpContent_ML.ColumnNames.HelpTitle;
					ht[HelpContent] = _HelpContent_ML.ColumnNames.HelpContent;

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
            public const string HelpContentID = "s_HelpContentID";
            public const string LanguageID = "s_LanguageID";
            public const string HelpTitle = "s_HelpTitle";
            public const string HelpContent = "s_HelpContent";

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

		public virtual int HelpContentID
	    {
			get
	        {
				return base.Getint(ColumnNames.HelpContentID);
			}
			set
	        {
				base.Setint(ColumnNames.HelpContentID, value);
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

		public virtual string HelpTitle
	    {
			get
	        {
				return base.Getstring(ColumnNames.HelpTitle);
			}
			set
	        {
				base.Setstring(ColumnNames.HelpTitle, value);
			}
		}

		public virtual string HelpContent
	    {
			get
	        {
				return base.Getstring(ColumnNames.HelpContent);
			}
			set
	        {
				base.Setstring(ColumnNames.HelpContent, value);
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

		public virtual string s_HelpContentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HelpContentID) ? string.Empty : base.GetintAsString(ColumnNames.HelpContentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HelpContentID);
				else
					this.HelpContentID = base.SetintAsString(ColumnNames.HelpContentID, value);
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

		public virtual string s_HelpTitle
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HelpTitle) ? string.Empty : base.GetstringAsString(ColumnNames.HelpTitle);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HelpTitle);
				else
					this.HelpTitle = base.SetstringAsString(ColumnNames.HelpTitle, value);
			}
		}

		public virtual string s_HelpContent
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HelpContent) ? string.Empty : base.GetstringAsString(ColumnNames.HelpContent);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HelpContent);
				else
					this.HelpContent = base.SetstringAsString(ColumnNames.HelpContent, value);
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

				public WhereParameter HelpContentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HelpContentID, Parameters.HelpContentID);
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

				public WhereParameter HelpTitle
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HelpTitle, Parameters.HelpTitle);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter HelpContent
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HelpContent, Parameters.HelpContent);
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

			public WhereParameter HelpContentID
		    {
				get
		        {
					if(_HelpContentID_W == null)
	        	    {
						_HelpContentID_W = TearOff.HelpContentID;
					}
					return _HelpContentID_W;
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

			public WhereParameter HelpTitle
		    {
				get
		        {
					if(_HelpTitle_W == null)
	        	    {
						_HelpTitle_W = TearOff.HelpTitle;
					}
					return _HelpTitle_W;
				}
			}

			public WhereParameter HelpContent
		    {
				get
		        {
					if(_HelpContent_W == null)
	        	    {
						_HelpContent_W = TearOff.HelpContent;
					}
					return _HelpContent_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _HelpContentID_W = null;
			private WhereParameter _LanguageID_W = null;
			private WhereParameter _HelpTitle_W = null;
			private WhereParameter _HelpContent_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_HelpContentID_W = null;
				_LanguageID_W = null;
				_HelpTitle_W = null;
				_HelpContent_W = null;

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

				public AggregateParameter HelpContentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HelpContentID, Parameters.HelpContentID);
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

				public AggregateParameter HelpTitle
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HelpTitle, Parameters.HelpTitle);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter HelpContent
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HelpContent, Parameters.HelpContent);
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

			public AggregateParameter HelpContentID
		    {
				get
		        {
					if(_HelpContentID_W == null)
	        	    {
						_HelpContentID_W = TearOff.HelpContentID;
					}
					return _HelpContentID_W;
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

			public AggregateParameter HelpTitle
		    {
				get
		        {
					if(_HelpTitle_W == null)
	        	    {
						_HelpTitle_W = TearOff.HelpTitle;
					}
					return _HelpTitle_W;
				}
			}

			public AggregateParameter HelpContent
		    {
				get
		        {
					if(_HelpContent_W == null)
	        	    {
						_HelpContent_W = TearOff.HelpContent;
					}
					return _HelpContent_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _HelpContentID_W = null;
			private AggregateParameter _LanguageID_W = null;
			private AggregateParameter _HelpTitle_W = null;
			private AggregateParameter _HelpContent_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_HelpContentID_W = null;
				_LanguageID_W = null;
				_HelpTitle_W = null;
				_HelpContent_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContent_MLInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContent_MLUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_HelpContent_MLDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.HelpContentID);
			p.SourceColumn = ColumnNames.HelpContentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LanguageID);
			p.SourceColumn = ColumnNames.LanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.HelpTitle);
			p.SourceColumn = ColumnNames.HelpTitle;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.HelpContent);
			p.SourceColumn = ColumnNames.HelpContent;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
