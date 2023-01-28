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
    public partial class EditStudentClassesForm : Form
    {
        private Student Student { get; set; }
        private BindingSource bsAllClasses { get; set; }
        private BindingSource bsRegisteredClasses { get; set; }
        private DataHandler DH { get; }
        public EditStudentClassesForm(Student stu)
        {
            InitializeComponent();
            Student = stu;
            DH = new DataHandler();
            bsAllClasses = new BindingSource
            {
                DataSource = Manager.GolestanManager.Classes
            };
            dataGridView_allClasses.DataSource = bsAllClasses;
        }

        private void btn_updateRegisteredClasses_Click(object sender, EventArgs e)
        {
            bsRegisteredClasses = new BindingSource
            {
                DataSource = Student.RegisteredClasses
            };
            dataGridView_registeredClasses.DataSource = bsRegisteredClasses;
        }

        private void btn_removeClass_Click(object sender, EventArgs e)
        {
            if (Student.RegisteredClasses.Count != 0)
            {
                Class cls = (Class)bsRegisteredClasses.Current;
                cls.RemoveStudent(Student);
                bsRegisteredClasses.RemoveCurrent();
                DH.UpdateClass(Manager.GolestanManager.Classes, cls);
                DH.UpdateStudent(Manager.GolestanManager.Students, Student);
            }
            else
            {
                MessageBox.Show("There Is No Class To Remove!");
            } 
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            Class newClass = (Class)bsAllClasses.Current;
            bool hasClassAdded = Manager.GolestanManager.AddStudent(Student.IdenticalNum, newClass.ID);
            if (hasClassAdded)
            {
                DH.UpdateClass(Manager.GolestanManager.Classes, newClass);
                MessageBox.Show("student added successfully to the class");
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            DH.UpdateStudent(Manager.GolestanManager.Students, Student);
            this.Close();
        }

        private void EditStudentClasses_Load(object sender, EventArgs e)
        {
            lbl_maxCredit.Text = Student.MaxCredit.ToString();
        }

    }
}
