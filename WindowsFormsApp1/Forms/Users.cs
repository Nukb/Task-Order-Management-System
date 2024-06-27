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
    public partial class Users : Form
    {
        DBConnection dbcon = new DBConnection();
        string sql_str;
        string st_t;
        SqlCommand cdcom;
        SqlDataReader rdr;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            searchOptions.SelectedIndex = -1;
            Active_state.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nu_Em.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                nu_Em.Focus();
                return;
            }

            sql_str = "SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data] WHERE (Nu_Emp=" + nu_Em.Text + ")";

            fill_grid(sql_str, 0);
        }

        private void fill_grid(string sql_TS, byte fl_cl)

        {
            sql_str = sql_TS;
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (fl_cl == 0)
            {
                dataGridView1.Rows.Clear();
            }

            Aut_tab.Clear();

            if (rdr.Read() == true)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = rdr["Nu_Emp"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr["Na_emp"];
            }
            else
            {
                MessageBox.Show("رقم الموظف غير موجود", "تنبيه");
                nu_Em.Clear();
            }
            rdr.Close();
            cdcom.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nu_Em.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                na_Em.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                num_textBox.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                na_textBox.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                sql_str = "SELECT [Aut_tab], [Nu_Emp], [Username] ,[Password], [Active_state], [Expire_password], [Change_password], [Re_change] FROM [dbo].[Ta_Users] WHERE (Nu_Emp=" + nu_Em.Text + ")";

                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                rdr = cdcom.ExecuteReader();

                if (rdr.Read() == true)
                {
                    Aut_tab.Text = Convert.ToString(rdr["Aut_tab"]);
                    user_name.Text = Convert.ToString(rdr["Username"]);
                    password1.Text = Convert.ToString(rdr["Password"]);
                    password2.Text = Convert.ToString(rdr["Password"]);
                    Active_state.Text = Convert.ToString(rdr["Active_state"]);

                    int x = Convert.ToInt16(rdr["Expire_password"]);
                    if (x == 0)
                    {
                        exp_pass.Checked = false;
                    }
                    else
                    {
                        exp_pass.Checked = true;
                    }

                    x = Convert.ToInt16(rdr["Change_password"]);
                    if (x == 0)
                    {
                        change_pass.Checked = false;
                    }
                    else
                    {
                        change_pass.Checked = true;
                    }

                    x = Convert.ToInt16(rdr["Re_change"]);
                    if (x == 1)
                    {
                        user_name.ReadOnly = true;
                        password1.ReadOnly = true;
                        password2.ReadOnly = true;
                    }
                    else
                    {
                        user_name.ReadOnly = false;
                        password1.ReadOnly = false;
                        password2.ReadOnly = false;
                    }


                }
                else
                {
                    exp_pass.Checked = false;
                    change_pass.Checked = false;
                    Active_state.SelectedIndex = -1;
                    user_name.Text = nu_Em.Text;
                    password1.Text = nu_Em.Text;
                    password2.Text = nu_Em.Text;
                    user_name.ReadOnly = false;
                    password1.ReadOnly = false;
                    password2.ReadOnly = false;
                }

                rdr.Close();
                cdcom.Dispose();
            }


        }

        private void na_Em_TextChanged(object sender, EventArgs e)
        {
            if (na_Em.Text != string.Empty)
            {
                if (searchOptions.SelectedIndex == 0)
                {
                    st_t = "WHERE (Na_emp LIKE N'" + na_Em.Text + "%')";
                }
                else if (searchOptions.SelectedIndex == 1)
                {
                    st_t = "WHERE (Na_emp LIKE N'%" + na_Em.Text + "%')";
                }
                else if (searchOptions.SelectedIndex == 2)
                {
                    st_t = "WHERE (Na_emp LIKE N'%" + na_Em.Text + "')";
                }

                sql_str = "SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data]" + st_t;
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                rdr = cdcom.ExecuteReader();

                dataGridView1.Rows.Clear();
                Aut_tab.Clear();

                if (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = rdr["Nu_Emp"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr["Na_emp"];
                }
                rdr.Close();
                cdcom.Dispose();

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Aut_tab.Clear();
            nu_Em.Clear();
            na_Em.Clear();
            num_textBox.Clear();
            na_textBox.Clear();
            dataGridView1.Rows.Clear();
            user_name.Clear();
            password1.Clear();
            password2.Clear();
            exp_pass.Checked = false;
            change_pass.Checked = false;
            user_name.ReadOnly = false;
            password1.ReadOnly = false;
            password2.ReadOnly = false;
            Active_state.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (num_textBox.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                nu_Em.Focus();
                return;
            }

            if (user_name.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المستخدم", "خطأ إدخال");
                user_name.Focus();
                return;
            }

            if (password1.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة المرور", "خطأ إدخال");
                password1.Focus();
                return;
            }

            if (Aut_tab.Text != string.Empty)
            {

                if (password1.ReadOnly != true)
                {
                    if (password1.Text.Length < 6)
                    {
                        MessageBox.Show("يجب أن تكون كلمة المرور أكبر من 6 أحرف", "خطأ إدخال");
                        password1.Focus();
                        return;
                    }

                }
            }

            if (password2.Text == string.Empty)
            {
                MessageBox.Show("يجب إعادة إدخال كلمة المرور", "خطأ إدخال");
                password2.Focus();
                return;
            }

            //to ensure the password fields is same
            if (password1.Text != password2.Text)
            {
                MessageBox.Show("كلمة المرور غير مطابقة", "خطأ إدخال");
                password1.Focus();
                return;
            }

            if (Active_state.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار حالة المستخدم", "خطأ إدخال");
                Active_state.Focus();
                return;
            }

            //Save Code Beginning

            //INSERT Code
            if (Aut_tab.Text == string.Empty)
            {
                sql_str = "INSERT INTO [dbo].[Ta_Users] ([Nu_Emp] ,[Username] ,[Password] ,[Active_state] ,[Expire_password] ,[Change_password] ,[User_power] ,[User_type] ,[User_state] ,[Re_change]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
                cdcom.Parameters.AddWithValue("@p2", user_name.Text);
                cdcom.Parameters.AddWithValue("@p3", password1.Text);
                cdcom.Parameters.AddWithValue("@p4", Active_state.Text);
                cdcom.Parameters.AddWithValue("@p5", exp_pass.Checked);
                cdcom.Parameters.AddWithValue("@p6", change_pass.Checked);
                cdcom.Parameters.AddWithValue("@p7", "1");
                cdcom.Parameters.AddWithValue("@p8", 0);
                cdcom.Parameters.AddWithValue("@p9", 0);
                cdcom.Parameters.AddWithValue("@p10", 0);
                cdcom.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ");
            }
            //UPDATE Code
            else
            {
                sql_str = "UPDATE [dbo].[Ta_Users] SET [Nu_Emp]=@p1 ,[Username]=@p2 ,[Password]=@p3 ,[Active_state]=@p4 ,[Expire_password]=@p5 ,[Change_password]=@p6 ,[User_type]=@p7 ,[User_state]=@p8 ,[Re_change]=@p9 WHERE (Nu_Emp=" + nu_Em.Text + ")";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", nu_Em.Text);
                cdcom.Parameters.AddWithValue("@p2", user_name.Text);
                cdcom.Parameters.AddWithValue("@p3", password1.Text);
                cdcom.Parameters.AddWithValue("@p4", Active_state.Text);
                cdcom.Parameters.AddWithValue("@p5", exp_pass.Checked);
                cdcom.Parameters.AddWithValue("@p6", change_pass.Checked);
                cdcom.Parameters.AddWithValue("@p7", 0);
                cdcom.Parameters.AddWithValue("@p8", 0);
                cdcom.Parameters.AddWithValue("@p9", 0);

                cdcom.ExecuteNonQuery();
                MessageBox.Show("تمت عملية تعديل البيانات بنجاح", "تعديل");
            }
            newButton_Click(sender, e);
        }
    }
}
