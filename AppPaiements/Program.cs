using System;
using System.Collections.Generic;

namespace AppConsoleLivres
{
  
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Année: {AnneePublication}");
        }
    }

    public class Revue : Livre
    {
        public int Volume { get; set; }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Revue - Titre: {Titre}, Auteur: {Auteur}, Année: {AnneePublication}, Volume: {Volume}");
        }
    }

    public class Roman : Livre
    {
        public string Genre { get; set; }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Roman - Titre: {Titre}, Auteur: {Auteur}, Année: {AnneePublication}, Genre: {Genre}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {e
            Revue revue1 = new Revue { Titre = "Science Magazine", Auteur = "John Doe", AnneePublication = 2021, Volume = 50 };
            Revue revue2 = new Revue { Titre = "Nature", Auteur = "Jane Smith", AnneePublication = 2020, Volume = 45 };
            Revue revue3 = new Revue { Titre = "Time", Auteur = "Emily Johnson", AnneePublication = 2022, Volume = 100 };

            revue1.AfficherDetails();
            revue2.AfficherDetails();
            revue3.AfficherDetails();

            Roman roman1 = new Roman { Titre = "Le Petit Prince", Auteur = "Antoine de Saint-Exupéry", AnneePublication = 1943, Genre = "Fiction" };
            Roman roman2 = new Roman { Titre = "1984", Auteur = "George Orwell", AnneePublication = 1949, Genre = "Dystopie" };
            Roman roman3 = new Roman { Titre = "To Kill a Mockingbird", Auteur = "Harper Lee", AnneePublication = 1960, Genre = "Fiction" };

            roman1.AfficherDetails();
            roman2.AfficherDetails();
            roman3.AfficherDetails();

            List<Livre> livres = new List<Livre>();
            livres.Add(revue1);
            livres.Add(revue2);
            livres.Add(revue3);
            livres.Add(roman1);
            livres.Add(roman2);
            livres.Add(roman3);

            Console.WriteLine("\nDétails des livres dans la liste:");
            foreach (var livre in livres)
            {
                livre.AfficherDetails();
            }

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}

