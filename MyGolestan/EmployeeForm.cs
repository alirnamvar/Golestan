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
    public partial class EmployeeForm : Form
    {
        private DataHandler DH { get; }
        private BindingSource bsTerms { get; set; }
        private BindingSource bsClassList { get; set; }
        private BindingSource bsStudentList { get; set; }
        private BindingSource bsProfessorList { get; set; }
        private Employee Employee { get; }
        public EmployeeForm(Employee emp)
        {
            InitializeComponent();
            DH = new DataHandler();
            Employee = emp;
        }

        private void btn_createTerm_Click(object sender, EventArgs e)
        {
            Term t = new Term(txtBox_termName.Text, dateTimePicker_startTerm.Value,
                dateTimePicker_endTerm.Value, dateTimePicker_startRegistration.Value,
                dateTimePicker_endRegistration.Value);
            Manager.GolestanManager.AddTerm(t);
            
            // save term to file
            string path = Environment.CurrentDirectory + @"TermsBinary.txt";
            DH.AddTerm(path, t);

            MessageBox.Show("Term Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_showTerms_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Terms.Count != 0)
            {
                bsTerms = new BindingSource
                {
                    DataSource = Manager.GolestanManager.Terms
                };
                dataGridView_terms.DataSource = bsTerms;
            }
            else
            {
                MessageBox.Show("There Is No Term To Show, Add One!");
            }

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_showSelectedTerm_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Terms.Count != 0)
            {
                TermForm tf = new TermForm((Term)bsTerms.Current);
                tf.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Is No Term To Edit!");
            }
            
        }

        private void toolStripButton_makeClass_Click(object sender, EventArgs e)
        {
            CreateClassForm ccf = new CreateClassForm();
            ccf.ShowDialog();
        }

        private void toolStripButton_updateClassList_Click(object sender, EventArgs e)
        {
            bsClassList = new BindingSource
            {
                DataSource = Manager.GolestanManager.Classes
            };
            dataGridView_classList.DataSource = bsClassList;
        }

        private void toolStripButton_removeClass_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Classes.Count != 0)
            {
                bsClassList.RemoveCurrent();
                DH.UpdateClass(Manager.GolestanManager.Classes, (Class)bsClassList.Current);
            }
            else
            {
                MessageBox.Show("There Is No Class To Remove!");
            }

        }

        private void toolStripButton_editClass_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Classes.Count != 0)
            {
                EditClassForm cif = new EditClassForm((Class)bsClassList.Current);
                cif.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Is No Class To Edit!");
            }  
        }

        private void toolStripButton_updateStudentList_Click(object sender, EventArgs e)
        {
            bsStudentList = new BindingSource
            {
                DataSource = Manager.GolestanManager.Students
            };
            dataGridView_studentList.DataSource = bsStudentList;

        }

        private void toolStripButton_editStudent_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Students.Count != 0)
            {
                EditStudentForm esf = new EditStudentForm((Student)bsStudentList.Current);
                esf.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Is No Student To Edit!");
            }
        }

        private void toolStripButton_updateProfessorList_Click(object sender, EventArgs e)
        {
            bsProfessorList = new BindingSource
            {
                DataSource = Manager.GolestanManager.Professors
            };
            dataGridView_professorList.DataSource = bsProfessorList;
        }

        private void toolStripButton_editProfessor_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Professors.Count != 0)
            {
                EditProfessorForm epf = new EditProfessorForm((Professor)bsProfessorList.Current);
                epf.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Is No Professor To Edit!");
            }
            
        }

        private void toolStripButton_addRemoveClass_Click(object sender, EventArgs e)
        {
            if (Manager.GolestanManager.Students.Count != 0)
            {
                EditStudentClassesForm escf = new EditStudentClassesForm((Student)bsStudentList.Current);
                escf.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Is No Student To Change It's Classes!");
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Manager.GolestanManager.LoadDataBase();
            //btn_showTerms_Click(sender, e);
            toolStripButton_updateClassList_Click(sender, e);
            toolStripButton_updateStudentList_Click(sender, e);
            toolStripButton_updateProfessorList_Click(sender, e);
        }
    }
}
