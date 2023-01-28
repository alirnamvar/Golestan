namespace MyGolestan
{
    partial class EditStudentClassesForm
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
            this.btn_removeClass = new System.Windows.Forms.Button();
            this.btn_addClass = new System.Windows.Forms.Button();
            this.btn_updateRegisteredClasses = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_maxCredit = new System.Windows.Forms.Label();
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_allClasses = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_registeredClasses = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classProfessorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allClasses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registeredClasses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_removeClass
            // 
            this.btn_removeClass.Location = new System.Drawing.Point(594, 409);
            this.btn_removeClass.Name = "btn_removeClass";
            this.btn_removeClass.Size = new System.Drawing.Size(194, 29);
            this.btn_removeClass.TabIndex = 1;
            this.btn_removeClass.Text = "Remove";
            this.btn_removeClass.UseVisualStyleBackColor = true;
            this.btn_removeClass.Click += new System.EventHandler(this.btn_removeClass_Click);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Location = new System.Drawing.Point(213, 409);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(182, 29);
            this.btn_addClass.TabIndex = 2;
            this.btn_addClass.Text = "Add";
            this.btn_addClass.UseVisualStyleBackColor = true;
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // btn_updateRegisteredClasses
            // 
            this.btn_updateRegisteredClasses.Location = new System.Drawing.Point(401, 409);
            this.btn_updateRegisteredClasses.Name = "btn_updateRegisteredClasses";
            this.btn_updateRegisteredClasses.Size = new System.Drawing.Size(187, 29);
            this.btn_updateRegisteredClasses.TabIndex = 5;
            this.btn_updateRegisteredClasses.Text = "Update Registered";
            this.btn_updateRegisteredClasses.UseVisualStyleBackColor = true;
            this.btn_updateRegisteredClasses.Click += new System.EventHandler(this.btn_updateRegisteredClasses_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(12, 409);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(195, 29);
            this.btn_finish.TabIndex = 6;
            this.btn_finish.Text = "Finish Editing";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max Credit:";
            // 
            // lbl_maxCredit
            // 
            this.lbl_maxCredit.AutoSize = true;
            this.lbl_maxCredit.Location = new System.Drawing.Point(94, 9);
            this.lbl_maxCredit.Name = "lbl_maxCredit";
            this.lbl_maxCredit.Size = new System.Drawing.Size(40, 16);
            this.lbl_maxCredit.TabIndex = 8;
            this.lbl_maxCredit.Text = "None";
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataSource = typeof(MyGolestan.Class);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MyGolestan.Class);
            // 
            // dataGridView_allClasses
            // 
            this.dataGridView_allClasses.AllowUserToAddRows = false;
            this.dataGridView_allClasses.AllowUserToDeleteRows = false;
            this.dataGridView_allClasses.AutoGenerateColumns = false;
            this.dataGridView_allClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_allClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.classProfessorDataGridViewTextBoxColumn});
            this.dataGridView_allClasses.DataSource = this.classBindingSource;
            this.dataGridView_allClasses.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_allClasses.Name = "dataGridView_allClasses";
            this.dataGridView_allClasses.ReadOnly = true;
            this.dataGridView_allClasses.RowHeadersWidth = 51;
            this.dataGridView_allClasses.RowTemplate.Height = 24;
            this.dataGridView_allClasses.Size = new System.Drawing.Size(371, 332);
            this.dataGridView_allClasses.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 124;
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            this.fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            this.fieldDataGridViewTextBoxColumn.Width = 124;
            // 
            // intFieldDataGridViewTextBoxColumn
            // 
            this.intFieldDataGridViewTextBoxColumn.DataPropertyName = "IntField";
            this.intFieldDataGridViewTextBoxColumn.HeaderText = "IntField";
            this.intFieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intFieldDataGridViewTextBoxColumn.Name = "intFieldDataGridViewTextBoxColumn";
            this.intFieldDataGridViewTextBoxColumn.Width = 124;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Width = 124;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.Width = 124;
            // 
            // classProfessorDataGridViewTextBoxColumn
            // 
            this.classProfessorDataGridViewTextBoxColumn.DataPropertyName = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn.HeaderText = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classProfessorDataGridViewTextBoxColumn.Name = "classProfessorDataGridViewTextBoxColumn";
            this.classProfessorDataGridViewTextBoxColumn.Width = 124;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_allClasses);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Classes";
            // 
            // dataGridView_registeredClasses
            // 
            this.dataGridView_registeredClasses.AllowUserToAddRows = false;
            this.dataGridView_registeredClasses.AllowUserToDeleteRows = false;
            this.dataGridView_registeredClasses.AutoGenerateColumns = false;
            this.dataGridView_registeredClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_registeredClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn1,
            this.fieldDataGridViewTextBoxColumn1,
            this.intFieldDataGridViewTextBoxColumn1,
            this.creditDataGridViewTextBoxColumn1,
            this.termDataGridViewTextBoxColumn1,
            this.classProfessorDataGridViewTextBoxColumn1});
            this.dataGridView_registeredClasses.DataSource = this.classBindingSource1;
            this.dataGridView_registeredClasses.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_registeredClasses.Name = "dataGridView_registeredClasses";
            this.dataGridView_registeredClasses.ReadOnly = true;
            this.dataGridView_registeredClasses.RowHeadersWidth = 51;
            this.dataGridView_registeredClasses.RowTemplate.Height = 24;
            this.dataGridView_registeredClasses.Size = new System.Drawing.Size(375, 332);
            this.dataGridView_registeredClasses.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 124;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 124;
            // 
            // fieldDataGridViewTextBoxColumn1
            // 
            this.fieldDataGridViewTextBoxColumn1.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn1.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fieldDataGridViewTextBoxColumn1.Name = "fieldDataGridViewTextBoxColumn1";
            this.fieldDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fieldDataGridViewTextBoxColumn1.Width = 124;
            // 
            // intFieldDataGridViewTextBoxColumn1
            // 
            this.intFieldDataGridViewTextBoxColumn1.DataPropertyName = "IntField";
            this.intFieldDataGridViewTextBoxColumn1.HeaderText = "IntField";
            this.intFieldDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.intFieldDataGridViewTextBoxColumn1.Name = "intFieldDataGridViewTextBoxColumn1";
            this.intFieldDataGridViewTextBoxColumn1.ReadOnly = true;
            this.intFieldDataGridViewTextBoxColumn1.Width = 124;
            // 
            // creditDataGridViewTextBoxColumn1
            // 
            this.creditDataGridViewTextBoxColumn1.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn1.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn1.Name = "creditDataGridViewTextBoxColumn1";
            this.creditDataGridViewTextBoxColumn1.ReadOnly = true;
            this.creditDataGridViewTextBoxColumn1.Width = 124;
            // 
            // termDataGridViewTextBoxColumn1
            // 
            this.termDataGridViewTextBoxColumn1.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn1.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.termDataGridViewTextBoxColumn1.Name = "termDataGridViewTextBoxColumn1";
            this.termDataGridViewTextBoxColumn1.ReadOnly = true;
            this.termDataGridViewTextBoxColumn1.Width = 124;
            // 
            // classProfessorDataGridViewTextBoxColumn1
            // 
            this.classProfessorDataGridViewTextBoxColumn1.DataPropertyName = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn1.HeaderText = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.classProfessorDataGridViewTextBoxColumn1.Name = "classProfessorDataGridViewTextBoxColumn1";
            this.classProfessorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.classProfessorDataGridViewTextBoxColumn1.Width = 124;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_registeredClasses);
            this.groupBox2.Location = new System.Drawing.Point(401, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 359);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registered Classes";
            // 
            // EditStudentClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_maxCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_updateRegisteredClasses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_removeClass);
            this.Controls.Add(this.btn_addClass);
            this.Name = "EditStudentClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student Classes";
            this.Load += new System.EventHandler(this.EditStudentClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allClasses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_registeredClasses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_removeClass;
        private System.Windows.Forms.Button btn_addClass;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private System.Windows.Forms.Button btn_updateRegisteredClasses;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_maxCredit;
        private System.Windows.Forms.DataGridView dataGridView_allClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_registeredClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classProfessorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}