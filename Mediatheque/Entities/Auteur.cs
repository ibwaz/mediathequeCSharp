using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Auteur : Personne
    {
        private int nbreLivre;

        public int NbreLivre { get => nbreLivre; set => nbreLivre = value; }

        public Auteur(string nom, string prenom, int nbreLivre) : base(nom, prenom)
        {
            this.nbreLivre = nbreLivre;
        }

        public override string ToString()
        {
            return "Auteur [nom=" + nom + ", prenom=" + prenom + ", nbreLivre=" + nbreLivre + "]";
        }

        public void AddLivre()
        {
            ++nbreLivre;
        }
    }
}
