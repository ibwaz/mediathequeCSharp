using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Livre : Produit
    {
        protected List<Auteur> auteurs;
        protected string editeur;

        public List<Auteur> Auteurs { get => auteurs; set => auteurs = value; }
        public string Editeur { get => editeur; set => editeur = value; }

        public Livre(string code, string titre, List<Auteur> auteurs, string editeur) : base(code, titre, true)
        {
            this.editeur = editeur;
            this.auteurs = auteurs;
        }

        public override string ToString()
        {
            return "Livre [code=" + code + ", titre=" + titre + ", disponible=" + disponible + ", auteurs=" + this.Asuteurs(auteurs) + ", editeur=" + editeur + "]";
        }
        protected  String Asuteurs(List<Auteur> L)
        {
            String A = "";
            foreach (Auteur aut in L)
            {
                A = A + "{" + aut.ToString()+"} ";
            }
            return A;
        }
        public virtual void AddAuteur(List<Auteur> auts)
        {
            switch (auts.Count)
            {
                case 1:
                case 3:
                    for (int i = 0; i < auts.Count; ++i)
                    {
                        auteurs.Add(auts[i]);
                    }
                    break;
                default:
                    throw new Exception("Le nombre d'auteurs doit etre compris entre 1 et 3");
            }
        }
    }
}
