using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA_01
{
    public partial class FormDemarrage : Form
    {
        public FormDemarrage()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            FormAffichageCarte formAffichage = new FormAffichageCarte();
            formAffichage.Show();
        }

    }
}
