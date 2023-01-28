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
    public partial class EditProfessorForm : Form
    {
        private Professor Professor { get; set; }
        public EditProfessorForm()
        {
            InitializeComponent();
        }

        public EditProfessorForm(Professor prof)
        {
            InitializeComponent();
            Professor = prof;
            professorBindingSource.DataSource = Professor;
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            comBox_field.SelectedIndex = Professor.IntField - 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Professor.UpdateField((int)(FieldEnum)comBox_field.SelectedItem);

            DataHandler dh = new DataHandler();
            dh.UpdateProfessor(Manager.GolestanManager.Professors, Professor);

            this.Close();
        }
    }
}
