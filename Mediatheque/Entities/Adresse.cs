using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Adresse
    {
        private int numRue;
        private string nomRue;
        private string codePostal;
        private string ville;

        public int NumRue { get => numRue; set => numRue = value; }
        public string NomRue { get => nomRue; set => nomRue = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }

        public Adresse(int numRue, string nomRue, string codePostal, string ville)
        {
            this.numRue = numRue;
            this.nomRue = nomRue;
            this.codePostal = codePostal;
            this.ville = ville;
        }

        public override string ToString()
        {
            return numRue + " " + nomRue + ", " + codePostal + " " + ville;
        }
    }
}
