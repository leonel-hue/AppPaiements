namespace AppPaiements
{
  
    public class Program
    {
        static void Main(string[] args)
        {
            CarteCredit carte1 = new CarteCredit(100, "Achat en ligne", 123456);
            CarteCredit carte2 = new CarteCredit(200, "Restaurant", 654321);
            CarteCredit carte3 = new CarteCredit(50, "Essence", 987654);

            Paypal paypal1 = new Paypal(150, "Achat numérique", "leonel@gmail.com");
            Paypal paypal2 = new Paypal(75, "Abonnement", "leonel@gmail.com");

            Utilisateur utilisateur = new Utilisateur("Leonel Brice");

            utilisateur.AjouterPaiement(carte1);
            utilisateur.AjouterPaiement(carte2);
            utilisateur.AjouterPaiement(carte3);
            utilisateur.AjouterPaiement(paypal1);
            utilisateur.AjouterPaiement(paypal2);

            utilisateur.AfficherInfo();
        }
    }
}

