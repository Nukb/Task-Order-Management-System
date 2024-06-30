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
    public partial class ChangePass : Form
    {
        DBConnection dbcon = new DBConnection();
        string sql_str;
        string st_t;
        SqlCommand cdcom;
        SqlDataReader rdr;
        public ChangePass(string x)
        {
            InitializeComponent();
            User_name.Text = x;
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (password1.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة المرور", "خطأ إدخال");
                password1.Focus();
                return;
            }

            if (password2.Text == string.Empty)
            {
                MessageBox.Show("يجب إدخال كلمة المرور الجديدة", "خطأ إدخال");
                password2.Focus();
                return;
            }

            if (password2.Text.Length < 6)
            {
                MessageBox.Show("يجب أن تكون كلمة المرور أكبر من 6 أحرف", "خطأ إدخال");
                password2.Focus();
                return;
            }

            if (password3.Text == string.Empty)
            {
                MessageBox.Show("يجب تأكيد كلمة المرور الجديدة", "خطأ إدخال");
                password3.Focus();
                return;
            }

            if (password2.Text != password3.Text)
            {
                MessageBox.Show("كلمة المرور الجديدة غير متطابقة", "خطأ إدخال");
                password2.Focus();
                return;
            }

            sql_str = "SELECT [User_type] FROM [dbo].[Ta_Users] WHERE (Username=" + User_name.Text + ") AND (Password=" + password1.Text + ")";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            rdr = cdcom.ExecuteReader();

            if (rdr.Read() == true)
            {
                rdr.Close();
                cdcom.Dispose();
            }
            else
            {
                rdr.Close();
                cdcom.Dispose();
                MessageBox.Show("لديك حطأ في كلمة المرور", "خطأ إدخال");
                return;
            }

            sql_str = "UPDATE [dbo].[Ta_Users] SET [Password]=@p1 WHERE (Username=" + User_name.Text + ") AND (Password=" + password1.Text + ")";
            cdcom = new SqlCommand(sql_str, dbcon.conn_db());
            cdcom.Parameters.AddWithValue("@p1", password2.Text);
            cdcom.ExecuteNonQuery();

            dbcon.change_val_user("[Change_password]", "0", dbcon.NU_Emp_log);

            MessageBox.Show("تمت عملية تغيير كلمة المرور", "حفظ");
            this.Close();
        }
    }
}
