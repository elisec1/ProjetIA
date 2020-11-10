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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Noeud conditionsInitiales = new Noeud(0, 0, 100, 200);
            SearchTree Arbre = new SearchTree();
            List<GenericNode> chemin = Arbre.RechercheSolutionAEtoile(conditionsInitiales);
            for (int i=0; i<chemin.Count()-1; i++)
            {
                DessinSegment((Noeud)chemin[i], (Noeud)chemin[i + 1]);
            }
            */
        }

        public void DessinSegment(Noeud n1, Noeud n2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            double x1 = n1.X;
            double x2 = n2.X;
            double y1 = n1.Y;
            double y2 = n2.Y;
            Pen penwhite = new Pen(Color.White); // d’autres couleurs sont disponibles
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(penwhite, new Point((int)x1, pictureBox1.Height - (int)y1),
            new Point((int)x2, pictureBox1.Height - (int)y2));
        }

        private void button1_Click(object sender, EventArgs e) //affichage trajectoire
        {
            Noeud conditionsInitiales = new Noeud(100, 200, 200, 100);
            SearchTree Arbre = new SearchTree();
            List<GenericNode> chemin = Arbre.RechercheSolutionAEtoile(conditionsInitiales);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                DessinSegment((Noeud)chemin[i], (Noeud)chemin[i + 1]);
            }
        }
    }
}
