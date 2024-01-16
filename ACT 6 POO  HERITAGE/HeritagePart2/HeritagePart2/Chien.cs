using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    internal class Chien : Animaux
    {
        public Chien(string nom, DateTime dateNaissance, int numeroDePuce, int taille, bool animalConcours) : base(nom, dateNaissance, numeroDePuce, taille, animalConcours)
        {

        }

        public string Aboyer()
        {
            string info = "wafff !    waffff!";
            return info;
        }
    }
}
