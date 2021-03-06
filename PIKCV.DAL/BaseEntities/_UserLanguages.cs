
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
	public abstract class _UserLanguages : SqlClientEntity
	{
		private string m_SchemaStoredProcedure = "Pikcv].[";
		public _UserLanguages()
		{
			this.QuerySource = "UserLanguages";
			this.MappingName = "UserLanguages";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserLanguagesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int UserLanguageID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.UserLanguageID, UserLanguageID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserLanguagesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter UserLanguageID
			{
				get
				{
					return new SqlParameter("@UserLanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ForeignLanguageID
			{
				get
				{
					return new SqlParameter("@ForeignLanguageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReadLevelID
			{
				get
				{
					return new SqlParameter("@ReadLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter WriteLevelID
			{
				get
				{
					return new SqlParameter("@WriteLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SpeakLevelID
			{
				get
				{
					return new SqlParameter("@SpeakLevelID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PlaceLearned
			{
				get
				{
					return new SqlParameter("@PlaceLearned", SqlDbType.NVarChar, 32);
				}
			}
			
			public static SqlParameter ForeignLanguageExamID
			{
				get
				{
					return new SqlParameter("@ForeignLanguageExamID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ExamDegree
			{
				get
				{
					return new SqlParameter("@ExamDegree", SqlDbType.Float, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string UserLanguageID = "UserLanguageID";
            public const string UserID = "UserID";
            public const string ForeignLanguageID = "ForeignLanguageID";
            public const string ReadLevelID = "ReadLevelID";
            public const string WriteLevelID = "WriteLevelID";
            public const string SpeakLevelID = "SpeakLevelID";
            public const string PlaceLearned = "PlaceLearned";
            public const string ForeignLanguageExamID = "ForeignLanguageExamID";
            public const string ExamDegree = "ExamDegree";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserLanguageID] = _UserLanguages.PropertyNames.UserLanguageID;
					ht[UserID] = _UserLanguages.PropertyNames.UserID;
					ht[ForeignLanguageID] = _UserLanguages.PropertyNames.ForeignLanguageID;
					ht[ReadLevelID] = _UserLanguages.PropertyNames.ReadLevelID;
					ht[WriteLevelID] = _UserLanguages.PropertyNames.WriteLevelID;
					ht[SpeakLevelID] = _UserLanguages.PropertyNames.SpeakLevelID;
					ht[PlaceLearned] = _UserLanguages.PropertyNames.PlaceLearned;
					ht[ForeignLanguageExamID] = _UserLanguages.PropertyNames.ForeignLanguageExamID;
					ht[ExamDegree] = _UserLanguages.PropertyNames.ExamDegree;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string UserLanguageID = "UserLanguageID";
            public const string UserID = "UserID";
            public const string ForeignLanguageID = "ForeignLanguageID";
            public const string ReadLevelID = "ReadLevelID";
            public const string WriteLevelID = "WriteLevelID";
            public const string SpeakLevelID = "SpeakLevelID";
            public const string PlaceLearned = "PlaceLearned";
            public const string ForeignLanguageExamID = "ForeignLanguageExamID";
            public const string ExamDegree = "ExamDegree";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserLanguageID] = _UserLanguages.ColumnNames.UserLanguageID;
					ht[UserID] = _UserLanguages.ColumnNames.UserID;
					ht[ForeignLanguageID] = _UserLanguages.ColumnNames.ForeignLanguageID;
					ht[ReadLevelID] = _UserLanguages.ColumnNames.ReadLevelID;
					ht[WriteLevelID] = _UserLanguages.ColumnNames.WriteLevelID;
					ht[SpeakLevelID] = _UserLanguages.ColumnNames.SpeakLevelID;
					ht[PlaceLearned] = _UserLanguages.ColumnNames.PlaceLearned;
					ht[ForeignLanguageExamID] = _UserLanguages.ColumnNames.ForeignLanguageExamID;
					ht[ExamDegree] = _UserLanguages.ColumnNames.ExamDegree;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string UserLanguageID = "s_UserLanguageID";
            public const string UserID = "s_UserID";
            public const string ForeignLanguageID = "s_ForeignLanguageID";
            public const string ReadLevelID = "s_ReadLevelID";
            public const string WriteLevelID = "s_WriteLevelID";
            public const string SpeakLevelID = "s_SpeakLevelID";
            public const string PlaceLearned = "s_PlaceLearned";
            public const string ForeignLanguageExamID = "s_ForeignLanguageExamID";
            public const string ExamDegree = "s_ExamDegree";

		}
		#endregion		
		
		#region Properties
	
		public virtual int UserLanguageID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserLanguageID);
			}
			set
	        {
				base.Setint(ColumnNames.UserLanguageID, value);
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

		public virtual int ForeignLanguageID
	    {
			get
	        {
				return base.Getint(ColumnNames.ForeignLanguageID);
			}
			set
	        {
				base.Setint(ColumnNames.ForeignLanguageID, value);
			}
		}

		public virtual int ReadLevelID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReadLevelID);
			}
			set
	        {
				base.Setint(ColumnNames.ReadLevelID, value);
			}
		}

		public virtual int WriteLevelID
	    {
			get
	        {
				return base.Getint(ColumnNames.WriteLevelID);
			}
			set
	        {
				base.Setint(ColumnNames.WriteLevelID, value);
			}
		}

		public virtual int SpeakLevelID
	    {
			get
	        {
				return base.Getint(ColumnNames.SpeakLevelID);
			}
			set
	        {
				base.Setint(ColumnNames.SpeakLevelID, value);
			}
		}

		public virtual string PlaceLearned
	    {
			get
	        {
				return base.Getstring(ColumnNames.PlaceLearned);
			}
			set
	        {
				base.Setstring(ColumnNames.PlaceLearned, value);
			}
		}

		public virtual int ForeignLanguageExamID
	    {
			get
	        {
				return base.Getint(ColumnNames.ForeignLanguageExamID);
			}
			set
	        {
				base.Setint(ColumnNames.ForeignLanguageExamID, value);
			}
		}

		public virtual double ExamDegree
	    {
			get
	        {
				return base.Getdouble(ColumnNames.ExamDegree);
			}
			set
	        {
				base.Setdouble(ColumnNames.ExamDegree, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_UserLanguageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserLanguageID) ? string.Empty : base.GetintAsString(ColumnNames.UserLanguageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserLanguageID);
				else
					this.UserLanguageID = base.SetintAsString(ColumnNames.UserLanguageID, value);
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

		public virtual string s_ForeignLanguageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ForeignLanguageID) ? string.Empty : base.GetintAsString(ColumnNames.ForeignLanguageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ForeignLanguageID);
				else
					this.ForeignLanguageID = base.SetintAsString(ColumnNames.ForeignLanguageID, value);
			}
		}

		public virtual string s_ReadLevelID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReadLevelID) ? string.Empty : base.GetintAsString(ColumnNames.ReadLevelID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReadLevelID);
				else
					this.ReadLevelID = base.SetintAsString(ColumnNames.ReadLevelID, value);
			}
		}

		public virtual string s_WriteLevelID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.WriteLevelID) ? string.Empty : base.GetintAsString(ColumnNames.WriteLevelID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.WriteLevelID);
				else
					this.WriteLevelID = base.SetintAsString(ColumnNames.WriteLevelID, value);
			}
		}

		public virtual string s_SpeakLevelID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SpeakLevelID) ? string.Empty : base.GetintAsString(ColumnNames.SpeakLevelID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SpeakLevelID);
				else
					this.SpeakLevelID = base.SetintAsString(ColumnNames.SpeakLevelID, value);
			}
		}

		public virtual string s_PlaceLearned
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PlaceLearned) ? string.Empty : base.GetstringAsString(ColumnNames.PlaceLearned);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PlaceLearned);
				else
					this.PlaceLearned = base.SetstringAsString(ColumnNames.PlaceLearned, value);
			}
		}

		public virtual string s_ForeignLanguageExamID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ForeignLanguageExamID) ? string.Empty : base.GetintAsString(ColumnNames.ForeignLanguageExamID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ForeignLanguageExamID);
				else
					this.ForeignLanguageExamID = base.SetintAsString(ColumnNames.ForeignLanguageExamID, value);
			}
		}

		public virtual string s_ExamDegree
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ExamDegree) ? string.Empty : base.GetdoubleAsString(ColumnNames.ExamDegree);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ExamDegree);
				else
					this.ExamDegree = base.SetdoubleAsString(ColumnNames.ExamDegree, value);
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
				
				
				public WhereParameter UserLanguageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserLanguageID, Parameters.UserLanguageID);
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

				public WhereParameter ForeignLanguageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ForeignLanguageID, Parameters.ForeignLanguageID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReadLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReadLevelID, Parameters.ReadLevelID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter WriteLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.WriteLevelID, Parameters.WriteLevelID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SpeakLevelID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SpeakLevelID, Parameters.SpeakLevelID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PlaceLearned
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PlaceLearned, Parameters.PlaceLearned);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ForeignLanguageExamID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ForeignLanguageExamID, Parameters.ForeignLanguageExamID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ExamDegree
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ExamDegree, Parameters.ExamDegree);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter UserLanguageID
		    {
				get
		        {
					if(_UserLanguageID_W == null)
	        	    {
						_UserLanguageID_W = TearOff.UserLanguageID;
					}
					return _UserLanguageID_W;
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

			public WhereParameter ForeignLanguageID
		    {
				get
		        {
					if(_ForeignLanguageID_W == null)
	        	    {
						_ForeignLanguageID_W = TearOff.ForeignLanguageID;
					}
					return _ForeignLanguageID_W;
				}
			}

			public WhereParameter ReadLevelID
		    {
				get
		        {
					if(_ReadLevelID_W == null)
	        	    {
						_ReadLevelID_W = TearOff.ReadLevelID;
					}
					return _ReadLevelID_W;
				}
			}

			public WhereParameter WriteLevelID
		    {
				get
		        {
					if(_WriteLevelID_W == null)
	        	    {
						_WriteLevelID_W = TearOff.WriteLevelID;
					}
					return _WriteLevelID_W;
				}
			}

			public WhereParameter SpeakLevelID
		    {
				get
		        {
					if(_SpeakLevelID_W == null)
	        	    {
						_SpeakLevelID_W = TearOff.SpeakLevelID;
					}
					return _SpeakLevelID_W;
				}
			}

			public WhereParameter PlaceLearned
		    {
				get
		        {
					if(_PlaceLearned_W == null)
	        	    {
						_PlaceLearned_W = TearOff.PlaceLearned;
					}
					return _PlaceLearned_W;
				}
			}

			public WhereParameter ForeignLanguageExamID
		    {
				get
		        {
					if(_ForeignLanguageExamID_W == null)
	        	    {
						_ForeignLanguageExamID_W = TearOff.ForeignLanguageExamID;
					}
					return _ForeignLanguageExamID_W;
				}
			}

			public WhereParameter ExamDegree
		    {
				get
		        {
					if(_ExamDegree_W == null)
	        	    {
						_ExamDegree_W = TearOff.ExamDegree;
					}
					return _ExamDegree_W;
				}
			}

			private WhereParameter _UserLanguageID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _ForeignLanguageID_W = null;
			private WhereParameter _ReadLevelID_W = null;
			private WhereParameter _WriteLevelID_W = null;
			private WhereParameter _SpeakLevelID_W = null;
			private WhereParameter _PlaceLearned_W = null;
			private WhereParameter _ForeignLanguageExamID_W = null;
			private WhereParameter _ExamDegree_W = null;

			public void WhereClauseReset()
			{
				_UserLanguageID_W = null;
				_UserID_W = null;
				_ForeignLanguageID_W = null;
				_ReadLevelID_W = null;
				_WriteLevelID_W = null;
				_SpeakLevelID_W = null;
				_PlaceLearned_W = null;
				_ForeignLanguageExamID_W = null;
				_ExamDegree_W = null;

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
				
				
				public AggregateParameter UserLanguageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserLanguageID, Parameters.UserLanguageID);
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

				public AggregateParameter ForeignLanguageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ForeignLanguageID, Parameters.ForeignLanguageID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReadLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReadLevelID, Parameters.ReadLevelID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter WriteLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.WriteLevelID, Parameters.WriteLevelID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SpeakLevelID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SpeakLevelID, Parameters.SpeakLevelID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PlaceLearned
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PlaceLearned, Parameters.PlaceLearned);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ForeignLanguageExamID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ForeignLanguageExamID, Parameters.ForeignLanguageExamID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ExamDegree
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ExamDegree, Parameters.ExamDegree);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter UserLanguageID
		    {
				get
		        {
					if(_UserLanguageID_W == null)
	        	    {
						_UserLanguageID_W = TearOff.UserLanguageID;
					}
					return _UserLanguageID_W;
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

			public AggregateParameter ForeignLanguageID
		    {
				get
		        {
					if(_ForeignLanguageID_W == null)
	        	    {
						_ForeignLanguageID_W = TearOff.ForeignLanguageID;
					}
					return _ForeignLanguageID_W;
				}
			}

			public AggregateParameter ReadLevelID
		    {
				get
		        {
					if(_ReadLevelID_W == null)
	        	    {
						_ReadLevelID_W = TearOff.ReadLevelID;
					}
					return _ReadLevelID_W;
				}
			}

			public AggregateParameter WriteLevelID
		    {
				get
		        {
					if(_WriteLevelID_W == null)
	        	    {
						_WriteLevelID_W = TearOff.WriteLevelID;
					}
					return _WriteLevelID_W;
				}
			}

			public AggregateParameter SpeakLevelID
		    {
				get
		        {
					if(_SpeakLevelID_W == null)
	        	    {
						_SpeakLevelID_W = TearOff.SpeakLevelID;
					}
					return _SpeakLevelID_W;
				}
			}

			public AggregateParameter PlaceLearned
		    {
				get
		        {
					if(_PlaceLearned_W == null)
	        	    {
						_PlaceLearned_W = TearOff.PlaceLearned;
					}
					return _PlaceLearned_W;
				}
			}

			public AggregateParameter ForeignLanguageExamID
		    {
				get
		        {
					if(_ForeignLanguageExamID_W == null)
	        	    {
						_ForeignLanguageExamID_W = TearOff.ForeignLanguageExamID;
					}
					return _ForeignLanguageExamID_W;
				}
			}

			public AggregateParameter ExamDegree
		    {
				get
		        {
					if(_ExamDegree_W == null)
	        	    {
						_ExamDegree_W = TearOff.ExamDegree;
					}
					return _ExamDegree_W;
				}
			}

			private AggregateParameter _UserLanguageID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _ForeignLanguageID_W = null;
			private AggregateParameter _ReadLevelID_W = null;
			private AggregateParameter _WriteLevelID_W = null;
			private AggregateParameter _SpeakLevelID_W = null;
			private AggregateParameter _PlaceLearned_W = null;
			private AggregateParameter _ForeignLanguageExamID_W = null;
			private AggregateParameter _ExamDegree_W = null;

			public void AggregateClauseReset()
			{
				_UserLanguageID_W = null;
				_UserID_W = null;
				_ForeignLanguageID_W = null;
				_ReadLevelID_W = null;
				_WriteLevelID_W = null;
				_SpeakLevelID_W = null;
				_PlaceLearned_W = null;
				_ForeignLanguageExamID_W = null;
				_ExamDegree_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserLanguagesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.UserLanguageID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserLanguagesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserLanguagesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.UserLanguageID);
			p.SourceColumn = ColumnNames.UserLanguageID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.UserLanguageID);
			p.SourceColumn = ColumnNames.UserLanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ForeignLanguageID);
			p.SourceColumn = ColumnNames.ForeignLanguageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReadLevelID);
			p.SourceColumn = ColumnNames.ReadLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.WriteLevelID);
			p.SourceColumn = ColumnNames.WriteLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SpeakLevelID);
			p.SourceColumn = ColumnNames.SpeakLevelID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PlaceLearned);
			p.SourceColumn = ColumnNames.PlaceLearned;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ForeignLanguageExamID);
			p.SourceColumn = ColumnNames.ForeignLanguageExamID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ExamDegree);
			p.SourceColumn = ColumnNames.ExamDegree;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
