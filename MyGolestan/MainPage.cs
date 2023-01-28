using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolestan
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?",
                "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void lbl_addAccount_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student")
            {
                SignUpStudentForm stu = new SignUpStudentForm();
                this.Hide();
                stu.ShowDialog();
                this.Close();
            }
            else if (comboBox1.Text == "Professor")
            {
                SignUpProfessorForm pro = new SignUpProfessorForm();
                //this.Hide();
                pro.ShowDialog();
                //this.Close();
            }
            else if (comboBox1.Text == "Employee")
            {
                SignUpEmployeeForm emp = new SignUpEmployeeForm();
                //this.Hide();
                emp.ShowDialog();
                //this.Close();
            }
            else
                MessageBox.Show("Please choose one!");
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Manager.GolestanManager.LoadDataBase();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioButton_student.Checked)
            {
                Student stu = Manager.GolestanManager.GetStudent(txtbox_username.Text, txtbox_password.Text);
                if (stu != null)
                {
                    StudentForm sf = new StudentForm(stu);
                    sf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Such Student Exists!");
                }
            }
            else if (radioButton_employee.Checked)
            {
                Employee emp = Manager.GolestanManager.GetEmployee(txtbox_username.Text, txtbox_password.Text);
                if (emp != null)
                {
                    EmployeeForm ef = new EmployeeForm(emp);
                    ef.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Such Employee Exists!");
                }
            }
            else if (radioButton_professor.Checked)
            {
                Professor prof = Manager.GolestanManager.GetProfessor(txtbox_username.Text, txtbox_password.Text);
                if (prof != null)
                {
                    ProfessorForm pf = new ProfessorForm(prof);
                    pf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Such Professor Exists!");
                }
            }
        }
    }
}
