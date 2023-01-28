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
    public partial class EditClassForm : Form
    {
        private Class Class { get; set; }
        public EditClassForm()
        {
            InitializeComponent();
        }

        public EditClassForm(Class cls)
        {
            InitializeComponent();
            Class = cls;
            classBindingSource.DataSource = Class;
            professorBindingSource.DataSource = Manager.GolestanManager.Professors;
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            comBox_field.SelectedIndex = Class.IntField - 1;
            comBox_term.DataSource = Manager.GolestanManager.Terms;
            comBox_term.SelectedIndex = Class.Term.ID;
            dataGridView_professors.DataSource = professorBindingSource;
        }

        private void btn_updateClass_Click(object sender, EventArgs e)
        {
            Class.UpdateField((int)(FieldEnum)comBox_field.SelectedItem);
            Class.UpdateTerm((Term)comBox_term.SelectedItem);

            // update class in file
            DataHandler dh = new DataHandler();
            dh.UpdateClass(Manager.GolestanManager.Classes, Class);

            this.Close();
        }

        private void btn_assignProfessor_Click(object sender, EventArgs e)
        {
            Professor prof = (Professor)professorBindingSource.Current;
            bool hasProfessorAssig = Manager.GolestanManager.AddProfessor(prof.IdenticalNum, Class.ID);
            if (hasProfessorAssig)
            {
                // update class in file
                DataHandler dh = new DataHandler();
                dh.UpdateClass(Manager.GolestanManager.Classes, Class);

                this.Close();
            }
            //else
            //{
            //    MessageBox.Show("Error: Can't Add Professor!");
            //}
        }
    }
}
