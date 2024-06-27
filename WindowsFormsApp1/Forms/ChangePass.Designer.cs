
namespace WindowsFormsApp1.Forms
{
    partial class ChangePass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.password2 = new System.Windows.Forms.TextBox();
            this.pass2label = new System.Windows.Forms.Label();
            this.password3 = new System.Windows.Forms.TextBox();
            this.pass3label = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.pass1label = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.User_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // password2
            // 
            this.password2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password2.Location = new System.Drawing.Point(231, 226);
            this.password2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password2.MaxLength = 12;
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(223, 30);
            this.password2.TabIndex = 45;
            this.password2.UseSystemPasswordChar = true;
            // 
            // pass2label
            // 
            this.pass2label.AutoSize = true;
            this.pass2label.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.pass2label.Location = new System.Drawing.Point(313, 91);
            this.pass2label.Name = "pass2label";
            this.pass2label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pass2label.Size = new System.Drawing.Size(146, 24);
            this.pass2label.TabIndex = 46;
            this.pass2label.Text = "كلمة المرور الجديدة:";
            // 
            // password3
            // 
            this.password3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password3.Location = new System.Drawing.Point(231, 288);
            this.password3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password3.MaxLength = 12;
            this.password3.Name = "password3";
            this.password3.PasswordChar = '*';
            this.password3.Size = new System.Drawing.Size(223, 30);
            this.password3.TabIndex = 43;
            this.password3.UseSystemPasswordChar = true;
            // 
            // pass3label
            // 
            this.pass3label.AutoSize = true;
            this.pass3label.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.pass3label.Location = new System.Drawing.Point(323, 153);
            this.pass3label.Name = "pass3label";
            this.pass3label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pass3label.Size = new System.Drawing.Size(130, 24);
            this.pass3label.TabIndex = 44;
            this.pass3label.Text = "تأكيد كلمة المرور:";
            // 
            // password1
            // 
            this.password1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password1.Location = new System.Drawing.Point(231, 160);
            this.password1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password1.MaxLength = 12;
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(223, 30);
            this.password1.TabIndex = 41;
            this.password1.UseSystemPasswordChar = true;
            // 
            // pass1label
            // 
            this.pass1label.AutoSize = true;
            this.pass1label.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.pass1label.Location = new System.Drawing.Point(348, 31);
            this.pass1label.Name = "pass1label";
            this.pass1label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pass1label.Size = new System.Drawing.Size(95, 24);
            this.pass1label.TabIndex = 42;
            this.pass1label.Text = "كلمة المرور:";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.usernamelabel.Location = new System.Drawing.Point(98, 69);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernamelabel.Size = new System.Drawing.Size(104, 24);
            this.usernamelabel.TabIndex = 40;
            this.usernamelabel.Text = "اسم المستخدم:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pass1label);
            this.groupBox1.Controls.Add(this.pass2label);
            this.groupBox1.Controls.Add(this.pass3label);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 211);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(600, 17);
            this.panel1.TabIndex = 50;
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_close_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(201, 387);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 62);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // User_name
            // 
            this.User_name.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.User_name.Location = new System.Drawing.Point(231, 66);
            this.User_name.Name = "User_name";
            this.User_name.ReadOnly = true;
            this.User_name.Size = new System.Drawing.Size(223, 30);
            this.User_name.TabIndex = 49;
            this.User_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 518);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password3);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير كلمة المرور";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label pass2label;
        private System.Windows.Forms.TextBox password3;
        private System.Windows.Forms.Label pass3label;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label pass1label;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox User_name;
    }
}