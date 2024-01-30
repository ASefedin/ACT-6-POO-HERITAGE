using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HERITAGE
{
    internal class Voiture : Vehicule
    {
        protected string _motorisation;
        protected bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, int prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public string Affiche()
        {
            string info = "le type du vélo : " + Motorisation + "la voiture a un gps ? : " + Gps;
            return info;
        }

    }
}
