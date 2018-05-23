using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public abstract class Produit
    {
        protected string code;
        protected string titre;
        protected bool disponible;

        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
        public bool Disponible { get => disponible; set => disponible = value; }

        protected Produit(string code, string titre, bool disponible)
        {
            this.code = code;
            this.titre = titre;
            this.disponible = disponible;
        }
    }
}
