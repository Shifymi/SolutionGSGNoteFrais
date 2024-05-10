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
    public partial class SaisieNote : Form
    {
        public List<Visiteur> listeVisiteurs = new List<Visiteur>();
        public int typeNote;
        public Visiteur leVisiteur;
        public DateTime laDate;
        public int nbkm;
        public double mttmidi;
        public double mttnuitee;
        public int region;
        public SaisieNote(List<Visiteur> visiteurs)
        {
            listeVisiteurs = visiteurs;
            InitializeComponent();
            RemplirComboBoxVisiteurs();
            // Masquer tous les contrôles initialement
            label3.Visible = false;
            label.Visible = false;
            dateTimePicker1.Visible = false;
            textBoxnbkm.Visible = false;
            textBoxmttmidi.Visible = false;
            textBoxmttnuitee.Visible = false;
            textBoxregion.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            
        }
        
        private void RemplirComboBoxVisiteurs()
        {
            comboBox1.Items.Clear(); // Nettoyer les items existants pour éviter les doublons
            foreach (Visiteur unVisiteur in listeVisiteurs)
            {
                comboBox1.Items.Add(unVisiteur.Nom); // Ajoute le nom de chaque visiteur à la comboBox
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifie d'abord si un élément est sélectionné dans le ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Trouver le Visiteur correspondant au nom sélectionné
                string nomVisiteurSelectionne = comboBox1.SelectedItem.ToString();
                leVisiteur = listeVisiteurs.FirstOrDefault(visiteur => visiteur.Nom == nomVisiteurSelectionne);

                if (leVisiteur == null)
                {
                    MessageBox.Show("Erreur lors de la récupération du visiteur sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Masquer tous les contrôles initialement
            label3.Visible = false;
            label.Visible = false;
            dateTimePicker1.Visible = false;
            textBoxnbkm.Visible = false;
            textBoxmttmidi.Visible = false;
            textBoxmttnuitee.Visible = false;
            textBoxregion.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            // Vérifier quelle option est sélectionnée
            switch (comboBox2.SelectedIndex)
            {
                case 0:  // Choix 1
                    label3.Visible = true;
                    dateTimePicker1.Visible = true;
                    textBoxnbkm.Visible = true;
                    label.Visible = true;
                    typeNote = 1;
                    break;
                case 1:  // Choix 2
                    label3.Visible = true;
                    dateTimePicker1.Visible = true;
                    label4.Visible = true;
                    textBoxmttmidi.Visible = true;
                    typeNote = 2;
                    break;
                case 2:  // Choix 3
                    label3.Visible = true;
                    dateTimePicker1.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    textBoxmttnuitee.Visible = true;
                    textBoxregion.Visible = true;
                    typeNote = 3;
                    break;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            laDate = dateTimePicker1.Value;
        }
        private void textBoxnbkm_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxnbkm.Text, out int result))
            {
                nbkm = result;
            }
        }

        private void textBoxmttmidi_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxmttmidi.Text, out double result))
            {
                mttmidi = result;
            }
        }

        private void textBoxmttnuitee_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxmttnuitee.Text, out double result))
            {
                mttnuitee = result;
            }
        }

        private void textBoxregion_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxregion.Text, out int result))
            {
                region = result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValiderSelectionVisiteur())
                return;

            if (!ValiderDonneesNoteFrais())
                return;

            AfficherConfirmation();
        }

        private bool ValiderSelectionVisiteur()
        {
            if (comboBox1.SelectedItem == null)
            {
                AfficherMessageErreur("Veuillez sélectionner un visiteur.");
                return false;
            }
            return true;
        }

        private bool ValiderDonneesNoteFrais()
        {
            switch (typeNote)
            {
                case 1: // FraisTransport
                    if (nbkm <= 0)
                    {
                        AfficherMessageErreur("Veuillez saisir un nombre de kilomètres valide.");
                        return false;
                    }
                    break;
                case 2: // FraisRepasMidi
                    if (mttmidi <= 0)
                    {
                        AfficherMessageErreur("Veuillez saisir un montant de repas midi valide.");
                        return false;
                    }
                    break;
                case 3: // FraisNuitee
                    if (mttnuitee <= 0 || region <= 0)
                    {
                        AfficherMessageErreur("Veuillez saisir un montant de nuitée et une région valide.");
                        return false;
                    }
                    break;
            }
            return true;
        }

        private void AfficherConfirmation()
        {
            if (laDate == DateTime.MinValue)
            {
                laDate = DateTime.Now;
            }
            string typeNotestring = "";
            switch (comboBox2.SelectedIndex)
            {
                case 0:  // Choix 1
                    typeNotestring = $"Nombre de kilomètres: {nbkm}";
                    break;
                case 1:  // Choix 2
                    typeNotestring = $"Montant du repas midi: {mttmidi}";
                    break;
                case 2:  // Choix 3
                    typeNotestring = $"Montant de la nuitée: {mttnuitee}\nRégion: {region}";
                    break;
            }

            // Construire le message de confirmation
            string messageConfirmation = $"Voulez-vous créer un nouveau profil avec les informations suivantes ?\n\n" +
                                            $"Nom: {leVisiteur.Nom}\n" +
                                            $"Prénom: {leVisiteur.Prenom}\n" +
                                            $"Type de note: {comboBox2.SelectedItem}\n" +
                                            $"Date: {laDate.ToString("dd/MM/yyyy")}\n\n" +
                                            $"{typeNotestring}\n\n" +
                                            $"Confirmez-vous cette action ?";
            DialogResult resultatConfirmation = MessageBox.Show(messageConfirmation, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Vérifier la réponse de l'utilisateur
            if (resultatConfirmation == DialogResult.Yes)
            {
                // Afficher un message de confirmation
                MessageBox.Show("Profil créé avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                NoteFrais uneNote;

                switch (typeNote)
                {
                    case 1:
                        uneNote = new FraisTransport(laDate, leVisiteur, nbkm);
                        break;
                    case 2:
                        uneNote = new FraisRepasMidi(laDate, leVisiteur, mttmidi);
                        break;
                    case 3:
                        uneNote = new FraisNuitee(laDate, leVisiteur, mttnuitee, region);
                        break;
                    default:
                        throw new ArgumentException("Type de note invalide.");
                }
                
                Form1 formAccueil = new Form1(listeVisiteurs);
                formAccueil.Show();
            }
            else
            {
                // L'utilisateur a annulé l'action, ne rien faire ou afficher un message selon le besoin
                MessageBox.Show("Opération annulée.", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AfficherMessageErreur(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Afficher un message de confirmation avant de fermer la page
            DialogResult resultatConfirmation = MessageBox.Show("Êtes-vous sûr de vouloir quitter la page d'ajout d'une note de frais ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier si l'utilisateur a confirmé
            if (resultatConfirmation == DialogResult.Yes)
            {
                // Fermer la page et afficher le formulaire d'accueil
                this.Close();
                Form1 frmAccueil = new Form1(listeVisiteurs);
                frmAccueil.Show();
            }
        }
    }
}
