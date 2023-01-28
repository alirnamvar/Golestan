namespace MyGolestan
{
    partial class EditClassForm
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
            this.comBox_term = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.btn_updateClass = new System.Windows.Forms.Button();
            this.txtBox_credit = new System.Windows.Forms.TextBox();
            this.passtex = new System.Windows.Forms.Label();
            this.branchTex = new System.Windows.Forms.Label();
            this.txtbox_classID = new System.Windows.Forms.TextBox();
            this.StudentNumberTex = new System.Windows.Forms.Label();
            this.txtbox_className = new System.Windows.Forms.TextBox();
            this.FirstNameTex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_assignProfessor = new System.Windows.Forms.Button();
            this.dataGridView_professors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identicalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_professors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox_term);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comBox_field);
            this.groupBox1.Controls.Add(this.btn_updateClass);
            this.groupBox1.Controls.Add(this.txtBox_credit);
            this.groupBox1.Controls.Add(this.passtex);
            this.groupBox1.Controls.Add(this.branchTex);
            this.groupBox1.Controls.Add(this.txtbox_classID);
            this.groupBox1.Controls.Add(this.StudentNumberTex);
            this.groupBox1.Controls.Add(this.txtbox_className);
            this.groupBox1.Controls.Add(this.FirstNameTex);
            this.groupBox1.Location = new System.Drawing.Point(2, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 281);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            // 
            // comBox_term
            // 
            this.comBox_term.FormattingEnabled = true;
            this.comBox_term.Location = new System.Drawing.Point(102, 166);
            this.comBox_term.Name = "comBox_term";
            this.comBox_term.Size = new System.Drawing.Size(132, 24);
            this.comBox_term.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Term";
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(103, 105);
            this.comBox_field.Name = "comBox_field";
            this.comBox_field.Size = new System.Drawing.Size(132, 24);
            this.comBox_field.TabIndex = 27;
            // 
            // btn_updateClass
            // 
            this.btn_updateClass.BackColor = System.Drawing.Color.Silver;
            this.btn_updateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateClass.Location = new System.Drawing.Point(55, 210);
            this.btn_updateClass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateClass.Name = "btn_updateClass";
            this.btn_updateClass.Size = new System.Drawing.Size(180, 28);
            this.btn_updateClass.TabIndex = 29;
            this.btn_updateClass.Text = "Update";
            this.btn_updateClass.UseVisualStyleBackColor = false;
            this.btn_updateClass.Click += new System.EventHandler(this.btn_updateClass_Click);
            // 
            // txtBox_credit
            // 
            this.txtBox_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_credit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Credit", true));
            this.txtBox_credit.Location = new System.Drawing.Point(103, 137);
            this.txtBox_credit.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_credit.Name = "txtBox_credit";
            this.txtBox_credit.Size = new System.Drawing.Size(132, 22);
            this.txtBox_credit.TabIndex = 28;
            // 
            // passtex
            // 
            this.passtex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passtex.AutoSize = true;
            this.passtex.ForeColor = System.Drawing.Color.Black;
            this.passtex.Location = new System.Drawing.Point(53, 143);
            this.passtex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passtex.Name = "passtex";
            this.passtex.Size = new System.Drawing.Size(42, 16);
            this.passtex.TabIndex = 21;
            this.passtex.Text = "Credit";
            // 
            // branchTex
            // 
            this.branchTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchTex.AutoSize = true;
            this.branchTex.ForeColor = System.Drawing.Color.Black;
            this.branchTex.Location = new System.Drawing.Point(58, 113);
            this.branchTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branchTex.Name = "branchTex";
            this.branchTex.Size = new System.Drawing.Size(37, 16);
            this.branchTex.TabIndex = 22;
            this.branchTex.Text = "Field";
            // 
            // txtbox_classID
            // 
            this.txtbox_classID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_classID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "ID", true));
            this.txtbox_classID.Location = new System.Drawing.Point(103, 74);
            this.txtbox_classID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_classID.Name = "txtbox_classID";
            this.txtbox_classID.Size = new System.Drawing.Size(132, 22);
            this.txtbox_classID.TabIndex = 26;
            // 
            // StudentNumberTex
            // 
            this.StudentNumberTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNumberTex.AutoSize = true;
            this.StudentNumberTex.ForeColor = System.Drawing.Color.Black;
            this.StudentNumberTex.Location = new System.Drawing.Point(38, 80);
            this.StudentNumberTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNumberTex.Name = "StudentNumberTex";
            this.StudentNumberTex.Size = new System.Drawing.Size(57, 16);
            this.StudentNumberTex.TabIndex = 23;
            this.StudentNumberTex.Text = "Class ID";
            // 
            // txtbox_className
            // 
            this.txtbox_className.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_className.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Name", true));
            this.txtbox_className.Location = new System.Drawing.Point(103, 44);
            this.txtbox_className.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_className.Name = "txtbox_className";
            this.txtbox_className.Size = new System.Drawing.Size(132, 22);
            this.txtbox_className.TabIndex = 25;
            // 
            // FirstNameTex
            // 
            this.FirstNameTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTex.AutoSize = true;
            this.FirstNameTex.ForeColor = System.Drawing.Color.Black;
            this.FirstNameTex.Location = new System.Drawing.Point(14, 50);
            this.FirstNameTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameTex.Name = "FirstNameTex";
            this.FirstNameTex.Size = new System.Drawing.Size(81, 16);
            this.FirstNameTex.TabIndex = 24;
            this.FirstNameTex.Text = "Class Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_assignProfessor);
            this.groupBox2.Controls.Add(this.dataGridView_professors);
            this.groupBox2.Location = new System.Drawing.Point(279, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 281);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professors";
            // 
            // btn_assignProfessor
            // 
            this.btn_assignProfessor.BackColor = System.Drawing.Color.Silver;
            this.btn_assignProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignProfessor.Location = new System.Drawing.Point(165, 245);
            this.btn_assignProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_assignProfessor.Name = "btn_assignProfessor";
            this.btn_assignProfessor.Size = new System.Drawing.Size(200, 28);
            this.btn_assignProfessor.TabIndex = 25;
            this.btn_assignProfessor.Text = "Assign Professor";
            this.btn_assignProfessor.UseVisualStyleBackColor = false;
            this.btn_assignProfessor.Click += new System.EventHandler(this.btn_assignProfessor_Click);
            // 
            // dataGridView_professors
            // 
            this.dataGridView_professors.AutoGenerateColumns = false;
            this.dataGridView_professors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_professors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.identicalNumDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn});
            this.dataGridView_professors.DataSource = this.professorBindingSource;
            this.dataGridView_professors.Location = new System.Drawing.Point(6, 34);
            this.dataGridView_professors.Name = "dataGridView_professors";
            this.dataGridView_professors.RowHeadersWidth = 51;
            this.dataGridView_professors.RowTemplate.Height = 24;
            this.dataGridView_professors.Size = new System.Drawing.Size(508, 204);
            this.dataGridView_professors.TabIndex = 24;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // identicalNumDataGridViewTextBoxColumn
            // 
            this.identicalNumDataGridViewTextBoxColumn.DataPropertyName = "IdenticalNum";
            this.identicalNumDataGridViewTextBoxColumn.HeaderText = "IdenticalNum";
            this.identicalNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identicalNumDataGridViewTextBoxColumn.Name = "identicalNumDataGridViewTextBoxColumn";
            this.identicalNumDataGridViewTextBoxColumn.Width = 124;
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
            this.intFieldDataGridViewTextBoxColumn.Width = 70;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(MyGolestan.Professor);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MyGolestan.Class);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Class Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_professors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comBox_term;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.Button btn_updateClass;
        private System.Windows.Forms.TextBox txtBox_credit;
        private System.Windows.Forms.Label passtex;
        private System.Windows.Forms.Label branchTex;
        private System.Windows.Forms.TextBox txtbox_classID;
        private System.Windows.Forms.Label StudentNumberTex;
        private System.Windows.Forms.TextBox txtbox_className;
        private System.Windows.Forms.Label FirstNameTex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_assignProfessor;
        private System.Windows.Forms.DataGridView dataGridView_professors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identicalNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
    }
}