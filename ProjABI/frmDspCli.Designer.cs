namespace ProjABI
{
    partial class frmDspCli
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
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnSupCli1 = new System.Windows.Forms.Button();
            this.btnModCont1 = new System.Windows.Forms.Button();
            this.btnCreerCont1 = new System.Windows.Forms.Button();
            this.btnSupCont1 = new System.Windows.Forms.Button();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxInfClient.SuspendLayout();
            this.gbxContacts.SuspendLayout();
            this.gbxCommentaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdresse
            // 
            this.txtAdresse.Size = new System.Drawing.Size(272, 105);
            // 
            // txtRaisSoc
            // 
            this.txtRaisSoc.Size = new System.Drawing.Size(272, 67);
            // 
            // gbxContacts
            // 
            this.gbxContacts.Controls.Add(this.btnSupCont1);
            this.gbxContacts.Controls.Add(this.btnCreerCont1);
            this.gbxContacts.Controls.Add(this.btnModCont1);
            this.gbxContacts.Controls.Add(this.btnAfficher);
            this.gbxContacts.Controls.SetChildIndex(this.lstContact, 0);
            this.gbxContacts.Controls.SetChildIndex(this.btnAfficher, 0);
            this.gbxContacts.Controls.SetChildIndex(this.btnModCont1, 0);
            this.gbxContacts.Controls.SetChildIndex(this.btnCreerCont1, 0);
            this.gbxContacts.Controls.SetChildIndex(this.btnSupCont1, 0);
            // 
            // gbxCommentaires
            // 
            this.gbxCommentaires.Size = new System.Drawing.Size(912, 260);
            // 
            // rtbxCommentaires
            // 
            this.rtbxCommentaires.Size = new System.Drawing.Size(875, 216);
            // 
            // lstContact
            // 
            this.lstContact.ItemHeight = 13;
            this.lstContact.Size = new System.Drawing.Size(350, 199);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(857, 762);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(64, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(382, 24);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(64, 23);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnSupCli1
            // 
            this.btnSupCli1.Location = new System.Drawing.Point(772, 762);
            this.btnSupCli1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupCli1.Name = "btnSupCli1";
            this.btnSupCli1.Size = new System.Drawing.Size(64, 23);
            this.btnSupCli1.TabIndex = 6;
            this.btnSupCli1.Text = "Supprimer";
            this.btnSupCli1.UseVisualStyleBackColor = true;
            this.btnSupCli1.Click += new System.EventHandler(this.btnSupCli1_Click);
            // 
            // btnModCont1
            // 
            this.btnModCont1.Location = new System.Drawing.Point(382, 58);
            this.btnModCont1.Margin = new System.Windows.Forms.Padding(2);
            this.btnModCont1.Name = "btnModCont1";
            this.btnModCont1.Size = new System.Drawing.Size(64, 23);
            this.btnModCont1.TabIndex = 2;
            this.btnModCont1.Text = "Modifier";
            this.btnModCont1.UseVisualStyleBackColor = true;
            this.btnModCont1.Click += new System.EventHandler(this.btnModCont1_Click);
            // 
            // btnCreerCont1
            // 
            this.btnCreerCont1.Location = new System.Drawing.Point(382, 92);
            this.btnCreerCont1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreerCont1.Name = "btnCreerCont1";
            this.btnCreerCont1.Size = new System.Drawing.Size(64, 23);
            this.btnCreerCont1.TabIndex = 3;
            this.btnCreerCont1.Text = "Créer";
            this.btnCreerCont1.UseVisualStyleBackColor = true;
            this.btnCreerCont1.Click += new System.EventHandler(this.btnCreerCont1_Click);
            // 
            // btnSupCont1
            // 
            this.btnSupCont1.Location = new System.Drawing.Point(382, 156);
            this.btnSupCont1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupCont1.Name = "btnSupCont1";
            this.btnSupCont1.Size = new System.Drawing.Size(64, 23);
            this.btnSupCont1.TabIndex = 4;
            this.btnSupCont1.Text = "Supprimer";
            this.btnSupCont1.UseVisualStyleBackColor = true;
            this.btnSupCont1.Click += new System.EventHandler(this.btnSupCont1_Click);
            // 
            // frmDspCli
            // 
            this.AcceptButton = this.btnAfficher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(947, 849);
            this.Controls.Add(this.btnSupCli1);
            this.Controls.Add(this.btnQuitter);
            this.Name = "frmDspCli";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche client";
            this.Load += new System.EventHandler(this.frmDspCli_Load);
            this.Controls.SetChildIndex(this.gbxCoordonnees, 0);
            this.Controls.SetChildIndex(this.gbxInfClient, 0);
            this.Controls.SetChildIndex(this.gbxContacts, 0);
            this.Controls.SetChildIndex(this.gbxCommentaires, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnSupCli1, 0);
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.gbxInfClient.ResumeLayout(false);
            this.gbxInfClient.PerformLayout();
            this.gbxContacts.ResumeLayout(false);
            this.gbxCommentaires.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnSupCont1;
        private System.Windows.Forms.Button btnCreerCont1;
        private System.Windows.Forms.Button btnModCont1;
        private System.Windows.Forms.Button btnSupCli1;
    }
}
