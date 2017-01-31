namespace cSharpMeteo
{
    partial class FrmMeteo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocalite = new System.Windows.Forms.Label();
            this.cbxLocalite = new System.Windows.Forms.ComboBox();
            this.cbxJours = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblJours = new System.Windows.Forms.Label();
            this.lblAjout = new System.Windows.Forms.Label();
            this.tbxAjout = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalite
            // 
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Location = new System.Drawing.Point(34, 126);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(44, 13);
            this.lblLocalite.TabIndex = 0;
            this.lblLocalite.Text = "Localité";
            // 
            // cbxLocalite
            // 
            this.cbxLocalite.FormattingEnabled = true;
            this.cbxLocalite.Location = new System.Drawing.Point(155, 118);
            this.cbxLocalite.Name = "cbxLocalite";
            this.cbxLocalite.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalite.TabIndex = 1;
            // 
            // cbxJours
            // 
            this.cbxJours.FormattingEnabled = true;
            this.cbxJours.Location = new System.Drawing.Point(155, 145);
            this.cbxJours.Name = "cbxJours";
            this.cbxJours.Size = new System.Drawing.Size(121, 21);
            this.cbxJours.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(318, 143);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblJours
            // 
            this.lblJours.AutoSize = true;
            this.lblJours.Location = new System.Drawing.Point(34, 153);
            this.lblJours.Name = "lblJours";
            this.lblJours.Size = new System.Drawing.Size(84, 13);
            this.lblJours.TabIndex = 8;
            this.lblJours.Text = "Nombre de jours";
            // 
            // lblAjout
            // 
            this.lblAjout.AutoSize = true;
            this.lblAjout.Location = new System.Drawing.Point(34, 30);
            this.lblAjout.Name = "lblAjout";
            this.lblAjout.Size = new System.Drawing.Size(95, 13);
            this.lblAjout.TabIndex = 9;
            this.lblAjout.Text = "ajout d\'une localité";
            // 
            // tbxAjout
            // 
            this.tbxAjout.Location = new System.Drawing.Point(155, 30);
            this.tbxAjout.Name = "tbxAjout";
            this.tbxAjout.Size = new System.Drawing.Size(100, 20);
            this.tbxAjout.TabIndex = 10;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(318, 26);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // FrmMeteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 543);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.tbxAjout);
            this.Controls.Add(this.lblAjout);
            this.Controls.Add(this.lblJours);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxJours);
            this.Controls.Add(this.cbxLocalite);
            this.Controls.Add(this.lblLocalite);
            this.Name = "FrmMeteo";
            this.Text = "Metéo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalite;
        private System.Windows.Forms.ComboBox cbxLocalite;
        private System.Windows.Forms.ComboBox cbxJours;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblJours;
        private System.Windows.Forms.Label lblAjout;
        private System.Windows.Forms.TextBox tbxAjout;
        private System.Windows.Forms.Button btnAjout;
    }
}

