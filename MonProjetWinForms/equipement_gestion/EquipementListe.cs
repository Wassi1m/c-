using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class EquipementListe : Form
    {
        private List<Equipement> equipements; // Store the list of equipment

        // Constructor that accepts a list of equipment
        public EquipementListe(List<Equipement> equipements)
        {
            InitializeComponent();
            this.equipements = equipements; // Initialize the equipment list
            LoadEquipementList(); // Load the equipment list
        }

        private void LoadEquipementList()
        {
            listViewEquipements.Items.Clear(); // Clear existing items
            foreach (var equipement in equipements) // Use the passed equipment
            {
                var listItem = new ListViewItem(equipement.Nom)
                {
                    Tag = equipement // Set the Tag property to store the equipment object
                };
                listItem.SubItems.Add(equipement.Nombre.ToString());
                listItem.SubItems.Add(equipement.Type);
                listItem.SubItems.Add(equipement.Description);
                listViewEquipements.Items.Add(listItem);
            }
        }

        // Add equipment button event
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            EquipementForm form = new EquipementForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Add a new equipment
                var newEquipement = form.NewEquipement;
                SaveEquipement(newEquipement); // Simulate saving the equipment
                equipements.Add(newEquipement); // Add new equipment to the list
                LoadEquipementList(); // Reload the list
            }
        }

        // Modify equipment button event
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (listViewEquipements.SelectedItems.Count > 0)
            {
                var selectedEquipement = (Equipement)listViewEquipements.SelectedItems[0].Tag;
                EquipementForm form = new EquipementForm();
                form.SetEquipement(selectedEquipement);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Update the equipment
                    var updatedEquipement = form.NewEquipement;
                    selectedEquipement.Nom = updatedEquipement.Nom; // Update fields directly
                    selectedEquipement.Nombre = updatedEquipement.Nombre;
                    selectedEquipement.Type = updatedEquipement.Type;
                    selectedEquipement.Description = updatedEquipement.Description;

                    UpdateEquipement(selectedEquipement); // Simulate the update
                    LoadEquipementList(); // Reload the list
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un équipement à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete equipment button event
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (listViewEquipements.SelectedItems.Count > 0)
            {
                var selectedEquipement = (Equipement)listViewEquipements.SelectedItems[0].Tag;
                equipements.Remove(selectedEquipement); // Remove selected equipment
                LoadEquipementList(); // Reload list after deletion
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un équipement à supprimer.");
            }
        }

        private void SaveEquipement(Equipement equipement)
        {
            // Implement the save logic here
        }

        private void UpdateEquipement(Equipement equipement)
        {
            // Implement the update logic here
        }
    }
}
