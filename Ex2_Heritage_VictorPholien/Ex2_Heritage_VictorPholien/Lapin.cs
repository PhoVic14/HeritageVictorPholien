using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Heritage_VictorPholien
{
    class Lapin : Animal
    {
        private int _tailleOreilles;
        public Lapin(string nom, DateTime date, int numPuce, int taille, bool concours, int tailleOreilles) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _dateDeNaissance = date;
            _puce = numPuce;
            _taille = taille;
            _concours = concours;
            _tailleOreilles = tailleOreilles;
        }

        public int TailleOreilles
        {
            get
            {
                return _tailleOreilles;
            }
        }

        public string Sauter()
        {
            return "*Saut*";
        }

        public override string ToString()
        {
            string moi = "je m'appelle " + _nom + " je suis née le " + _dateDeNaissance + " ma puce est " + _puce + "je fais " + _taille + " de hauteur" + " je fais les concours ? " + _concours + " mes oreilles font " + _tailleOreilles;

            return moi;
        }
    }
}
