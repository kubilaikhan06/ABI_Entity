namespace ProjABI
{
    partial class frmNewCont1
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjoutCont = new System.Windows.Forms.Button();
            this.gbxCoordCont.SuspendLayout();
            this.gbxInt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(856, 743);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjoutCont
            // 
            this.btnAjoutCont.Location = new System.Drawing.Point(765, 743);
            this.btnAjoutCont.Name = "btnAjoutCont";
            this.btnAjoutCont.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutCont.TabIndex = 5;
            this.btnAjoutCont.Text = "&Ajouter";
            this.btnAjoutCont.UseVisualStyleBackColor = true;
            // 
            // frmNewCont1
            // 
            this.AcceptButton = this.btnAjoutCont;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(946, 856);
            this.Controls.Add(this.btnAjoutCont);
            this.Controls.Add(this.btnQuitter);
            this.Name = "frmNewCont1";
            this.Text = "Nouveau contact";
            this.Load += new System.EventHandler(this.frmNewCont1_Load);
            this.Controls.SetChildIndex(this.gbxCoordCont, 0);
            this.Controls.SetChildIndex(this.gbxInt, 0);
            this.Controls.SetChildIndex(this.gbxDocu, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnAjoutCont, 0);
            this.gbxCoordCont.ResumeLayout(false);
            this.gbxCoordCont.PerformLayout();
            this.gbxInt.ResumeLayout(false);
            this.gbxInt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjoutCont;
    }
}
