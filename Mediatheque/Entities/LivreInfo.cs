using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class LivreInfo : Livre
    {
        protected int nbreCDROM;

        public int NbreCDROM { get => nbreCDROM; set => nbreCDROM = value; }

        public LivreInfo(string code, string titre, bool disponible, List<Auteur> auteurs, string editeur, int nbreCDROM) : base(code, titre, auteurs, editeur)
        {
            this.NbreCDROM = nbreCDROM;
        }

        public LivreInfo(string code, string titre, List<Auteur> auteurs, string editeur, int v) : base(code, titre, auteurs, editeur)
        {
        }

        public override string ToString()
        {
            return "LivreInfo [code=" + code + ", titre=" + titre + ", disponible=" + disponible + ", nbreCDROM=" + nbreCDROM + ", auteurs=" + this.Asuteurs(auteurs) + ", editeur=" + editeur + "]";
        }

        public override void AddAuteur(List<Auteur> auts)
        {
            switch (auts.Count)
            {
                case 1:
                case 2:
                    for (int i = 0; i < auts.Count; ++i)
                    {
                        auteurs.Add(auts[i]);
                    }
                    break;
                default:
                    throw new Exception("Le nombre d'auteurs doit etre compris entre 1 et 2");
            }
        }
    }
}
