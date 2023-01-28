using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolestan
{
    public partial class SignUpEmployeeForm : Form
    {
        private DataHandler DH { get; }
        public SignUpEmployeeForm()
        {
            InitializeComponent();
            DH = new DataHandler();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //var input = txtBoxPassword.Text;
            //var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMinimum8Chars = new Regex(@".{8,}");
            //var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);

            var isValidated = true;
            if (isValidated)
            {
                Employee emp = new Employee(txtBox_fullName.Text, txtBox_ID.Text, txtBox_password.Text);

                bool isRegistrationSuccess = emp.RegisterToGolestan(Manager.GolestanManager.GetRegistor());
                if (isRegistrationSuccess)
                {
                    string path = Environment.CurrentDirectory + @"EmployeesBinary.txt";
                    DH.AppendIRegisterableObjectsToBinaryFile(path, emp);

                    MessageBox.Show("Employee Added Succesfully");
                    btn_mainPage.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Employee did't Add Succesfully!");
                }
            }
            else
            {
                MessageBox.Show("Password must contains one Capital letter and one number.");
            }
        }

        private void btn_mainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage F1 = new MainPage();
            F1.ShowDialog();
            this.Close();
        }
    }
}
