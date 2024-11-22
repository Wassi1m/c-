using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class EquipementForm : Form
    {
        public Equipement NewEquipement { get; private set; }

        public EquipementForm()
        {
            InitializeComponent();

        }

        public void SetEquipement(Equipement equipement)
        {
            txtNom.Text = equipement.Nom;
            txtNombre.Text = equipement.Nombre.ToString();
            txtType.Text = equipement.Type;
            txtDescription.Text = equipement.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (!Equipement.ValidateNom(txtNom.Text))
            {
                MessageBox.Show("Le nom doit contenir uniquement des lettres.");
                return;
            }
            if (!Equipement.ValidateNombre(int.Parse(txtNombre.Text)))
            {
                MessageBox.Show("Le nombre doit être positif.");
                return;
            }
            

            // Créer un nouvel objet Equipement
            NewEquipement = new Equipement(
                txtNom.Text,
                int.Parse(txtNombre.Text),
                txtType.Text,
                txtDescription.Text
            );

            // Fermer le formulaire avec succès
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
