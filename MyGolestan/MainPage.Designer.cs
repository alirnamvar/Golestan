namespace MyGolestan
{
    partial class MainPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_professor = new System.Windows.Forms.RadioButton();
            this.radioButton_employee = new System.Windows.Forms.RadioButton();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_addAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(285, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Isfahan University of Technology";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(307, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Golestan System";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblpassword.Location = new System.Drawing.Point(201, 188);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(70, 16);
            this.lblpassword.TabIndex = 17;
            this.lblpassword.Text = "Password:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblusername.Location = new System.Drawing.Point(198, 142);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(73, 16);
            this.lblusername.TabIndex = 16;
            this.lblusername.Text = "Username:";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(279, 188);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(223, 22);
            this.txtbox_password.TabIndex = 2;
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(279, 136);
            this.txtbox_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(223, 22);
            this.txtbox_username.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_professor);
            this.panel1.Controls.Add(this.radioButton_employee);
            this.panel1.Controls.Add(this.radioButton_student);
            this.panel1.Location = new System.Drawing.Point(510, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 121);
            this.panel1.TabIndex = 21;
            // 
            // radioButton_professor
            // 
            this.radioButton_professor.AutoSize = true;
            this.radioButton_professor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_professor.Location = new System.Drawing.Point(40, 52);
            this.radioButton_professor.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_professor.Name = "radioButton_professor";
            this.radioButton_professor.Size = new System.Drawing.Size(83, 20);
            this.radioButton_professor.TabIndex = 8;
            this.radioButton_professor.Text = "Professor";
            this.radioButton_professor.UseVisualStyleBackColor = true;
            // 
            // radioButton_employee
            // 
            this.radioButton_employee.AutoSize = true;
            this.radioButton_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_employee.Location = new System.Drawing.Point(40, 80);
            this.radioButton_employee.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_employee.Name = "radioButton_employee";
            this.radioButton_employee.Size = new System.Drawing.Size(87, 20);
            this.radioButton_employee.TabIndex = 9;
            this.radioButton_employee.Text = "Employee";
            this.radioButton_employee.UseVisualStyleBackColor = true;
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Checked = true;
            this.radioButton_student.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton_student.Location = new System.Drawing.Point(40, 21);
            this.radioButton_student.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(70, 20);
            this.radioButton_student.TabIndex = 7;
            this.radioButton_student.TabStop = true;
            this.radioButton_student.Text = "Student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnter.Location = new System.Drawing.Point(402, 238);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 30);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(279, 238);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Professor",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(157, 343);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lbl_addAccount
            // 
            this.lbl_addAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_addAccount.AutoSize = true;
            this.lbl_addAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_addAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_addAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_addAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_addAccount.Location = new System.Drawing.Point(34, 343);
            this.lbl_addAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addAccount.Name = "lbl_addAccount";
            this.lbl_addAccount.Size = new System.Drawing.Size(115, 20);
            this.lbl_addAccount.TabIndex = 6;
            this.lbl_addAccount.Text = "Add Account";
            this.lbl_addAccount.Click += new System.EventHandler(this.lbl_addAccount_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_addAccount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_professor;
        private System.Windows.Forms.RadioButton radioButton_employee;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_addAccount;
    }
}

