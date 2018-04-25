namespace ProjABI
{
    partial class FrmUpdCont1
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
            this.btnValidCont = new System.Windows.Forms.Button();
            this.gbxCoordCont.SuspendLayout();
            this.gbxInt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(858, 741);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnValidCont
            // 
            this.btnValidCont.Location = new System.Drawing.Point(767, 741);
            this.btnValidCont.Name = "btnValidCont";
            this.btnValidCont.Size = new System.Drawing.Size(75, 23);
            this.btnValidCont.TabIndex = 5;
            this.btnValidCont.Text = "&Valider";
            this.btnValidCont.UseVisualStyleBackColor = true;
            // 
            // FrmUpdCont1
            // 
            this.AcceptButton = this.btnValidCont;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(946, 856);
            this.Controls.Add(this.btnValidCont);
            this.Controls.Add(this.btnQuitter);
            this.Name = "FrmUpdCont1";
            this.Text = "Modifier contact";
            this.Load += new System.EventHandler(this.FrmUpdCont1_Load);
            this.Controls.SetChildIndex(this.gbxCoordCont, 0);
            this.Controls.SetChildIndex(this.gbxInt, 0);
            this.Controls.SetChildIndex(this.gbxDocu, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnValidCont, 0);
            this.gbxCoordCont.ResumeLayout(false);
            this.gbxCoordCont.PerformLayout();
            this.gbxInt.ResumeLayout(false);
            this.gbxInt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValidCont;
    }
}
