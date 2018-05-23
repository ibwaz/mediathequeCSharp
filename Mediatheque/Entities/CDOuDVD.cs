using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Entities
{
    public class CDOuDVD : Produit
    {
        private List<Personne> acteursChanteurs;
        private Personne realisateurProducteur;

        public List<Personne> ActeursChanteurs { get => acteursChanteurs; set => acteursChanteurs = value; }
        public Personne RealisateurProducteur { get => realisateurProducteur; set => realisateurProducteur = value; }

        public CDOuDVD(string code, string titre, bool disponible, Personne realisateurProducteur, List<Personne> acteursChanteurs) : base(code, titre, disponible)
        {
            acteursChanteurs = new List<Personne>();
            this.realisateurProducteur = realisateurProducteur;
            AddActeursOuChanteurs(acteursChanteurs);
        }

        public void AddActeursOuChanteurs(List<Personne> personnes)
        {
            switch (personnes.Count)
            {
                case 2 : case 3 :
                    for(int i=0; i<personnes.Count; ++i)
                    {
                        acteursChanteurs.Add(personnes[i]);
                    }
                    break;
                default:
                    throw new Exception("Le nombre max d'acteurs et/ou chanteurs est 3");
            }
        }
    }
}
