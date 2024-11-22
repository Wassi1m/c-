using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class ChambreListe : Form
    {
        private List<Chambre> chambres; // Stocker la liste des chambres

        // Constructeur qui accepte une liste de chambres
        public ChambreListe(List<Chambre> chambres)
        {
            InitializeComponent();
            this.chambres = chambres; // Initialiser la liste de chambres
            LoadChambreList(); // Charger la liste des chambres
        }

        private void LoadChambreList()
        {
            listViewChambres.Items.Clear(); // Vider les éléments existants
            foreach (var chambre in chambres) // Utiliser la liste de chambres fournie
            {
                // Conversion de chambre.Numero en string
                var listItem = new ListViewItem(chambre.Numero.ToString())
                {
                    Tag = chambre // Définir la propriété Tag pour stocker l'objet chambre
                };
                listItem.SubItems.Add(chambre.Capacite.ToString());
                listItem.SubItems.Add(chambre.TypeChambre);
                listItem.SubItems.Add(chambre.Disponible ? "Oui" : "Non");
                listViewChambres.Items.Add(listItem);
            }
        }

        // Événement du bouton Ajouter une chambre
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ChambreForm form = new ChambreForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Ajouter une nouvelle chambre
                var newChambre = form.NewChambre;
                SaveChambre(newChambre); // Simuler la sauvegarde de la chambre
                chambres.Add(newChambre); // Ajouter la nouvelle chambre à la liste
                LoadChambreList(); // Recharger la liste
            }
        }

        // Événement du bouton Modifier une chambre
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (listViewChambres.SelectedItems.Count > 0)
            {
                var selectedChambre = (Chambre)listViewChambres.SelectedItems[0].Tag;
                ChambreForm form = new ChambreForm();
                form.SetChambre(selectedChambre);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Mettre à jour la chambre
                    var updatedChambre = form.NewChambre;
                    selectedChambre.Numero = updatedChambre.Numero;
                    selectedChambre.Capacite = updatedChambre.Capacite;
                    selectedChambre.TypeChambre = updatedChambre.TypeChambre;
                    selectedChambre.Disponible = updatedChambre.Disponible;

                    UpdateChambre(selectedChambre); // Simuler la mise à jour
                    LoadChambreList(); // Recharger la liste
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chambre à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Événement du bouton Supprimer une chambre
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (listViewChambres.SelectedItems.Count > 0)
            {
                var selectedChambre = (Chambre)listViewChambres.SelectedItems[0].Tag;
                chambres.Remove(selectedChambre); // Supprimer la chambre sélectionnée
                LoadChambreList(); // Recharger la liste après suppression
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chambre à supprimer.");
            }
        }

        private void SaveChambre(Chambre chambre)
        {
            // Implémentez ici la logique de sauvegarde
        }

        private void UpdateChambre(Chambre chambre)
        {
            // Implémentez ici la logique de mise à jour
        }
    }
}
