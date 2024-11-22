using System;
using System.Text.RegularExpressions;

namespace MonProjetWinForms
{
    public class Chambre
    {
        public int Numero { get; set; }
        public int Capacite { get; set; }
        public string TypeChambre { get; set; }
        public string Description { get; set; }
        public bool Disponible { get; set; }

        // Constructeur
        public Chambre(int numero, int capacite, string typeChambre, string description, bool disponible)
        {
            if (!ValidateNumero(numero))
                throw new ArgumentException("Le numéro de la chambre doit être positif.");
            if (!ValidateCapacite(capacite))
                throw new ArgumentException("La capacité doit être un entier positif.");
            if (!ValidateTypeChambre(typeChambre))
                throw new ArgumentException("Le type de chambre n'est pas valide.");

            Numero = numero;
            Capacite = capacite;
            TypeChambre = typeChambre;
            Description = description;
            Disponible = disponible;
        }

        // Validation du numéro de la chambre (doit être un entier positif)
        public static bool ValidateNumero(int numero)
        {
            return numero > 0;
        }

        // Validation de la capacité de la chambre (doit être un entier positif)
        public static bool ValidateCapacite(int capacite)
        {
            return capacite > 0;
        }

        // Validation du type de chambre (exemples : "Simple", "Double", "Suite", etc.)
        public static bool ValidateTypeChambre(string typeChambre)
        {
            // Add specific allowed types if needed (e.g., Simple, Double, Suite, etc.)
            return !string.IsNullOrWhiteSpace(typeChambre);
        }

        // Redéfinition de ToString pour afficher les informations sur la chambre
        public override string ToString()
        {
            string disponibilite = Disponible ? "Disponible" : "Non disponible";
            return $"Numéro: {Numero}, Capacité: {Capacite}, Type: {TypeChambre}, Description: {Description}, Disponibilité: {disponibilite}";
        }
    }
}
