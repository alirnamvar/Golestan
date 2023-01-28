namespace MyGolestan
{
    partial class EditProfessorForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.passtex = new System.Windows.Forms.Label();
            this.branchTex = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.StudentNumberTex = new System.Windows.Forms.Label();
            this.txtbox_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTex = new System.Windows.Forms.Label();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.comBox_field);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.txtBox_password);
            this.panel2.Controls.Add(this.passtex);
            this.panel2.Controls.Add(this.branchTex);
            this.panel2.Controls.Add(this.txtbox_ID);
            this.panel2.Controls.Add(this.StudentNumberTex);
            this.panel2.Controls.Add(this.txtbox_fullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FirstNameTex);
            this.panel2.Location = new System.Drawing.Point(103, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 407);
            this.panel2.TabIndex = 5;
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(255, 181);
            this.comBox_field.Name = "comBox_field";
            this.comBox_field.Size = new System.Drawing.Size(132, 24);
            this.comBox_field.TabIndex = 3;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Silver;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(186, 254);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(201, 28);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtBox_password
            // 
            this.txtBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "Password", true));
            this.txtBox_password.Location = new System.Drawing.Point(254, 213);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(132, 22);
            this.txtBox_password.TabIndex = 4;
            // 
            // passtex
            // 
            this.passtex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passtex.AutoSize = true;
            this.passtex.ForeColor = System.Drawing.Color.Black;
            this.passtex.Location = new System.Drawing.Point(183, 213);
            this.passtex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passtex.Name = "passtex";
            this.passtex.Size = new System.Drawing.Size(67, 16);
            this.passtex.TabIndex = 0;
            this.passtex.Text = "Password";
            // 
            // branchTex
            // 
            this.branchTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchTex.AutoSize = true;
            this.branchTex.ForeColor = System.Drawing.Color.Black;
            this.branchTex.Location = new System.Drawing.Point(209, 181);
            this.branchTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branchTex.Name = "branchTex";
            this.branchTex.Size = new System.Drawing.Size(37, 16);
            this.branchTex.TabIndex = 0;
            this.branchTex.Text = "Field";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "IdenticalNum", true));
            this.txtbox_ID.Location = new System.Drawing.Point(254, 150);
            this.txtbox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(132, 22);
            this.txtbox_ID.TabIndex = 2;
            // 
            // StudentNumberTex
            // 
            this.StudentNumberTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNumberTex.AutoSize = true;
            this.StudentNumberTex.ForeColor = System.Drawing.Color.Black;
            this.StudentNumberTex.Location = new System.Drawing.Point(175, 153);
            this.StudentNumberTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNumberTex.Name = "StudentNumberTex";
            this.StudentNumberTex.Size = new System.Drawing.Size(71, 16);
            this.StudentNumberTex.TabIndex = 0;
            this.StudentNumberTex.Text = "ID Number";
            // 
            // txtbox_fullName
            // 
            this.txtbox_fullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_fullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "Name", true));
            this.txtbox_fullName.Location = new System.Drawing.Point(254, 120);
            this.txtbox_fullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_fullName.Name = "txtbox_fullName";
            this.txtbox_fullName.Size = new System.Drawing.Size(132, 22);
            this.txtbox_fullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(173, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Professor Information";
            // 
            // FirstNameTex
            // 
            this.FirstNameTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTex.AutoSize = true;
            this.FirstNameTex.ForeColor = System.Drawing.Color.Black;
            this.FirstNameTex.Location = new System.Drawing.Point(179, 126);
            this.FirstNameTex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameTex.Name = "FirstNameTex";
            this.FirstNameTex.Size = new System.Drawing.Size(68, 16);
            this.FirstNameTex.TabIndex = 0;
            this.FirstNameTex.Text = "Full Name";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(MyGolestan.Professor);
            // 
            // EditProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "EditProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Professor Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label passtex;
        private System.Windows.Forms.Label branchTex;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Label StudentNumberTex;
        private System.Windows.Forms.TextBox txtbox_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FirstNameTex;
        private System.Windows.Forms.BindingSource professorBindingSource;
    }
}