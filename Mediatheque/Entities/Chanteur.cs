using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Chanteur : Personne
    {
        public Chanteur(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override string ToString()
        {
            return "Chanteur [nom=" + nom + ", prenom=" + prenom + "]";
        }
    }
}
