namespace MonProjetWinForms;

partial class UserForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.TextBox txtPrenom;
    private System.Windows.Forms.TextBox txtNum;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

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
        this.txtNom = new System.Windows.Forms.TextBox();
        this.txtPrenom = new System.Windows.Forms.TextBox();
        this.txtNum = new System.Windows.Forms.TextBox();
        this.txtAge = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();

        this.SuspendLayout();

        // 
        // txtNom
        // 
        this.txtNom.Location = new System.Drawing.Point(100, 30);
        this.txtNom.Name = "txtNom";
        this.txtNom.Size = new System.Drawing.Size(200, 22);
        this.txtNom.TabIndex = 0;
        this.txtNom.PlaceholderText = "Nom";

        // 
        // txtPrenom
        // 
        this.txtPrenom.Location = new System.Drawing.Point(100, 70);
        this.txtPrenom.Name = "txtPrenom";
        this.txtPrenom.Size = new System.Drawing.Size(200, 22);
        this.txtPrenom.TabIndex = 1;
        this.txtPrenom.PlaceholderText = "Prénom";

        // 
        // txtNum
        // 
        this.txtNum.Location = new System.Drawing.Point(100, 110);
        this.txtNum.Name = "txtNum";
        this.txtNum.Size = new System.Drawing.Size(200, 22);
        this.txtNum.TabIndex = 2;
        this.txtNum.PlaceholderText = "Numéro de téléphone";

        // 
        // txtAge
        // 
        this.txtAge.Location = new System.Drawing.Point(100, 150);
        this.txtAge.Name = "txtAge";
        this.txtAge.Size = new System.Drawing.Size(200, 22);
        this.txtAge.TabIndex = 3;
        this.txtAge.PlaceholderText = "Âge";

        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(100, 200);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 4;
        this.btnSave.Text = "Enregistrer";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

        // 
        // btnCancel
        // 
        this.btnCancel.Location = new System.Drawing.Point(225, 200);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 5;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        // 
        // UserForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 250);
        this.Controls.Add(this.txtNom);
        this.Controls.Add(this.txtPrenom);
        this.Controls.Add(this.txtNum);
        this.Controls.Add(this.txtAge);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnCancel);
        this.Name = "UserForm";
        this.Text = "Créer un Utilisateur";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
