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
    public partial class Task_order : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        string sql_str;
        string st_t;
        ListBox listTemp_Nu_ty_task = new ListBox();
        ListBox listTemp_Nu_loc = new ListBox();
        ListBox listTemp_Nu_Emp = new ListBox();
        byte flag_st;
        public Task_order()
        {
            InitializeComponent();
        }

        private void Task_order_Load(object sender, EventArgs e)
        {
            fill_combo("SELECT [Type_Task],[Nu_Ty_task] FROM[dbo].[Ta_Type_Task]", Type_Task, listTemp_Nu_ty_task);
            fill_combo("SELECT [Na_location],[Nu_location]  FROM [dbo].[Ta_Struct]", Na_location, listTemp_Nu_loc);
            searchOptions.SelectedIndex = 0;
            Date_Task.Value = DateTime.Now;
            Start_date.Value = DateTime.Now;
            End_date.Value = DateTime.Now;
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
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = rdr["Nu_Emp"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = rdr["Na_emp"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = rdr["Na_jop"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = rdr["Na_location"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = rdr["Nu_jop"];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = rdr["Nu_location"];
            }
            rdr.Close();
            cdcom.Dispose();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            searchOptions.SelectedIndex = 0;
            Aut_tab.Clear();
            Nu_Task.Clear();
            Text_Task.Clear();
            name_Emp.Clear();
            Num_Emp.Clear();
            Type_Task.SelectedIndex = -1;
            Na_location.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            fill_combo("SELECT [Type_Task],[Nu_Ty_task] FROM[dbo].[Ta_Type_Task]", Type_Task, listTemp_Nu_ty_task);
            fill_combo("SELECT [Na_location],[Nu_location]  FROM [dbo].[Ta_Struct]", Na_location, listTemp_Nu_loc);
        }

        private void name_Emp_TextChanged(object sender, EventArgs e)
        {
            if (flag_st != 1)
            {

                if (name_Emp.Text != string.Empty)
                {
                    if (searchOptions.SelectedIndex == 0)
                    {
                        st_t = "WHERE (Na_emp LIKE N'" + name_Emp.Text + "%')";
                    }
                    else if (searchOptions.SelectedIndex == 1)
                    {
                        st_t = "WHERE (Na_emp LIKE N'%" + name_Emp.Text + "%')";
                    }
                    else if (searchOptions.SelectedIndex == 2)
                    {
                        st_t = "WHERE (Na_emp LIKE N'%" + name_Emp.Text + "')";
                    }

                    fill_listSearch(st_t);
                }

                else
                {
                    showListBox.Visible = false;
                }
            }
        }

        private void showListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTemp_Nu_Emp.SelectedIndex = showListBox.SelectedIndex;

            if (showListBox.SelectedIndex != -1)
            {
                flag_st = 1;
                name_Emp.Text = showListBox.Text;
                flag_st = 0;
                Num_Emp.Text = listTemp_Nu_Emp.Text;
                showListBox.Visible = false;
            }
        }

        private void fill_listSearch(string wherest)
        {
            sql_str = "SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data]" + wherest;
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            showListBox.Items.Clear();
            listTemp_Nu_Emp.Items.Clear();

            while (rdr.Read() == true)
            {
                showListBox.Visible = true;
                showListBox.Items.Add(rdr.GetValue(2));
                listTemp_Nu_Emp.Items.Add(rdr.GetValue(1));
            }
            rdr.Close();
            cdcom.Dispose();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (Nu_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم أمر العمل", "خطأ إدخال");
                Nu_Task.Focus();
                return;
            }
            sql_str = "SELECT [Nu_Emp],[Na_emp],[Na_jop],[Na_location],[Nu_Jop],[Nu_location],[Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] FROM [dbo].[View_task_data] WHERE (Nu_Task=" + Nu_Task.Text + ")";


            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (rdr.Read() == true)
            {
                flag_st = 1;
                Aut_tab.Text = Convert.ToString(rdr["Aut_tab"]);
                Date_Task.Text = Convert.ToString(rdr["Date_Task"]);
                Start_date.Text = Convert.ToString(rdr["Start_date"]);
                End_date.Text = Convert.ToString(rdr["End_date"]);
                Type_Task.Text = Convert.ToString(rdr["Type_Task"]);
                Na_location.Text = Convert.ToString(rdr["Na_location"]);
                Text_Task.Text = Convert.ToString(rdr["Txt_Task"]);
                name_Emp.Text = Convert.ToString(rdr["Na_emp"]);
                Num_Emp.Text = Convert.ToString(rdr["Nu_Emp"]);
                flag_st = 0;
            }
            else
            {
                Aut_tab.Clear();
                name_Emp.Clear();
                MessageBox.Show("الرقم غير موجود", "البحث برقم أمر العمل");
                Num_Emp.Focus();
            }
            rdr.Close();
            cdcom.Dispose();

            fill_grid("SELECT [Nu_Emp],[Na_emp],[Na_jop],[Na_location],[Nu_Jop],[Nu_location],[Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] FROM [dbo].[View_task_data] WHERE (Nu_Task=" + Nu_Task.Text + ")", 0);
        }

        private void listAddButton_Click(object sender, EventArgs e)
        {
            if (Num_Emp.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                Num_Emp.Focus();
                return;
            }

            if (name_Emp.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال اسم الموظف", "خطأ إدخال");
                name_Emp.Focus();
                return;
            }

            //-for- to test if the number of emploeey is added to database and dataGridView already
            flag_st = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                if (Num_Emp.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    flag_st = 1;

                }
                if (flag_st == 1)
                {
                    // the number of emploeey is found so Exite from -for- we do not need to add it again
                    return;
                }
            }

            if (flag_st == 0)
            {

                fill_grid("SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data] WHERE (Nu_Emp=" + Num_Emp.Text + ")", 1);
            }
        }

        private void IDsearchButton_Click(object sender, EventArgs e)
        {
            if (Num_Emp.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم الموظف", "خطأ إدخال");
                Num_Emp.Focus();
                return;
            }

            sql_str = "SELECT [Aut_tab] ,[Nu_Emp] ,[Na_emp] ,[Nu_Jop] ,[Nu_location] ,[Na_jop] ,[Na_location] FROM [dbo].[View_emp_data] WHERE (Nu_Emp=" + Num_Emp.Text + ")";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (rdr.Read() == true)
            {
                flag_st = 1;
                name_Emp.Text = Convert.ToString(rdr.GetValue(2));
                flag_st = 0;
            }
            else
            {
                name_Emp.Clear();
                MessageBox.Show("الرقم غير موجود", "البحث برقم موظف");
                Num_Emp.Focus();
            }
            rdr.Close();
            cdcom.Dispose();
        }

        // function used to create general combobox according to SELECT Querey
        private void fill_combo(string stSQL, ComboBox fill_com, ListBox fill_list)
        {
            //fill_com = new ComboBox();

            cdcom = new SqlCommand(stSQL, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            fill_com.Items.Clear();
            fill_list.Items.Clear();

            while (rdr.Read() == true)
            {
                fill_com.Items.Add(rdr.GetValue(0));
                fill_list.Items.Add(rdr.GetValue(1));
            }

            rdr.Close();
            cdcom.Dispose();
            // return fill_combo;
        }

        private void Type_Task_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTemp_Nu_ty_task.SelectedIndex = Type_Task.SelectedIndex;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Nu_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم أمر العمل", "خطأ إدخال");
                Nu_Task.Focus();
                return;
            }
            if (Type_Task.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار المهمة", "خطأ إدخال");
                Type_Task.Focus();
                return;
            }
            if (Na_location.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار موقع العمل", "خطأ إدخال");
                Na_location.Focus();
                return;
            }
            if (Text_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال العمل المطلوب انجازه", "خطأ إدخال");
                Text_Task.Focus();
                return;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("يجب اختيار الموظفين", "خطأ إدخال");
                Num_Emp.Focus();
                return;
            }

            if (Aut_tab.Text == string.Empty)
            {
                sql_str = "INSERT INTO [dbo].[Ta_Main_Task] ([Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.Parameters.AddWithValue("@p1", Nu_Task.Text);
                cdcom.Parameters.AddWithValue("@p2", Date_Task.Value.Date);
                cdcom.Parameters.AddWithValue("@p3", Start_date.Value.Date);
                cdcom.Parameters.AddWithValue("@p4", End_date.Value.Date);
                cdcom.Parameters.AddWithValue("@p5", listTemp_Nu_loc.Text);
                cdcom.Parameters.AddWithValue("@p6", Text_Task.Text);
                cdcom.Parameters.AddWithValue("@p7", listTemp_Nu_ty_task.Text);
                cdcom.Parameters.AddWithValue("@p8", 1);
                cdcom.ExecuteNonQuery();
                //newButton_Click(sender, e);

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {

                    sql_str = "INSERT INTO [dbo].[Ta_Pranch_Task] ([Nu_Task] ,[Nu_Emp]) VALUES (@p1,@p2)";
                    cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                    cdcom.Parameters.AddWithValue("@p1", Nu_Task.Text);
                    cdcom.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[0].Value);
                    cdcom.ExecuteNonQuery();
                    //newButton_Click(sender, e);
                }
                MessageBox.Show("تم الحفظ بنجاح", "حفظ");

            }
            else
            {
                sql_str = "UPDATE [dbo].[Ta_Main_Task] SET [Date_Task]=@p2 ,[Start_date]=@p3 ,[End_date]=@p4 ,[Nu_location]=@p5 ,[Txt_Task]=@p6 ,[Nu_Ty_task]=@p7 ,[Nu_sta]=@p8 WHERE (Nu_Task=" + Nu_Task.Text + ")";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                // cdcom.Parameters.AddWithValue("@p1", Num_Emp.Text);
                cdcom.Parameters.AddWithValue("@p2", Date_Task.Value.Date);
                cdcom.Parameters.AddWithValue("@p3", Start_date.Value.Date);
                cdcom.Parameters.AddWithValue("@p4", End_date.Value.Date);
                cdcom.Parameters.AddWithValue("@p5", listTemp_Nu_loc.Text);
                cdcom.Parameters.AddWithValue("@p6", Text_Task.Text);
                cdcom.Parameters.AddWithValue("@p7", listTemp_Nu_ty_task.Text);
                cdcom.Parameters.AddWithValue("@p8", 1);
                cdcom.ExecuteNonQuery();
                //newButton_Click(sender, e);

                //we need to delete all items in grid and re-fill it again with updates
                sql_str = "DELETE FROM [dbo].[Ta_Pranch_Task] WHERE (Nu_Task=" + Nu_Task.Text + ")";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.ExecuteNonQuery();

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {

                    sql_str = "INSERT INTO [dbo].[Ta_Pranch_Task] ([Nu_Task] ,[Nu_Emp]) VALUES (@p1,@p2)";
                    cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                    cdcom.Parameters.AddWithValue("@p1", Nu_Task.Text);
                    cdcom.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[0].Value);
                    cdcom.ExecuteNonQuery();
                    //newButton_Click(sender, e);
                }
                MessageBox.Show("تم تعديل البيانات بنجاح", "تعديل");
            }

            newButton_Click(sender, e);
        }

        private void Na_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTemp_Nu_loc.SelectedIndex = Na_location.SelectedIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("لا يمكن حذف بيانات الموظف من أمر العمل", "تنبيه");
                return;
            }

            if (e.ColumnIndex == 6)
            {

                if (MessageBox.Show("هل تريد حذف بيانات الموظف؟", "حذف بيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql_str = "DELETE FROM [dbo].[Ta_Pranch_Task] WHERE (Nu_Task=" + Nu_Task.Text + ") AND( Nu_Emp =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + ")";
                    cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                    cdcom.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Aut_tab.Text == string.Empty)
            {
                return;
            }

            if (Nu_Task.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم أمر العمل", "خطأ إدخال");
                Nu_Task.Focus();
                return;
            }

            if (MessageBox.Show("هل تريد حذف بيانات أمر العمل؟", "حذف بيانات", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql_str = "DELETE FROM [dbo].[Ta_Main_Task] WHERE (Nu_Task=" + Nu_Task.Text + ")";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.ExecuteNonQuery();


                sql_str = "DELETE FROM [dbo].[Ta_Pranch_Task] WHERE (Nu_Task=" + Nu_Task.Text + ")";
                cdcom = new SqlCommand(sql_str, dbcon.conn_db());
                cdcom.ExecuteNonQuery();
                newButton_Click(sender, e);

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Report_Viewer r = new Report_Viewer();
            r.ShowDialog();
        }
    }
}
