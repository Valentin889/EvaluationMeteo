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
            this.SuspendLayout();
            // 
            // lblLocalite
            // 
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Location = new System.Drawing.Point(34, 43);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(44, 13);
            this.lblLocalite.TabIndex = 0;
            this.lblLocalite.Text = "Localité";
            // 
            // cbxLocalite
            // 
            this.cbxLocalite.FormattingEnabled = true;
            this.cbxLocalite.Location = new System.Drawing.Point(124, 43);
            this.cbxLocalite.Name = "cbxLocalite";
            this.cbxLocalite.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalite.TabIndex = 1;
            // 
            // cbxJours
            // 
            this.cbxJours.FormattingEnabled = true;
            this.cbxJours.Location = new System.Drawing.Point(124, 95);
            this.cbxJours.Name = "cbxJours";
            this.cbxJours.Size = new System.Drawing.Size(121, 21);
            this.cbxJours.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(286, 64);
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
            this.lblJours.Location = new System.Drawing.Point(34, 103);
            this.lblJours.Name = "lblJours";
            this.lblJours.Size = new System.Drawing.Size(84, 13);
            this.lblJours.TabIndex = 8;
            this.lblJours.Text = "Nombre de jours";
            // 
            // FrmMeteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 605);
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
    }
}

