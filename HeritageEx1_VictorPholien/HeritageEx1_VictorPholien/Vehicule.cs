using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageEx1_VictorPholien
{
    class Vehicule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected int _prix;

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }

        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Vehicule(string modele, string marque, string couleur, int prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }

        public virtual string Affiche()
        {
            string info = "le modele du véhicule : " + Modele + "La marque du véhicule : " + Marque + " la couleur du véhicule : " + Couleur + "son prix est de : " + Prix;
            return info;
        }
    }
}

