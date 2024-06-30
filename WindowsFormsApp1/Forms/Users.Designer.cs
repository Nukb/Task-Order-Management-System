
namespace WindowsFormsApp1.Forms
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.na_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Aut_tab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nu_EmpG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_empG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.na_Em = new System.Windows.Forms.TextBox();
            this.nu_Em = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Active_state = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.change_pass = new System.Windows.Forms.CheckBox();
            this.exp_pass = new System.Windows.Forms.CheckBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_close_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(483, 14);
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
            this.newButton.Location = new System.Drawing.Point(690, 14);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(152, 62);
            this.newButton.TabIndex = 20;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.newButton);
            this.panel4.Location = new System.Drawing.Point(39, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1381, 87);
            this.panel4.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 17);
            this.panel1.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.title.Location = new System.Drawing.Point(589, 97);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(194, 35);
            this.title.TabIndex = 3;
            this.title.Text = "بيانات المستخدمين";
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
            // na_textBox
            // 
            this.na_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.na_textBox.Location = new System.Drawing.Point(83, 56);
            this.na_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.na_textBox.Name = "na_textBox";
            this.na_textBox.ReadOnly = true;
            this.na_textBox.Size = new System.Drawing.Size(349, 30);
            this.na_textBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(332, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "اسم الموظف";
            // 
            // num_textBox
            // 
            this.num_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.num_textBox.Location = new System.Drawing.Point(482, 56);
            this.num_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.ReadOnly = true;
            this.num_textBox.Size = new System.Drawing.Size(131, 30);
            this.num_textBox.TabIndex = 25;
            this.num_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(506, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم الموظف";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Aut_tab);
            this.panel5.Controls.Add(this.na_textBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.num_textBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(39, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 132);
            this.panel5.TabIndex = 22;
            // 
            // Aut_tab
            // 
            this.Aut_tab.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Aut_tab.Location = new System.Drawing.Point(23, 10);
            this.Aut_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Aut_tab.Name = "Aut_tab";
            this.Aut_tab.ReadOnly = true;
            this.Aut_tab.Size = new System.Drawing.Size(102, 30);
            this.Aut_tab.TabIndex = 30;
            this.Aut_tab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aut_tab.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(584, 74);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "اسم الموظف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nu_EmpG,
            this.Na_empG});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(725, 353);
            this.dataGridView1.TabIndex = 61;
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
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.searchButton);
            this.panel6.Controls.Add(this.searchOptions);
            this.panel6.Controls.Add(this.na_Em);
            this.panel6.Controls.Add(this.nu_Em);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(704, 218);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(716, 488);
            this.panel6.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(225, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 39);
            this.searchButton.TabIndex = 60;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.searchOptions.Location = new System.Drawing.Point(145, 74);
            this.searchOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchOptions.Name = "searchOptions";
            this.searchOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchOptions.Size = new System.Drawing.Size(136, 32);
            this.searchOptions.TabIndex = 59;
            // 
            // na_Em
            // 
            this.na_Em.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.na_Em.Location = new System.Drawing.Point(287, 74);
            this.na_Em.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.na_Em.Name = "na_Em";
            this.na_Em.Size = new System.Drawing.Size(274, 30);
            this.na_Em.TabIndex = 54;
            this.na_Em.TextChanged += new System.EventHandler(this.na_Em_TextChanged);
            // 
            // nu_Em
            // 
            this.nu_Em.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.nu_Em.Location = new System.Drawing.Point(288, 18);
            this.nu_Em.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nu_Em.Name = "nu_Em";
            this.nu_Em.Size = new System.Drawing.Size(273, 30);
            this.nu_Em.TabIndex = 53;
            this.nu_Em.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(581, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "رقم الموظف";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 875);
            this.panel2.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.Active_state);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.password2);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.password1);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.user_name);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(39, 350);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(659, 356);
            this.panel7.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(229, 220);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "الحالة";
            // 
            // Active_state
            // 
            this.Active_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Active_state.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Active_state.FormattingEnabled = true;
            this.Active_state.Items.AddRange(new object[] {
            "نشط ",
            "غير نشط"});
            this.Active_state.Location = new System.Drawing.Point(42, 255);
            this.Active_state.Name = "Active_state";
            this.Active_state.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Active_state.Size = new System.Drawing.Size(243, 31);
            this.Active_state.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.change_pass);
            this.groupBox1.Controls.Add(this.exp_pass);
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(290, 95);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // change_pass
            // 
            this.change_pass.AutoSize = true;
            this.change_pass.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.change_pass.Location = new System.Drawing.Point(5, 53);
            this.change_pass.Name = "change_pass";
            this.change_pass.Size = new System.Drawing.Size(230, 27);
            this.change_pass.TabIndex = 1;
            this.change_pass.Text = "تغيير كلمة المرور عند الدخول";
            this.change_pass.UseVisualStyleBackColor = true;
            // 
            // exp_pass
            // 
            this.exp_pass.AutoSize = true;
            this.exp_pass.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.exp_pass.Location = new System.Drawing.Point(75, 23);
            this.exp_pass.Name = "exp_pass";
            this.exp_pass.Size = new System.Drawing.Size(170, 27);
            this.exp_pass.TabIndex = 0;
            this.exp_pass.Text = "صلاحية كلمة المرور";
            this.exp_pass.UseVisualStyleBackColor = true;
            // 
            // password2
            // 
            this.password2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password2.Location = new System.Drawing.Point(340, 256);
            this.password2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password2.MaxLength = 12;
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password2.Size = new System.Drawing.Size(283, 30);
            this.password2.TabIndex = 36;
            this.password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(474, 226);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "تأكيد كلمة المرور";
            // 
            // password1
            // 
            this.password1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.password1.Location = new System.Drawing.Point(340, 150);
            this.password1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password1.MaxLength = 12;
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password1.Size = new System.Drawing.Size(283, 30);
            this.password1.TabIndex = 34;
            this.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(510, 120);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "كلمة المرور";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.user_name.Location = new System.Drawing.Point(340, 56);
            this.user_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_name.Name = "user_name";
            this.user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_name.Size = new System.Drawing.Size(283, 30);
            this.user_name.TabIndex = 32;
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(504, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "اسم المستخدم";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات المستخدمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox na_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.TextBox na_Em;
        private System.Windows.Forms.TextBox nu_Em;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Aut_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_EmpG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_empG;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Active_state;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox change_pass;
        private System.Windows.Forms.CheckBox exp_pass;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label5;
    }
}