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
using WindowsFormsApp1.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        DBConnection dbcon = new DBConnection();
        string sql_str;
        string st_t;
        SqlCommand cdcom;
        SqlDataReader rdr;
        int flag_login;
        byte change_pass, re_ch_pass;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            loginpanel.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            title.Visible = false;
            aboutpanel.Visible = false;
            settingpanel.Visible = false;
            datapanel.Visible = false;
            querypanel.Visible = false;
            taskgridpanel.Visible = false;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            aboutpanel.Visible = true;
            settingpanel.Visible = false;
            datapanel.Visible = false;
            loginpanel.Visible = false;
            querypanel.Visible = false;
            taskgridpanel.Visible = false;

        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            settingpanel.Visible = true;
            aboutpanel.Visible = false;
            datapanel.Visible = false;
            loginpanel.Visible = false;
            querypanel.Visible = false;
            taskgridpanel.Visible = false;

        }

        private void empdata_Click(object sender, EventArgs e)
        {
            Employee m = new Employee();
            m.ShowDialog();
        }

        private void tasktypebutton_Click(object sender, EventArgs e)
        {
            Task_Type t = new Task_Type();
            t.ShowDialog();
        }

        private void jopsbutton_Click(object sender, EventArgs e)
        {
            Jobs j= new Jobs();
            j.ShowDialog();
        }

        private void taskbutton_Click(object sender, EventArgs e)
        {
            Task_order t = new Task_order();
            t.ShowDialog();
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            ChangePass c = new ChangePass(dbcon.NA_Emp_log);
            c.ShowDialog();
        }

        private void powerbutton_Click(object sender, EventArgs e)
        {
            Power_User u = new Power_User();
            u.ShowDialog();
        }

        private void usersbutton_Click(object sender, EventArgs e)
        {
            Users u2 = new Users();
            u2.ShowDialog();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            querypanel.Visible = true;
            datapanel.Visible = false;
            settingpanel.Visible = false;
            aboutpanel.Visible = false;
            loginpanel.Visible = false;
            taskgridpanel.Visible = false;

        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            View_Tasks v = new View_Tasks();
            v.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (username.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم المستخدم", "خطأ إدخال");
                username.Focus();
                return;
            }

            if (password.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة المرور", "خطأ إدخال");
                password.Focus();
                return;
            }

            if (flag_login <= 2)
            {
                sql_str = "SELECT [Aut_tab], [Nu_Emp], [Username] ,[Password], [Active_state], [Expire_password], [Change_password], [Re_change], [User_power] FROM [dbo].[Ta_Users] WHERE (Username=@p1) AND (Password=@p2)";

                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", usernamelogin.Text);
                cdcom.Parameters.AddWithValue("@p2", passwordlogin.Text);
                rdr = cdcom.ExecuteReader();

                dbcon.NU_Emp_log = 0;

                if (rdr.Read() == true)
                {
                                                     
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    title.Visible = true;
                    taskgridpanel.Visible = true;
                    loginpanel.Visible = false;
                    panel2.BringToFront ();
                    name.Text = Convert.ToString(rdr["Username"]);

                    change_pass = Convert.ToByte(rdr["Change_password"]);
                    re_ch_pass = Convert.ToByte(rdr["Re_change"]);
                    dbcon.NU_Emp_log = Convert.ToInt32(rdr["Nu_Emp"]);
                    dbcon.User_Power = Convert.ToString(rdr["User_power"]);
                    dbcon.NA_Emp_log = name.Text;

                    rdr.Close();
                    cdcom.Dispose();

                    dbcon.change_val_user("[User_state]", "1", dbcon.NU_Emp_log);



                    // This code to give permissions depending to the power Chain

                    if (dbcon.User_Power.Substring(1, 1) == "1")
                    {
                        mytaskbutton.Enabled = true;
                    }
                    else
                    {
                        mytaskbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(2, 1) == "1")
                    {
                        databutton.Enabled = true;
                    }
                    else
                    {
                        databutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(3, 1) == "1")
                    {
                        taskbutton.Enabled = true;
                    }
                    else
                    {
                        taskbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(4, 1) == "1")
                    {
                        viewbutton.Enabled = true;
                    }
                    else
                    {
                        viewbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(5, 1) == "1")
                    {
                        setting_button.Enabled = true;
                    }
                    else
                    {
                        setting_button.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(6, 1) == "1")
                    {
                        querybutton.Enabled = true;
                    }
                    else
                    {
                        querybutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(7, 1) == "1")
                    {
                        empdata.Enabled = true;
                    }
                    else
                    {
                        empdata.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(8, 1) == "1")
                    {
                        tasktypebutton.Enabled = true;
                    }
                    else
                    {
                        tasktypebutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(9, 1) == "1")
                    {
                        branchbutton.Enabled = true;
                    }
                    else
                    {
                        branchbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(10, 1) == "1")
                    {
                        jopsbutton.Enabled = true;
                    }
                    else
                    {
                        jopsbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(11, 1) == "1")
                    {
                        powerbutton.Enabled = true;
                    }
                    else
                    {
                        powerbutton.Enabled = false;
                    }
                    if (dbcon.User_Power.Substring(12, 1) == "1")
                    {
                        powerbutton.Enabled = true;
                    }
                    else
                    {
                        powerbutton.Enabled = false;
                    }
                    

                    if (change_pass == 1)
                    {
                        ChangePass ch = new ChangePass(dbcon.NA_Emp_log);
                        ch.Show();
                    }


                }
                else
                {
                    rdr.Close();
                    cdcom.Dispose();
                    flag_login += 1;
                    MessageBox.Show("خطأ في كلمة الإدخال أو اسم المستخدم", "خطأ تسجيل دخول");
                    return;
                }

                rdr.Close();
                cdcom.Dispose();

                fill_grid("SELECT [Na_emp] ,[Na_jop] ,[Na_location] ,[Nu_Jop] ,[Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Txt_Task] ,[Type_Task] ,[Nu_location] ,[Nu_Ty_task] ,[Nu_sta] ,[Nu_Emp] FROM [dbo].[View_task_data] WHERE (Nu_Emp=" + dbcon.NU_Emp_log + ") AND (Nu_sta=" + 1 + ")", 0);

            }
            else
            {
                MessageBox.Show("خطأ في تسجيل الدخول: استنفذت جميع المحاولات", "خطأ تسجيل دخول");
                this.Close();
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            sql_str = "UPDATE [dbo].[Ta_Users] SET [User_state]=@p1 WHERE (Nu_Emp=" + dbcon.NU_Emp_log + ")";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            cdcom.Parameters.AddWithValue("@p1", 0);
            cdcom.ExecuteNonQuery();

            dbcon.NU_Emp_log = 0;
            //dataGridView1.Rows.Clear();
            usernamelogin.Clear();
            passwordlogin.Clear();
            name.Text = "";
            loginpanel.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            title.Visible = false;
            aboutpanel.Visible = false;
            settingpanel.Visible = false;
            datapanel.Visible = false;
            querypanel.Visible = false;
            taskgridpanel.Visible = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
           sql_str = "UPDATE [dbo].[Ta_Users] SET [User_state]=@p1 WHERE (Nu_Emp=" + dbcon.NU_Emp_log + ")";
           cdcom = new SqlCommand(sql_str, dbcon.conn_db());
           cdcom.Parameters.AddWithValue("@p1", 0);
           cdcom.ExecuteNonQuery();

               //// Save changes logic (if applicable)
               // DateTime d1 = DateTime.Now;
               // sql_str = "BACKUP DATABASE [DATATASKMA] TO DISK = D:/Backups/MyDatabaseBackup" + d1.ToString("dd-MM-yyyy") + ".bak";
               // SqlCommand command = new SqlCommand(sql_str, dbcon.conn_db());
               // command.ExecuteNonQuery();
               // MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح", "حفظ");
                             
        }

        private void mytaskbutton_Click(object sender, EventArgs e)
        {
            taskgridpanel.Visible = true;
        }

        private void databutton_Click(object sender, EventArgs e)
        {
            datapanel.Visible = true;
            settingpanel.Visible = false;
            aboutpanel.Visible = false;
            loginpanel.Visible = false;
            querypanel.Visible = false;
            taskgridpanel.Visible = false;

        }

        private void backup_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Replace "YourDatabaseName" with your actual value
                string databaseName = "DATATASKMA";
                string backupFileName = $"{databaseName}_{DateTime.Now:yyyy/MM/dd_(HH:mm:ss)}.bak";
                string backupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB Backup2", backupFileName);
                //C:\\Users\\AL DALEL\\VStudio Files Nuha\\Task Order Managment System\\DB Backup

                // Build the backup command
                string backupCommand = $"BACKUP DATABASE [{databaseName}] TO  DISK = N'{backupPath}' WITH FORMAT";

                // Use DBConnection class for connection and command execution
                DBConnection dbConnection = new DBConnection();
                SqlConnection connection = dbConnection.conn_db();

                // Execute the backup command
                cdcom = new SqlCommand(backupCommand, dbcon.conn_db());
                rdr = cdcom.ExecuteReader();
                rdr.Close();

                MessageBox.Show($"تم النسخ الاحتياطي لقاعدة البيانات إلى {backupPath} بنجاح", "نجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء backup قاعدة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            Report_Viewer r = new Report_Viewer();
            r.ShowDialog();
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


            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = rdr["Txt_Task"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr["Nu_Task"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = rdr["Aut_tab"];
            }
            rdr.Close();
            cdcom.Dispose();
        }

    }
}
