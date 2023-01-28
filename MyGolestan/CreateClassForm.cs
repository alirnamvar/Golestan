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
    public partial class CreateClassForm : Form
    {
        public CreateClassForm()
        {
            InitializeComponent();
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            comBox_term.DataSource = Manager.GolestanManager.Terms;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createClass_Click(object sender, EventArgs e)
        {
            bool classHasMade = Manager.GolestanManager.MakeClass(txtbox_className.Text, txtbox_classID.Text,
                (int)(FieldEnum)comBox_field.SelectedItem, int.Parse(txtBox_credit.Text),
                (Term)comBox_term.SelectedItem);

            if (classHasMade)
            {
                MessageBox.Show("Class Added Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("this class id previously use");
            }
        }
    }
}
