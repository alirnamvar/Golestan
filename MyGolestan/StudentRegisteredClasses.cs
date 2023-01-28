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
    public partial class StudentRegisteredClasses : Form
    {
        private Student Student { get; }
        private Term Term { get; }
        private BindingSource bsClasses { get; set; }
        public StudentRegisteredClasses(Student student, Term term)
        {
            InitializeComponent();
            Student = student;
            Term = term;
            bsClasses = new BindingSource();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentRegisteredClasses_Load(object sender, EventArgs e)
        {
            lbl_studentName.Text = $"{Student.Name} ({Student.IdenticalNum})";
            List<Class> tempClasses = new List<Class>();
            foreach (var cls in Student.RegisteredClasses)
            {
                if (cls.Term.ID == Term.ID)
                {
                    tempClasses.Add(cls);
                }
            }
            bsClasses.DataSource = tempClasses;
            dataGridView_classes.DataSource = bsClasses;
        }
    }
}
