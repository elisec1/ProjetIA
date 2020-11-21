using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIA_01
{
    public class Noeud : GenericNode
    {

        public double X { get; set; }
        public double Y { get; set; }
        public char cas { get; set; }
        public static Noeud Nf { get; set; }

        //CONCTRUCTEURS
        public Noeud (double x, double y): base()
        {
            X = x;
            Y = y;
        }
        public Noeud(double x, double y, double xf, double yf, char choixCas) : base()
        {
            X = x;
            Y = y;
            Nf = new Noeud(xf, yf);
            cas = choixCas;
        }

        //METHODES
        public override bool IsEqual(GenericNode N2)
        {
            //on travaille avec des entiers donc tester l'égalité est acceptable
            Noeud N = (Noeud)N2;
            bool estEgal = false;
            if (N.X == X && N.Y == Y)
            {
                estEgal = true;
            }
            return estEgal;
        }

        public override double GetArcCost(GenericNode N2)
        {
            Noeud N = (Noeud)N2;
            double coutArc = time_estimation(X, Y, N.X, N.Y);
            return coutArc;
        }

        public override bool EndState()
        {
            if (IsEqual(Nf) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double CalculeHCost()
        {
            double distance = Math.Sqrt(Math.Pow(Nf.X - X,2)+ Math.Pow(Nf.Y - Y,2));
            double tempsRestant = 0;
            //On divise cette distance totale en tronçons de 10 km pour pouvoir utiliser time_estimation
            int nbTroncons = (int)distance / 10;
            List<double> Xintermediaire = new List<double>();
            List<double> Yintermediaire = new List<double>();
            Xintermediaire.Add(X);
            Yintermediaire.Add(Y);
            for (int i = 1; i < nbTroncons; i++)
            {
                Xintermediaire.Add((2 * Xintermediaire[i - 1] + Math.Sqrt(4 * 2 * Xintermediaire[i - 1] * (Math.Pow(Xintermediaire[i - 1], 2) - 50)))/2);
                Yintermediaire.Add((2 * Yintermediaire[i - 1] + Math.Sqrt(4 * 2 * Yintermediaire[i - 1] * (Math.Pow(Yintermediaire[i - 1], 2) - 50)))/2);
                /*
                if (Nf.X > X)
                {
                    if (Nf.Y > Y)
                    {
                        Xintermediaire.Add(2*Xintermediaire[i - 1] + Math.Sqrt(4*2*Xintermediaire[i-1]*(Math.Pow(Xintermediaire[i-1],2)-50)));
                        Yintermediaire.Add(2 * Yintermediaire[i - 1] + Math.Sqrt(4 * 2 * Yintermediaire[i - 1] * (Math.Pow(Yintermediaire[i - 1], 2) - 50)));
                    }
                    else
                    {
                        Xintermediaire.Add(2 * Xintermediaire[i - 1] + Math.Sqrt(4 * 2 * Xintermediaire[i - 1] * (Math.Pow(Xintermediaire[i - 1], 2) - 50)));
                        Yintermediaire.Add(2 * Yintermediaire[i - 1] - Math.Sqrt(4 * 2 * Yintermediaire[i - 1] * (Math.Pow(Yintermediaire[i - 1], 2) - 50)));
                    }
                }
                else
                {
                    if (Nf.Y > Y)
                    {
                        Xintermediaire.Add(2 * Xintermediaire[i - 1] - Math.Sqrt(4 * 2 * Xintermediaire[i - 1] * (Math.Pow(Xintermediaire[i - 1], 2) - 50)));
                        Yintermediaire.Add(2 * Yintermediaire[i - 1] + Math.Sqrt(4 * 2 * Yintermediaire[i - 1] * (Math.Pow(Yintermediaire[i - 1], 2) - 50))); ;
                    }
                    else
                    {
                        Xintermediaire.Add(2 * Xintermediaire[i - 1] + Math.Sqrt(4 * 2 * Xintermediaire[i - 1] * (Math.Pow(Xintermediaire[i - 1], 2) - 50)));
                        Yintermediaire.Add(2 * Yintermediaire[i - 1] - Math.Sqrt(4 * 2 * Yintermediaire[i - 1] * (Math.Pow(Yintermediaire[i - 1], 2) - 50))); ;
                    }
                }
                */
            }
            Xintermediaire.Add(Nf.X);
            Yintermediaire.Add(Nf.Y);

            for (int i = 0; i<nbTroncons; i++)
            {
                tempsRestant = tempsRestant + time_estimation(Xintermediaire[i], Yintermediaire[i], Xintermediaire[i + 1], Yintermediaire[i + 1]);
            }
            return tempsRestant;
        }



        public override List<GenericNode> GetListSucc()
        {
            //PAVAGE CARRE DE 1 A 3 CASES AUTOUR DU NOEUD COURANT :
            List<GenericNode> ListeSuccesseur = new List<GenericNode>();

            for (int i = 0; i<=3;i++)
            {
                Noeud NoeudHautGauche = new Noeud(X - i, Y + i);
                Noeud NoeudHaut = new Noeud(X, Y + i);
                Noeud NoeudHautDroite = new Noeud(X + i, Y + i);
                Noeud NoeudDroite = new Noeud(X + i, Y);
                Noeud NoeudBasDroite = new Noeud(X + i, Y - i);
                Noeud NoeudBas = new Noeud(X, Y - i);
                Noeud NoeudBasGauche = new Noeud(X - i, Y - i);
                Noeud NoeudGauche = new Noeud(X - i, Y);
                ListeSuccesseur.Add(NoeudHautGauche);
                ListeSuccesseur.Add(NoeudHaut);
                ListeSuccesseur.Add(NoeudHautDroite);
                ListeSuccesseur.Add(NoeudDroite);
                ListeSuccesseur.Add(NoeudBasDroite);
                ListeSuccesseur.Add(NoeudBas);
                ListeSuccesseur.Add(NoeudBasGauche);
                ListeSuccesseur.Add(NoeudGauche);
            }
            
            
            return ListeSuccesseur;

        }

        public override string ToString()
        {
            string chaine = "Coordonnée X : " + X + " Coordonnee Y : "+Y + "\n";
            return chaine;
        }

        
        public double get_wind_speed(double x, double y)
        {
            if (cas == 'a')
            {
                return 50;
            }
            else if (cas == 'b')
            {
                if (y > 150)
                {
                    return 50;
                }
                else return 20;
            }
            else if (y > 150)
            {
                return 50;
            }
            else return 20;
        }
        public double get_wind_direction(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance /boatspeed);
        }
    }

    
}
