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
            Reinitialiser();
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
            double tempsTotal = 0;
            double distanceTotale = 0;
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                Noeud noeud = (Noeud)chemin[i];
                Noeud noeud1 = (Noeud)chemin[i+1];
                DessinSegment(noeud, noeud1);
                tempsTotal = tempsTotal + noeud.GetArcCost(noeud1);
                distanceTotale = distanceTotale + Math.Sqrt(Math.Pow(Math.Abs(noeud.X - noeud1.X), 2) + Math.Pow(Math.Abs(noeud.Y - noeud1.Y), 2));
                richTextBoxNoeud.Text = richTextBoxNoeud.Text +noeud.ToString();
                
            }
            btnRecommencer.Show();
            lblTemps.Text = lblTemps.Text + Math.Round(tempsTotal, 1) + " h" ;
            lblDistance.Text = lblDistance.Text + Math.Round(distanceTotale, 1) + " Km";
            lblOuverts.Text = lblOuverts.Text + Arbre.L_Fermes.Count();
            lblFermes.Text = lblFermes.Text + Arbre.L_Ouverts.Count();


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
            Reinitialiser();
            //Close();
        }

        public void Reinitialiser ()
        {
            fond.Show();
            fond.BringToFront();
            fond.Refresh();
            lblDistance.Text = "Distance Totale : ";
            lblTemps.Text = "Temps de parcourt total :";
            richTextBoxNoeud.Text = "";
            lblFermes.Text = "Nombre de fermés : ";
            lblOuverts.Text = "Nombre d'ouverts : ";
        }


    }
}
