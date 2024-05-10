using ProjetGSG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGSGForm
{
    public partial class SaisieVisiteur : Form
    {
        private string nom;
        private string prenom;
        private char categProf;
        private int PuissanceVeh;
        private List<Visiteur> lesVisiteurs;
        public SaisieVisiteur(List<Visiteur> lesVisiteurs)
        {
            InitializeComponent();
            this.lesVisiteurs = lesVisiteurs;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                nom = textBox.Text; // Mettre à jour la variable nom avec le texte de la TextBox
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                prenom = textBox.Text; // Mettre à jour la variable prenom avec le texte de la TextBox
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string selectedValue = comboBox.SelectedItem?.ToString();

                // Mettre à jour la variable CategProf en fonction de l'élément sélectionné
                categProf = (!string.IsNullOrEmpty(selectedValue) && selectedValue.Length == 1) ? selectedValue[0] : '\0';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int puissance))
                {
                    PuissanceVeh = puissance; // Mettre à jour la propriété PuissanceVeh si la conversion réussit
                }
                else
                {
                    PuissanceVeh = 0; // Réinitialiser PuissanceVeh à zéro si la conversion échoue
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation du champ 'Nom'
            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Veuillez saisir le nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrête l'exécution de la méthode si le champ 'Nom' est vide
            }

            // Validation du champ 'Prénom'
            if (string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Veuillez saisir le prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrête l'exécution de la méthode si le champ 'Prénom' est vide
            }

            // Validation de la catégorie professionnelle (CategProf)
            if (categProf == '\0')
            {
                MessageBox.Show("Veuillez sélectionner une catégorie professionnelle.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrête l'exécution de la méthode si aucune catégorie professionnelle n'est sélectionnée
            }

            // Validation de la puissance du véhicule (PuissanceVeh)
            if (PuissanceVeh <= 0)
            {
                MessageBox.Show("Veuillez saisir une puissance de véhicule valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Arrête l'exécution de la méthode si la puissance du véhicule est invalide
            }

            // Si toutes les validations sont passées avec succès, préparer le message de confirmation
            string messageConfirmation = $"Voulez-vous créer un nouveau profil avec les informations suivantes ?\n\n" +
                                          $"Nom: {nom}\n" +
                                          $"Prénom: {prenom}\n" +
                                          $"Catégorie professionnelle: {categProf}\n" +
                                          $"Puissance du véhicule: {PuissanceVeh}\n\n" +
                                          $"Confirmez-vous cette action ?";

            // Afficher une boîte de dialogue de confirmation (Oui/Non)
            DialogResult result = MessageBox.Show(messageConfirmation, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                Visiteur nouveauVisiteur = new Visiteur(nom, prenom, categProf, PuissanceVeh);
                lesVisiteurs.Add(nouveauVisiteur);
                // Afficher un message de succès
                MessageBox.Show("Profil créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                // Fermer le formulaire actuel
                this.Close();

                // Ouvrir le formulaire d'accueil (FormAccueil)
                Form1 formAccueil = new Form1(lesVisiteurs);
                formAccueil.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Afficher un message de confirmation avant de fermer la page
            DialogResult resultatConfirmation = MessageBox.Show("Êtes-vous sûr de vouloir quitter la page d'ajout d'un visiteur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier si l'utilisateur a confirmé
            if (resultatConfirmation == DialogResult.Yes)
            {
                // Fermer la page et afficher le formulaire d'accueil
                this.Close();
                Form1 frmAccueil = new Form1(lesVisiteurs);
                frmAccueil.Show();
            }
        }

    }
}
