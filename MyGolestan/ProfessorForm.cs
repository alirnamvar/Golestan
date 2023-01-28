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
    public partial class ProfessorForm : Form
    {
        private Professor Professor { get; }
        public ProfessorForm(Professor professor)
        {
            InitializeComponent();
            Professor = professor;
        }
    }
}
