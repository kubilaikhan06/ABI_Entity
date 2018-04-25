namespace ProjABI
{
    partial class frmNewDoc
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
            this.btnAjoutDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjoutDoc
            // 
            this.btnAjoutDoc.Location = new System.Drawing.Point(1056, 926);
            this.btnAjoutDoc.Name = "btnAjoutDoc";
            this.btnAjoutDoc.Size = new System.Drawing.Size(85, 28);
            this.btnAjoutDoc.TabIndex = 12;
            this.btnAjoutDoc.Text = "Ajouter";
            this.btnAjoutDoc.UseVisualStyleBackColor = true;
            // 
            // frmNewDoc
            // 
            this.AcceptButton = this.btnAjoutDoc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(1262, 1053);
            this.Controls.Add(this.btnAjoutDoc);
            this.Name = "frmNewDoc";
            this.ShowInTaskbar = false;
            this.Text = "Nouveau document";
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
            this.Controls.SetChildIndex(this.btnAjoutDoc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutDoc;
    }
}
