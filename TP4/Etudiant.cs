using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class Etudiant
    {
        private string nomprenom;
        private int ds;
        private int exam;
        private int np;
        public void Instialisation (string nomprenom, int ds,
            int exam, int np)
        {
            this.nomprenom = nomprenom;
            this.ds = ds;
            this.exam = exam;
            this.np = np;
        }
         public double CalculMoyenne()
        {
            double moy = this.ds * 0.3 + this.np * 0.2 + this.exam * 0.5;
            return moy;
        }
        public string Affiche ()
        {
            return nomprenom + "\t" + this.CalculMoyenne().ToString();
        }


    }
}
