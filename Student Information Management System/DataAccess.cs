using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Student_Information_Management_System
{
    class DataAccess
    {
        public static DataTable Data(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENAN_PC;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds.Tables[0];
        }

        public static int GetInfoInt(string query, string req)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENAN_PC;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            int info = int.Parse(dt.Rows[0]["" + req + ""].ToString());
            return info;
        }

        public static string GetInfoString(string query, string req)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENAN_PC;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            string info = dt.Rows[0]["" + req + ""].ToString();
            return info;
        }

        public static void RunQuery(string query)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ENAN_PC;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

    }
}
