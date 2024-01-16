using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Heritage_VictorPholien
{
    class Chat : Animal
    {
        public Chat(string nom, DateTime date, int numPuce, int taille, bool concours) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _dateDeNaissance = date;
            _puce = numPuce;
            _taille = taille;
            _concours = concours;
        }
        public string Miauler()
        {
            return "Miouuuuu";
        }

        public string Ronronner()
        {
            return "Grrrrrr";
        }
    }
}

