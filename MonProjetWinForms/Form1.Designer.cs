namespace MonProjetWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel descriptionPanel;
        private Label lblDescription;
      

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarPanel = new System.Windows.Forms.Panel(); // Champ utilisé explicitement
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCreateChambre = new System.Windows.Forms.Button();
            this.btnCreateEquipement = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnViewEquipement = new System.Windows.Forms.Button();
            this.btnViewChambres = new System.Windows.Forms.Button();

            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.BackColor = System.Drawing.Color.LightGray;
            this.sidebarPanel.Width = 250;
            this.sidebarPanel.Controls.Add(this.btnCreateUser);
            this.sidebarPanel.Controls.Add(this.btnCreateChambre);
            this.sidebarPanel.Controls.Add(this.btnCreateEquipement);
            this.sidebarPanel.Controls.Add(this.btnViewUsers);
            this.sidebarPanel.Controls.Add(this.btnViewEquipement);
            this.sidebarPanel.Controls.Add(this.btnViewChambres);

            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionPanel.Controls.Add(this.lblDescription);

            // 
            // lblDescription
            // 
            // 
            // lblDescription
            // 
            // lblDescription
            this.lblDescription.AutoSize = false; // Permet de définir une taille fixe pour le label
            this.lblDescription.Size = new System.Drawing.Size(450, 200);
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray; // Couleur du texte
            this.lblDescription.BackColor = System.Drawing.Color.White; // Fond blanc pour un contraste professionnel
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Bordure pour encadrer le texte
            this.lblDescription.Padding = new System.Windows.Forms.Padding(10); // Espacement intérieur
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // Alignement à gauche
            this.lblDescription.Text = "Bienvenue dans le système de gestion d'hôtel.\n\n" +
                                        "Vous pouvez gérer :\n" +
                                        "• Les utilisateurs\n" +
                                        "• Les chambres\n" +
                                        "• Les équipements\n\n" +
                                        "👉 Utilisez les boutons à gauche pour accéder aux fonctionnalités.";

            // Centrer le label dans le panneau
            this.lblDescription.Location = new System.Drawing.Point(
                (this.descriptionPanel.Width - this.lblDescription.Width) / 2, // Centrage horizontal
                (this.descriptionPanel.Height - this.lblDescription.Height) / 2 // Centrage vertical
            );

            // Si le panneau change de taille (par ex., lors d’un redimensionnement), appliquer dynamiquement le centrage
            this.descriptionPanel.Resize += (s, e) =>
            {
                this.lblDescription.Location = new System.Drawing.Point(
                    (this.descriptionPanel.Width - this.lblDescription.Width) / 2,
                    (this.descriptionPanel.Height - this.lblDescription.Height) / 2
                );
            };


            // 
            // Buttons
            // 
            ConfigureButton(this.btnCreateUser, "Créer Utilisateur", new System.Drawing.Point(10, 20), this.btnCreateUser_Click);
            ConfigureButton(this.btnCreateChambre, "Créer Chambre", new System.Drawing.Point(10, 70), this.btnCreateChambre_Click);
            ConfigureButton(this.btnCreateEquipement, "Créer Equipement", new System.Drawing.Point(10, 120), this.btnCreateEquipement_Click);
            ConfigureButton(this.btnViewUsers, "Voir Utilisateurs", new System.Drawing.Point(10, 170), this.btnViewUsers_Click);
            ConfigureButton(this.btnViewEquipement, "Voir Équipements", new System.Drawing.Point(10, 220), this.btnViewEquipement_Click);
            ConfigureButton(this.btnViewChambres, "Voir Chambres", new System.Drawing.Point(10, 270), this.btnViewChambres_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.sidebarPanel); // Utilisation correcte du champ
            this.Text = "Hotel Management";
        }

        private void ConfigureButton(Button button, string text, System.Drawing.Point location, EventHandler clickHandler)
        {
            button.Text = text;
            button.Location = location;
            button.Size = new System.Drawing.Size(220, 40);
            button.UseVisualStyleBackColor = true;
            button.Click += clickHandler;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
