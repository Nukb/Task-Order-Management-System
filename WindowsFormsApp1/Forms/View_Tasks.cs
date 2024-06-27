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
    public partial class View_Tasks : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        string sql_str;
        int row_index;

        public View_Tasks()
        {
            InitializeComponent();
        }

        private void View_Tasks_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                comboMonth1.Items.Add(i);
                comboMonth2.Items.Add(i);
            }
            comboMonth1.Text = Convert.ToString(DateTime.Now.Month);
            comboMonth2.Text = Convert.ToString(DateTime.Now.Month);
            YearUpDown1.Value = DateTime.Now.Year;
            YearUpDown2.Value = DateTime.Now.Year;
            YearUpDown3.Value = DateTime.Now.Year;
        }

        private void fill_grid(string sql_TS, byte fl_cl)

        {
            sql_str = sql_TS;
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (fl_cl == 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView1.Rows.Clear();
                row_index = -1;
            }


            while (rdr.Read() == true)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = rdr["Nu_Task"];
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[1].Value = Convert.ToDateTime(rdr["Date_Task"]).ToString("dd-MM-yyyy");
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[2].Value = Convert.ToDateTime(rdr["Start_date"]).ToString("dd-MM-yyyy");
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[3].Value = Convert.ToDateTime(rdr["End_date"]).ToString("dd-MM-yyyy");
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[4].Value = rdr["Na_location"];
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[5].Value = rdr["Txt_Task"];
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[6].Value = rdr["Type_Task"];
            }
            rdr.Close();
            cdcom.Dispose();
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            if (comboMonth1.SelectedIndex != -1)
            {
                //SelectedIndex+1 because the index begin at -1 (Empty item)
                fill_grid("SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task] WHERE (MONTH(Date_Task) =" + comboMonth1.Text + ")", 0);
            }
        }

        private void searchButton3_Click(object sender, EventArgs e)
        {
            fill_grid("SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task] WHERE (YEAR(Date_Task) =" + YearUpDown1.Value + ")", 0);
        }

        string t1, t2;

        private void searchButton4_Click(object sender, EventArgs e)
        {
            DateTime d1, d2;
            int year = Convert.ToInt16(YearUpDown2.Value);

            if (comboQuarter.SelectedIndex != -1)
            {
                switch (comboQuarter.SelectedIndex)
                {
                    case 0:
                        d1 = new DateTime(year, 1, 1);
                        d2 = new DateTime(year, 3, 31);
                        t1 = d1.ToString("MM-dd-yyyy");
                        t2 = d2.ToString("MM-dd-yyyy");
                        break;

                    case 1:
                        d1 = new DateTime(year, 4, 1);
                        d2 = new DateTime(year, 6, 30);
                        t1 = d1.ToString("MM-dd-yyyy");
                        t2 = d2.ToString("MM-dd-yyyy");
                        break;

                    case 2:
                        d1 = new DateTime(year, 7, 1);
                        d2 = new DateTime(year, 9, 30);
                        t1 = d1.ToString("MM-dd-yyyy");
                        t2 = d2.ToString("MM-dd-yyyy");
                        break;

                    case 3:
                        d1 = new DateTime(year, 10, 1);
                        d2 = new DateTime(year, 12, 31);
                        t1 = d1.ToString("MM-dd-yyyy");
                        t2 = d2.ToString("MM-dd-yyyy");
                        break;
                }
                fill_grid("SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task] WHERE (Date_Task BETWEEN '" + t1 + "' AND '" + t2 + "')", 0);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fill_grid1(sql_str = "SELECT [Na_emp] ,[Na_jop] ,[Na_location] ,[Nu_Jop] ,[Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Txt_Task] ,[Type_Task] ,[Nu_location] ,[Nu_Ty_task] ,[Nu_sta] ,[Nu_Emp] FROM[dbo].[View_task_data] WHERE(Nu_Task = " + dataGridView2.Rows[e.RowIndex].Cells[0].Value + ")", 0);

                row_index = e.RowIndex;

            }
        }

        private void searchButton6_Click(object sender, EventArgs e)
        {
            if (comboMonth2.SelectedIndex != -1)
            {
                //SelectedIndex+1 because the index begin at -1 (Empty item)
                fill_grid("SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task] WHERE (MONTH(Date_Task) = " + comboMonth2.Text + ")AND (YEAR(Date_Task) = " + YearUpDown3.Value + ")", 0);
            }
        }

        private void searchButton5_Click(object sender, EventArgs e)
        {
            string t1, t2;
            t1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            t2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");


            fill_grid("SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task] WHERE (Date_Task BETWEEN '" + t1 + "' AND '" + t2 + "')", 0);
        }

        private void fill_grid1(string sql_TS, byte fl_cl)
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


    }
}
