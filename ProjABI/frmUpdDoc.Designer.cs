namespace ProjABI
{
    partial class frmUpdDoc
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
            this.btnValidDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValidDoc
            // 
            this.btnValidDoc.Location = new System.Drawing.Point(1049, 926);
            this.btnValidDoc.Name = "btnValidDoc";
            this.btnValidDoc.Size = new System.Drawing.Size(85, 28);
            this.btnValidDoc.TabIndex = 12;
            this.btnValidDoc.Text = "Valider";
            this.btnValidDoc.UseVisualStyleBackColor = true;
            // 
            // frmUpdDoc
            // 
            this.AcceptButton = this.btnValidDoc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(1262, 1053);
            this.Controls.Add(this.btnValidDoc);
            this.Name = "frmUpdDoc";
            this.ShowInTaskbar = false;
            this.Text = "Modifier document";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtIdDoc, 0);
            this.Controls.SetChildIndex(this.txtTitre, 0);
            this.Controls.SetChildIndex(this.txtAuteur, 0);
            this.Controls.SetChildIndex(this.txtDateDiff, 0);
            this.Controls.SetChildIndex(this.rtxtResume, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnValidDoc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidDoc;
    }
}
