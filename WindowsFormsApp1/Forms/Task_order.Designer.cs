
namespace WindowsFormsApp1.Forms
{
    partial class Task_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nu_Emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_jop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_jop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Nu_Task = new System.Windows.Forms.TextBox();
            this.Aut_tab = new System.Windows.Forms.TextBox();
            this.IDsearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.Text_Task = new System.Windows.Forms.TextBox();
            this.End_date = new System.Windows.Forms.DateTimePicker();
            this.Start_date = new System.Windows.Forms.DateTimePicker();
            this.listAddButton = new System.Windows.Forms.Button();
            this.Date_Task = new System.Windows.Forms.DateTimePicker();
            this.name_Emp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Type_Task = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Na_location = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Num_Emp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 17);
            this.panel1.TabIndex = 2;
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
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.printButton);
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.newButton);
            this.panel4.Location = new System.Drawing.Point(39, 709);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1381, 87);
            this.panel4.TabIndex = 21;
            // 
            // printButton
            // 
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.printButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_printer_32;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(322, 11);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(152, 61);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "طباعة";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.deleteButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_32;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(497, 11);
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
            this.saveButton.Location = new System.Drawing.Point(671, 10);
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
            this.newButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_add_32;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(843, 10);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(152, 62);
            this.newButton.TabIndex = 20;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
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
            this.Nu_location,
            this.ColumnButton});
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
            this.dataGridView1.Size = new System.Drawing.Size(657, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.Na_jop.HeaderText = "الوظيفة ";
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
            this.Nu_jop.Visible = false;
            // 
            // Nu_location
            // 
            this.Nu_location.HeaderText = "رقم مكان العمل";
            this.Nu_location.MinimumWidth = 6;
            this.Nu_location.Name = "Nu_location";
            this.Nu_location.ReadOnly = true;
            this.Nu_location.Visible = false;
            // 
            // ColumnButton
            // 
            this.ColumnButton.HeaderText = "حذف";
            this.ColumnButton.MinimumWidth = 6;
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.ReadOnly = true;
            this.ColumnButton.Text = "حذف";
            this.ColumnButton.UseColumnTextForButtonValue = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Nu_Task);
            this.panel6.Controls.Add(this.Aut_tab);
            this.panel6.Controls.Add(this.IDsearchButton);
            this.panel6.Controls.Add(this.searchButton);
            this.panel6.Controls.Add(this.showListBox);
            this.panel6.Controls.Add(this.searchOptions);
            this.panel6.Controls.Add(this.Text_Task);
            this.panel6.Controls.Add(this.End_date);
            this.panel6.Controls.Add(this.Start_date);
            this.panel6.Controls.Add(this.listAddButton);
            this.panel6.Controls.Add(this.Date_Task);
            this.panel6.Controls.Add(this.name_Emp);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.Type_Task);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.Na_location);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.Num_Emp);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(704, 218);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(716, 488);
            this.panel6.TabIndex = 20;
            // 
            // Nu_Task
            // 
            this.Nu_Task.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Nu_Task.Location = new System.Drawing.Point(351, 20);
            this.Nu_Task.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nu_Task.MaxLength = 5;
            this.Nu_Task.Name = "Nu_Task";
            this.Nu_Task.Size = new System.Drawing.Size(182, 30);
            this.Nu_Task.TabIndex = 49;
            this.Nu_Task.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Aut_tab
            // 
            this.Aut_tab.Location = new System.Drawing.Point(30, 20);
            this.Aut_tab.Name = "Aut_tab";
            this.Aut_tab.ReadOnly = true;
            this.Aut_tab.Size = new System.Drawing.Size(100, 24);
            this.Aut_tab.TabIndex = 48;
            this.Aut_tab.Visible = false;
            // 
            // IDsearchButton
            // 
            this.IDsearchButton.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsearchButton.Image = ((System.Drawing.Image)(resources.GetObject("IDsearchButton.Image")));
            this.IDsearchButton.Location = new System.Drawing.Point(283, 70);
            this.IDsearchButton.Name = "IDsearchButton";
            this.IDsearchButton.Size = new System.Drawing.Size(54, 39);
            this.IDsearchButton.TabIndex = 47;
            this.IDsearchButton.UseVisualStyleBackColor = true;
            this.IDsearchButton.Click += new System.EventHandler(this.IDsearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(283, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 39);
            this.searchButton.TabIndex = 46;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showListBox
            // 
            this.showListBox.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 23;
            this.showListBox.Location = new System.Drawing.Point(351, 150);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(182, 119);
            this.showListBox.TabIndex = 45;
            this.showListBox.Visible = false;
            this.showListBox.SelectedIndexChanged += new System.EventHandler(this.showListBox_SelectedIndexChanged);
            // 
            // searchOptions
            // 
            this.searchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptions.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.searchOptions.FormattingEnabled = true;
            this.searchOptions.Items.AddRange(new object[] {
            "الحرف الأول",
            "يحتوي على ",
            "الحرف الأخير"});
            this.searchOptions.Location = new System.Drawing.Point(186, 122);
            this.searchOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchOptions.Name = "searchOptions";
            this.searchOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchOptions.Size = new System.Drawing.Size(151, 32);
            this.searchOptions.TabIndex = 44;
            // 
            // Text_Task
            // 
            this.Text_Task.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Text_Task.Location = new System.Drawing.Point(204, 322);
            this.Text_Task.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_Task.Multiline = true;
            this.Text_Task.Name = "Text_Task";
            this.Text_Task.Size = new System.Drawing.Size(329, 122);
            this.Text_Task.TabIndex = 42;
            // 
            // End_date
            // 
            this.End_date.AllowDrop = true;
            this.End_date.CustomFormat = "";
            this.End_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.End_date.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.End_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.End_date.Location = new System.Drawing.Point(26, 222);
            this.End_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End_date.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.End_date.Name = "End_date";
            this.End_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.End_date.RightToLeftLayout = true;
            this.End_date.Size = new System.Drawing.Size(182, 30);
            this.End_date.TabIndex = 39;
            this.End_date.Value = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            // 
            // Start_date
            // 
            this.Start_date.AllowDrop = true;
            this.Start_date.CustomFormat = "";
            this.Start_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Start_date.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Start_date.Location = new System.Drawing.Point(351, 222);
            this.Start_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_date.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.Start_date.Name = "Start_date";
            this.Start_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Start_date.RightToLeftLayout = true;
            this.Start_date.Size = new System.Drawing.Size(182, 30);
            this.Start_date.TabIndex = 38;
            this.Start_date.Value = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            // 
            // listAddButton
            // 
            this.listAddButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.listAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listAddButton.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.listAddButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_done_32;
            this.listAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listAddButton.Location = new System.Drawing.Point(26, 352);
            this.listAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAddButton.Name = "listAddButton";
            this.listAddButton.Size = new System.Drawing.Size(155, 49);
            this.listAddButton.TabIndex = 43;
            this.listAddButton.Text = "إضافة إلى القائمة";
            this.listAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listAddButton.UseVisualStyleBackColor = true;
            this.listAddButton.Click += new System.EventHandler(this.listAddButton_Click);
            // 
            // Date_Task
            // 
            this.Date_Task.AllowDrop = true;
            this.Date_Task.CustomFormat = "";
            this.Date_Task.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_Task.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Date_Task.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Task.Location = new System.Drawing.Point(351, 172);
            this.Date_Task.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_Task.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.Date_Task.Name = "Date_Task";
            this.Date_Task.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_Task.RightToLeftLayout = true;
            this.Date_Task.Size = new System.Drawing.Size(182, 30);
            this.Date_Task.TabIndex = 37;
            this.Date_Task.Value = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            // 
            // name_Emp
            // 
            this.name_Emp.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.name_Emp.Location = new System.Drawing.Point(351, 122);
            this.name_Emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_Emp.Name = "name_Emp";
            this.name_Emp.Size = new System.Drawing.Size(182, 30);
            this.name_Emp.TabIndex = 40;
            this.name_Emp.TextChanged += new System.EventHandler(this.name_Emp_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(548, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "اسم الموظف:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(539, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "العمل المطلوب إنجازه:";
            // 
            // Type_Task
            // 
            this.Type_Task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Task.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Type_Task.FormattingEnabled = true;
            this.Type_Task.Location = new System.Drawing.Point(351, 275);
            this.Type_Task.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type_Task.Name = "Type_Task";
            this.Type_Task.Size = new System.Drawing.Size(182, 32);
            this.Type_Task.TabIndex = 35;
            this.Type_Task.SelectedIndexChanged += new System.EventHandler(this.Type_Task_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(576, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "المهمة:";
            // 
            // Na_location
            // 
            this.Na_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Na_location.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Na_location.FormattingEnabled = true;
            this.Na_location.Location = new System.Drawing.Point(26, 278);
            this.Na_location.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Na_location.Name = "Na_location";
            this.Na_location.Size = new System.Drawing.Size(182, 32);
            this.Na_location.TabIndex = 36;
            this.Na_location.SelectedIndexChanged += new System.EventHandler(this.Na_location_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(241, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "موقع العمل:";
            // 
            // Num_Emp
            // 
            this.Num_Emp.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.Num_Emp.Location = new System.Drawing.Point(351, 70);
            this.Num_Emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Num_Emp.MaxLength = 5;
            this.Num_Emp.Name = "Num_Emp";
            this.Num_Emp.Size = new System.Drawing.Size(182, 30);
            this.Num_Emp.TabIndex = 41;
            this.Num_Emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(222, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "تاريخ الإنتهاء:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(552, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "تاريخ البدء:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(536, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "تاريخ أمر العمل:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(539, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "رقم الموظف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(539, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "رقم أمر العمل:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(178)));
            this.title.Location = new System.Drawing.Point(619, 94);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(149, 35);
            this.title.TabIndex = 3;
            this.title.Text = "أمر عمل جديد";
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
            // Task_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Task_order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "أمر عمل جديد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Task_order_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_Emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_jop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_jop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nu_location;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Nu_Task;
        private System.Windows.Forms.TextBox Aut_tab;
        private System.Windows.Forms.Button IDsearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.TextBox Text_Task;
        private System.Windows.Forms.DateTimePicker End_date;
        private System.Windows.Forms.DateTimePicker Start_date;
        private System.Windows.Forms.Button listAddButton;
        private System.Windows.Forms.DateTimePicker Date_Task;
        private System.Windows.Forms.TextBox name_Emp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Type_Task;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Na_location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Num_Emp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printButton;
    }
}