using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Heritage_VictorPholien
{
    class Chien : Animal
    {
        public Chien(string nom, DateTime date, int numPuce, int taille, bool concours) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _dateDeNaissance = date;
            _puce = numPuce;
            _taille = taille;
            _concours = concours;
        }
        public string Aboyer()
        {
            return "Woof";
        }
    }
}