using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Heritage_VictorPholien
{
    class Animal
    {
        protected string _nom;
        protected DateTime _dateDeNaissance;
        protected int _puce;
        protected int _taille;
        protected bool _concours;

        public Animal(string nom, DateTime date, int numPuce, int taille, bool concours)
        {
            _nom = nom;
            _dateDeNaissance = date;
            _puce = numPuce;
            _taille = taille;
            _concours = concours;
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
        }

        public DateTime DateDeNaissance
        {
            get
            {
                return _dateDeNaissance;
            }
        }

        public int Puce
        {
            get
            {
                return _puce;
            }
        }

        public float Taille
        {
            get
            {
                return _taille;
            }
        }

        public bool Concours
        {
            get
            {
                return _concours;
            }
        }

       
       
        public virtual string Affiche()
        {
            string info = "je m'appelle " + _nom + " je suis née le " + _dateDeNaissance + " ma puce est " + _puce + "je fais " + _taille + " de hauteur" + " je fais les concours ? " + _concours;
            return info;
        }

    }

}