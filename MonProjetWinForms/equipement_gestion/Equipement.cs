using System;
using System.Text.RegularExpressions;

namespace MonProjetWinForms
{
    public class Equipement
    {
        public string Nom { get; set; }
        public int Nombre { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        // Constructeur
        public Equipement(string nom, int nombre, string type, string description)
        {
            if (!ValidateNom(nom))
                throw new ArgumentException("Le nom n'est pas valide.");
            if (!ValidateNombre(nombre))
                throw new ArgumentException("Le nombre doit être positif.");
            if (!ValidateType(type))
                throw new ArgumentException("Le type n'est pas valide.");

            Nom = nom;
            Nombre = nombre;
            Type = type;
            Description = description;
        } 

        // Validation du nom (ex : le nom ne doit contenir que des lettres)
        public static bool ValidateNom(string nom)
        {
            // Allow letters, spaces, and accents
            return !string.IsNullOrWhiteSpace(nom) && Regex.IsMatch(nom, @"^[a-zA-ZÀ-ÿ\s]+$");
        }

        // Validation du nombre (doit être un entier positif)
        public static bool ValidateNombre(int nombre)
        {
            return nombre > 0;
        }

        // Validation du type (ajustable selon les types acceptés)
        public static bool ValidateType(string type)
        {
            // Add your type validation logic here (example: only specific types allowed)
            return !string.IsNullOrWhiteSpace(type);
        }

        // Redéfinition de ToString pour afficher les informations sur l'équipement
        public override string ToString()
        {
            return $"Nom: {Nom}, Nombre: {Nombre}, Type: {Type}, Description: {Description}";
        }
    }
}
