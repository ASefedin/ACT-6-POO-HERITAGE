using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    internal class Lapin : Animaux
    {
        protected int _tailleOreilles;

        public int TailleOreilles
        {
            get { return _tailleOreilles; }
            set { _tailleOreilles = value; }
        }

        public Lapin(string nom, DateTime dateNaissance, int numeroDePuce, int taille, bool animalConcours) : base(nom, dateNaissance, numeroDePuce, taille, animalConcours)
        {

        }

        public string FaireBonds()
        {
            string info = "boundsss !    waffff!";
            return info;
        }

        public string AfficheInfo()
        {
            string info = "tailleOreilles : " + TailleOreilles;
            return info;
        }
    }


}
