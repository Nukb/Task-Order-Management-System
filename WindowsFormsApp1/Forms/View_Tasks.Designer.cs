
namespace WindowsFormsApp1.Forms
{
    partial class View_Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Tasks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.YearUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.searchButton6 = new System.Windows.Forms.Button();
            this.comboMonth2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.YearUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.searchButton4 = new System.Windows.Forms.Button();
            this.comboQuarter = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YearUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.searchButton3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.comboMonth1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nu_TaskG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nu_Emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_jop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_jop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Location = new System.Drawing.Point(1020, 218);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 578);
            this.panel6.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.YearUpDown3);
            this.groupBox5.Controls.Add(this.searchButton6);
            this.groupBox5.Controls.Add(this.comboMonth2);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.groupBox5.Location = new System.Drawing.Point(39, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 102);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "خلال شهر وسنة";
            // 
            // YearUpDown3
            // 
            this.YearUpDown3.Location = new System.Drawing.Point(96, 39);
            this.YearUpDown3.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YearUpDown3.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearUpDown3.Name = "YearUpDown3";
            this.YearUpDown3.Size = new System.Drawing.Size(84, 30);
            this.YearUpDown3.TabIndex = 35;
            this.YearUpDown3.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // searchButton6
            // 
            this.searchButton6.Image = ((System.Drawing.Image)(resources.GetObject("searchButton6.Image")));
            this.searchButton6.Location = new System.Drawing.Point(16, 35);
            this.searchButton6.Name = "searchButton6";
            this.searchButton6.Size = new System.Drawing.Size(54, 39);
            this.searchButton6.TabIndex = 31;
            this.searchButton6.UseVisualStyleBackColor = true;
            this.searchButton6.Click += new System.EventHandler(this.searchButton6_Click);
            // 
            // comboMonth2
            // 
            this.comboMonth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth2.FormattingEnabled = true;
            this.comboMonth2.Location = new System.Drawing.Point(201, 39);
            this.comboMonth2.Name = "comboMonth2";
            this.comboMonth2.Size = new System.Drawing.Size(122, 32);
            this.comboMonth2.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.searchButton5);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(39, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 137);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "خلال فترة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "إلى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "من";
            // 
            // searchButton5
            // 
            this.searchButton5.Image = ((System.Drawing.Image)(resources.GetObject("searchButton5.Image")));
            this.searchButton5.Location = new System.Drawing.Point(16, 55);
            this.searchButton5.Name = "searchButton5";
            this.searchButton5.Size = new System.Drawing.Size(54, 39);
            this.searchButton5.TabIndex = 36;
            this.searchButton5.UseVisualStyleBackColor = true;
            this.searchButton5.Click += new System.EventHandler(this.searchButton5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 30);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.YearUpDown2);
            this.groupBox3.Controls.Add(this.searchButton4);
            this.groupBox3.Controls.Add(this.comboQuarter);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(39, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 102);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "خلال الربع";
            // 
            // YearUpDown2
            // 
            this.YearUpDown2.Location = new System.Drawing.Point(96, 51);
            this.YearUpDown2.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YearUpDown2.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearUpDown2.Name = "YearUpDown2";
            this.YearUpDown2.Size = new System.Drawing.Size(84, 30);
            this.YearUpDown2.TabIndex = 35;
            this.YearUpDown2.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // searchButton4
            // 
            this.searchButton4.Image = ((System.Drawing.Image)(resources.GetObject("searchButton4.Image")));
            this.searchButton4.Location = new System.Drawing.Point(16, 46);
            this.searchButton4.Name = "searchButton4";
            this.searchButton4.Size = new System.Drawing.Size(54, 39);
            this.searchButton4.TabIndex = 31;
            this.searchButton4.UseVisualStyleBackColor = true;
            this.searchButton4.Click += new System.EventHandler(this.searchButton4_Click);
            // 
            // comboQuarter
            // 
            this.comboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuarter.FormattingEnabled = true;
            this.comboQuarter.Items.AddRange(new object[] {
            "الربع الأول",
            "الربع الثاني",
            "الربع الثالث",
            "الربع الرابع"});
            this.comboQuarter.Location = new System.Drawing.Point(201, 49);
            this.comboQuarter.Name = "comboQuarter";
            this.comboQuarter.Size = new System.Drawing.Size(122, 32);
            this.comboQuarter.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YearUpDown1);
            this.groupBox2.Controls.Add(this.searchButton3);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(39, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 102);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "خلال سنة";
            // 
            // YearUpDown1
            // 
            this.YearUpDown1.Location = new System.Drawing.Point(132, 42);
            this.YearUpDown1.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YearUpDown1.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearUpDown1.Name = "YearUpDown1";
            this.YearUpDown1.Size = new System.Drawing.Size(102, 30);
            this.YearUpDown1.TabIndex = 34;
            this.YearUpDown1.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // searchButton3
            // 
            this.searchButton3.Image = ((System.Drawing.Image)(resources.GetObject("searchButton3.Image")));
            this.searchButton3.Location = new System.Drawing.Point(16, 40);
            this.searchButton3.Name = "searchButton3";
            this.searchButton3.Size = new System.Drawing.Size(54, 39);
            this.searchButton3.TabIndex = 31;
            this.searchButton3.UseVisualStyleBackColor = true;
            this.searchButton3.Click += new System.EventHandler(this.searchButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton2);
            this.groupBox1.Controls.Add(this.comboMonth1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(39, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 102);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خلال شهر";
            // 
            // searchButton2
            // 
            this.searchButton2.Image = ((System.Drawing.Image)(resources.GetObject("searchButton2.Image")));
            this.searchButton2.Location = new System.Drawing.Point(14, 39);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(54, 39);
            this.searchButton2.TabIndex = 31;
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // comboMonth1
            // 
            this.comboMonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth1.FormattingEnabled = true;
            this.comboMonth1.Location = new System.Drawing.Point(130, 43);
            this.comboMonth1.Name = "comboMonth1";
            this.comboMonth1.Size = new System.Drawing.Size(102, 32);
            this.comboMonth1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nu_TaskG,
            this.Date_Task,
            this.Start_date,
            this.End_date,
            this.Na_location,
            this.Txt_Task,
            this.Type_Task});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(973, 278);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Nu_TaskG
            // 
            this.Nu_TaskG.HeaderText = "رقم أمر العمل";
            this.Nu_TaskG.MinimumWidth = 6;
            this.Nu_TaskG.Name = "Nu_TaskG";
            this.Nu_TaskG.ReadOnly = true;
            // 
            // Date_Task
            // 
            this.Date_Task.HeaderText = "التاريخ";
            this.Date_Task.MinimumWidth = 6;
            this.Date_Task.Name = "Date_Task";
            this.Date_Task.ReadOnly = true;
            // 
            // Start_date
            // 
            this.Start_date.HeaderText = "تاريخ البدء";
            this.Start_date.MinimumWidth = 6;
            this.Start_date.Name = "Start_date";
            this.Start_date.ReadOnly = true;
            // 
            // End_date
            // 
            this.End_date.HeaderText = "تاريخ الإنتهاء";
            this.End_date.MinimumWidth = 6;
            this.End_date.Name = "End_date";
            this.End_date.ReadOnly = true;
            // 
            // Na_location
            // 
            this.Na_location.HeaderText = "موقع العمل";
            this.Na_location.MinimumWidth = 6;
            this.Na_location.Name = "Na_location";
            this.Na_location.ReadOnly = true;
            // 
            // Txt_Task
            // 
            this.Txt_Task.HeaderText = "البيان";
            this.Txt_Task.MinimumWidth = 6;
            this.Txt_Task.Name = "Txt_Task";
            this.Txt_Task.ReadOnly = true;
            // 
            // Type_Task
            // 
            this.Type_Task.HeaderText = "المهمة";
            this.Type_Task.MinimumWidth = 6;
            this.Type_Task.Name = "Type_Task";
            this.Type_Task.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(39, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(975, 280);
            this.panel5.TabIndex = 22;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.title.Location = new System.Drawing.Point(575, 96);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 35);
            this.title.TabIndex = 3;
            this.title.Text = "استعلام عن أوامر العمل";
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(39, 506);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 290);
            this.panel4.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nu_Emp,
            this.Na_emp,
            this.Na_jop,
            this.Na_loc,
            this.Nu_jop,
            this.Nu_location});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(973, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nu_Emp
            // 
            this.Nu_Emp.HeaderText = "رقم الموظف";
            this.Nu_Emp.MinimumWidth = 6;
            this.Nu_Emp.Name = "Nu_Emp";
            this.Nu_Emp.ReadOnly = true;
            // 
            // Na_emp
            // 
            this.Na_emp.HeaderText = "اسم الموظف";
            this.Na_emp.MinimumWidth = 6;
            this.Na_emp.Name = "Na_emp";
            this.Na_emp.ReadOnly = true;
            // 
            // Na_jop
            // 
            this.Na_jop.HeaderText = "الوظيفة";
            this.Na_jop.MinimumWidth = 6;
            this.Na_jop.Name = "Na_jop";
            this.Na_jop.ReadOnly = true;
            // 
            // Na_loc
            // 
            this.Na_loc.HeaderText = "مكان العمل";
            this.Na_loc.MinimumWidth = 6;
            this.Na_loc.Name = "Na_loc";
            this.Na_loc.ReadOnly = true;
            // 
            // Nu_jop
            // 
            this.Nu_jop.HeaderText = "رقم الوظيفة";
            this.Nu_jop.MinimumWidth = 6;
            this.Nu_jop.Name = "Nu_jop";
            this.Nu_jop.ReadOnly = true;
            // 
            // Nu_location
            // 
            this.Nu_location.HeaderText = "رقم مكان العمل";
            this.Nu_location.MinimumWidth = 6;
            this.Nu_location.Name = "Nu_location";
            this.Nu_location.ReadOnly = true;
            // 
            // View_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Tasks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Tasks_Load);
            this.panel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown YearUpDown3;
        private System.Windows.Forms.Button searchButton6;
        private System.Windows.Forms.ComboBox comboMonth2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown YearUpDown2;
        private System.Windows.Forms.Button searchButton4;
        private System.Windows.Forms.ComboBox comboQuarter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown YearUpDown1;
        private System.Windows.Forms.Button searchButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.ComboBox comboMonth1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_TaskG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_Emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_jop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_jop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_location;
    }
}