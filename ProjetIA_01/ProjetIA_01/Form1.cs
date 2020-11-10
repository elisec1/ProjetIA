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
            char cas=''; //il veut forcement que je mette autre chose ici
            if(radioButton1.Checked)
            {
                cas = 'a';
            }
            else
            {
                if(radioButton2.Checked)
                {
                    cas = 'b';
                }
                else
                {
                    if(radioButton3.Checked)
                    {
                        cas = 'c';
                    }
                    else
                    {
                        //comment on dit erreur ?
                    }
                }
            }
            Noeud conditionsInitiales = new Noeud(100, 200, 80, 180, cas);
            SearchTree Arbre = new SearchTree();
            List<GenericNode> chemin = Arbre.RechercheSolutionAEtoile(conditionsInitiales);
            for (int i = 0; i < chemin.Count() - 1; i++)
            {
                DessinSegment((Noeud)chemin[i], (Noeud)chemin[i + 1]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //cas a
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e) //image de fond
        {

        }
    }
}
