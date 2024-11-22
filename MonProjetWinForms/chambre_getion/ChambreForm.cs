using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class ChambreForm : Form
    {
        public Chambre NewChambre { get; private set; }

        public ChambreForm()
        {
            InitializeComponent();
        }

        public void SetChambre(Chambre chambre)
        {
            txtNumero.Text = chambre.Numero.ToString();
            txtCapacite.Text = chambre.Capacite.ToString();
            txtTypeChambre.Text = chambre.TypeChambre;
            txtDescription.Text = chambre.Description;
            chkDisponible.Checked = chambre.Disponible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (!int.TryParse(txtNumero.Text, out int numero) || !Chambre.ValidateNumero(numero))
            {
                MessageBox.Show("Le numéro de la chambre doit être un entier positif.");
                return;
            }
            if (!int.TryParse(txtCapacite.Text, out int capacite) || !Chambre.ValidateCapacite(capacite))
            {
                MessageBox.Show("La capacité doit être un entier positif.");
                return;
            }
            if (!Chambre.ValidateTypeChambre(txtTypeChambre.Text))
            {
                MessageBox.Show("Le type de chambre n'est pas valide.");
                return;
            }

            // Créer un nouvel objet Chambre
            NewChambre = new Chambre(
                numero,
                capacite,
                txtTypeChambre.Text,
                txtDescription.Text,
                chkDisponible.Checked
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
