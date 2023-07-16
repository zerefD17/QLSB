using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SanBanh
{
    class XULYCSDL
    {
        SqlConnection con;
        SqlDataAdapter da;
        public XULYCSDL()
        {
            string sqlconnect = @"Data Source=ADMINISTRATOR\SQLEXPRESS; database= SanBanh; Integrated Security= True";
            con = new SqlConnection(sqlconnect);

        }

        public DataTable DocCSDL(string sql)
        {
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int AddDelUp(string sql)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            return cmd.ExecuteNonQuery();
            con.Close();
        }
        public int UpDate(string sql, DataTable tablename)
        {
            da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            return da.Update(tablename);
        }
    }
}
