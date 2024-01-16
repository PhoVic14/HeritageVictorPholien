using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEx1_VictorPholien
{
    class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;



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
        public override string Affiche()
        {
            string chaine = "Modele : " + _modele + "  Marque : " + _marque + " - Couleur : " + _couleur + " - Prix : " + _prix + " Type : " + _type + " EstElectrique" + _estElectrique;
            return chaine;
        }

    }
}
