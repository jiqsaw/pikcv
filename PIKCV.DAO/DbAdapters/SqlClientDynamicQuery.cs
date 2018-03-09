using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace PIKCV.DAO
{
	/// <summary>
	/// SqlClientDynamicQuery is the Microsoft SQL implementation of DynamicQuery
	/// </summary>
	public class SqlClientDynamicQuery : DynamicQuery
	{
		public SqlClientDynamicQuery(BusinessEntity entity)
			: base(entity)
		{
			
		}

		public override void AddOrderBy(string column, PIKCV.DAO.WhereParameter.Dir direction)
		{
			base.AddOrderBy ("[" + column + "]", direction);
		}

		public override void AddOrderBy(DynamicQuery countAll, PIKCV.DAO.WhereParameter.Dir direction)
		{
			if(countAll.CountAll)
			{
				base.AddOrderBy ("COUNT(*)", direction);
			}
		}

		public override void AddOrderBy(AggregateParameter aggregate, PIKCV.DAO.WhereParameter.Dir direction)
		{
			base.AddOrderBy (GetAggregate(aggregate, false), direction);
		}

		public override void AddGroupBy(string column)
		{
			base.AddGroupBy ("[" + column + "]");
		}
	
		public override void AddGroupBy(AggregateParameter aggregate)
		{
			// SQL Server does not support aggregates in a GROUP BY.
			// Common method
			base.AddGroupBy (GetAggregate(aggregate, false));
		}

		public override void AddResultColumn(string columnName)
		{
			base.AddResultColumn ("[" + columnName + "]");
		}

		protected string GetAggregate(AggregateParameter wItem, bool withAlias)
		{
			string query = string.Empty;

			switch(wItem.Function)
			{
				case AggregateParameter.Func.Avg:
					query += "AVG(";
					break;
				case AggregateParameter.Func.Count:
					query += "COUNT(";
					break;
				case AggregateParameter.Func.Max:
					query += "MAX(";
					break;
				case AggregateParameter.Func.Min:
					query += "MIN(";
					break;
				case AggregateParameter.Func.Sum:
					query += "SUM(";
					break;
				case AggregateParameter.Func.StdDev:
					query += "STDEV(";
					break;
				case AggregateParameter.Func.Var:
					query += "VAR(";
					break;
			}
			
			if(wItem.Distinct)
			{
				query += "DISTINCT ";
			}

			query += "[" + wItem.Column + "])";
			
			if(withAlias && wItem.Alias != string.Empty)
			{
				// Need DBMS string delimiter here
				query += " AS '" + wItem.Alias + "'";
			}
			
			return query;
		}
	
		override protected IDbCommand _Load(string conjuction) 
		{
			bool hasColumn = false;
			bool selectAll = true;
			string query;

			query = "SELECT ";

			if( this._distinct) query += " DISTINCT ";
			if( this._top >= 0) query += " TOP " + this._top.ToString() + " ";

			if(this._resultColumns.Length > 0)
			{
				query += this._resultColumns;
				hasColumn = true;
				selectAll = false;
			}

			if(this._countAll)
			{
				if(hasColumn)
				{
					query += ", ";
				}
				
				query += "COUNT(*)";

				if(this._countAllAlias != string.Empty)
				{
					// Need DBMS string delimiter here
					query += " AS '" + this._countAllAlias + "'";
				}
				
				hasColumn = true;
				selectAll = false;
			}

			if(_aggregateParameters != null && _aggregateParameters.Count > 0)
			{
				bool isFirst = true;
				
				if(hasColumn)
				{
					query += ", ";
				}
				
				AggregateParameter wItem;
	
				foreach(object obj in _aggregateParameters)
				{
					wItem = obj as AggregateParameter;
	
					if(wItem.IsDirty)
					{
						if(isFirst)
						{
							query += GetAggregate(wItem, true);
							isFirst = false;
						}
						else
						{
							query += ", " + GetAggregate(wItem, true);
						}
					}
				}
				
				selectAll = false;
			}
			
			if(selectAll)
			{
				query += "*";
			}

			query += " FROM [" + this._entity.QuerySource + "]";

			SqlCommand cmd = new SqlCommand();

			if(_whereParameters != null && _whereParameters.Count > 0)
			{
				query += " WHERE ";

				bool first = true;

				bool requiresParam;

				WhereParameter wItem;
				bool skipConjuction = false;

				string paramName;
				string columnName;

				foreach(object obj in _whereParameters)
				{
					// Maybe we injected text or a WhereParameter
					if(obj.GetType().ToString() == "System.String")
					{
						string text = obj as string;
						query += text;

						if(text == "(")
						{
							skipConjuction = true;
						}
					}
					else
					{
						wItem = obj as WhereParameter;

						if(wItem.IsDirty)
						{
							if(!first && !skipConjuction)
							{
								if(wItem.Conjuction != WhereParameter.Conj.UseDefault)
								{
									if(wItem.Conjuction == WhereParameter.Conj.And)
										query += " AND ";
									else
										query += " OR ";
								}
								else
								{
									query += " " + conjuction + " ";
								}
							}

							requiresParam = true;

							columnName = "[" + wItem.Column + "]";
							paramName  = "@" + wItem.Column + (++inc).ToString();
							wItem.Param.ParameterName = paramName;

							switch(wItem.Operator)
							{
								case WhereParameter.Operand.Equal:
									query += columnName + " = " + paramName + " ";
									break;
								case WhereParameter.Operand.NotEqual:
									query += columnName + " <> " + paramName + " ";
									break;
								case WhereParameter.Operand.GreaterThan:
									query += columnName + " > " + paramName + " ";
									break;
								case WhereParameter.Operand.LessThan:
									query += columnName + " < " + paramName + " ";
									break;
								case WhereParameter.Operand.LessThanOrEqual:
									query += columnName + " <= " + paramName + " ";
									break;
								case WhereParameter.Operand.GreaterThanOrEqual:
									query += columnName + " >= " + paramName + " ";
									break;
								case WhereParameter.Operand.Like:
									query += columnName + " LIKE " + paramName + " ";
									break;
								case WhereParameter.Operand.NotLike:
									query += columnName + " NOT LIKE " + paramName + " ";
									break;
								case WhereParameter.Operand.IsNull:
									query += columnName + " IS NULL ";
									requiresParam = false;
									break;
								case WhereParameter.Operand.IsNotNull:
									query += columnName + " IS NOT NULL ";
									requiresParam = false;
									break;
								case WhereParameter.Operand.In:
									query += columnName + " IN (" + wItem.Value + ") ";
									requiresParam = false;
									break;
								case WhereParameter.Operand.NotIn:
									query += columnName + " NOT IN (" + wItem.Value + ") ";
									requiresParam = false;
									break;
								case WhereParameter.Operand.Between:
									query += columnName + " BETWEEN " + paramName;
									AddParameter(cmd, paramName, wItem.BetweenBeginValue);

									paramName  = "@" + wItem.Column + (++inc).ToString();
									query += " AND " + paramName;
									AddParameter(cmd, paramName, wItem.BetweenEndValue);

									requiresParam = false;
									break;
							}

							if(requiresParam)
							{
								IDbCommand dbCmd = cmd as IDbCommand;
								dbCmd.Parameters.Add(wItem.Param);
								wItem.Param.Value = wItem.Value;
							}

							first = false;
							skipConjuction = false;
						}
					}
				}
			}

			if(_groupBy.Length > 0) 
			{
				query += " GROUP BY " + _groupBy;
				
				if(this._withRollup)
				{
					query += " WITH ROLLUP";
				}
			}
		
			if(_orderBy.Length > 0) 
			{
				query += " ORDER BY " + _orderBy;
			}

			cmd.CommandText = query;
			return cmd;
		}

		private void AddParameter(SqlCommand cmd, string paramName, object data)
		{
#if(VS2005)
			cmd.Parameters.AddWithValue(paramName, data);
#else
			cmd.Parameters.Add(paramName, data);
#endif
		}
	}
}