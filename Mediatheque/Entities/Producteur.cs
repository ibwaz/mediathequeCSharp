using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Producteur : Personne
    {
        public Producteur(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override string ToString()
        {
            return "Producteur [nom=" + nom + ", prenom=" + prenom + "]";
        }
    }
}
