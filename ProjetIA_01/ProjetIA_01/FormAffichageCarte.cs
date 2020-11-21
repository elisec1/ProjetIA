using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA_01
{
    public partial class FormAffichageCarte : Form
    {
        public FormAffichageCarte()
        {
            InitializeComponent();
        }

        private void btnAfficherTrajectoire_Click(object sender, EventArgs e) //affichage trajectoire
        {
            char cas = 'd';
            double x = 0;
            double y = 0;
            double Xf = 0;
            double Yf = 0;
            if (radioA.Checked)
            {
                cas = 'a';
                x = 100;
                y = 200;
                Xf = 110;
                Yf = 190;

            }
            else if (radioB.Checked)
            {
                cas = 'b';
                x = 100;
                y = 200;
                Xf = 110;
                Yf = 190;
            }
            else if (radioC.Checked)
            {
                cas = 'c';
                x = 100;
                y = 200;
                Xf = 110;
                Yf = 190;
            }
            Noeud conditionsInitiales = new Noeud(x, y, Xf, Yf, cas);
            SearchTree Arbre = new SearchTree();
            List<GenericNode> chemin = Arbre.RechercheSolutionAEtoile(conditionsInitiales);
            double tempsTotal = 0;
            double distanceTotale = 0;
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                Noeud noeud = (Noeud)chemin[i];
                Noeud noeud1 = (Noeud)chemin[i+1];
                DessinSegment(noeud, noeud1);
                tempsTotal = tempsTotal + noeud.GetArcCost(noeud1);
                distanceTotale = distanceTotale + Math.Sqrt(Math.Pow(Math.Abs(noeud.X - noeud1.X), 2) + Math.Pow(Math.Abs(noeud.Y - noeud1.Y), 2));
                richTextBoxNoeu.Text = richTextBoxNoeu.Text +noeud.ToString();
            }
            btnRecommencer.Show();
            lblTemps.Text = lblTemps.Text + tempsTotal;
            lblDistance.Text = lblDistance.Text + distanceTotale;
        }
        public void DessinSegment(Noeud n1, Noeud n2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            double x1 = n1.X;
            double x2 = n2.X;
            double y1 = n1.Y;
            double y2 = n2.Y;
            Pen penwhite = new Pen(Color.White);
            Graphics g = fond.CreateGraphics();
            g.DrawLine(penwhite, new Point((int)x1, fond.Height - (int)y1),
            new Point((int)x2, fond.Height - (int)y2));
        }
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
