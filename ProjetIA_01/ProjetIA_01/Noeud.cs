﻿using System;
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
            int nbTroncons = (int)distance / 10; //nombre de tronçon arrondi à l'entier inférieur
            List<double> Xintermediaire = new List<double>();
            List<double> Yintermediaire = new List<double>();
            Xintermediaire.Add(X); //coordonnée x du point de départ
            Yintermediaire.Add(Y); // coordonnée y du point de départ
            for (int i = 1; i < nbTroncons; i++)
            {
                if(X>Nf.X)
                {
                    Xintermediaire.Add(Xintermediaire[i - 1] + (X-Nf.X) / nbTroncons);
                }
                else
                {
                    Xintermediaire.Add(Xintermediaire[i - 1] - (X-Nf.X) / nbTroncons);
                }
                if(Y>Nf.Y)
                {
                    Yintermediaire.Add(Yintermediaire[i - 1] + (Y-Nf.Y) / nbTroncons);
                }
                else
                {
                    Yintermediaire.Add(Yintermediaire[i - 1] + (Y-Nf.Y) / nbTroncons);
                }
            }
            Xintermediaire.Add(Nf.X); //coordonnée x du point final
            Yintermediaire.Add(Nf.Y); //coordonnée y du point final

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
                if (X-i>0 && Y+i<300)
                {
                    Noeud NoeudHautGauche = new Noeud(X - i, Y + i);
                    ListeSuccesseur.Add(NoeudHautGauche);
                }
                if (Y+i<300)
                {
                    Noeud NoeudHaut = new Noeud(X, Y + i);
                    ListeSuccesseur.Add(NoeudHaut);
                }
                if (X+i<300 && Y+i <300)
                {
                    Noeud NoeudHautDroite = new Noeud(X + i, Y + i);
                    ListeSuccesseur.Add(NoeudHautDroite);
                }
                if (X+i<300)
                {
                    Noeud NoeudDroite = new Noeud(X + i, Y);
                    ListeSuccesseur.Add(NoeudDroite);
                }
                if (X + i < 300 && Y - i > 0)
                {
                    Noeud NoeudBasDroite = new Noeud(X + i, Y - i);
                    ListeSuccesseur.Add(NoeudBasDroite);
                }
                if (Y-i>0)
                {
                    Noeud NoeudBas = new Noeud(X, Y - i);
                    ListeSuccesseur.Add(NoeudBas);
                }
               if (X-i>0 && Y-i>0)
                {
                    Noeud NoeudBasGauche = new Noeud(X - i, Y - i);
                    ListeSuccesseur.Add(NoeudBasGauche);
                }
                if (X-i>0)
                {
                    Noeud NoeudGauche = new Noeud(X - i, Y);
                    ListeSuccesseur.Add(NoeudGauche);
                }          
            }

            return ListeSuccesseur;

        }

        public override string ToString()
        {
            string chaine = "X : " + X + " Y : "+Y + "\n";
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
