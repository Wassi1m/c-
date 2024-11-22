using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class UserForm : Form
    {
        public Person NewUser { get; private set; }

        public UserForm()
        {
            InitializeComponent();
        }

        public void SetUser(Person user)
        {
            txtNom.Text = user.Nom;
            txtPrenom.Text = user.Prenom;
            txtNum.Text = user.Num;
            txtAge.Text = user.Age.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string num = txtNum.Text;
            string ageText = txtAge.Text;

            // Validate fields
            if (!Person.ValidateName(nom))
            {
                MessageBox.Show("Le nom ne doit contenir que des lettres.");
                return;
            }
            if (!Person.ValidateName(prenom))
            {
                MessageBox.Show("Le prénom ne doit contenir que des lettres.");
                return;
            }
            if (!Person.ValidatePhoneNumber(num))
            {
                MessageBox.Show("Le numéro de téléphone ne doit contenir que des chiffres.");
                return;
            }
            if (!Person.ValidateAge(ageText))
            {
                MessageBox.Show("L'âge doit être un entier positif.");
                return;
            }

            // Create a new user
            NewUser = new Person
            {
                Nom = nom,
                Prenom = prenom,
                Num = num,
                Age = int.Parse(ageText)
            };

            // Close the form successfully
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
