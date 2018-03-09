
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
	public abstract class _UserOtherHobbies : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _UserOtherHobbies()
		{
			this.QuerySource = "UserOtherHobbies";
			this.MappingName = "UserOtherHobbies";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserOtherHobbiesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int UserOtherHobbies)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.UserOtherHobbies, UserOtherHobbies);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserOtherHobbiesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter UserOtherHobbies
			{
				get
				{
					return new SqlParameter("@UserOtherHobbies", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Hobbies
			{
				get
				{
					return new SqlParameter("@Hobbies", SqlDbType.NVarChar, 400);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string UserOtherHobbies = "UserOtherHobbies";
            public const string UserID = "UserID";
            public const string Hobbies = "Hobbies";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserOtherHobbies] = _UserOtherHobbies.PropertyNames.UserOtherHobbies;
					ht[UserID] = _UserOtherHobbies.PropertyNames.UserID;
					ht[Hobbies] = _UserOtherHobbies.PropertyNames.Hobbies;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string UserOtherHobbies = "UserOtherHobbies";
            public const string UserID = "UserID";
            public const string Hobbies = "Hobbies";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserOtherHobbies] = _UserOtherHobbies.ColumnNames.UserOtherHobbies;
					ht[UserID] = _UserOtherHobbies.ColumnNames.UserID;
					ht[Hobbies] = _UserOtherHobbies.ColumnNames.Hobbies;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string UserOtherHobbies = "s_UserOtherHobbies";
            public const string UserID = "s_UserID";
            public const string Hobbies = "s_Hobbies";

		}
		#endregion		
		
		#region Properties
	
		public virtual int UserOtherHobbies
	    {
			get
	        {
				return base.Getint(ColumnNames.UserOtherHobbies);
			}
			set
	        {
				base.Setint(ColumnNames.UserOtherHobbies, value);
			}
		}

		public virtual int UserID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserID);
			}
			set
	        {
				base.Setint(ColumnNames.UserID, value);
			}
		}

		public virtual string Hobbies
	    {
			get
	        {
				return base.Getstring(ColumnNames.Hobbies);
			}
			set
	        {
				base.Setstring(ColumnNames.Hobbies, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_UserOtherHobbies
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserOtherHobbies) ? string.Empty : base.GetintAsString(ColumnNames.UserOtherHobbies);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserOtherHobbies);
				else
					this.UserOtherHobbies = base.SetintAsString(ColumnNames.UserOtherHobbies, value);
			}
		}

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetintAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetintAsString(ColumnNames.UserID, value);
			}
		}

		public virtual string s_Hobbies
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Hobbies) ? string.Empty : base.GetstringAsString(ColumnNames.Hobbies);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Hobbies);
				else
					this.Hobbies = base.SetstringAsString(ColumnNames.Hobbies, value);
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
				
				
				public WhereParameter UserOtherHobbies
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserOtherHobbies, Parameters.UserOtherHobbies);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Hobbies
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Hobbies, Parameters.Hobbies);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter UserOtherHobbies
		    {
				get
		        {
					if(_UserOtherHobbies_W == null)
	        	    {
						_UserOtherHobbies_W = TearOff.UserOtherHobbies;
					}
					return _UserOtherHobbies_W;
				}
			}

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public WhereParameter Hobbies
		    {
				get
		        {
					if(_Hobbies_W == null)
	        	    {
						_Hobbies_W = TearOff.Hobbies;
					}
					return _Hobbies_W;
				}
			}

			private WhereParameter _UserOtherHobbies_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _Hobbies_W = null;

			public void WhereClauseReset()
			{
				_UserOtherHobbies_W = null;
				_UserID_W = null;
				_Hobbies_W = null;

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
				
				
				public AggregateParameter UserOtherHobbies
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserOtherHobbies, Parameters.UserOtherHobbies);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Hobbies
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Hobbies, Parameters.Hobbies);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter UserOtherHobbies
		    {
				get
		        {
					if(_UserOtherHobbies_W == null)
	        	    {
						_UserOtherHobbies_W = TearOff.UserOtherHobbies;
					}
					return _UserOtherHobbies_W;
				}
			}

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public AggregateParameter Hobbies
		    {
				get
		        {
					if(_Hobbies_W == null)
	        	    {
						_Hobbies_W = TearOff.Hobbies;
					}
					return _Hobbies_W;
				}
			}

			private AggregateParameter _UserOtherHobbies_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _Hobbies_W = null;

			public void AggregateClauseReset()
			{
				_UserOtherHobbies_W = null;
				_UserID_W = null;
				_Hobbies_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserOtherHobbiesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.UserOtherHobbies.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserOtherHobbiesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserOtherHobbiesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.UserOtherHobbies);
			p.SourceColumn = ColumnNames.UserOtherHobbies;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.UserOtherHobbies);
			p.SourceColumn = ColumnNames.UserOtherHobbies;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Hobbies);
			p.SourceColumn = ColumnNames.Hobbies;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
