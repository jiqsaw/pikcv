
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class Companies : _Companies
	{
        // �irket Credi Son Durumunu Getir
        public DataTable GetCompanyCreditSituation(int CompanyID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCreditSituation", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
	}
}
