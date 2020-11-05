using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA_01
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Noeud pointDepart = new Noeud(0, 0);
            Noeud pointArrivee = new Noeud(10, 18);
            SearchTree Arbre = new SearchTree();
        }
    }
}
