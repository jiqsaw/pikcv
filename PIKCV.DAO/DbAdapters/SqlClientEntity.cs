using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace PIKCV.DAO
{
	/// <summary>
	/// SqlClientEntity is the Microsoft SQL implementation of BusinessEntity
	/// </summary>
	public class SqlClientEntity : BusinessEntity
	{
		public SqlClientEntity()
		{

		}

		override internal DynamicQuery CreateDynamicQuery(BusinessEntity entity)
		{
			return new SqlClientDynamicQuery(entity);
		}

		override internal IDataParameter CreateIDataParameter(string name, object value)
		{
			SqlParameter p = new SqlParameter();
			p.ParameterName = name;
			p.Value = value;
			return p;
		}

		override internal IDataParameter CreateIDataParameter()
		{
			return new SqlParameter();
		}

		override internal IDbCommand CreateIDbCommand()
		{
			return new SqlCommand();
		}

		override internal IDbDataAdapter CreateIDbDataAdapter()
		{	
			return new SqlDataAdapter();
		}

		override internal IDbConnection CreateIDbConnection()
		{
			return new SqlConnection();
		}

		override internal DbDataAdapter ConvertIDbDataAdapter(IDbDataAdapter dataAdapter)
		{
			return (dataAdapter as SqlDataAdapter) as DbDataAdapter;
		}

		override internal IDbCommand _LoadFromRawSql(string rawSql, params object[] parameters)
		{
			int i = 0;
			string token  = "";
			string sIndex = "";
			string param  = "";

			SqlCommand cmd = new SqlCommand();

			foreach(object o in parameters)
			{
				sIndex = i.ToString();
				token = '{' + sIndex + '}';
				param = "@p" + sIndex;

				rawSql = rawSql.Replace(token, param);

				SqlParameter p = new SqlParameter(param, o);
				cmd.Parameters.Add(p);
				i++;
			}

			cmd.CommandText = rawSql;
			return cmd;
		}
	}
}
