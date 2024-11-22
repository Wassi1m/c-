namespace MonProjetWinForms
{
    partial class ChambreListe
    {
        private System.Windows.Forms.ListView listViewChambres;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        private void InitializeComponent()
        {
            this.listViewChambres = new System.Windows.Forms.ListView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            
            // 
            // listViewChambres
            // 
            this.listViewChambres.FullRowSelect = true;
            this.listViewChambres.GridLines = true;
            this.listViewChambres.HideSelection = false;
            this.listViewChambres.Location = new System.Drawing.Point(12, 12);
            this.listViewChambres.Name = "listViewChambres";
            this.listViewChambres.Size = new System.Drawing.Size(450, 200);
            this.listViewChambres.TabIndex = 0;
            this.listViewChambres.UseCompatibleStateImageBehavior = false;
            this.listViewChambres.View = System.Windows.Forms.View.Details;

            // Ajout des colonnes
            this.listViewChambres.Columns.Add("Numéro", -2, HorizontalAlignment.Left);
            this.listViewChambres.Columns.Add("Capacité", -2, HorizontalAlignment.Left);
            this.listViewChambres.Columns.Add("Type de Chambre", -2, HorizontalAlignment.Left);
            this.listViewChambres.Columns.Add("Disponible", -2, HorizontalAlignment.Left);

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
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(190, 220);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // 
            // ChambreListe
            // 
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.listViewChambres);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "ChambreListe";
            this.Text = "Liste des Chambres";
        }
    }
}
