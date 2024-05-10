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
    public class Visiteur
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public char CategProf { get; private set; }
        public int PuissanceVeh { get; private set; }

        public Visiteur() { } // Constructeur sans paramètres
        public List<NoteFrais> mesNotesFrais { get; set; }
         
        // Constructeur de la classe Visiteur
        public Visiteur(string nom, string prenom, char categorieProf, int puissanceVeh)
        {
            Nom = nom;
            Prenom = prenom;
            CategProf = categorieProf;
            PuissanceVeh = puissanceVeh;
            mesNotesFrais = new List<NoteFrais>();
        }
        
        public void AjouterNoteFrais(NoteFrais noteFrais)
        {
            mesNotesFrais.Add(noteFrais);
        }
        public override string ToString()
        {
            return $"Nom/Prénom : {Nom} {Prenom}\n" +
               $"Catégorie professionnelle : {CategProf}\n" +
               $"Puissance véhicule : {PuissanceVeh}";
        }
        public double CumulNoteFraisParAnnee(int annee)
        {
           double cumul = 0; 
           foreach(NoteFrais uneNote in mesNotesFrais)  
            {
                if (uneNote.dateNF.Year == annee)
                {
                    cumul += uneNote.mttARembourser;
                }
            }
           return cumul;
        }
        public int NbNotesParVIsiteur()
        {
            return mesNotesFrais.Count();
        }
    }
}
