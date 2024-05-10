using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetGSG;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un visiteur pour tester les frais
            Visiteur visiteur = new Visiteur("DUPONT", "Louis", 'A', 8);

            // Création et affichage d'un frais de transport
            FraisTransport fraisTransport = new FraisTransport(new DateTime(2023, 11, 8), visiteur, 250);
            Console.WriteLine(fraisTransport.ToString());


            // Création et affichage d'un frais de repas de midi
            FraisRepasMidi fraisRepasMidi = new FraisRepasMidi(new DateTime(2023, 11, 9), visiteur, 35);
            Console.WriteLine(fraisRepasMidi.ToString());

            // Création et affichage d'un frais de repas de midi
            FraisRepasMidi fraisRepasMidi2 = new FraisRepasMidi(new DateTime(2023, 11, 9), visiteur, 15.5);
            Console.WriteLine(fraisRepasMidi.ToString());

            // Création et affichage d'un frais de nuitée
            FraisNuitee fraisNuitee = new FraisNuitee(new DateTime(2023, 11, 10), visiteur, 70, 2);
            Console.WriteLine("Frais de nuitée créé :");
            Console.WriteLine(fraisNuitee);
            Console.WriteLine($"Remboursement : {fraisNuitee.CalculMttARembourser()} euros\n");

            //Création d'un visiteur
            // Création d'un visiteur et ajout dans le service commercial
            // Création d'un visiteur
            // Création d'un visiteur
            // Création des visiteurs
            Visiteur visiteur1 = new Visiteur("DUPONT", "LOUIS", 'B', 8);
            Visiteur visiteur2 = new Visiteur("MARTIN", "EMMA", 'A', 10);
            Visiteur visiteur3 = new Visiteur("DUBOIS", "LEA", 'C', 6);

            //Création du service commercial

            SceCommercial sceCommercial = new SceCommercial();
            // Ajout des visiteurs et de leurs notes de frais
            DateTime date1 = new DateTime(2023, 11, 10);
            DateTime date2 = new DateTime(2023, 12, 5);
            DateTime date3 = new DateTime(2023, 10, 20);

            sceCommercial.AjouterVisiteur(visiteur1);
            sceCommercial.AjouterVisiteur(visiteur2);
            sceCommercial.AjouterVisiteur(visiteur3);

            //Notes de frais pour le visiteur 1
            sceCommercial.AjouterFraisTransport(date1, visiteur1, 100); // Exemple de frais de transport
            sceCommercial.AjouterFraisRepasMidi(date1, visiteur1, 15.5); // Exemple de frais de repas de midi
            sceCommercial.AjouterFraisNuitee(date1, visiteur1, 105, 2); // Exemple de frais de nuitée

            //Notes de frais pour le visiteur 2
            sceCommercial.AjouterFraisTransport(date2, visiteur2, 80); // Exemple de frais de transport
            sceCommercial.AjouterFraisRepasMidi(date2, visiteur2, 20); // Exemple de frais de repas de midi
            sceCommercial.AjouterFraisNuitee(date2, visiteur2, 90, 1); // Exemple de frais de nuitée

            //Notes de frais pour le visiteur 3
            sceCommercial.AjouterFraisTransport(date3, visiteur3, 120); // Exemple de frais de transport
            sceCommercial.AjouterFraisRepasMidi(date3, visiteur3, 18); // Exemple de frais de repas de midi
            sceCommercial.AjouterFraisNuitee(date3, visiteur3, 80, 3); // Exemple de frais de nuitée

            Console.WriteLine(visiteur3.mesNotesFrais.Count);
            //Chemin du fichier où les données seront sérialisées
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serviceCommercial.dat");

            //Sérialiser les données au format JSON
            Serialisation.Serialiser(sceCommercial, filePath);

            //Désérialiser les données depuis le format JSON
            SceCommercial loadedService = Serialisation.Deserialiser(filePath);

            //Afficher les résultats pour vérifier
            Console.WriteLine($"Nombre de visiteurs: {loadedService.lesVisiteurs.Count}");
            Console.WriteLine($"Nom du premier visiteur: {loadedService.lesVisiteurs[0].Nom}");
            Console.WriteLine($"Nombre de notes de frais: {loadedService.lesVisiteurs[0].mesNotesFrais.Count}");

            //Garder la console ouverte jusqu'à ce qu'une touche soit pressée
            Console.Read();

            //    Console.WriteLine("Bienvenue ur le gestionnaire de note de frais :");
            //    Console.WriteLine("Souhaitez vous ouvir un fichier ayant déja des données ?");
            //    Console.WriteLine("1. DeSérialiser les données");
            //    Console.WriteLine("2. Commencer un nouvelle enregistrement de données ");
            //    //Lire le choix de l'utilisateur
            //    string choix = Console.ReadLine();
            //    switch (choix)
            //    {
            //        case "1":
            //            // Desérialiser les données
            //            //Console.
            //            //sceCommercial = Serialisation.Deserialiser(filePath);
            //            break;
            //        case "2":
            //            // Commencer un nouvel enregistrement de données
            //            SceCommercial nouveauSceCommercial = CommencerNouvelEnregistrement();
            //            break;
            //        default:
            //            Console.WriteLine("Choix invalide.");
            //            break;
            //    }

            //}
            //public static SceCommercial CommencerNouvelEnregistrement()
            //{
            //    bool continuer = true;
            //    while (continuer)
            //    {
            //        List<Visiteur> listeVisiteurs = new List<Visiteur>();
            //        // Afficher le menu
            //        AfficherMenu();

            //        // Lire le choix de l'utilisateur
            //        string choix = Console.ReadLine();

            //        // Effectuer une action en fonction du choix de l'utilisateur
            //        switch (choix)
            //        {
            //            case "1":
            //                listeVisiteurs.Add(CreerNouveauVisiteur());
            //                break;
            //            case "2":
            //                AfficherMenuNoteFrais();
            //                string choixNote = Console.ReadLine();
            //                switch (choixNote)
            //                {
            //                    case "1":
            //                        CreerNouvelleNoteDeFrais(listeVisiteurs);

            //                        break;
            //                    case "2":
            //                        break;
            //                    case "3":
            //                        break;
            //                    case "4":
            //                        break;

            //                }
            //                break;
            //            case "3":
            //                // Ajouter d'autres options de menu ici
            //                break;
            //            case "4":
            //                // Quitter le programme
            //                continuer = false;
            //                break;
            //            default:
            //                Console.WriteLine("Choix invalide. Veuillez sélectionner une option valide.");
            //                break;
            //        }
            //    }
            //    return new SceCommercial();
            //}
            //static void AfficherMenuNoteFrais()
            //{
            //    Console.WriteLine("\nMenu :");
            //    Console.WriteLine("1. Créer un note de nuitee");
            //    Console.WriteLine("2. Créer une note de repas midi");
            //    Console.WriteLine("3. Créer une note de transport");
            //    Console.WriteLine("4. Quitter");
            //    Console.Write("Votre choix : ");
            //}
            //static void AfficherMenu()
            //{
            //    Console.WriteLine("\nMenu :");
            //    Console.WriteLine("1. Créer un nouveau visiteur");
            //    Console.WriteLine("2. Créer une nouvelle note de frais");
            //    Console.WriteLine("3. Lister les notes de frais");
            //    Console.WriteLine("4. Quitter");
            //    Console.Write("Votre choix : ");
            //}
            //static Visiteur CreerNouveauVisiteur()
            //{
            //    Console.WriteLine("\nCréation d'un nouveau visiteur :");

            //    // Demander et lire le nom du visiteur
            //    Console.Write("Entrez le nom du visiteur : ");
            //    string nom = Console.ReadLine();

            //    // Demander et lire le prénom du visiteur
            //    Console.Write("Entrez le prénom du visiteur : ");
            //    string prenom = Console.ReadLine();

            //    // Demander et lire la catégorie professionnelle du visiteur
            //    char categProf;
            //    do
            //    {
            //        Console.Write("Entrez la catégorie professionnelle du visiteur (A, B ou C) : ");
            //        categProf = char.ToUpper(Console.ReadKey().KeyChar);
            //        Console.WriteLine(); // Aller à la ligne après la saisie
            //    } while (categProf != 'A' && categProf != 'B' && categProf != 'C');

            //    // Demander et lire la puissance du véhicule du visiteur
            //    Console.Write("Entrez la puissance du véhicule du visiteur : ");
            //    int puissanceVeh;
            //    while (!int.TryParse(Console.ReadLine(), out puissanceVeh))
            //    {
            //        Console.WriteLine("Veuillez saisir un nombre entier valide pour la puissance du véhicule.");
            //        Console.Write("Entrez la puissance du véhicule du visiteur : ");
            //    }

            //    // Demander confirmation à l'utilisateur avant de créer le visiteur
            //    Console.WriteLine("\nÊtes-vous sûr de vouloir créer ce visiteur ? (O/N)");
            //    char confirmation = char.ToUpper(Console.ReadKey().KeyChar);
            //    Console.WriteLine(); // Aller à la ligne après la saisie

            //    if (confirmation == 'O')
            //    {
            //        // Créer un nouvel objet Visiteur avec les informations saisies
            //        Visiteur nouveauVisiteur = new Visiteur(nom, prenom, categProf, puissanceVeh);

            //        // Afficher les informations du visiteur créé
            //        Console.WriteLine($"\nNouveau visiteur créé : {nouveauVisiteur.Prenom} {nouveauVisiteur.Nom}");
            //        Console.WriteLine($"Catégorie professionnelle : {nouveauVisiteur.CategProf}");
            //        Console.WriteLine($"Puissance du véhicule : {nouveauVisiteur.PuissanceVeh}");
            //        return nouveauVisiteur;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Création du visiteur annulée.");
            //        return null;
            //    }
            //}
            //static void CreerNouvelleNoteDeFrais(List<Visiteur> listeVisiteurs)
            //    {
            //        // Vérifier s'il existe des visiteurs dans la liste
            //        if (listeVisiteurs.Count == 0)
            //        {
            //            Console.WriteLine("Aucun visiteur n'est disponible pour créer une note de frais.");
            //            return;
            //        }

            //        // Afficher la liste des visiteurs disponibles
            //        Console.WriteLine("Liste des visiteurs disponibles :");
            //        for (int i = 0; i < listeVisiteurs.Count; i++)
            //        {
            //            Console.WriteLine($"{i + 1}. {listeVisiteurs[i].Nom} {listeVisiteurs[i].Prenom}");
            //        }

            //        // Demander à l'utilisateur de choisir un visiteur
            //        Console.Write("\nChoisissez un visiteur en entrant son numéro : ");
            //        int choixVisiteur;
            //        while (!int.TryParse(Console.ReadLine(), out choixVisiteur) || choixVisiteur < 1 || choixVisiteur > listeVisiteurs.Count)
            //        {
            //            Console.WriteLine("Veuillez saisir un numéro valide.");
            //            Console.Write("Choisissez un visiteur en entrant son numéro : ");
            //        }

            //        // Récupérer le visiteur choisi
            //        Visiteur visiteurChoisi = listeVisiteurs[choixVisiteur - 1];

            //        // Demander et lire la date de la note de frais
            //        Console.Write("\nEntrez la date de la note de frais (format : JJ/MM/AAAA) : ");
            //        DateTime dateNoteFrais;
            //        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateNoteFrais))
            //        {
            //            Console.WriteLine("Veuillez saisir une date valide au format JJ/MM/AAAA.");
            //            Console.Write("Entrez la date de la note de frais (format : JJ/MM/AAAA) : ");
            //        }

            //        // Demander et lire le montant de la note de frais
            //        Console.Write("Entrez le montant de la note de frais : ");
            //        decimal montantNoteFrais;
            //        while (!decimal.TryParse(Console.ReadLine(), out montantNoteFrais) || montantNoteFrais <= 0)
            //        {
            //            Console.WriteLine("Veuillez saisir un montant valide (nombre positif).");
            //            Console.Write("Entrez le montant de la note de frais : ");
            //        }


            //        Console.WriteLine("Nouvelle note de frais ajoutée avec succès !");
            //    }


        }
    }
    }