using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DBConnection
    {
        public SqlConnection dbcon;
        public SqlCommand cdcom;
        string sql_str;
        public int NU_Emp_log;
        public string NA_Emp_log;
        public string User_Power;


        public SqlConnection conn_db()
        {
            dbcon = new SqlConnection(@"server=DESKTOP-QH0F62T\SQLEXPRESS;database=DATATASKMA;Trusted_Connection=True;");
            if (dbcon.State == ConnectionState.Closed)
            {
                dbcon.Open();
            }
            return dbcon;
        }

        public void change_val_user(string fill_na, string fill_val, int Nu_user)
        {
            sql_str = "UPDATE [dbo].[Ta_Users] SET " + fill_na + "=" + fill_val + " WHERE (Nu_Emp=" + Nu_user + ")";
            cdcom = new SqlCommand(sql_str, conn_db());
            cdcom.ExecuteNonQuery();
        }

    }
}
