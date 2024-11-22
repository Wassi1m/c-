using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Instanciez le formulaire de connexion
                LoginForm loginForm = new LoginForm();

                // Affichez le formulaire de connexion
                Application.Run(loginForm);

                // Si l'utilisateur est connecté, démarrez la fenêtre principale
                if (!string.IsNullOrEmpty(loginForm.Username) && !string.IsNullOrEmpty(loginForm.Password))
                {
                    Application.Run(new Form1()); // Charge le formulaire principal
                }
            }

    }
}
