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
    public partial class ListNoteFraisForm : Form
    {
        public List<Visiteur> listesVisiteurs = new List<Visiteur>();
        public ListNoteFraisForm(List<Visiteur> lesVisiteurs)
        {
            InitializeComponent();
            listesVisiteurs = lesVisiteurs;
            RemplirComboBoxVisiteurs();

        }
        private void RemplirComboBoxVisiteurs()
        {
            comboBox1.Items.Clear(); // Nettoyer les items existants pour éviter les doublons

            foreach (Visiteur unVisiteur in listesVisiteurs)
            {
                comboBox1.Items.Add(unVisiteur); // Ajoute l'objet Visiteur directement à la comboBox
            }
        }
        private void RemplirListViewNoteFrais()
        {
            listView1.Items.Clear(); // Nettoyer les éléments existants pour éviter les doublons

            // Récupérer le visiteur sélectionné dans le comboBox
            Visiteur leVisiteur = comboBox1.SelectedItem as Visiteur;

            // Vérifier si un visiteur est sélectionné
            if (leVisiteur != null)
            {
                foreach (NoteFrais uneNote in leVisiteur.mesNotesFrais)
                {
                    // Créer un ListViewItem correspondant à chaque objet NoteFrais
                    ListViewItem item = new ListViewItem();

                    // Ajouter le type de note de frais à la première colonne (index 0)
                    if (uneNote is FraisNuitee)
                    {
                        item.Text = "FraisNuitee";
                    }
                    else if (uneNote is FraisTransport)
                    {
                        item.Text = "FraisTransport";
                    }
                    else if (uneNote is FraisRepasMidi)
                    {
                        item.Text = "FraisRepasMidi";
                    }
                    else
                    {
                        item.Text = "Type Inconnu";
                    }

                    // Ajouter les autres sous-éléments à partir de la deuxième colonne
                    item.SubItems.Add(uneNote.numero.ToString());
                    item.SubItems.Add(uneNote.dateNF.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(uneNote.estRembourse.ToString());
                    item.SubItems.Add(uneNote.mttARembourser.ToString());
                    // Vérifier le type de note de frais spécifique et remplir la colonne correspondante
                    if (uneNote is FraisNuitee)
                    {
                        FraisNuitee fraisNuitee = uneNote as FraisNuitee;
                        item.SubItems.Add(fraisNuitee.numRegion.ToString());
                    }
                    else if (uneNote is FraisTransport)
                    {
                        FraisTransport fraisTransport = uneNote as FraisTransport;
                        item.SubItems.Add("");
                        item.SubItems.Add(fraisTransport.nbKm.ToString());
                    }
                    else if (uneNote is FraisRepasMidi)
                    {
                        // Ajouter une valeur spécifique pour FraisRepasMidi (si nécessaire)
                    }
                    else
                    {
                        // Ajouter une valeur vide ou une indication de type inconnu pour d'autres types de frais
                        item.SubItems.Add("");
                    }

                    // Ajouter l'élément ListViewItem à la ListView
                    listView1.Items.Add(item);
                }
            }
            else
            {
                // Afficher un message d'erreur si aucun visiteur n'est sélectionné
                MessageBox.Show("Aucun visiteur sélectionné");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirListViewNoteFrais();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frmAccueil = new Form1(listesVisiteurs);
            frmAccueil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
