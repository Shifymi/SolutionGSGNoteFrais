using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace ProjetGSG
{
    [Serializable]
    public class FraisNuitee : NoteFrais
    {
        public double mttFactureNuitee { get; }
        public int numRegion { get; }

        public FraisNuitee(DateTime date, Visiteur visiteur, double montantFactureNuitee, int regionTouristique)
            : base(date, visiteur)
        {
            this.mttFactureNuitee = montantFactureNuitee;
            this.numRegion = regionTouristique;
            SetMttARembourser();
        }

        // Méthode pour calculer le remboursement en fonction de la catégorie professionnelle et de la région touristique
        public override double CalculMttARembourser()
        {
            double remboursementBase;
            switch (leVisiteur.CategProf)
            {
                case 'A':
                    remboursementBase = 65;
                    break;
                case 'B':
                    remboursementBase = 55;
                    break;
                case 'C':
                    remboursementBase = 50;
                    break;
                default:
                    return 0;
            }

            double coefficient;
            switch (numRegion)
            {
                case 1:
                    coefficient = 0.90;
                    break;
                case 2:
                    coefficient = 1.0;
                    break;
                case 3:
                    coefficient = 1.15;
                    break;
                default:
                    return 0;
            }

            // Calculer le montant de remboursement en appliquant le coefficient
            double montantRemboursement = remboursementBase * coefficient;

            // Déterminer le montant de remboursement final en fonction du plafond par rapport au montant de la facture
            return (montantRemboursement > mttFactureNuitee) ? mttFactureNuitee : montantRemboursement;
        }
        public override string ToString()
        {
            return "Frais nuitée \n " + base.ToString() + $" \n Numéro de Région : {numRegion} "+$" \nMontant facturé repas midi : {mttFactureNuitee} \n";
        }
    }
}
