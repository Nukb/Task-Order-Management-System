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
    public partial class Task_Type : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        string sql_str;
        public Task_Type()
        {
            InitializeComponent();
        }

        private void Task_Type_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        //fillgrid function to used with grid and database
        private void fillgrid()
        {
            sql_str = "SELECT [Aut_tab] ,[Nu_Ty_task] ,[Type_Task] FROM [dbo].[Ta_Type_Task]";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            dataGridView2.Rows.Clear();

            while (rdr.Read() == true)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = dataGridView2.Rows.Count;
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[1].Value = rdr.GetValue(2);
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[2].Value = rdr.GetValue(1);
            }
            rdr.Close();
            cdcom.Dispose();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Type_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار المهمة", "خطأ إدخال");
                Type_Task.Focus();
            }

            if (Nu_Ty_task.Text != string.Empty)
            {

                cdcom = new SqlCommand("SELECT [Nu_Ty_task] FROM [dbo].[Ta_Main_Task] WHERE (Nu_Ty_task=" + Nu_Ty_task.Text + ")", dbcon.conn_db());
                rdr = cdcom.ExecuteReader();

                if (rdr.Read() == true)
                {
                    rdr.Close();
                    cdcom.Dispose();
                    MessageBox.Show("هذه المهمة مستخدمة في أوامر العمل ولا يمكن حذفها", "تنبيه");
                    return;

                }
                rdr.Close();
                cdcom.Dispose();

                if (MessageBox.Show("هل بالتأكيد تريد حذف هذه المهمة؟", "حذف بيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    cdcom = new SqlCommand("DELETE FROM [dbo].[Ta_Type_Task] WHERE (Nu_Ty_task=@p1)", dbcon.conn_db());
                    cdcom.Parameters.AddWithValue("@p1", Nu_Ty_task.Text);
                    cdcom.ExecuteNonQuery();
                    newButton_Click(sender, e);
                }
                else
                {
                    this.Close();

                }

            }


        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Nu_Ty_task.Clear();
            Type_Task.Clear();
            fillgrid();
            aut_n_u();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Type_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال المهمة", "خطأ إدخال");
                Type_Task.Focus();
            }

            string st_sql;
            SqlCommand cdcom;
            if (Nu_Ty_task.Text == string.Empty)
            {
                st_sql = "INSERT INTO [dbo].[Ta_Type_Task] ([Nu_Ty_task],[Type_Task]) VALUES (@p1, @p2)";
                cdcom = new SqlCommand(st_sql, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", aut_n_u());
                cdcom.Parameters.AddWithValue("@p2", Type_Task.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);
            }
            else
            {
                st_sql = "UPDATE [dbo].[Ta_Type_Task] SET[Nu_Ty_task] = @p1 ,[Type_Task] = @p2 WHERE (Nu_Ty_task=@p1)";
                cdcom = new SqlCommand(st_sql, dbcon.conn_db());
                cdcom.Parameters.Clear();
                cdcom.Parameters.AddWithValue("@p1", Nu_Ty_task.Text);
                cdcom.Parameters.AddWithValue("@p2", Type_Task.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);
            }
        }

        public int aut_n_u()
        {
            int inc_x = 0;


            sql_str = "SELECT [Aut_tab] ,[Nu_Ty_task] ,[Type_Task] FROM [dbo].[Ta_Type_Task] ORDER BY Nu_Ty_task ";
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Nu_Ty_task.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
                Type_Task.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            }
        }



    }
}
