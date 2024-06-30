
namespace WindowsFormsApp1.Forms
{
    partial class Power_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Power_User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUser_type = new System.Windows.Forms.ComboBox();
            this.usename_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Na_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridPower = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.na_Em = new System.Windows.Forms.TextBox();
            this.nu_Em = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPower)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.saveButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_close_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(497, 10);
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
            this.newButton.Location = new System.Drawing.Point(677, 10);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(152, 62);
            this.newButton.TabIndex = 20;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
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
            this.title.Location = new System.Drawing.Point(581, 97);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(226, 35);
            this.title.TabIndex = 3;
            this.title.Text = "صلاحيات المستخدمين";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(50, 14);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "نوع المستخدم";
            // 
            // comboUser_type
            // 
            this.comboUser_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser_type.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.comboUser_type.FormattingEnabled = true;
            this.comboUser_type.Items.AddRange(new object[] {
            "مستخدم",
            "مدير نظام",
            "",
            ""});
            this.comboUser_type.Location = new System.Drawing.Point(24, 52);
            this.comboUser_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboUser_type.Name = "comboUser_type";
            this.comboUser_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboUser_type.Size = new System.Drawing.Size(154, 31);
            this.comboUser_type.TabIndex = 27;
            this.comboUser_type.SelectedIndexChanged += new System.EventHandler(this.comboUser_type_SelectedIndexChanged);
            // 
            // usename_textBox
            // 
            this.usename_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.usename_textBox.Location = new System.Drawing.Point(198, 53);
            this.usename_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usename_textBox.Name = "usename_textBox";
            this.usename_textBox.ReadOnly = true;
            this.usename_textBox.Size = new System.Drawing.Size(277, 30);
            this.usename_textBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(290, 16);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "اسم المستخدم";
            // 
            // num_textBox
            // 
            this.num_textBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.num_textBox.Location = new System.Drawing.Point(492, 53);
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
            this.label3.Location = new System.Drawing.Point(512, 16);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم المستخدم";
            // 
            // Na_power
            // 
            this.Na_power.HeaderText = "اسم الأداة";
            this.Na_power.MinimumWidth = 6;
            this.Na_power.Name = "Na_power";
            this.Na_power.Visible = false;
            // 
            // Txt_power
            // 
            this.Txt_power.HeaderText = "الصلاحية";
            this.Txt_power.MinimumWidth = 6;
            this.Txt_power.Name = "Txt_power";
            // 
            // Nu_power
            // 
            this.Nu_power.HeaderText = "ترقيم";
            this.Nu_power.MinimumWidth = 6;
            this.Nu_power.Name = "Nu_power";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "تحديد";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 175;
            // 
            // dataGridPower
            // 
            this.dataGridPower.AllowUserToAddRows = false;
            this.dataGridPower.AllowUserToDeleteRows = false;
            this.dataGridPower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPower.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridPower.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.Nu_power,
            this.Txt_power,
            this.Na_power});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPower.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPower.Location = new System.Drawing.Point(-1, 133);
            this.dataGridPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridPower.Name = "dataGridPower";
            this.dataGridPower.RowHeadersWidth = 51;
            this.dataGridPower.Size = new System.Drawing.Size(659, 353);
            this.dataGridPower.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridPower);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboUser_type);
            this.panel5.Controls.Add(this.usename_textBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.num_textBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(39, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 488);
            this.panel5.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(584, 74);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "اسم الموظف:";
            // 
            // username
            // 
            this.username.HeaderText = "اسم المستخدم";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // Na_emp
            // 
            this.Na_emp.HeaderText = "الموظف";
            this.Na_emp.MinimumWidth = 6;
            this.Na_emp.Name = "Na_emp";
            this.Na_emp.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "رقم المستخدم";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowUserToAddRows = false;
            this.dataGridUser.AllowUserToDeleteRows = false;
            this.dataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Na_emp,
            this.username});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUser.Location = new System.Drawing.Point(-1, 133);
            this.dataGridUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.ReadOnly = true;
            this.dataGridUser.RowHeadersWidth = 51;
            this.dataGridUser.Size = new System.Drawing.Size(725, 353);
            this.dataGridUser.TabIndex = 61;
            this.dataGridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellClick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dataGridUser);
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
            this.searchButton.Location = new System.Drawing.Point(228, 17);
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
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "رقم الموظف:";
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
            this.panel2.TabIndex = 7;
            // 
            // Power_User2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Power_User2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صلاحيات المستخدمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Power_User2_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPower)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboUser_type;
        private System.Windows.Forms.TextBox usename_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_power;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridPower;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.TextBox na_Em;
        private System.Windows.Forms.TextBox nu_Em;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}