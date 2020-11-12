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
            pictureBox1.Hide();
            button1.Hide();
            button3.Hide();
            label1.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            
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
            pictureBox1.Show();
            char cas='d';
            if (radioButton1.Checked)
            {
                cas = 'a';
            }
            else
            {
                if (radioButton2.Checked)
                {
                    cas = 'b';
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        cas = 'c';
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
            button3.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //cas a
        {
            button1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //image de fond
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            label1.Show();
            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
