using System;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    partial class ChambreForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private TextBox txtCapacite;
        private TextBox txtTypeChambre;
        private TextBox txtDescription;
        private CheckBox chkDisponible;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNumero;
        private Label lblCapacite;
        private Label lblTypeChambre;
        private Label lblDescription;
        private Label lblDisponible;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.txtTypeChambre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCapacite = new System.Windows.Forms.Label();
            this.lblTypeChambre = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();

            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numéro:";

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(120, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 1;

            // 
            // lblCapacite
            // 
            this.lblCapacite.AutoSize = true;
            this.lblCapacite.Location = new System.Drawing.Point(30, 70);
            this.lblCapacite.Name = "lblCapacite";
            this.lblCapacite.Size = new System.Drawing.Size(53, 13);
            this.lblCapacite.TabIndex = 2;
            this.lblCapacite.Text = "Capacité:";

            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(120, 70);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(150, 20);
            this.txtCapacite.TabIndex = 3;

            // 
            // lblTypeChambre
            // 
            this.lblTypeChambre.AutoSize = true;
            this.lblTypeChambre.Location = new System.Drawing.Point(30, 110);
            this.lblTypeChambre.Name = "lblTypeChambre";
            this.lblTypeChambre.Size = new System.Drawing.Size(34, 13);
            this.lblTypeChambre.TabIndex = 4;
            this.lblTypeChambre.Text = "Type:";

            // 
            // txtTypeChambre
            // 
            this.txtTypeChambre.Location = new System.Drawing.Point(120, 110);
            this.txtTypeChambre.Name = "txtTypeChambre";
            this.txtTypeChambre.Size = new System.Drawing.Size(150, 20);
            this.txtTypeChambre.TabIndex = 5;

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 150);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 7;

            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(30, 190);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(62, 13);
            this.lblDisponible.TabIndex = 8;
            this.lblDisponible.Text = "Disponible:";

            // 
            // chkDisponible
            // 
            this.chkDisponible.Location = new System.Drawing.Point(120, 190);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(15, 14);
            this.chkDisponible.TabIndex = 9;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // ChambreForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.txtTypeChambre);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCapacite);
            this.Controls.Add(this.lblTypeChambre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDisponible);
            this.Name = "ChambreForm";
            this.Text = "Ajouter/Modifier une chambre";
        }
    }
}
