namespace MyGolestan
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.tabPage_personalInformation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstNameTex = new System.Windows.Forms.Label();
            this.txtbox_fullName = new System.Windows.Forms.TextBox();
            this.StudentNumberTex = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.branchTex = new System.Windows.Forms.Label();
            this.passtex = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.btn_updateInformation = new System.Windows.Forms.Button();
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.tabPage_registration = new System.Windows.Forms.TabPage();
            this.tabPage_terms = new System.Windows.Forms.TabPage();
            this.dataGridView_terms = new System.Windows.Forms.DataGridView();
            this.btn_showTermAndClasses = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_currentTerm = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_canRegister = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTermDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTermDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startRegisterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRegisterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_personalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_registration.SuspendLayout();
            this.tabPage_terms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_terms)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_currentTerm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_personalInformation
            // 
            this.tabPage_personalInformation.Controls.Add(this.groupBox1);
            this.tabPage_personalInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPage_personalInformation.Name = "tabPage_personalInformation";
            this.tabPage_personalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_personalInformation.Size = new System.Drawing.Size(792, 421);
            this.tabPage_personalInformation.TabIndex = 4;
            this.tabPage_personalInformation.Text = "Personal Information";
            this.tabPage_personalInformation.UseVisualStyleBackColor = true;
            this.tabPage_personalInformation.Enter += new System.EventHandler(this.tabPage_personalInformation_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox_field);
            this.groupBox1.Controls.Add(this.btn_updateInformation);
            this.groupBox1.Controls.Add(this.txtBox_password);
            this.groupBox1.Controls.Add(this.passtex);
            this.groupBox1.Controls.Add(this.branchTex);
            this.groupBox1.Controls.Add(this.txtbox_ID);
            this.groupBox1.Controls.Add(this.StudentNumberTex);
            this.groupBox1.Controls.Add(this.txtbox_fullName);
            this.groupBox1.Controls.Add(this.FirstNameTex);
            this.groupBox1.Location = new System.Drawing.Point(209, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 354);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // FirstNameTex
            // 
            this.FirstNameTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTex.AutoSize = true;
            this.FirstNameTex.ForeColor = System.Drawing.Color.Black;
            this.FirstNameTex.Location = new System.Drawing.Point(100, 86);
            this.FirstNameTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameTex.Name = "FirstNameTex";
            this.FirstNameTex.Size = new System.Drawing.Size(68, 16);
            this.FirstNameTex.TabIndex = 11;
            this.FirstNameTex.Text = "Full Name";
            // 
            // txtbox_fullName
            // 
            this.txtbox_fullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_fullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Name", true));
            this.txtbox_fullName.Location = new System.Drawing.Point(175, 80);
            this.txtbox_fullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_fullName.Name = "txtbox_fullName";
            this.txtbox_fullName.Size = new System.Drawing.Size(132, 22);
            this.txtbox_fullName.TabIndex = 12;
            // 
            // StudentNumberTex
            // 
            this.StudentNumberTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNumberTex.AutoSize = true;
            this.StudentNumberTex.ForeColor = System.Drawing.Color.Black;
            this.StudentNumberTex.Location = new System.Drawing.Point(96, 113);
            this.StudentNumberTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNumberTex.Name = "StudentNumberTex";
            this.StudentNumberTex.Size = new System.Drawing.Size(71, 16);
            this.StudentNumberTex.TabIndex = 9;
            this.StudentNumberTex.Text = "ID Number";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "IdenticalNum", true));
            this.txtbox_ID.Location = new System.Drawing.Point(175, 110);
            this.txtbox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(132, 22);
            this.txtbox_ID.TabIndex = 13;
            // 
            // branchTex
            // 
            this.branchTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchTex.AutoSize = true;
            this.branchTex.ForeColor = System.Drawing.Color.Black;
            this.branchTex.Location = new System.Drawing.Point(130, 141);
            this.branchTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branchTex.Name = "branchTex";
            this.branchTex.Size = new System.Drawing.Size(37, 16);
            this.branchTex.TabIndex = 8;
            this.branchTex.Text = "Field";
            // 
            // passtex
            // 
            this.passtex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passtex.AutoSize = true;
            this.passtex.ForeColor = System.Drawing.Color.Black;
            this.passtex.Location = new System.Drawing.Point(104, 173);
            this.passtex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passtex.Name = "passtex";
            this.passtex.Size = new System.Drawing.Size(67, 16);
            this.passtex.TabIndex = 7;
            this.passtex.Text = "Password";
            // 
            // txtBox_password
            // 
            this.txtBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.txtBox_password.Location = new System.Drawing.Point(175, 173);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(132, 22);
            this.txtBox_password.TabIndex = 15;
            // 
            // btn_updateInformation
            // 
            this.btn_updateInformation.BackColor = System.Drawing.Color.Silver;
            this.btn_updateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateInformation.Location = new System.Drawing.Point(107, 214);
            this.btn_updateInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateInformation.Name = "btn_updateInformation";
            this.btn_updateInformation.Size = new System.Drawing.Size(201, 28);
            this.btn_updateInformation.TabIndex = 16;
            this.btn_updateInformation.Text = "Update";
            this.btn_updateInformation.UseVisualStyleBackColor = false;
            this.btn_updateInformation.Click += new System.EventHandler(this.btn_updateInformation_Click);
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(176, 141);
            this.comBox_field.Name = "comBox_field";
            this.comBox_field.Size = new System.Drawing.Size(132, 24);
            this.comBox_field.TabIndex = 14;
            // 
            // tabPage_registration
            // 
            this.tabPage_registration.Controls.Add(this.groupBox4);
            this.tabPage_registration.Controls.Add(this.groupBox3);
            this.tabPage_registration.Controls.Add(this.groupBox2);
            this.tabPage_registration.Location = new System.Drawing.Point(4, 25);
            this.tabPage_registration.Name = "tabPage_registration";
            this.tabPage_registration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_registration.Size = new System.Drawing.Size(792, 421);
            this.tabPage_registration.TabIndex = 2;
            this.tabPage_registration.Text = "Registration";
            this.tabPage_registration.UseVisualStyleBackColor = true;
            this.tabPage_registration.Enter += new System.EventHandler(this.tabPage_registration_Enter);
            // 
            // tabPage_terms
            // 
            this.tabPage_terms.Controls.Add(this.btn_showTermAndClasses);
            this.tabPage_terms.Controls.Add(this.dataGridView_terms);
            this.tabPage_terms.Location = new System.Drawing.Point(4, 25);
            this.tabPage_terms.Name = "tabPage_terms";
            this.tabPage_terms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_terms.Size = new System.Drawing.Size(792, 421);
            this.tabPage_terms.TabIndex = 0;
            this.tabPage_terms.Text = "Terms";
            this.tabPage_terms.UseVisualStyleBackColor = true;
            this.tabPage_terms.Enter += new System.EventHandler(this.tabPage_terms_Enter);
            // 
            // dataGridView_terms
            // 
            this.dataGridView_terms.AllowUserToAddRows = false;
            this.dataGridView_terms.AllowUserToDeleteRows = false;
            this.dataGridView_terms.AutoGenerateColumns = false;
            this.dataGridView_terms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_terms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.startTermDataGridViewTextBoxColumn,
            this.endTermDataGridViewTextBoxColumn,
            this.startRegisterDataGridViewTextBoxColumn,
            this.endRegisterDataGridViewTextBoxColumn});
            this.dataGridView_terms.DataSource = this.termBindingSource;
            this.dataGridView_terms.Location = new System.Drawing.Point(58, 18);
            this.dataGridView_terms.Name = "dataGridView_terms";
            this.dataGridView_terms.ReadOnly = true;
            this.dataGridView_terms.RowHeadersWidth = 51;
            this.dataGridView_terms.RowTemplate.Height = 24;
            this.dataGridView_terms.Size = new System.Drawing.Size(681, 330);
            this.dataGridView_terms.TabIndex = 7;
            // 
            // btn_showTermAndClasses
            // 
            this.btn_showTermAndClasses.Location = new System.Drawing.Point(295, 367);
            this.btn_showTermAndClasses.Name = "btn_showTermAndClasses";
            this.btn_showTermAndClasses.Size = new System.Drawing.Size(184, 33);
            this.btn_showTermAndClasses.TabIndex = 18;
            this.btn_showTermAndClasses.Text = "Show Term And Classes";
            this.btn_showTermAndClasses.UseVisualStyleBackColor = true;
            this.btn_showTermAndClasses.Click += new System.EventHandler(this.btn_showTermAndClasses_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_terms);
            this.tabControl1.Controls.Add(this.tabPage_registration);
            this.tabControl1.Controls.Add(this.tabPage_personalInformation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Term";
            // 
            // dataGridView_currentTerm
            // 
            this.dataGridView_currentTerm.AllowUserToAddRows = false;
            this.dataGridView_currentTerm.AllowUserToDeleteRows = false;
            this.dataGridView_currentTerm.AutoGenerateColumns = false;
            this.dataGridView_currentTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_currentTerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.startTermDataGridViewTextBoxColumn1,
            this.endTermDataGridViewTextBoxColumn1,
            this.startRegisterDataGridViewTextBoxColumn1,
            this.endRegisterDataGridViewTextBoxColumn1});
            this.dataGridView_currentTerm.DataSource = this.termBindingSource1;
            this.dataGridView_currentTerm.Location = new System.Drawing.Point(99, 21);
            this.dataGridView_currentTerm.Name = "dataGridView_currentTerm";
            this.dataGridView_currentTerm.ReadOnly = true;
            this.dataGridView_currentTerm.RowHeadersWidth = 51;
            this.dataGridView_currentTerm.RowTemplate.Height = 24;
            this.dataGridView_currentTerm.Size = new System.Drawing.Size(671, 54);
            this.dataGridView_currentTerm.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_time);
            this.groupBox2.Controls.Add(this.lbl_date);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_currentTerm);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 93);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date, Time:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(175, 18);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(41, 18);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(96, 18);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(39, 18);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date";
            // 
            // btn_canRegister
            // 
            this.btn_canRegister.Location = new System.Drawing.Point(63, 33);
            this.btn_canRegister.Name = "btn_canRegister";
            this.btn_canRegister.Size = new System.Drawing.Size(199, 34);
            this.btn_canRegister.TabIndex = 6;
            this.btn_canRegister.Text = "Check Register Possibility";
            this.btn_canRegister.UseVisualStyleBackColor = true;
            this.btn_canRegister.Click += new System.EventHandler(this.btn_canRegister_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_register);
            this.groupBox4.Controls.Add(this.btn_canRegister);
            this.groupBox4.Location = new System.Drawing.Point(226, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 130);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.Enabled = false;
            this.btn_register.Location = new System.Drawing.Point(107, 73);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(117, 34);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // startTermDataGridViewTextBoxColumn
            // 
            this.startTermDataGridViewTextBoxColumn.DataPropertyName = "StartTerm";
            this.startTermDataGridViewTextBoxColumn.HeaderText = "StartTerm";
            this.startTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTermDataGridViewTextBoxColumn.Name = "startTermDataGridViewTextBoxColumn";
            this.startTermDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTermDataGridViewTextBoxColumn.Width = 124;
            // 
            // endTermDataGridViewTextBoxColumn
            // 
            this.endTermDataGridViewTextBoxColumn.DataPropertyName = "EndTerm";
            this.endTermDataGridViewTextBoxColumn.HeaderText = "EndTerm";
            this.endTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTermDataGridViewTextBoxColumn.Name = "endTermDataGridViewTextBoxColumn";
            this.endTermDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTermDataGridViewTextBoxColumn.Width = 124;
            // 
            // startRegisterDataGridViewTextBoxColumn
            // 
            this.startRegisterDataGridViewTextBoxColumn.DataPropertyName = "StartRegister";
            this.startRegisterDataGridViewTextBoxColumn.HeaderText = "StartRegister";
            this.startRegisterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startRegisterDataGridViewTextBoxColumn.Name = "startRegisterDataGridViewTextBoxColumn";
            this.startRegisterDataGridViewTextBoxColumn.ReadOnly = true;
            this.startRegisterDataGridViewTextBoxColumn.Width = 124;
            // 
            // endRegisterDataGridViewTextBoxColumn
            // 
            this.endRegisterDataGridViewTextBoxColumn.DataPropertyName = "EndRegister";
            this.endRegisterDataGridViewTextBoxColumn.HeaderText = "EndRegister";
            this.endRegisterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endRegisterDataGridViewTextBoxColumn.Name = "endRegisterDataGridViewTextBoxColumn";
            this.endRegisterDataGridViewTextBoxColumn.ReadOnly = true;
            this.endRegisterDataGridViewTextBoxColumn.Width = 124;
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataSource = typeof(MyGolestan.Term);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 120;
            // 
            // startTermDataGridViewTextBoxColumn1
            // 
            this.startTermDataGridViewTextBoxColumn1.DataPropertyName = "StartTerm";
            this.startTermDataGridViewTextBoxColumn1.HeaderText = "StartTerm";
            this.startTermDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startTermDataGridViewTextBoxColumn1.Name = "startTermDataGridViewTextBoxColumn1";
            this.startTermDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startTermDataGridViewTextBoxColumn1.Width = 124;
            // 
            // endTermDataGridViewTextBoxColumn1
            // 
            this.endTermDataGridViewTextBoxColumn1.DataPropertyName = "EndTerm";
            this.endTermDataGridViewTextBoxColumn1.HeaderText = "EndTerm";
            this.endTermDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endTermDataGridViewTextBoxColumn1.Name = "endTermDataGridViewTextBoxColumn1";
            this.endTermDataGridViewTextBoxColumn1.ReadOnly = true;
            this.endTermDataGridViewTextBoxColumn1.Width = 124;
            // 
            // startRegisterDataGridViewTextBoxColumn1
            // 
            this.startRegisterDataGridViewTextBoxColumn1.DataPropertyName = "StartRegister";
            this.startRegisterDataGridViewTextBoxColumn1.HeaderText = "StartRegister";
            this.startRegisterDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startRegisterDataGridViewTextBoxColumn1.Name = "startRegisterDataGridViewTextBoxColumn1";
            this.startRegisterDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startRegisterDataGridViewTextBoxColumn1.Width = 124;
            // 
            // endRegisterDataGridViewTextBoxColumn1
            // 
            this.endRegisterDataGridViewTextBoxColumn1.DataPropertyName = "EndRegister";
            this.endRegisterDataGridViewTextBoxColumn1.HeaderText = "EndRegister";
            this.endRegisterDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endRegisterDataGridViewTextBoxColumn1.Name = "endRegisterDataGridViewTextBoxColumn1";
            this.endRegisterDataGridViewTextBoxColumn1.ReadOnly = true;
            this.endRegisterDataGridViewTextBoxColumn1.Width = 124;
            // 
            // termBindingSource1
            // 
            this.termBindingSource1.DataSource = typeof(MyGolestan.Term);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(MyGolestan.Student);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.tabPage_personalInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_registration.ResumeLayout(false);
            this.tabPage_terms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_terms)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_currentTerm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource termBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TabPage tabPage_personalInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.Button btn_updateInformation;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label passtex;
        private System.Windows.Forms.Label branchTex;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Label StudentNumberTex;
        private System.Windows.Forms.TextBox txtbox_fullName;
        private System.Windows.Forms.Label FirstNameTex;
        private System.Windows.Forms.TabPage tabPage_registration;
        private System.Windows.Forms.DataGridView dataGridView_currentTerm;
        private System.Windows.Forms.BindingSource termBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_terms;
        private System.Windows.Forms.Button btn_showTermAndClasses;
        private System.Windows.Forms.DataGridView dataGridView_terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_canRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTermDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTermDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startRegisterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRegisterDataGridViewTextBoxColumn1;
    }
}