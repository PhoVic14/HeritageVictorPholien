﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Heritage_VictorPholien
{
    internal abstract class Forme
    {
        protected string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public abstract double Surface();
        public abstract double Perimetre();
        public abstract string Afficher();
    }
}