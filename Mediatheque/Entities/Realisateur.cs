using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Realisateur : Personne
    {
        public Realisateur(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override string ToString()
        {
            return "Realisateur [nom=" + nom + ", prenom=" + prenom + "]";
        }
    }
}
