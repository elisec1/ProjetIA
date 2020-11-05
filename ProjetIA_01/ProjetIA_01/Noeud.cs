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
        public Noeud (double x, double y )
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

        public override double CalculeHCost()
        {
            //distance jusqu'à la fin
        }

        public override double GetArcCost(GenericNode N2)
        {
            Noeud N = (Noeud)N2;
            double coutArc = N2.GetGCost() - this.GetGCost();
            return coutArc;
        }
        public override bool EndState()
        {
            throw new NotImplementedException(); 
        }
        public override List<GenericNode> GetListSucc()
        {
            //
        }
    }
}
