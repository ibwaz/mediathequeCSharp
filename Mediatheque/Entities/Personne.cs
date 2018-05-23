using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public abstract class Personne
    {
        protected string nom;
        protected string prenom;

        protected string Nom { get => nom; set => nom = value; }
        protected string Prenom { get => prenom; set => prenom = value; }

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
