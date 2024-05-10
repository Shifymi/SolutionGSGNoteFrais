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
    public partial class Form1 : Form
    {
        public List<Visiteur> listeVisiteurs = new List<Visiteur>();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Visiteur> lesVisiteur)
        {
            InitializeComponent();
            listeVisiteurs = lesVisiteur;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Créer une nouvelle instance du formulaire SaisieVisiteur
            SaisieVisiteur saisieVisiteur = new SaisieVisiteur(listeVisiteurs);
            this.Hide();
            // Afficher le formulaire SaisieVisiteur
            saisieVisiteur.Show();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    SceCommercial sceCommercial = Serialisation.Deserialiser(filePath);
                    listeVisiteurs = sceCommercial.lesVisiteurs;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors du chargement des données: " + ex.Message);
                }
            }
        }
        private void enregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers binaires (*.bin)|*.bin";
            saveFileDialog.Title = "Enregistrer les données";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    // Créer une instance de SceCommercial à partir de vos données actuelles
                    SceCommercial sceCommercial = new SceCommercial();
                    sceCommercial.lesVisiteurs = listeVisiteurs; 

                    // Appeler votre méthode de sérialisation pour enregistrer les données
                    Serialisation.Serialiser(sceCommercial, filePath);
                    MessageBox.Show("Les données ont été enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaisieNote formVisiteurs = new SaisieNote(listeVisiteurs);
            this.Hide();
            formVisiteurs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListNoteFraisForm formList = new ListNoteFraisForm(listeVisiteurs);
            this.Hide(); 
            formList.Show();
        }

        
    }
}
