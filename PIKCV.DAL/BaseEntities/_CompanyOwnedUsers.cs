
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
	public abstract class _CompanyOwnedUsers : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _CompanyOwnedUsers()
		{
			this.QuerySource = "CompanyOwnedUsers";
			this.MappingName = "CompanyOwnedUsers";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CompanyOwnedUsersLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CompanyOwnedUsersLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter CompanyID
			{
				get
				{
					return new SqlParameter("@CompanyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter DateOwned
			{
				get
				{
					return new SqlParameter("@DateOwned", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EndDate
			{
				get
				{
					return new SqlParameter("@EndDate", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RowID = "RowID";
            public const string CompanyID = "CompanyID";
            public const string UserID = "UserID";
            public const string DateOwned = "DateOwned";
            public const string EndDate = "EndDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _CompanyOwnedUsers.PropertyNames.RowID;
					ht[CompanyID] = _CompanyOwnedUsers.PropertyNames.CompanyID;
					ht[UserID] = _CompanyOwnedUsers.PropertyNames.UserID;
					ht[DateOwned] = _CompanyOwnedUsers.PropertyNames.DateOwned;
					ht[EndDate] = _CompanyOwnedUsers.PropertyNames.EndDate;

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
            public const string CompanyID = "CompanyID";
            public const string UserID = "UserID";
            public const string DateOwned = "DateOwned";
            public const string EndDate = "EndDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RowID] = _CompanyOwnedUsers.ColumnNames.RowID;
					ht[CompanyID] = _CompanyOwnedUsers.ColumnNames.CompanyID;
					ht[UserID] = _CompanyOwnedUsers.ColumnNames.UserID;
					ht[DateOwned] = _CompanyOwnedUsers.ColumnNames.DateOwned;
					ht[EndDate] = _CompanyOwnedUsers.ColumnNames.EndDate;

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
            public const string CompanyID = "s_CompanyID";
            public const string UserID = "s_UserID";
            public const string DateOwned = "s_DateOwned";
            public const string EndDate = "s_EndDate";

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

		public virtual int CompanyID
	    {
			get
	        {
				return base.Getint(ColumnNames.CompanyID);
			}
			set
	        {
				base.Setint(ColumnNames.CompanyID, value);
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

		public virtual DateTime DateOwned
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.DateOwned);
			}
			set
	        {
				base.SetDateTime(ColumnNames.DateOwned, value);
			}
		}

		public virtual DateTime EndDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EndDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EndDate, value);
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

		public virtual string s_CompanyID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompanyID) ? string.Empty : base.GetintAsString(ColumnNames.CompanyID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompanyID);
				else
					this.CompanyID = base.SetintAsString(ColumnNames.CompanyID, value);
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

		public virtual string s_DateOwned
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DateOwned) ? string.Empty : base.GetDateTimeAsString(ColumnNames.DateOwned);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DateOwned);
				else
					this.DateOwned = base.SetDateTimeAsString(ColumnNames.DateOwned, value);
			}
		}

		public virtual string s_EndDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EndDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EndDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EndDate);
				else
					this.EndDate = base.SetDateTimeAsString(ColumnNames.EndDate, value);
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

				public WhereParameter CompanyID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompanyID, Parameters.CompanyID);
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

				public WhereParameter DateOwned
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DateOwned, Parameters.DateOwned);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EndDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EndDate, Parameters.EndDate);
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

			public WhereParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
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

			public WhereParameter DateOwned
		    {
				get
		        {
					if(_DateOwned_W == null)
	        	    {
						_DateOwned_W = TearOff.DateOwned;
					}
					return _DateOwned_W;
				}
			}

			public WhereParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
				}
			}

			private WhereParameter _RowID_W = null;
			private WhereParameter _CompanyID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _DateOwned_W = null;
			private WhereParameter _EndDate_W = null;

			public void WhereClauseReset()
			{
				_RowID_W = null;
				_CompanyID_W = null;
				_UserID_W = null;
				_DateOwned_W = null;
				_EndDate_W = null;

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

				public AggregateParameter CompanyID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompanyID, Parameters.CompanyID);
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

				public AggregateParameter DateOwned
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DateOwned, Parameters.DateOwned);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EndDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EndDate, Parameters.EndDate);
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

			public AggregateParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
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

			public AggregateParameter DateOwned
		    {
				get
		        {
					if(_DateOwned_W == null)
	        	    {
						_DateOwned_W = TearOff.DateOwned;
					}
					return _DateOwned_W;
				}
			}

			public AggregateParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
				}
			}

			private AggregateParameter _RowID_W = null;
			private AggregateParameter _CompanyID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _DateOwned_W = null;
			private AggregateParameter _EndDate_W = null;

			public void AggregateClauseReset()
			{
				_RowID_W = null;
				_CompanyID_W = null;
				_UserID_W = null;
				_DateOwned_W = null;
				_EndDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompanyOwnedUsersInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompanyOwnedUsersUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompanyOwnedUsersDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DateOwned);
			p.SourceColumn = ColumnNames.DateOwned;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndDate);
			p.SourceColumn = ColumnNames.EndDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
