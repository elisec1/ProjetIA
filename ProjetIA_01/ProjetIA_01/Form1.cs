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
            PictureBox bof = new PictureBox();
            bof.ImageLocation = "C:/Users/elise/Downloads/IMG_20191130_155337.jpg";
            bof.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
