using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritagepar3
{
    internal class Rectangle
    {
        private int _longeur;

        public int Longeur
        {
            get { return _longeur; }
            set { _longeur = value; }
        }

        private int _largeur;

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public Rectangle(int longueur, int largeur)
        {
            _longeur=longueur;
            _largeur=largeur;
        }

        public string CalculeSurface()
        {
            string info = "la surface du rectangle = "+ Longeur*Largeur;
            return info;
        }

        public string CalculePerimetre()
        {
            string info = "le perimetre du rectangle = " + (Longeur + Largeur) * 2;
            return info;
        }
    }
}
