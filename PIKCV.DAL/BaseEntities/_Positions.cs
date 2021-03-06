
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
	public abstract class _Positions : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _Positions()
		{
			this.QuerySource = "Positions";
			this.MappingName = "Positions";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PositionsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PositionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PositionID, PositionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PositionsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PositionID
			{
				get
				{
					return new SqlParameter("@PositionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PositionTypeCode
			{
				get
				{
					return new SqlParameter("@PositionTypeCode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreateDate
			{
				get
				{
					return new SqlParameter("@CreateDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifyDate
			{
				get
				{
					return new SqlParameter("@ModifyDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter UpdatedBy
			{
				get
				{
					return new SqlParameter("@UpdatedBy", SqlDbType.Int, 0);
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
            public const string PositionID = "PositionID";
            public const string PositionTypeCode = "PositionTypeCode";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PositionID] = _Positions.PropertyNames.PositionID;
					ht[PositionTypeCode] = _Positions.PropertyNames.PositionTypeCode;
					ht[CreateDate] = _Positions.PropertyNames.CreateDate;
					ht[ModifyDate] = _Positions.PropertyNames.ModifyDate;
					ht[UpdatedBy] = _Positions.PropertyNames.UpdatedBy;
					ht[IsDeleted] = _Positions.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PositionID = "PositionID";
            public const string PositionTypeCode = "PositionTypeCode";
            public const string CreateDate = "CreateDate";
            public const string ModifyDate = "ModifyDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PositionID] = _Positions.ColumnNames.PositionID;
					ht[PositionTypeCode] = _Positions.ColumnNames.PositionTypeCode;
					ht[CreateDate] = _Positions.ColumnNames.CreateDate;
					ht[ModifyDate] = _Positions.ColumnNames.ModifyDate;
					ht[UpdatedBy] = _Positions.ColumnNames.UpdatedBy;
					ht[IsDeleted] = _Positions.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PositionID = "s_PositionID";
            public const string PositionTypeCode = "s_PositionTypeCode";
            public const string CreateDate = "s_CreateDate";
            public const string ModifyDate = "s_ModifyDate";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PositionID
	    {
			get
	        {
				return base.Getint(ColumnNames.PositionID);
			}
			set
	        {
				base.Setint(ColumnNames.PositionID, value);
			}
		}

		public virtual int PositionTypeCode
	    {
			get
	        {
				return base.Getint(ColumnNames.PositionTypeCode);
			}
			set
	        {
				base.Setint(ColumnNames.PositionTypeCode, value);
			}
		}

		public virtual DateTime CreateDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreateDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreateDate, value);
			}
		}

		public virtual DateTime ModifyDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ModifyDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ModifyDate, value);
			}
		}

		public virtual int UpdatedBy
	    {
			get
	        {
				return base.Getint(ColumnNames.UpdatedBy);
			}
			set
	        {
				base.Setint(ColumnNames.UpdatedBy, value);
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
	
		public virtual string s_PositionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PositionID) ? string.Empty : base.GetintAsString(ColumnNames.PositionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PositionID);
				else
					this.PositionID = base.SetintAsString(ColumnNames.PositionID, value);
			}
		}

		public virtual string s_PositionTypeCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PositionTypeCode) ? string.Empty : base.GetintAsString(ColumnNames.PositionTypeCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PositionTypeCode);
				else
					this.PositionTypeCode = base.SetintAsString(ColumnNames.PositionTypeCode, value);
			}
		}

		public virtual string s_CreateDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreateDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreateDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreateDate);
				else
					this.CreateDate = base.SetDateTimeAsString(ColumnNames.CreateDate, value);
			}
		}

		public virtual string s_ModifyDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifyDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ModifyDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifyDate);
				else
					this.ModifyDate = base.SetDateTimeAsString(ColumnNames.ModifyDate, value);
			}
		}

		public virtual string s_UpdatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UpdatedBy) ? string.Empty : base.GetintAsString(ColumnNames.UpdatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UpdatedBy);
				else
					this.UpdatedBy = base.SetintAsString(ColumnNames.UpdatedBy, value);
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
				
				
				public WhereParameter PositionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PositionID, Parameters.PositionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PositionTypeCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PositionTypeCode, Parameters.PositionTypeCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreateDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreateDate, Parameters.CreateDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifyDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifyDate, Parameters.ModifyDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UpdatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
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
		
			public WhereParameter PositionID
		    {
				get
		        {
					if(_PositionID_W == null)
	        	    {
						_PositionID_W = TearOff.PositionID;
					}
					return _PositionID_W;
				}
			}

			public WhereParameter PositionTypeCode
		    {
				get
		        {
					if(_PositionTypeCode_W == null)
	        	    {
						_PositionTypeCode_W = TearOff.PositionTypeCode;
					}
					return _PositionTypeCode_W;
				}
			}

			public WhereParameter CreateDate
		    {
				get
		        {
					if(_CreateDate_W == null)
	        	    {
						_CreateDate_W = TearOff.CreateDate;
					}
					return _CreateDate_W;
				}
			}

			public WhereParameter ModifyDate
		    {
				get
		        {
					if(_ModifyDate_W == null)
	        	    {
						_ModifyDate_W = TearOff.ModifyDate;
					}
					return _ModifyDate_W;
				}
			}

			public WhereParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
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

			private WhereParameter _PositionID_W = null;
			private WhereParameter _PositionTypeCode_W = null;
			private WhereParameter _CreateDate_W = null;
			private WhereParameter _ModifyDate_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_PositionID_W = null;
				_PositionTypeCode_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;
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
				
				
				public AggregateParameter PositionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PositionID, Parameters.PositionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PositionTypeCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PositionTypeCode, Parameters.PositionTypeCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreateDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreateDate, Parameters.CreateDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifyDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifyDate, Parameters.ModifyDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UpdatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
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
		
			public AggregateParameter PositionID
		    {
				get
		        {
					if(_PositionID_W == null)
	        	    {
						_PositionID_W = TearOff.PositionID;
					}
					return _PositionID_W;
				}
			}

			public AggregateParameter PositionTypeCode
		    {
				get
		        {
					if(_PositionTypeCode_W == null)
	        	    {
						_PositionTypeCode_W = TearOff.PositionTypeCode;
					}
					return _PositionTypeCode_W;
				}
			}

			public AggregateParameter CreateDate
		    {
				get
		        {
					if(_CreateDate_W == null)
	        	    {
						_CreateDate_W = TearOff.CreateDate;
					}
					return _CreateDate_W;
				}
			}

			public AggregateParameter ModifyDate
		    {
				get
		        {
					if(_ModifyDate_W == null)
	        	    {
						_ModifyDate_W = TearOff.ModifyDate;
					}
					return _ModifyDate_W;
				}
			}

			public AggregateParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
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

			private AggregateParameter _PositionID_W = null;
			private AggregateParameter _PositionTypeCode_W = null;
			private AggregateParameter _CreateDate_W = null;
			private AggregateParameter _ModifyDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_PositionID_W = null;
				_PositionTypeCode_W = null;
				_CreateDate_W = null;
				_ModifyDate_W = null;
				_UpdatedBy_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PositionsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PositionID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PositionsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PositionsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PositionID);
			p.SourceColumn = ColumnNames.PositionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PositionID);
			p.SourceColumn = ColumnNames.PositionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PositionTypeCode);
			p.SourceColumn = ColumnNames.PositionTypeCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreateDate);
			p.SourceColumn = ColumnNames.CreateDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifyDate);
			p.SourceColumn = ColumnNames.ModifyDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UpdatedBy);
			p.SourceColumn = ColumnNames.UpdatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
