using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace ProjetGSG
{
    [Serializable]
    public class FraisTransport : NoteFrais
    {
        public int nbKm { get; }

        public FraisTransport(DateTime date, Visiteur visiteur, int nombreKm)
            : base(date, visiteur)
        {
            this.nbKm = nombreKm;
            SetMttARembourser();
        }

        // Méthode pour calculer le remboursement en fonction de la puissance du véhicule
        public override double CalculMttARembourser()
        {
            int puissance = leVisiteur.PuissanceVeh;
            double tauxRemboursement;

            if (puissance < 5)
            {
                tauxRemboursement = 0.1;
            }
            else if (puissance >= 5 && puissance <= 10)
            {
                tauxRemboursement = 0.2;
            }
            else
            {
                tauxRemboursement = 0.3;
            }
            return tauxRemboursement * nbKm;            
        }
        public override string ToString()
        {
            return "Frais Transport \n" + base.ToString() + $"\nNombre kilomètres : {nbKm} \n";
        }
    }
}
