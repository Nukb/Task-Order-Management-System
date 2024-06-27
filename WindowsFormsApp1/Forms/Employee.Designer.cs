
namespace WindowsFormsApp1.Forms
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.moreButton2 = new System.Windows.Forms.Button();
            this.moreButton1 = new System.Windows.Forms.Button();
            this.Na_location = new System.Windows.Forms.ComboBox();
            this.Nu_job = new System.Windows.Forms.ComboBox();
            this.na_Em = new System.Windows.Forms.TextBox();
            this.nu_Em = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nu_locationG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_JopG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nu_EmpG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_empG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_JopG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_locationG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.deleteButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_32;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(450, 11);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(152, 61);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_close_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(624, 10);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 62);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(796, 10);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(152, 62);
            this.newButton.TabIndex = 20;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(243, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 39);
            this.searchButton.TabIndex = 60;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.newButton);
            this.panel4.Location = new System.Drawing.Point(39, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1381, 87);
            this.panel4.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.searchButton);
            this.panel6.Controls.Add(this.searchOptions);
            this.panel6.Controls.Add(this.moreButton2);
            this.panel6.Controls.Add(this.moreButton1);
            this.panel6.Controls.Add(this.Na_location);
            this.panel6.Controls.Add(this.Nu_job);
            this.panel6.Controls.Add(this.na_Em);
            this.panel6.Controls.Add(this.nu_Em);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(704, 218);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(716, 488);
            this.panel6.TabIndex = 20;
            // 
            // searchOptions
            // 
            this.searchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptions.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.searchOptions.FormattingEnabled = true;
            this.searchOptions.Items.AddRange(new object[] {
            "الحرف الأول",
            "يحتوي على ",
            "الحرف الأخير"});
            this.searchOptions.Location = new System.Drawing.Point(146, 127);
            this.searchOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchOptions.Name = "searchOptions";
            this.searchOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchOptions.Size = new System.Drawing.Size(136, 32);
            this.searchOptions.TabIndex = 59;
            // 
            // moreButton2
            // 
            this.moreButton2.Location = new System.Drawing.Point(229, 283);
            this.moreButton2.Name = "moreButton2";
            this.moreButton2.Size = new System.Drawing.Size(53, 31);
            this.moreButton2.TabIndex = 58;
            this.moreButton2.Text = "...";
            this.moreButton2.UseVisualStyleBackColor = true;
            // 
            // moreButton1
            // 
            this.moreButton1.Location = new System.Drawing.Point(229, 203);
            this.moreButton1.Name = "moreButton1";
            this.moreButton1.Size = new System.Drawing.Size(53, 31);
            this.moreButton1.TabIndex = 57;
            this.moreButton1.Text = "...";
            this.moreButton1.UseVisualStyleBackColor = true;
            this.moreButton1.Click += new System.EventHandler(this.moreButton1_Click);
            // 
            // Na_location
            // 
            this.Na_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Na_location.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Na_location.FormattingEnabled = true;
            this.Na_location.Location = new System.Drawing.Point(288, 283);
            this.Na_location.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Na_location.Name = "Na_location";
            this.Na_location.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Na_location.Size = new System.Drawing.Size(277, 31);
            this.Na_location.TabIndex = 56;
            this.Na_location.SelectedIndexChanged += new System.EventHandler(this.Na_location_SelectedIndexChanged);
            // 
            // Nu_job
            // 
            this.Nu_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nu_job.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Nu_job.FormattingEnabled = true;
            this.Nu_job.Location = new System.Drawing.Point(288, 203);
            this.Nu_job.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nu_job.Name = "Nu_job";
            this.Nu_job.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Nu_job.Size = new System.Drawing.Size(277, 31);
            this.Nu_job.TabIndex = 55;
            this.Nu_job.SelectedIndexChanged += new System.EventHandler(this.Nu_job_SelectedIndexChanged);
            // 
            // na_Em
            // 
            this.na_Em.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.na_Em.Location = new System.Drawing.Point(288, 127);
            this.na_Em.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.na_Em.Name = "na_Em";
            this.na_Em.Size = new System.Drawing.Size(274, 30);
            this.na_Em.TabIndex = 54;
            this.na_Em.TextChanged += new System.EventHandler(this.na_Em_TextChanged);
            // 
            // nu_Em
            // 
            this.nu_Em.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.nu_Em.Location = new System.Drawing.Point(317, 47);
            this.nu_Em.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nu_Em.Name = "nu_Em";
            this.nu_Em.Size = new System.Drawing.Size(244, 30);
            this.nu_Em.TabIndex = 53;
            this.nu_Em.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(585, 283);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "مكان العمل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(601, 206);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "الوظيفة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(576, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "اسم الموظف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(581, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "رقم الموظف:";
            // 
            // Nu_locationG
            // 
            this.Nu_locationG.HeaderText = "رقم مكان العمل";
            this.Nu_locationG.MinimumWidth = 6;
            this.Nu_locationG.Name = "Nu_locationG";
            this.Nu_locationG.ReadOnly = true;
            this.Nu_locationG.Visible = false;
            // 
            // Nu_JopG
            // 
            this.Nu_JopG.HeaderText = "رقم الوظيفة";
            this.Nu_JopG.MinimumWidth = 6;
            this.Nu_JopG.Name = "Nu_JopG";
            this.Nu_JopG.ReadOnly = true;
            this.Nu_JopG.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 17);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 875);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(39, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 488);
            this.panel5.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nu_EmpG,
            this.Na_empG,
            this.Na_JopG,
            this.Na_locationG,
            this.Nu_JopG,
            this.Nu_locationG});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(657, 486);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Nu_EmpG
            // 
            this.Nu_EmpG.HeaderText = "رقم الموظف";
            this.Nu_EmpG.MinimumWidth = 6;
            this.Nu_EmpG.Name = "Nu_EmpG";
            this.Nu_EmpG.ReadOnly = true;
            // 
            // Na_empG
            // 
            this.Na_empG.HeaderText = "اسم الموظف";
            this.Na_empG.MinimumWidth = 6;
            this.Na_empG.Name = "Na_empG";
            this.Na_empG.ReadOnly = true;
            // 
            // Na_JopG
            // 
            this.Na_JopG.HeaderText = "الوظيفة";
            this.Na_JopG.MinimumWidth = 6;
            this.Na_JopG.Name = "Na_JopG";
            this.Na_JopG.ReadOnly = true;
            // 
            // Na_locationG
            // 
            this.Na_locationG.HeaderText = "مكان العمل";
            this.Na_locationG.MinimumWidth = 6;
            this.Na_locationG.Name = "Na_locationG";
            this.Na_locationG.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.title.Location = new System.Drawing.Point(606, 98);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(170, 35);
            this.title.TabIndex = 3;
            this.title.Text = "بيانات الموظفين";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1089, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 195);
            this.panel3.TabIndex = 1;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الموظفين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.Button moreButton2;
        private System.Windows.Forms.Button moreButton1;
        private System.Windows.Forms.ComboBox Na_location;
        private System.Windows.Forms.ComboBox Nu_job;
        private System.Windows.Forms.TextBox na_Em;
        private System.Windows.Forms.TextBox nu_Em;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_locationG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_JopG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_EmpG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_empG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_JopG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_locationG;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
    }
}