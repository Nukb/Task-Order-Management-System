using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class Jobs : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        string sql_str;

        public Jobs()
        {
            InitializeComponent();
        }

        private void Jops_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            aut_n_u();
            fill_grid();
            nu_job.Clear();
            na_job.Clear();
        }

        int aut_n_u()
        {

            int inc_x;

            sql_str = "SELECT [Aut_tab] ,[Nu_Jop] ,[Na_jop] FROM [dbo].[Ta_Jop] ORDER BY Nu_Jop ";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            inc_x = 0;
            while (rdr.Read() == true)
            {
                inc_x = (int)rdr.GetValue(1);

            }
            rdr.Close();
            cdcom.Dispose();
            inc_x += 1;
            return inc_x;
        }

        private void fill_grid()
        {
            sql_str = "SELECT [Aut_tab] ,[Nu_Jop] ,[Na_jop] FROM [dbo].[Ta_Jop]";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr.GetValue(2);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = rdr.GetValue(1);
            }
            rdr.Close();
            cdcom.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nu_job.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                na_job.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (na_job.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الوظيفة", "خطأ إدخال");
                na_job.Focus();
            }

            //INSERT Code
            if (nu_job.Text == string.Empty)
            {
                string st_sql;
                SqlCommand cdcom;
                st_sql = "INSERT INTO [dbo].[Ta_Jop] ([Nu_Jop] ,[Na_jop]) VALUES(@p1,@p2)";
                cdcom = new SqlCommand(st_sql, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", aut_n_u());
                cdcom.Parameters.AddWithValue("@p2", na_job.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);
            }

            //UPDATE Code

            else
            {
                string st_sql;
                st_sql = "UPDATE [dbo].[Ta_Jop] SET [Nu_Jop] = @p1,[Na_jop] = @p2 WHERE (Nu_Jop=@p1)";
                cdcom = new SqlCommand(st_sql, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_job.Text);
                cdcom.Parameters.AddWithValue("@p2", na_job.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (na_job.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال الوظيفة", "خطأ إدخال");
                na_job.Focus();

            }

            if (nu_job.Text != string.Empty)
            {

                cdcom = new SqlCommand("SELECT [Nu_Jop] FROM [dbo].[Ta_Employ] WHERE (Nu_Jop=" + nu_job.Text + ")", dbcon.conn_db());
                rdr = cdcom.ExecuteReader();

                if (rdr.Read() == true)
                {
                    rdr.Close();
                    cdcom.Dispose();
                    MessageBox.Show("هذه الوظيفة مستخدمة في بيانات الموظفين ولا يمكن حذفها", "تنبيه");
                    return;

                }
                rdr.Close();
                cdcom.Dispose();



                if (MessageBox.Show("هل تريد حذف هذه الوظيفة", "حذف بيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cdcom = new SqlCommand("DELETE FROM [dbo].[Ta_Jop] WHERE (Nu_Jop=@p1)", dbcon.conn_db());
                    cdcom.Parameters.AddWithValue("@p1", nu_job.Text);
                    cdcom.ExecuteNonQuery();
                    newButton_Click(sender, e);
                }
                else
                {
                    return;
                }

            }
        
    }
    }
}
