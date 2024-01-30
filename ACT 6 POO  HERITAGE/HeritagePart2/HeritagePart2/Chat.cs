using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    internal class Chat : Animaux
    {
        public Chat(string nom, DateTime dateNaissance, int numeroDePuce, int taille, bool animalConcours) : base (nom, dateNaissance, numeroDePuce, taille, animalConcours)
        {

        }

        public string Miauler()
        {
            string info = "Miaou !    Miaou!";
            return info;
        }

        public string Rononer()
        {
            string info = "ronnhhhh !    ronnhhhhh!";
            return info;
        }
    }
}
