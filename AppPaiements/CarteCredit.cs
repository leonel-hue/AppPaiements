using System.Text;

namespace AppPaiements
{
    public class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int numeroCarte): base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Carte de credit - montant : {Montant}, Description : {Description}, Numero de carte : {NumeroCarte}");
        }


    }
}
