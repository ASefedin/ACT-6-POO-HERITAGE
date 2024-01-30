using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritagepar3
{
    internal class Carre
    {
        private int _cote;

        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }


        public Carre(int cote)
        {
            _cote = cote;
        }

        public string CalculeSurface()
        {
            string info = "la surface du carre = "+ Cote * Cote ;
            return info;
        }

        public string CalculePerimetre()
        {
            string info = "le perimetre du carre = "+ Cote * 4;
            return info;
        }
    }
}
