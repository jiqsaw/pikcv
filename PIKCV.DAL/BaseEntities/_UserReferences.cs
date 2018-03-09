
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
	public abstract class _UserReferences : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _UserReferences()
		{
			this.QuerySource = "UserReferences";
			this.MappingName = "UserReferences";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserReferencesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int UserReferenceID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.UserReferenceID, UserReferenceID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserReferencesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter UserReferenceID
			{
				get
				{
					return new SqlParameter("@UserReferenceID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReferenceName
			{
				get
				{
					return new SqlParameter("@ReferenceName", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter Company
			{
				get
				{
					return new SqlParameter("@Company", SqlDbType.NVarChar, 512);
				}
			}
			
			public static SqlParameter Phone
			{
				get
				{
					return new SqlParameter("@Phone", SqlDbType.VarChar, 18);
				}
			}
			
			public static SqlParameter Position
			{
				get
				{
					return new SqlParameter("@Position", SqlDbType.NVarChar, 512);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string UserReferenceID = "UserReferenceID";
            public const string UserID = "UserID";
            public const string ReferenceName = "ReferenceName";
            public const string Company = "Company";
            public const string Phone = "Phone";
            public const string Position = "Position";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserReferenceID] = _UserReferences.PropertyNames.UserReferenceID;
					ht[UserID] = _UserReferences.PropertyNames.UserID;
					ht[ReferenceName] = _UserReferences.PropertyNames.ReferenceName;
					ht[Company] = _UserReferences.PropertyNames.Company;
					ht[Phone] = _UserReferences.PropertyNames.Phone;
					ht[Position] = _UserReferences.PropertyNames.Position;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string UserReferenceID = "UserReferenceID";
            public const string UserID = "UserID";
            public const string ReferenceName = "ReferenceName";
            public const string Company = "Company";
            public const string Phone = "Phone";
            public const string Position = "Position";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserReferenceID] = _UserReferences.ColumnNames.UserReferenceID;
					ht[UserID] = _UserReferences.ColumnNames.UserID;
					ht[ReferenceName] = _UserReferences.ColumnNames.ReferenceName;
					ht[Company] = _UserReferences.ColumnNames.Company;
					ht[Phone] = _UserReferences.ColumnNames.Phone;
					ht[Position] = _UserReferences.ColumnNames.Position;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string UserReferenceID = "s_UserReferenceID";
            public const string UserID = "s_UserID";
            public const string ReferenceName = "s_ReferenceName";
            public const string Company = "s_Company";
            public const string Phone = "s_Phone";
            public const string Position = "s_Position";

		}
		#endregion		
		
		#region Properties
	
		public virtual int UserReferenceID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserReferenceID);
			}
			set
	        {
				base.Setint(ColumnNames.UserReferenceID, value);
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

		public virtual string ReferenceName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ReferenceName);
			}
			set
	        {
				base.Setstring(ColumnNames.ReferenceName, value);
			}
		}

		public virtual string Company
	    {
			get
	        {
				return base.Getstring(ColumnNames.Company);
			}
			set
	        {
				base.Setstring(ColumnNames.Company, value);
			}
		}

		public virtual string Phone
	    {
			get
	        {
				return base.Getstring(ColumnNames.Phone);
			}
			set
	        {
				base.Setstring(ColumnNames.Phone, value);
			}
		}

		public virtual string Position
	    {
			get
	        {
				return base.Getstring(ColumnNames.Position);
			}
			set
	        {
				base.Setstring(ColumnNames.Position, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_UserReferenceID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserReferenceID) ? string.Empty : base.GetintAsString(ColumnNames.UserReferenceID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserReferenceID);
				else
					this.UserReferenceID = base.SetintAsString(ColumnNames.UserReferenceID, value);
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

		public virtual string s_ReferenceName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReferenceName) ? string.Empty : base.GetstringAsString(ColumnNames.ReferenceName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReferenceName);
				else
					this.ReferenceName = base.SetstringAsString(ColumnNames.ReferenceName, value);
			}
		}

		public virtual string s_Company
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Company) ? string.Empty : base.GetstringAsString(ColumnNames.Company);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Company);
				else
					this.Company = base.SetstringAsString(ColumnNames.Company, value);
			}
		}

		public virtual string s_Phone
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Phone) ? string.Empty : base.GetstringAsString(ColumnNames.Phone);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Phone);
				else
					this.Phone = base.SetstringAsString(ColumnNames.Phone, value);
			}
		}

		public virtual string s_Position
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Position) ? string.Empty : base.GetstringAsString(ColumnNames.Position);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Position);
				else
					this.Position = base.SetstringAsString(ColumnNames.Position, value);
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
				
				
				public WhereParameter UserReferenceID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserReferenceID, Parameters.UserReferenceID);
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

				public WhereParameter ReferenceName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReferenceName, Parameters.ReferenceName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Company
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Company, Parameters.Company);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Phone
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Phone, Parameters.Phone);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Position
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Position, Parameters.Position);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter UserReferenceID
		    {
				get
		        {
					if(_UserReferenceID_W == null)
	        	    {
						_UserReferenceID_W = TearOff.UserReferenceID;
					}
					return _UserReferenceID_W;
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

			public WhereParameter ReferenceName
		    {
				get
		        {
					if(_ReferenceName_W == null)
	        	    {
						_ReferenceName_W = TearOff.ReferenceName;
					}
					return _ReferenceName_W;
				}
			}

			public WhereParameter Company
		    {
				get
		        {
					if(_Company_W == null)
	        	    {
						_Company_W = TearOff.Company;
					}
					return _Company_W;
				}
			}

			public WhereParameter Phone
		    {
				get
		        {
					if(_Phone_W == null)
	        	    {
						_Phone_W = TearOff.Phone;
					}
					return _Phone_W;
				}
			}

			public WhereParameter Position
		    {
				get
		        {
					if(_Position_W == null)
	        	    {
						_Position_W = TearOff.Position;
					}
					return _Position_W;
				}
			}

			private WhereParameter _UserReferenceID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _ReferenceName_W = null;
			private WhereParameter _Company_W = null;
			private WhereParameter _Phone_W = null;
			private WhereParameter _Position_W = null;

			public void WhereClauseReset()
			{
				_UserReferenceID_W = null;
				_UserID_W = null;
				_ReferenceName_W = null;
				_Company_W = null;
				_Phone_W = null;
				_Position_W = null;

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
				
				
				public AggregateParameter UserReferenceID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserReferenceID, Parameters.UserReferenceID);
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

				public AggregateParameter ReferenceName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReferenceName, Parameters.ReferenceName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Company
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Company, Parameters.Company);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Phone
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Phone, Parameters.Phone);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Position
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Position, Parameters.Position);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter UserReferenceID
		    {
				get
		        {
					if(_UserReferenceID_W == null)
	        	    {
						_UserReferenceID_W = TearOff.UserReferenceID;
					}
					return _UserReferenceID_W;
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

			public AggregateParameter ReferenceName
		    {
				get
		        {
					if(_ReferenceName_W == null)
	        	    {
						_ReferenceName_W = TearOff.ReferenceName;
					}
					return _ReferenceName_W;
				}
			}

			public AggregateParameter Company
		    {
				get
		        {
					if(_Company_W == null)
	        	    {
						_Company_W = TearOff.Company;
					}
					return _Company_W;
				}
			}

			public AggregateParameter Phone
		    {
				get
		        {
					if(_Phone_W == null)
	        	    {
						_Phone_W = TearOff.Phone;
					}
					return _Phone_W;
				}
			}

			public AggregateParameter Position
		    {
				get
		        {
					if(_Position_W == null)
	        	    {
						_Position_W = TearOff.Position;
					}
					return _Position_W;
				}
			}

			private AggregateParameter _UserReferenceID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _ReferenceName_W = null;
			private AggregateParameter _Company_W = null;
			private AggregateParameter _Phone_W = null;
			private AggregateParameter _Position_W = null;

			public void AggregateClauseReset()
			{
				_UserReferenceID_W = null;
				_UserID_W = null;
				_ReferenceName_W = null;
				_Company_W = null;
				_Phone_W = null;
				_Position_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserReferencesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.UserReferenceID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserReferencesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserReferencesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.UserReferenceID);
			p.SourceColumn = ColumnNames.UserReferenceID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.UserReferenceID);
			p.SourceColumn = ColumnNames.UserReferenceID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReferenceName);
			p.SourceColumn = ColumnNames.ReferenceName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Company);
			p.SourceColumn = ColumnNames.Company;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Phone);
			p.SourceColumn = ColumnNames.Phone;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Position);
			p.SourceColumn = ColumnNames.Position;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
