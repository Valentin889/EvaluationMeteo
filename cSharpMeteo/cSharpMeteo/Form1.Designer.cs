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
            this.cbxLocalite.Location = new System.Drawing.Point(101, 43);
            this.cbxLocalite.Name = "cbxLocalite";
            this.cbxLocalite.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalite.TabIndex = 1;
            this.cbxLocalite.SelectedIndexChanged += new System.EventHandler(this.cbxLocalite_SelectedIndexChanged);
            // 
            // FrmMeteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 348);
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
    }
}

