namespace ProjABI
{
    partial class frmDspDoc
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
            this.SuspendLayout();
            // 
            // rtxtResume
            // 
            this.rtxtResume.Size = new System.Drawing.Size(920, 431);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmDspDoc
            // 
            this.AcceptButton = this.btnQuitter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(946, 856);
            this.Name = "frmDspDoc";
            this.ShowInTaskbar = false;
            this.Text = "Fiche document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
