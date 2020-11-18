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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fond.Hide();
            btnAfficherTrajectoire.Hide();
            btnRecommencer.Hide();
            lblChoix.Hide();
            radioA.Hide();
            radioB.Hide();
            radioC.Hide();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void DessinSegment(Noeud n1, Noeud n2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            double x1 = n1.X;
            double x2 = n2.X;
            double y1 = n1.Y;
            double y2 = n2.Y;
            Pen penwhite = new Pen(Color.White); // d’autres couleurs sont disponibles
            Graphics g = fond.CreateGraphics();
            g.DrawLine(penwhite, new Point((int)x1, fond.Height - (int)y1),
            new Point((int)x2, fond.Height - (int)y2));
        }

        private void btnAfficherTrajectoire_Click(object sender, EventArgs e) //affichage trajectoire
        {
            Stopwatch stopwatch = new Stopwatch(); //Permet de calculer le temps d'execution du programme
            stopwatch.Start();
            char cas='d';
            double x = 0;
            double y = 0;
            double Xf = 0;
            double Yf = 0;
            if (radioA.Checked)
            {
                cas = 'a';
                x = 100;
                y = 200;
                Xf = 200;
                Yf = 100;

            }
            else if (radioB.Checked)
            {
                cas = 'b';
                x = 100;
                y = 200;
                Xf = 200;
                Yf = 100;
            }
            else if (radioC.Checked)
            {
                cas = 'c';
                x = 200;
                y = 100;
                Xf = 100;
                Yf = 200;
            }
            Noeud conditionsInitiales = new Noeud(x, y, Xf, Yf, cas);
            SearchTree Arbre = new SearchTree();
            List<GenericNode> chemin = Arbre.RechercheSolutionAEtoile(conditionsInitiales);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                DessinSegment((Noeud)chemin[i], (Noeud)chemin[i + 1]);
            }
            btnRecommencer.Show();
            stopwatch.Stop();  //Fin du calcul du temps d'execution du programme
            lblSolution.Text = "Une solution a été trouvée en " + stopwatch.Elapsed.TotalSeconds + " secondes.";
            lblSolution.Visible = true;
        }

        private void radioA_CheckedChanged(object sender, EventArgs e) //cas a
        {
            btnAfficherTrajectoire.Show();
            fond.Show();
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            btnDemarrer.Hide();
            lblChoix.Show();
            radioA.Show();
            radioB.Show();
            radioC.Show();

        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            btnAfficherTrajectoire.Show();
            fond.Show();
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            btnAfficherTrajectoire.Show();
            fond.Show();
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            MainForm NewForm = new MainForm();
            NewForm.Show();
            this.Dispose(false);
        }



    }
}
