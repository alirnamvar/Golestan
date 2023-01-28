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
    public partial class TermForm : Form
    {
        private Term Term { get; set; }
        public TermForm(Term term)
        {
            InitializeComponent();
            Term = term;
            bindingSource_term.DataSource = Term;
            //////////////////////////////
            bindingSource_classes.DataSource = (List<Class>)Term.Classes;
            //////////////////////////////
        }

        private void btn_showClass_Click(object sender, EventArgs e)
        {
            if (bindingSource_classes.Current != null)
            {
                //this.Hide();
                EditClassForm scf = new EditClassForm((Class)bindingSource_classes.Current);
                scf.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("This Term Has No Class!");
            }
            
        }

        private void btn_finishEditing_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.UpdateTerm(Manager.GolestanManager.Terms, Term);
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
