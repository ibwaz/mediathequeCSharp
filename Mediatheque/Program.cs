using Mediatheque.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatheque
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Personne> personnes = new List<Personne>();
            List<Produit> produits = new List<Produit>();

            Adresse adresse1 = new Adresse(1, "rue d'Aquitaine", "91130", "Ris Orangis");
            Adresse adresse2 = new Adresse(128, "allee des champs", "91042", "Evry");
            Adresse adresse3 = new Adresse(3, "square de vesoul", "91080", "Courcouronnes");
            Adresse adresse4 = new Adresse(3, "avenue charon", "91270", "Vigneux-sur-seine");

            Personne auteur1 = new Auteur("med", "ali", 2);
            Personne auteur2 = new Auteur("waz", "ib", 3);
            Personne auteur3 = new Auteur("Hamadoun", "Koreissi", 5);
            Personne auteur4 = new Auteur("Yaouza", "Jaafar", 4);

            personnes.Add(auteur1);
            personnes.Add(auteur2);
            personnes.Add(auteur3);
            personnes.Add(auteur4);





            List<Auteur> auteurs1 = new List<Auteur>();
            auteurs1.Add((Auteur)auteur1);
            auteurs1.Add((Auteur)auteur3);

            List<Auteur> auteurs2 = new List<Auteur>();
            auteurs2.Add((Auteur)auteur1);
            auteurs2.Add((Auteur)auteur4);

            List<Auteur> auteurs3 = new List<Auteur>();
            auteurs3.Add((Auteur)auteur2);
            auteurs3.Add((Auteur)auteur3);
            auteurs3.Add((Auteur)auteur4);



            Produit livre1 = new Livre("01", " Java Programing OO", auteurs1, "Magic Paper");
            Produit livre2 = new Livre("02", " Programing OO basics", auteurs2, "Printer");
            Produit livre3 = new Livre("03", " PHP Programing OO", auteurs1, "Magic Paper2");
            Produit livre4 = new Livre("04", " PHP Programing OO", auteurs1, "Printer2");

            produits.Add(livre1);
            produits.Add(livre2);
            produits.Add(livre3);
            produits.Add(livre4);






            Produit livreInfo1 = new LivreInfo("01", "Neural Network", auteurs3, "PrintMax", 1);
            Produit livreInfo2 = new LivreInfo("02", "Deep Learning", auteurs3, "GreatPrint", 2);

            produits.Add(livreInfo1);
            produits.Add(livreInfo2);






           


            Console.WriteLine(adresse1);
            Console.WriteLine(adresse2);
            Console.WriteLine(adresse3);
            Console.WriteLine(adresse4);

            Console.WriteLine("*******************************************************");

            Console.WriteLine(auteur1);
            Console.WriteLine(auteur2);
            Console.WriteLine(auteur3);
            Console.WriteLine(auteur4);

            foreach (Personne p in personnes)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("*******************************************************");

            foreach (Personne a in auteurs1)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("*******************************************************");

            foreach (Personne b in auteurs2)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("*******************************************************");

            foreach (Personne c in auteurs3)
            {
                Console.WriteLine(c);
            }



            foreach (Produit p in produits)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("*******************************************************");

            
            Console.WriteLine("Tepez une touche pour continuer!");
            Console.ReadLine();

        }
    }
}
