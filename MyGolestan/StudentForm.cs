using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGolestan
{
    public partial class StudentForm : Form
    {
        private Student Student { get; }
        private BindingSource bsTerms { get; set; }
        private Term CurrentTerm { get; set; }
        private DateTime Now { get; }

        public StudentForm(Student stu)
        {
            InitializeComponent();
            PersianCal();
            Student = stu;
            bsTerms = new BindingSource();
            Now = DateTime.Now;
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 800;
            timer.Start();
        }

        private Term FindCurrentTerm()
        {
            //var now = DateTime.Now;
            foreach (var term in Manager.GolestanManager.Terms)
            {
                if (Now < term.EndTerm && Now > term.StartTerm)
                {
                    return term;
                }
            }
            return null;
        }

        private void PersianCal()
        {
            PersianCalendar p = new PersianCalendar();
            DateTime dt = DateTime.Now;
            int y, m, d;
            y = p.GetYear(dt); 
            m = p.GetMonth(dt);
            d = p.GetDayOfMonth(dt);
            lbl_date.Text = y.ToString() + "/" + m.ToString() + "/" + d.ToString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btn_showTermAndClasses_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Terms.Count != 0)
            {
                StudentRegisteredClasses srcf = new StudentRegisteredClasses(Student, (Term)bsTerms.Current);
                srcf.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Term To Show!");
            }
            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Manager.GolestanManager.LoadDataBase();
        }

        private void tabPage_personalInformation_Enter(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = Student;
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            comBox_field.SelectedIndex = Student.IntField - 1;
        }

        private void tabPage_terms_Enter(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Terms.Count != 0)
            {
                bsTerms.DataSource = Manager.GolestanManager.Terms;
                dataGridView_terms.DataSource = bsTerms;
            }
        }

        private void btn_updateInformation_Click(object sender, EventArgs e)
        {
            Student.UpdateField((int)(FieldEnum)comBox_field.SelectedItem);
            DataHandler dh = new DataHandler();
            dh.UpdateStudent(Manager.GolestanManager.Students, Student);
            MessageBox.Show("Updated");
        }

        private void btn_canRegister_Click(object sender, EventArgs e)
        {
            if (Now > CurrentTerm.StartRegister && Now < CurrentTerm.EndRegister)
            {
                MessageBox.Show("Time For Registration");
                btn_register.Enabled = true;
            }
            else
            {
                MessageBox.Show("Not In Registration Time");
                btn_register.Enabled = false;
            }
        }

        private void tabPage_registration_Enter(object sender, EventArgs e)
        {
            CurrentTerm = FindCurrentTerm();
            BindingSource bst = new BindingSource();
            bst.DataSource = CurrentTerm;
            dataGridView_currentTerm.DataSource = bst;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterClassesStudentForm rcsf = new RegisterClassesStudentForm(Student, CurrentTerm);
            rcsf.ShowDialog();
        }
    }
}
