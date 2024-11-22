using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class UserListForm : Form
    {
        private List<Person> people;

        public UserListForm(List<Person> users)
        {
            InitializeComponent();
            this.people = users;
            LoadUserList();
        }

        private void LoadUserList()
        {
            listViewUsers.Items.Clear();
            foreach (var user in people)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    user.Nom,
                    user.Prenom,
                    user.Num,
                    user.Age.ToString()
                });

                listViewItem.Tag = user; // Store user in the tag
                listViewUsers.Items.Add(listViewItem);
            }
              }
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (listViewUsers.SelectedItems.Count > 0)
                {
                    var selectedUser = (Person)listViewUsers.SelectedItems[0].Tag;
                    UserForm userForm = new UserForm();
                    userForm.SetUser(selectedUser);
                    Console.WriteLine("88888");
                    Console.WriteLine(selectedUser);

                    if (userForm.ShowDialog() == DialogResult.OK)
                    {
                        // Apply the changes to the selected user
                        var updatedUser = userForm.NewUser;
                        selectedUser.Nom = updatedUser.Nom;
                        selectedUser.Prenom = updatedUser.Prenom;
                        selectedUser.Num = updatedUser.Num;
                        selectedUser.Age = updatedUser.Age;

                        // Reload the list to reflect the changes
                        LoadUserList(); // Assurez-vous que cette méthode recharge la liste correctement
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur à mettre à jour.");
                }
            }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                var selectedUser = (Person)listViewUsers.SelectedItems[0].Tag;
                people.Remove(selectedUser);
                LoadUserList(); // Reload list after deletion
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }
    }
}
