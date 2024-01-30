using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HERITAGE
{
    internal class Velo : Vehicule
    {
        protected string _type;
        protected bool _estElectrique;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool EstElectrique
        {
            get { return _estElectrique; }
            set { _estElectrique = value; }
        }

        public Velo(string type, bool estElectrique, string modele, string marque, string couleur, int prix) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

        public string Affiche()
        {
            string info = "le type du vélo : " + Type + "Le vélo est électrique ? : " + EstElectrique;
            return info;
        }
    }
}
