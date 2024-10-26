using System.Text;

namespace AppPaiements
{
    public class Utilisateur
    {
        public string Nom {  get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
        public void AfficherInfo()
        {
            Console.WriteLine($"Utilisateur: {Nom}");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}
