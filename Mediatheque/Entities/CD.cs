using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class CD : CDOuDVD
    {
        public CD(string code, string titre, bool disponible, Personne realisateurProducteur, List<Personne> acteursChanteurs) : base(code, titre, disponible, realisateurProducteur, acteursChanteurs)
        {
        }

        public override string ToString()
        {
            return "CD [code=" + code + ", titre=" + titre + ", disponible=" + disponible + "]"; 
        }
    }
}
