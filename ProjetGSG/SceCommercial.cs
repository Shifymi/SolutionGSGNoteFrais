using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ProjetGSG
{
    [Serializable]
    public class SceCommercial
    {
        public List<Visiteur> lesVisiteurs { get; set; }
        public SceCommercial()
        {
            this.lesVisiteurs = new List<Visiteur>();
        }
        public void AjouterVisiteur(Visiteur unVisiteur)
        {
            lesVisiteurs.Add(unVisiteur);
        }

        // Méthode pour ajouter une note de frais de transport pour un visiteur donné
        public void AjouterFraisTransport(DateTime dateNote, Visiteur visiteur, int nbkm)
        {
            // Création d'une note de frais de transport
            NoteFrais fraisTransport = new FraisTransport(dateNote, visiteur, nbkm);

        }

        // Méthode pour ajouter une note de frais de repas midi pour un visiteur donné
        public void AjouterFraisRepasMidi(DateTime dateNote, Visiteur visiteur, double montant)
        {
            // Création d'une note de frais de repas midi
            NoteFrais fraisRepasMidi = new FraisRepasMidi(dateNote, visiteur, montant);
        }

        // Méthode pour ajouter une note de frais de nuitée pour un visiteur donné
        public void AjouterFraisNuitee(DateTime dateNote, Visiteur visiteur, double montant,int region)
        {
            // Création d'une note de frais de nuitée
            NoteFrais fraisNuitee = new FraisNuitee(dateNote, visiteur, montant, region);
        }
        public int NbNotesFraisNonRemboursees()
        {
            int rep = 0;
            foreach(Visiteur unVisiteur in lesVisiteurs)
            {
                foreach(NoteFrais uneNote in unVisiteur.mesNotesFrais)
                {
                    if (!uneNote.estRembourse)
                    {
                        rep++;
                    }
                }
            }
            return rep;
        }
        public int NbNotesFraisParAnneePourtousVisiteurs(int annee)
        {
            int nb = 0;
            foreach(Visiteur visiteur in lesVisiteurs)
            {
                nb += visiteur.mesNotesFrais.Count;
            }
            return nb;
        }
        // Méthode pour obtenir le cumul des notes de frais de TOUS les visiteurs pour une année donnée
        public double CumulNotesFraisParAnneePourtousVisiteurs(int annee)
        {
            double cumulTotal = 0.0;

            foreach (Visiteur visiteur in lesVisiteurs)
            {
                cumulTotal += visiteur.CumulNoteFraisParAnnee(annee);
            }

            return cumulTotal;
        }
    }
}
