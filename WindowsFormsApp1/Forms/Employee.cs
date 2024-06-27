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
    public partial class Employee : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        ListBox listtemp_nu_job = new ListBox();
        ListBox listtemp_nu_location = new ListBox();
        string sql_str;
        string st_t;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            fill_combo_na_job();
            fill_combo_na_location();
            fill_grid("");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            nu_Em.Clear();
            na_Em.Clear();
            Nu_job.SelectedIndex = -1;
            Na_location.SelectedIndex = -1;
            fill_combo_na_job();
            fill_combo_na_location();
            fill_grid("");
        }

        private void fill_grid(string wherest)
        {
            sql_str = "SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data]" + wherest;

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = rdr.GetValue(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr.GetValue(2);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = rdr.GetValue(5);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = rdr.GetValue(6);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = rdr.GetValue(3);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = rdr.GetValue(4);
            }
            rdr.Close();
            cdcom.Dispose();
        }

        private void fill_combo_na_job()
        {
            sql_str = "SELECT [Aut_tab],[Nu_Jop],[Na_Jop] FROM[dbo].[Ta_Jop]";

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            Nu_job.Items.Clear();
            listtemp_nu_job.Items.Clear();

            while (rdr.Read() == true)
            {
                Nu_job.Items.Add(rdr.GetValue(2));
                listtemp_nu_job.Items.Add(rdr.GetValue(1));
            }

            rdr.Close();
            cdcom.Dispose();
        }

        private void fill_combo_na_location()
        {
            sql_str = "SELECT [Aut_tab] ,[Nu_location] ,[Na_location] ,[Nu_De] ,[Nu_Ty] FROM [dbo].[Ta_Struct]";

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            Na_location.Items.Clear();
            listtemp_nu_location.Items.Clear();

            while (rdr.Read() == true)
            {
                Na_location.Items.Add(rdr.GetValue(2));
                listtemp_nu_location.Items.Add(rdr.GetValue(1));
            }

            rdr.Close();
            cdcom.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nu_Em.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                nu_Em.Focus();
                return;
            }

            if (na_Em.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الموظف", "خطأ إدخال");
                na_Em.Focus();
                return;
            }

            if (Nu_job.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار الوظيفة", "خطأ إدخال");
                Nu_job.Focus();
                return;
            }

            if (Na_location.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار مكان العمل", "خطأ إدخال");
                Na_location.Focus();
                return;
            }
            SqlCommand cdcom;

            sql_str = "SELECT [Nu_Emp] FROM [dbo].[Ta_Employ] WHERE (Nu_Emp=" + nu_Em.Text + ")";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            //UPDATE Code
            if (rdr.Read())
            {
                rdr.Close();
                cdcom.Dispose();

                sql_str = "UPDATE [dbo].[Ta_Employ] SET [Nu_Emp]=@p1 ,[Na_emp]=@p2 ,[Nu_Jop]=@p3 ,[Nu_location]=@p4 WHERE (Nu_Emp=@p1)";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
                cdcom.Parameters.AddWithValue("@p2", na_Em.Text);
                cdcom.Parameters.AddWithValue("@p3", listtemp_nu_job.Text);
                cdcom.Parameters.AddWithValue("@p4", listtemp_nu_location.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);
            }
            //INSERT Code
            else
            {
                rdr.Close();
                cdcom.Dispose();

                sql_str = "INSERT INTO [dbo].[Ta_Employ] ([Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location]) VALUES (@p1,@p2,@p3,@p4)";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
                cdcom.Parameters.AddWithValue("@p2", na_Em.Text);
                cdcom.Parameters.AddWithValue("@p3", listtemp_nu_job.Text);
                cdcom.Parameters.AddWithValue("@p4", listtemp_nu_location.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);
            }
        }

        private void Nu_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            listtemp_nu_job.SelectedIndex = Nu_job.SelectedIndex;
        }

        private void Na_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            listtemp_nu_location.SelectedIndex = Na_location.SelectedIndex;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nu_Em.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                nu_Em.Focus();
                return;
            }

            cdcom = new SqlCommand("SELECT [Nu_Emp] FROM [dbo].[Ta_Pranch_Task] WHERE (Nu_Emp=" + nu_Em.Text + ")", dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (rdr.Read() == true)
            {
                rdr.Close();
                cdcom.Dispose();
                MessageBox.Show("بيانات الموظف مستخدمة داخل أوامر العمل ولا يمكنك حذفها", "تنبيه");
                return;

            }
            rdr.Close();
            cdcom.Dispose();

            if (MessageBox.Show("هل تريد حذف بيانات الموظف؟", "حذف بيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cdcom = new SqlCommand("DELETE FROM [dbo].[Ta_Employ] WHERE (Nu_Emp=@p1)", dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e); //هل نستدعي الجديد ام الحفظ؟؟؟
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nu_Em.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                na_Em.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                Nu_job.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                Na_location.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
        }

        private void na_Em_TextChanged(object sender, EventArgs e)
        {
            if (na_Em.Text != string.Empty)
            {
                string searchText = na_Em.Text.Trim();
                string whereClause;

                switch (searchOptions.SelectedIndex)
                {
                    case 0:
                        whereClause = "WHERE Na_emp LIKE N'" + searchText + "%'";
                        break;
                    case 1:
                        whereClause = "WHERE Na_emp LIKE N'%" + searchText + "%'";
                        break;
                    case 2:
                        whereClause = "WHERE Na_emp LIKE N'%" + searchText + "'";
                        break;
                    default:
                        // Handle invalid selection (optional)
                        return;
                }

                fill_grid(whereClause);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Case 1: Text box is empty
            if (string.IsNullOrEmpty(nu_Em.Text))
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                nu_Em.Focus();
                return;
            }

            // Attempt to retrieve data for the given Nu_Emp
            SqlCommand cdcom = new SqlCommand("SELECT TOP 1 [Nu_Emp] FROM [dbo].[View_emp_data] WHERE Nu_Emp = @p1", dbcon.conn_db());
            cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
            SqlDataReader rdr = cdcom.ExecuteReader();
            // Case 2: Number not found
            if (!rdr.Read())
            {
                MessageBox.Show("هذا الرقم غير موجود", "تنبيه");
                fill_grid("");
            }
            // Case 3: Number found
            else
            {
                fill_grid("WHERE Nu_Emp=" + nu_Em.Text);
            }
        }

        private void moreButton1_Click(object sender, EventArgs e)
        {
            Form j;
            j = new Jobs();
            j.ShowDialog();
            fill_combo_na_job();
        }
    }
}
