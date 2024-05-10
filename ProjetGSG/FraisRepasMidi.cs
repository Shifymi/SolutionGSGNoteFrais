using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace ProjetGSG
{
    [Serializable]
    public class FraisRepasMidi : NoteFrais
    {
        public double mttFactureRepasMidi { get; }

        public FraisRepasMidi(DateTime date, Visiteur visiteur, double montantFacture)
            : base(date, visiteur)
        {
            this.mttFactureRepasMidi = montantFacture;
            SetMttARembourser();
        }

        // Méthode pour calculer le remboursement en fonction de la catégorie professionnelle
        public override double CalculMttARembourser()
        {
            char categorie = leVisiteur.CategProf;
            double montantMaxRemboursement;

            switch (categorie)
            {
                case 'A':
                    montantMaxRemboursement = 25;
                    break;
                case 'B':
                    montantMaxRemboursement = 22;
                    break;
                case 'C':
                    montantMaxRemboursement = 20;
                    break;
                default:
                    montantMaxRemboursement = 0;
                    break;
            }

            return (mttFactureRepasMidi < montantMaxRemboursement) ? mttFactureRepasMidi : montantMaxRemboursement;
        }
        public override string ToString()
        {
            return "Frais Repas midi \n " + base.ToString() + $" \nMontant facturé repas midi : {mttFactureRepasMidi} \n";
        }

    }
}
