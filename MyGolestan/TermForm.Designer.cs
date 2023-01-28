namespace MyGolestan
{
    partial class TermForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_finishEditing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_termName = new System.Windows.Forms.TextBox();
            this.bindingSource_term = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_startRegistration = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endRegistration = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_startTerm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endTerm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_classes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_classes = new System.Windows.Forms.BindingSource(this.components);
            this.btn_showClass = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_term)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_finishEditing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_termName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_startRegistration);
            this.groupBox1.Controls.Add(this.dateTimePicker_endRegistration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_startTerm);
            this.groupBox1.Controls.Add(this.dateTimePicker_endTerm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 71);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btn_finishEditing
            // 
            this.btn_finishEditing.Location = new System.Drawing.Point(477, 41);
            this.btn_finishEditing.Name = "btn_finishEditing";
            this.btn_finishEditing.Size = new System.Drawing.Size(174, 25);
            this.btn_finishEditing.TabIndex = 19;
            this.btn_finishEditing.Text = "Finish Editing";
            this.btn_finishEditing.UseVisualStyleBackColor = true;
            this.btn_finishEditing.Click += new System.EventHandler(this.btn_finishEditing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name (ID):";
            // 
            // txtBox_termName
            // 
            this.txtBox_termName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_term, "Name", true));
            this.txtBox_termName.Location = new System.Drawing.Point(551, 15);
            this.txtBox_termName.Name = "txtBox_termName";
            this.txtBox_termName.Size = new System.Drawing.Size(100, 22);
            this.txtBox_termName.TabIndex = 18;
            // 
            // bindingSource_term
            // 
            this.bindingSource_term.DataSource = typeof(MyGolestan.Term);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "End Registration:";
            // 
            // dateTimePicker_startRegistration
            // 
            this.dateTimePicker_startRegistration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_term, "StartRegister", true));
            this.dateTimePicker_startRegistration.Location = new System.Drawing.Point(124, 13);
            this.dateTimePicker_startRegistration.Name = "dateTimePicker_startRegistration";
            this.dateTimePicker_startRegistration.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker_startRegistration.TabIndex = 10;
            // 
            // dateTimePicker_endRegistration
            // 
            this.dateTimePicker_endRegistration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_term, "EndRegister", true));
            this.dateTimePicker_endRegistration.Location = new System.Drawing.Point(124, 44);
            this.dateTimePicker_endRegistration.Name = "dateTimePicker_endRegistration";
            this.dateTimePicker_endRegistration.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker_endRegistration.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Start Registration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "End Term:";
            // 
            // dateTimePicker_startTerm
            // 
            this.dateTimePicker_startTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_term, "StartTerm", true));
            this.dateTimePicker_startTerm.Location = new System.Drawing.Point(337, 13);
            this.dateTimePicker_startTerm.Name = "dateTimePicker_startTerm";
            this.dateTimePicker_startTerm.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker_startTerm.TabIndex = 8;
            // 
            // dateTimePicker_endTerm
            // 
            this.dateTimePicker_endTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_term, "EndTerm", true));
            this.dateTimePicker_endTerm.Location = new System.Drawing.Point(337, 44);
            this.dateTimePicker_endTerm.Name = "dateTimePicker_endTerm";
            this.dateTimePicker_endTerm.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker_endTerm.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Term:";
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
            this.dataGridView_classes.DataSource = this.bindingSource_classes;
            this.dataGridView_classes.Location = new System.Drawing.Point(12, 89);
            this.dataGridView_classes.Name = "dataGridView_classes";
            this.dataGridView_classes.ReadOnly = true;
            this.dataGridView_classes.RowHeadersWidth = 51;
            this.dataGridView_classes.RowTemplate.Height = 24;
            this.dataGridView_classes.Size = new System.Drawing.Size(776, 349);
            this.dataGridView_classes.TabIndex = 16;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name of Class";
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
            this.termDataGridViewTextBoxColumn.Width = 80;
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
            // bindingSource_classes
            // 
            this.bindingSource_classes.DataSource = typeof(MyGolestan.Class);
            // 
            // btn_showClass
            // 
            this.btn_showClass.Location = new System.Drawing.Point(690, 52);
            this.btn_showClass.Name = "btn_showClass";
            this.btn_showClass.Size = new System.Drawing.Size(98, 32);
            this.btn_showClass.TabIndex = 18;
            this.btn_showClass.Text = "Show Class";
            this.btn_showClass.UseVisualStyleBackColor = true;
            this.btn_showClass.Click += new System.EventHandler(this.btn_showClass_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(690, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 34);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // TermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_showClass);
            this.Controls.Add(this.dataGridView_classes);
            this.Controls.Add(this.groupBox1);
            this.Name = "TermForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Term Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_term)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_classes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_termName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startRegistration;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startTerm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_classes;
        private System.Windows.Forms.BindingSource bindingSource_classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource_term;
        private System.Windows.Forms.Button btn_showClass;
        private System.Windows.Forms.Button btn_finishEditing;
        private System.Windows.Forms.Button btn_exit;
    }
}