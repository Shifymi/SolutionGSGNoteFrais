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
    public class NoteFrais
    {
        public static int compteurNumeros = 0;
        public DateTime dateNF { get; private set; }
        public bool estRembourse { get; private set; }
        public double mttARembourser { get; private set; }
        public int numero { get; private set; }
        public Visiteur leVisiteur { get; private set; }


        public NoteFrais(DateTime dateNF, Visiteur leVisiteur)
        {
            this.dateNF = dateNF;
            this.leVisiteur = leVisiteur;
            this.estRembourse = false; // Par défaut, la note n'est pas remboursée

            // Incrémenter le compteur de numéros de note de frais et affecter le numéro à cette note
            compteurNumeros++;
            this.numero = compteurNumeros;

            // Ajouter cette note de frais à la liste des notes associées au visiteur
            leVisiteur.AjouterNoteFrais(this);
        }

        public void SetEstRembourse()
        {
            estRembourse = true;
        }
        public void SetMttARembourser()
        {
            mttARembourser = CalculMttARembourser();
        }
        public virtual double CalculMttARembourser()
        {
            return 0;
        }
        public override string ToString()
        {
            string etatRembourse = estRembourse ? "Remboursé" : "Non remboursé";
            char categorieVisiteur = leVisiteur.CategProf; 

            return $"Numéro note de frais : {numero}\n" +
                   $"Date: {dateNF.ToShortDateString()}\n" +
                   $"Puissance fiscale : {leVisiteur.PuissanceVeh}\n" +
                   $"Catégorie visiteur : {categorieVisiteur}\n\n" +
                   $"Montant à rembourser : {mttARembourser} euros - {etatRembourse}";
        }
    }
}
