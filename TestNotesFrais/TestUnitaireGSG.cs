using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetGSG;
using System;
namespace TestNotesFrais
{
    [TestClass]
    public class TestUnitaires
    {
        [TestMethod]
        public void TestAjouterNoteFrais()
        {
            // Création d'un visiteur
            Visiteur unVisiteur = new Visiteur("DUPON", "Louis", 'A', 5);

            // Ajout de deux notes de frais pour ce visiteur
            NoteFrais note1 = new NoteFrais(new DateTime(2023, 11, 8), unVisiteur);
            NoteFrais note2 = new NoteFrais(new DateTime(2023, 11, 8), unVisiteur);

            // Vérification du nombre de notes de frais pour ce visiteur
            Assert.AreEqual(2, unVisiteur.mesNotesFrais.Count);
        }
        [TestMethod]
        public void TestNbNotesFraisNonRemboursees()
        {
            // Création d'une instance de SceCommercial
            SceCommercial leSce = new SceCommercial();

            // Création de deux visiteurs
            Visiteur visit1 = new Visiteur("DUPONT", "Louis", 'B', 7);
            Visiteur visit2 = new Visiteur("DUPUY", "Pascaline", 'A', 5);

            // Ajout des visiteurs au service commercial
            leSce.AjouterVisiteur(visit1);
            leSce.AjouterVisiteur(visit2);

            // Création de quelques notes de frais pour les visiteurs
            NoteFrais note1 = new NoteFrais(new DateTime(2023, 11, 8), visit1);
            NoteFrais note2 = new NoteFrais(new DateTime(2023, 11, 9), visit1);
            NoteFrais note3 = new NoteFrais(new DateTime(2023, 11, 10), visit2);
            NoteFrais note4 = new NoteFrais(new DateTime(2023, 11, 11), visit2);
            NoteFrais note5 = new NoteFrais(new DateTime(2023, 11, 12), visit2);

            // Marquage de certaines notes comme remboursées
            note2.SetEstRembourse();
            note4.SetEstRembourse();
            note5.SetEstRembourse();

            // Vérification du nombre de notes de frais non remboursées
            int nbNotesNonRemboursees = leSce.NbNotesFraisNonRemboursees();

            // Assertion
            Assert.AreEqual(2, nbNotesNonRemboursees);
        }
        [TestMethod]
        public void TestCalculMttARembourserTransport()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'B', 7);
            NoteFrais fraisTransp = new FraisTransport(new DateTime(2023, 11, 08), unVisiteur, 100);
            Assert.AreEqual(20.0, fraisTransp.mttARembourser, "Résultat attendu 20");
        }
        [TestMethod]
        public void TestCalculMttARembourserRepasMidiCategorieA()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'A', 8);
            NoteFrais fraisRepasMidi = new FraisRepasMidi(new DateTime(2023, 11 , 08), unVisiteur, 35);
            Assert.AreEqual(25.0, fraisRepasMidi.mttARembourser, "Résultat attendu 25");
        }
        [TestMethod]
        public void TestCalculMttARembourserRepasMidiCategorieB()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'B', 8);
            NoteFrais fraisRepasMidi = new FraisRepasMidi(new DateTime(2023, 11, 08), unVisiteur, 15.5);
            Assert.AreEqual(15.5, fraisRepasMidi.mttARembourser, "Résultat attendu 15.5");
        }
        [TestMethod]
        public void TestCalculMttARembourserNuiterCategorieAReg2()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'A', 8);
            NoteFrais fraisNuitee = new FraisNuitee(new DateTime(2023, 11, 08), unVisiteur, 46, 2);
            Assert.AreEqual(46, fraisNuitee.mttARembourser, "Résultat attendu 46");
        }
        [TestMethod]
        public void TestCalculMttARembourserNuiterCategorieBReg3()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'B', 8);
            NoteFrais fraisNuitee = new FraisNuitee(new DateTime(2023, 11, 08), unVisiteur, 75.00, 3);

            // Assert
            Assert.AreEqual(63,25, fraisNuitee.mttARembourser, "Résultat attendu 46");
        }
        [TestMethod]
        public void TestSceCommercialCumulNotesFraisParAnneePourtousVisiteur()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'B', 8);
            Visiteur unVisiteur2 = new Visiteur("Likju", "FERNAND", 'A', 7);
            Visiteur unVisiteur3 = new Visiteur("KIUJ", "MOLO", 'C', 6);

            SceCommercial sceCommercial = new SceCommercial();
            sceCommercial.AjouterVisiteur(unVisiteur);
            DateTime maDate = new DateTime(2023, 11, 10);
            sceCommercial.AjouterFraisTransport(maDate, unVisiteur, 100);        
            sceCommercial.AjouterFraisRepasMidi(maDate, unVisiteur, 15.5);
            sceCommercial.AjouterFraisNuitee(maDate, unVisiteur, 105, 2);
            Assert.AreEqual(90.5, sceCommercial.CumulNotesFraisParAnneePourtousVisiteurs(2023));
        }
        
        [TestMethod]
        public void TestSceCommercialNbTotalNoteFrais()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "LOUIS", 'B', 8);


            SceCommercial sceCommercial = new SceCommercial();
            sceCommercial.AjouterVisiteur(unVisiteur);
            DateTime maDate = new DateTime(2023, 11, 10);
            sceCommercial.AjouterFraisTransport(maDate, unVisiteur, 100);
            sceCommercial.AjouterFraisRepasMidi(maDate, unVisiteur, 15.5);
            sceCommercial.AjouterFraisNuitee(maDate, unVisiteur, 105, 2);
            Assert.AreEqual(3, sceCommercial.NbNotesFraisParAnneePourtousVisiteurs(2023));
        }
    }
}
