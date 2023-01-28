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
    public partial class RegisterClassesStudentForm : Form
    {
        private Student Student { get; set; }
        private Term Term { get; set; }
        private BindingSource bsAllClasses { get; set; }
        private BindingSource bsRegisteredClasses { get; set; }
        private List<Class> CurrentTermClasses { get; }
        private DataHandler DH { get; }
        public RegisterClassesStudentForm(Student stu, Term term)
        {
            InitializeComponent();
            Student = stu;
            Term = term;
            CurrentTermClasses = new List<Class>();
            DH = new DataHandler();
            Init();
        }

        private void Init()
        {
            foreach (var cls in Manager.GolestanManager.Classes)
            {
                if (cls.Term.ID == Term.ID)
                {
                    CurrentTermClasses.Add(cls);
                }
            }
            bsAllClasses = new BindingSource
            {
                DataSource = CurrentTermClasses
            };
            dataGridView_allClasses.DataSource = bsAllClasses;
            
        }

        private void btn_updateRegisteredClasses_Click(object sender, EventArgs e)
        {
            List<Class> classes = new List<Class>();
            foreach (var cls in Student.RegisteredClasses)
            {
                if (cls.Term.ID == Term.ID)
                {
                    classes.Add(cls);
                }
            }
            bsRegisteredClasses = new BindingSource
            {
                DataSource = classes
            };
            dataGridView_registeredClasses.DataSource = bsRegisteredClasses;
        }

        private void btn_removeClass_Click(object sender, EventArgs e)
        {
            if ((Class)bsRegisteredClasses.Current != null)
            {
                Class cls = (Class)bsRegisteredClasses.Current;
                cls.RemoveStudent(Student);
                Student.RemoveClass(cls);
                bsRegisteredClasses.RemoveCurrent();
                DH.UpdateClass(Manager.GolestanManager.Classes, cls);
                DH.UpdateStudent(Manager.GolestanManager.Students, Student);
            }
            else
            {
                MessageBox.Show("There Is No Class To Remove!");
            }
            lbl_registeredCredit.Text = Student.GetTermRegisteredCredits(Term).ToString();
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            Class newClass = (Class)bsAllClasses.Current;
            bool hasClassAdded = Manager.GolestanManager.AddStudent(Student.IdenticalNum, newClass.ID);
            if (hasClassAdded)
            {
                var s = Student;
                DH.UpdateClass(Manager.GolestanManager.Classes, newClass);
                MessageBox.Show("student added successfully to the class");
            }
            lbl_registeredCredit.Text = Student.GetTermRegisteredCredits(Term).ToString();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            DH.UpdateStudent(Manager.GolestanManager.Students, Student);
            this.Close();
        }

        private void RegisterClassesStudentForm_Load(object sender, EventArgs e)
        {
            lbl_maxCredit.Text = Student.MaxCredit.ToString();
            lbl_registeredCredit.Text = Student.GetTermRegisteredCredits(Term).ToString();
            btn_updateRegisteredClasses_Click(sender, e);
        }
    }
}
