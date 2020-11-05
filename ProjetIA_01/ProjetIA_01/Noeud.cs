using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA_01
{
    class Noeud : GenericNode
    {

        double X
        {
            get;set;
        }
        double Y
        {
            get;set;
        }
        public Noeud (double x, double y): base()
        {
            X = x;
            Y = y;
        }
        public override bool IsEqual(GenericNode N2)
        {
            Noeud N = (Noeud)N2;
            bool estEgal = false;
            if (N.X == X && N.Y == Y)
            {
                estEgal = true;
            }
            return estEgal;
        }

        public override double CalculeHCost(GenericNode N2)
        {
            Noeud Nf = (Noeud)N2;
            double distance = Math.Sqrt(Math.Pow(Nf.X - X,2)+ Math.Pow(Nf.Y - Y,2));
            return distance;
        }

        public override double GetArcCost(GenericNode N2)
        {
            Noeud N = (Noeud)N2;
            double coutArc = N2.GetGCost() - this.GetGCost();
            return coutArc;
        }
        public override bool EndState(GenericNode N2)
        {
            Noeud Nf = (Noeud)N2;
            if (IsEqual(Nf) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override List<GenericNode> GetListSucc()
        {
            Noeud NoeudHautGauche = new Noeud(X - 1, Y + 1);
            Noeud NoeudHaut = new Noeud(X, Y + 1);
            Noeud NoeudHautDroite = new Noeud(X + 1, Y + 1);
            Noeud NoeudDroite = new Noeud(X + 1, Y);
            Noeud NoeudBasDroite = new Noeud(X + 1, Y - 1);
            Noeud NoeudBas = new Noeud(X, Y - 1);
            Noeud NoeudBasGauche = new Noeud(X - 1, Y - 1);
            Noeud NoeudGauche = new Noeud(X-1, Y);
            Enfants = Enfants.Add(NoeudHautGauche);

            return Enfants;

        }
    }
}
