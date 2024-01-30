using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    internal class Animaux
    {
		protected string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

        protected DateTime _dateNaissance;

		public DateTime DateNaissance
        {
			get { return _dateNaissance; }
			set { _dateNaissance = value; }
		}

        protected int _numeroDePuce;

		public int NumeroDePuce
        {
			get { return _numeroDePuce; }
			set { _numeroDePuce = value; }
		}

        protected int _taille;

		public int Taille
        {
			get { return _taille; }
			set { _taille = value; }
		}

        protected bool _animalConcours;

		public bool AnimalConcours
		{
			get { return _animalConcours; }
			set { _animalConcours = value; }
		}

		public Animaux(string nom, DateTime dateNaissance, int numeroDePuce, int taille, bool animalConcours)
		{
			_nom = nom;
			_dateNaissance = dateNaissance;
			_numeroDePuce = numeroDePuce;
			_taille = taille;
			_animalConcours = animalConcours;
		}

		public string Manger()
		{
            string info = " mange";
            return info;
        }

		public string Dormir()
		{
            string info = " fait dodo";
            return info;

        }

        public string AfficheInfo()
		{
            string info = " Nom : " + Nom + " Date de naissance : " + DateNaissance + " Numéro de puce : " + NumeroDePuce + " Taille : " + Taille + " Animal de concours : " + AnimalConcours;
            return info;

        }
    }
}
