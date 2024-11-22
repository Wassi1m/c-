using System.Text.RegularExpressions;

namespace MonProjetWinForms
{
    public class Person
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Num { get; set; } = string.Empty;
        public int Age { get; set; }

        // Méthode pour valider que les noms et prénoms ne contiennent que des lettres
        public static bool ValidateName(string name)
        {
            // Vérifie que le champ ne contient que des lettres
            return Regex.IsMatch(name, @"^[a-zA-ZÀ-ÿ]+$"); // Inclut les lettres accentuées
        }

        // Méthode pour valider que le numéro de téléphone ne contient que des chiffres
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Vérifie que le numéro ne contient que des chiffres
            return Regex.IsMatch(phoneNumber, @"^\d+$");
        }

        // Méthode pour valider que l'âge est un entier positif
        public static bool ValidateAge(string age)
        {
            return int.TryParse(age, out int result) && result > 0;
        }
    }
}
