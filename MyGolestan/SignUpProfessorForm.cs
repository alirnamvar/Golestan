using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MyGolestan
{
    public partial class SignUpProfessorForm : Form
    {
        private DataHandler DH { get; }
        public SignUpProfessorForm()
        {
            InitializeComponent();
            DH = new DataHandler();
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
        }

        private void btn_mainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage F1 = new MainPage();
            F1.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //var input = txtBoxPassword.Text;
            //var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMinimum8Chars = new Regex(@".{8,}");
            //var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);

            var isValidated = true;
            if (isValidated)
            {
                Professor prof = new Professor(txtbox_fullName.Text, txtbox_ID.Text,
                    txtBox_password.Text, (int)(FieldEnum)comBox_field.SelectedItem);

                bool isRegistrationSuccess = prof.RegisterToGolestan(Manager.GolestanManager.GetRegistor());
                if (isRegistrationSuccess)
                {                    
                    string path = Environment.CurrentDirectory + @"ProfessorsBinary.txt";
                    DH.AppendIRegisterableObjectsToBinaryFile(path, prof);

                    MessageBox.Show("Professor Added Succesfully");
                    btn_mainPage.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Professor did't Add Succesfully!");
                }
                
            }
            else
            {
                MessageBox.Show("Password must contains one Capital letter and one number.");
            }
        }
    }
}
