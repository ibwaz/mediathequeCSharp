using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class Adherent : Personne
    {
        private Adresse adresse;
        private List<Produit> produits;

        public Adresse Adresse { get => adresse; set => adresse = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }

        public Adherent(string nom, string prenom, Adresse adresse) : base(nom, prenom)
        {
            this.adresse = adresse;
            this.produits = new List<Produit>();
        }

        public override string ToString()
        {
            return "Adherent [nom=" + nom + ", prenom=" + prenom + ", adresse=" + adresse + ", produits=[" + produits + "]]";
        }

        // aciennement appelé empreinteLivre
        public void EmpreinteProduit(Produit produit)
        {
            if(this.produits.Count < 5)
            {
                produit.Disponible = false;
                this.produits.Add(produit);
            }
            else
            {
                throw new Exception("Vous avez emprunter 5 produits! (max : 5)");
            }
        }

        // aciennement appelé rendreLivre
        public void RendreProduit(Produit produit)
        {
            produit.Disponible = true;
            this.produits.Remove(produit);
        }

        // aciennement appelé liveEmpreintes
        public string ProduitEmpreintes()
        {
            string produitsEmp = "";
            foreach(Produit produit in this.produits)
            {
                if (!produit.Disponible)
                {
                    produitsEmp += produit.Titre + ", ";
                }
            }
            return produitsEmp;
        }
    }
}
