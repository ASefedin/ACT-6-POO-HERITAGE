using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritagepar3
{
    internal class Forme
    {
        protected string _couleur ;

        public string Couleur
        {
            get { return _couleur ; }
            set { _couleur  = value; }
        }

        public Forme(string couleur) 
        {
            _couleur = couleur;
        }

        public string AfficheCouleur()
        {
            string info = "la couleur de la forme est " + Couleur;
            return info;
        }
    }
}
