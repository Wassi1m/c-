using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();
        private List<Equipement> equipement = new List<Equipement>();
        private List<Chambre> chambres = new List<Chambre>(); // List of chambres

        private Panel sidebarPanel;
        private Button btnCreateUser;
        private Button btnCreateChambre;
        private Button btnCreateEquipement;
        private Button btnViewUsers;
        private Button btnViewEquipement;
        private Button btnViewChambres;
 
        public Form1()
        {
            InitializeComponent();
         }

     

        private void btnCreateChambre_Click(object sender, EventArgs e)
        {
            // Create instance of EquipementForm
            EquipementForm btnCreateChambre = new EquipementForm();
            
            // If the form is validated by the user (OK)
            if (btnCreateChambre.ShowDialog() == DialogResult.OK)
            {
                equipement.Add(btnCreateChambre.NewEquipement);
            }
        }

        private void btnCreateEquipement_Click(object sender, EventArgs e)
        {
            // Create instance of EquipementForm
            EquipementForm equipementForm = new EquipementForm();
            
            // If the form is validated by the user (OK)
            if (equipementForm.ShowDialog() == DialogResult.OK)
            {
                equipement.Add(equipementForm.NewEquipement);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                // Add the created user to the list
                people.Add(userForm.NewUser);
            }
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(people);
            userListForm.ShowDialog();
        }

        private void btnViewEquipement_Click(object sender, EventArgs e)
        {
            // Create instance of EquipementListe and pass the list of equipment
            EquipementListe equipementListe = new EquipementListe(equipement); // If equipement is a list
            // Show the form
            equipementListe.ShowDialog();
        }

        private void btnViewChambres_Click(object sender, EventArgs e) // New event handler
        {
            ChambreListe chambreListeForm = new ChambreListe(chambres);
            chambreListeForm.ShowDialog();
        }
    }
}
