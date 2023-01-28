namespace MyGolestan
{
    partial class StudentRegisteredClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name (ID):";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studentName.Location = new System.Drawing.Point(162, 26);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(44, 18);
            this.lbl_studentName.TabIndex = 1;
            this.lbl_studentName.Text = "None";
            // 
            // dataGridView_classes
            // 
            this.dataGridView_classes.AllowUserToAddRows = false;
            this.dataGridView_classes.AllowUserToDeleteRows = false;
            this.dataGridView_classes.AutoGenerateColumns = false;
            this.dataGridView_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.classProfessorDataGridViewTextBoxColumn});
            this.dataGridView_classes.DataSource = this.classBindingSource;
            this.dataGridView_classes.Location = new System.Drawing.Point(15, 71);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.ReadOnly = true;
            this.dataGridView_classes.RowHeadersWidth = 51;
            this.dataGridView_classes.RowTemplate.Height = 24;
            this.dataGridView_classes.Size = new System.Drawing.Size(773, 367);
            this.dataGridView_classes.TabIndex = 2;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 124;
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            this.fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            this.fieldDataGridViewTextBoxColumn.ReadOnly = true;
            this.fieldDataGridViewTextBoxColumn.Width = 124;
            // 
            // intFieldDataGridViewTextBoxColumn
            // 
            this.intFieldDataGridViewTextBoxColumn.DataPropertyName = "IntField";
            this.intFieldDataGridViewTextBoxColumn.HeaderText = "IntField";
            this.intFieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intFieldDataGridViewTextBoxColumn.Name = "intFieldDataGridViewTextBoxColumn";
            this.intFieldDataGridViewTextBoxColumn.ReadOnly = true;
            this.intFieldDataGridViewTextBoxColumn.Width = 70;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditDataGridViewTextBoxColumn.Width = 70;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            this.termDataGridViewTextBoxColumn.Width = 70;
            // 
            // classProfessorDataGridViewTextBoxColumn
            // 
            this.classProfessorDataGridViewTextBoxColumn.DataPropertyName = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn.HeaderText = "ClassProfessor";
            this.classProfessorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classProfessorDataGridViewTextBoxColumn.Name = "classProfessorDataGridViewTextBoxColumn";
            this.classProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.classProfessorDataGridViewTextBoxColumn.Width = 124;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MyGolestan.Class);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(680, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 37);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StudentRegisteredClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView_classes);
            this.Controls.Add(this.lbl_studentName);
            this.Controls.Add(this.label1);
            this.Name = "StudentRegisteredClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRegisteredClasses";
            this.Load += new System.EventHandler(this.StudentRegisteredClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.Button btn_exit;
    }
}