namespace MonProjetWinForms
{
    partial class EquipementListe
    {
        private System.Windows.Forms.ListView listViewEquipements;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        private void InitializeComponent()
        {
            this.listViewEquipements = new System.Windows.Forms.ListView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            
            // 
            // listViewEquipements
            // 
            this.listViewEquipements.FullRowSelect = true;
            this.listViewEquipements.GridLines = true;
            this.listViewEquipements.HideSelection = false;
            this.listViewEquipements.Location = new System.Drawing.Point(12, 12);
            this.listViewEquipements.Name = "listViewEquipements";
            this.listViewEquipements.Size = new System.Drawing.Size(400, 200);
            this.listViewEquipements.TabIndex = 0;
            this.listViewEquipements.UseCompatibleStateImageBehavior = false;
            this.listViewEquipements.View = System.Windows.Forms.View.Details;

            // Ajout des colonnes
            this.listViewEquipements.Columns.Add("Nom", -2, HorizontalAlignment.Left);
            this.listViewEquipements.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            this.listViewEquipements.Columns.Add("Type", -2, HorizontalAlignment.Left);
            this.listViewEquipements.Columns.Add("Description", -2, HorizontalAlignment.Left);

            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 220);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(100, 220);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

           
            // 
            // EquipementListe
            // 
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.listViewEquipements);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "EquipementListe";
            this.Text = "Liste des Équipements";
        }
    }
}
