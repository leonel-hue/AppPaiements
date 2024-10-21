using System;

namespace AppPaiements
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomUtilisateur;
            do
            {
                Console.Write("Entrez votre nom: ");
                nomUtilisateur = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nomUtilisateur))
                {
                    Console.WriteLine("Veuillez ressaisir votre nom.");
                }
            } while (string.IsNullOrWhiteSpace(nomUtilisateur));

            Console.WriteLine($"Votre nom est : {nomUtilisateur}");

            Utilisateur utilisateur = new Utilisateur(nomUtilisateur);

            Console.Write("Entrez le montant pour la Carte de Crédit: ");
            double montantCarte;
            while (!double.TryParse(Console.ReadLine(), out montantCarte) || montantCarte < 0)
            {
                Console.Write("Montant invalide. Veuillez entrer un montant valide: ");
            }

            Console.Write("Entrez une description pour la Carte de Crédit (appuyez sur Entrée pour laisser vide): ");
            string descriptionCarte = Console.ReadLine();
            descriptionCarte = string.IsNullOrWhiteSpace(descriptionCarte) ? "Aucune description fournie" : descriptionCarte;

            Console.Write("Entrez le numéro de Carte de Crédit: ");
            int numeroCarte;
            while (!int.TryParse(Console.ReadLine(), out numeroCarte) || numeroCarte <= 0)
            {
                Console.Write("Numéro de carte invalide. Veuillez entrer un numéro valide: ");
            }

            CarteCredit carte1 = new CarteCredit(montantCarte, descriptionCarte, numeroCarte);

            Console.Write("Entrez le montant pour PayPal: ");
            double montantPaypal;
            while (!double.TryParse(Console.ReadLine(), out montantPaypal) || montantPaypal < 0)
            {
                Console.Write("Montant invalide. Veuillez entrer un montant valide: ");
            }

            Console.Write("Entrez une description pour PayPal: ");
            string descriptionPaypal = Console.ReadLine();
            descriptionPaypal = string.IsNullOrWhiteSpace(descriptionPaypal) ? "Aucune description fournie" : descriptionPaypal;

            Console.Write("Entrez l'email associé à PayPal: ");
            string emailPaypal = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(emailPaypal))
            {
                emailPaypal = "email@exemple.com";
            }

            Paypal paypal1 = new Paypal(montantPaypal, descriptionPaypal, emailPaypal);

            utilisateur.AjouterPaiement(carte1);
            utilisateur.AjouterPaiement(paypal1);

            utilisateur.AfficherInfo();

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}
