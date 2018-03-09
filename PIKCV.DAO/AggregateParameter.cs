using System.Collections;
using System.Data;

namespace PIKCV.DAO
{
	
	public class AggregateParameter
	{
		/// <summary>
		/// The aggregate function used by Aggregate.Function
		/// </summary>
		public enum Func
		{
			/// <summary>
			/// Average
			/// </summary>
			Avg = 1,
			/// <summary>
			/// Count
			/// </summary>
			Count,
			/// <summary>
			/// Maximum
			/// </summary>
			Max,
			/// <summary>
			/// Minimum
			/// </summary>
			Min,
			/// <summary>
			/// Standard Deviation
			/// </summary>
			StdDev,
			/// <summary>
			/// Variance
			/// </summary>
			Var,
			/// <summary>
			/// Sum
			/// </summary>
			Sum
		};

		/// <summary>
		/// This is only called by dOOdads architecture.
		/// </summary>
		/// <param name="column"></param>
		/// <param name="param"></param>
		public AggregateParameter(string column, IDataParameter param)
		{
			this._column = column;
			this._alias = column;
			this._distinct = false;
			this._param = param;
			this._function = AggregateParameter.Func.Sum;
		}

		/// <summary>
		/// Used to determine if the AggregateParameter has a value
		/// </summary>
		public bool IsDirty
		{
			get
			{
				return _isDirty;
			}
		}

		/// <summary>
		/// The column in the BusinessEntity that this AggregateParameter is going to query against. 
		/// </summary>
		public string Column
		{
			get
			{
				return _column;
			}
		}

		/// <summary>
		/// The actual database Parameter 
		/// </summary>
		public IDataParameter Param
		{
			get
			{
				return _param;
			}
		}

		/// <summary>
		/// The value that will be placed into the Parameter
		/// </summary>
		public object Value
		{
			get
			{
				return _value;
			}

			set
			{
				_value = value;
				_isDirty = true;
			}
		}

		/// <summary>
		/// The type of aggregate function desired.
		/// Avg, Count, Min, Max, Sum, StdDev, or Var.
		/// (See AggregateParameter.Func enumeration.)
		/// </summary>
		public Func Function
		{
			get
			{
				return _function;
			}

			set
			{
				_function = value;
				_isDirty = true;
			}
		}

		/// <summary>
		/// The user-friendly name of the aggregate column
		/// </summary>
		public string Alias
		{
			get
			{
				return _alias;
			}

			set
			{
				_alias = value;
				_isDirty = true;
			}
		}

		/// <summary>
		/// If true, then use (DISTINCT columnName) in the aggregate.
		/// </summary>
		public bool Distinct
		{
			get
			{
				return _distinct;
			}

			set
			{
				_distinct = value;
				_isDirty = true;
			}
		}

		private object _value = null;
		private IDataParameter _param;
		private string _column;
		private Func _function = AggregateParameter.Func.Sum;
		private string _alias = string.Empty;
		private bool _isDirty = false;
		private bool _distinct = false;
	}
}
