using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEx1_VictorPholien
{
    class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;


        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }
        public bool Gps
        {
            get { return _gps; }
        }
        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, int prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public override string Affiche()
        {
            string chaine = "Modele : " + _modele + "  Marque : " + _marque + " - Couleur : " + _couleur + " - Prix : " + _prix + " Motorisation : " + _motorisation + " Gps : " + _gps;
            return chaine;
        }
    }
}
