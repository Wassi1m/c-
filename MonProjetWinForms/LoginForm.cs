using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

       private void btnLogin_Click(object sender, EventArgs e)
            {
                // Récupérer les informations d'authentification
                Username = txtUsername.Text;
                Password = txtPassword.Text;

                // Ajouter une logique d'authentification simple
                if (IsValidUser(Username, Password))
                {
                    // Show Form1 and close the LoginForm
                    Form1 mainForm = new Form1();  // Create an instance of Form1
                    this.Hide();  // Hide the LoginForm (optional, if you want to keep it open in the background)
                    mainForm.Show();  // Show Form1 (Main Form)
                }
                else
                {
                    // Optionally show a message box for invalid login
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        private bool IsValidUser(string username, string password)
        {
            // Remplacez cette logique par votre méthode d'authentification réelle
            return username == "b" && password == "b"; // Exemples pour tests
        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label(); // Étiquette pour le nom d'utilisateur
            this.lblPassword = new System.Windows.Forms.Label(); // Étiquette pour le mot de passe
            this.lblInstructions = new System.Windows.Forms.Label(); // Étiquette pour les instructions
            this.SuspendLayout();

            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(50, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(200, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Veuillez entrer vos identifiants :";
            this.lblInstructions.Font = new System.Drawing.Font("Arial", 10);

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nom d'utilisateur :";
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10);

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 22);
            this.txtUsername.TabIndex = 2;

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mot de passe :";
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10);

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true; // Masquer le mot de passe

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Se Connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Déclaration des contrôles
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;  
        private System.Windows.Forms.Label lblPassword;  
        private System.Windows.Forms.Label lblInstructions;  
    }
}
