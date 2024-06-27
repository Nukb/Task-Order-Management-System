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
using WindowsFormsApp1.Datasets;
using WindowsFormsApp1.Reports;

namespace WindowsFormsApp1.Forms
{
    public partial class Report_Viewer : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlCommand cdcom;
        SqlDataReader rdr;
        string sql_str;
        DS1 d = new DS1();
        DataRow drr;
        byte flag_nu;
        DateTime d1;


        public Report_Viewer()
        {
            InitializeComponent();
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            //crystalReportViewer1.ReportSource = null;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (Task_order_textBox.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال رقم أمر العمل", "خطأ إدخال");
                Task_order_textBox.Focus();
                return;
            }
            flag_nu = 0;


            //Fill The Tables in The Dataset

            sql_str = "SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] ,[Na_emp] ,[Nu_Emp] ,[Nu_Jop] ,[Na_jop] FROM [dbo].[View_task_data] where (Nu_Task=" + Task_order_textBox.Text + ")";

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            d.Clear();

            if (rdr.Read() == true)
            {
                flag_nu = 1;
                drr = d.Tables["Main_Task"].NewRow();

                drr["Nu_Task"] = rdr["Nu_Task"];

                // Convert the type of Dates to String
                d1 = Convert.ToDateTime(rdr["Date_Task"]);
                drr["Date_Task"] = d1.ToString("yyyy-MM-dd");

                d1 = Convert.ToDateTime(rdr["Start_date"]);
                drr["Start_date"] = d1.ToString("yyyy-MM-dd");

                d1 = Convert.ToDateTime(rdr["End_date"]);
                drr["End_date"] = d1.ToString("yyyy-MM-dd");

                drr["Txt_Task"] = rdr["Txt_Task"];
                drr["Type_Task"] = rdr["Type_Task"];
                drr["Na_location"] = rdr["Na_location"];

                d.Tables["Main_Task"].Rows.Add(drr);
            }

            rdr.Close();
            cdcom.Dispose();


            sql_str = "SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] ,[Na_emp] ,[Nu_Emp] ,[Nu_Jop] ,[Na_jop] FROM [dbo].[View_task_data] where (Nu_Task=" + Task_order_textBox.Text + ")";

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();
            
            while (rdr.Read() == true)
            {
                drr = d.Tables["Pranch_Task"].NewRow();

                drr["Nu_Emp"] = rdr["Nu_Emp"];
                drr["Na_emp"] = rdr["Na_emp"];
                drr["Na_jop"] = rdr["Na_jop"];
                drr["Nu_Task"] = rdr["Nu_Task"];

                d.Tables["Pranch_Task"].Rows.Add(drr);


            }
            rdr.Close();
            cdcom.Dispose();

            if (flag_nu != 1)
            {
                MessageBox.Show("رقم أمر العمل غير موجود");
                return;
            }

            Task_Order_Report RPT1 = new Task_Order_Report();
            RPT1.SetDataSource(d);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = RPT1;
        }

        private void viewButton2_Click(object sender, EventArgs e)
        {
            string t1, t2;
            t1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            t2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            flag_nu = 0;
            sql_str = "SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] ,[Na_emp] ,[Nu_Emp] ,[Nu_Jop] ,[Na_jop] FROM [dbo].[View_task_data] where (Nu_Task=" + Task_order_textBox.Text + ")";


            sql_str = "SELECT [Aut_tab] ,[Nu_Task] ,[Date_Task] ,[Start_date] ,[End_date] ,[Nu_location] ,[Txt_Task] ,[Nu_Ty_task] ,[Nu_sta] ,[Type_Task] ,[Na_location] FROM [dbo].[View_main_task]  WHERE  (Date_Task BETWEEN '" + t1 + "' AND '" + t2 + "')";

            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            d.Clear();

            while (rdr.Read() == true)
            {
                flag_nu = 1;
                drr = d.Tables["Main_Task"].NewRow();

                drr["Nu_Task"] = rdr["Nu_Task"];
                d1 = Convert.ToDateTime(rdr["Date_Task"]);
                drr["Date_Task"] = d1.ToString("yyyy-MM-dd");



                d1 = Convert.ToDateTime(rdr["Start_date"]);
                drr["Start_date"] = d1.ToString("yyyy-MM-dd");



                d1 = Convert.ToDateTime(rdr["End_date"]);
                drr["End_date"] = d1.ToString("yyyy-MM-dd");


                drr["Txt_Task"] = rdr["Txt_Task"];
                drr["Type_Task"] = rdr["Type_Task"];
                drr["Na_location"] = rdr["Na_location"];

                d.Tables["Main_Task"].Rows.Add(drr);
            }
            rdr.Close();
            cdcom.Dispose();

            if (flag_nu != 1)
            {
                MessageBox.Show("لا يوجد بيانات خلال هذه الفترة");
                return;
            }

            Task_Order_Report_Date RPT1 = new Task_Order_Report_Date();

            RPT1.SetDataSource(d);
            RPT1.SetParameterValue("STR_date", t1);
            RPT1.SetParameterValue("END_date", t2);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = RPT1;
        }
    }
}
