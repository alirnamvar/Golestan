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
    public partial class EditStudentForm : Form
    {
        private Student Student { get; set; }
        public EditStudentForm()
        {
            InitializeComponent();
        }

        public EditStudentForm(Student stu)
        {
            InitializeComponent();
            Student = stu;
            studentBindingSource.DataSource = Student;
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            comBox_field.SelectedIndex = Student.IntField - 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student.UpdateField((int)(FieldEnum)comBox_field.SelectedItem);

            DataHandler dh = new DataHandler();
            dh.UpdateStudent(Manager.GolestanManager.Students, Student);

            this.Close();
        }
    }
}
