namespace ProjABI
{
    partial class frmNewCli
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxInfClient.SuspendLayout();
            this.gbxContacts.SuspendLayout();
            this.gbxCommentaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtAdresse.Size = new System.Drawing.Size(272, 105);
            this.txtAdresse.Click += new System.EventHandler(this.txtAdresse_Click);
            // 
            // txtNumActi
            // 
            this.txtNumActi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtNumActi.Click += new System.EventHandler(this.txtNumActi_Click);
            // 
            // txtActivite
            // 
            this.txtActivite.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtActivite.Click += new System.EventHandler(this.txtActivite_Click);
            // 
            // txtRaisSoc
            // 
            this.txtRaisSoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtRaisSoc.Size = new System.Drawing.Size(272, 67);
            this.txtRaisSoc.Click += new System.EventHandler(this.txtRaisSoc_Click);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtIdClient.Click += new System.EventHandler(this.txtIdClient_Click);
            // 
            // txtTelCli
            // 
            this.txtTelCli.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtTelCli.Click += new System.EventHandler(this.txtTelCli_Click);
            // 
            // gbxInfClient
            // 
            this.gbxInfClient.Controls.Add(this.lblErreur);
            this.gbxInfClient.Controls.SetChildIndex(this.label9, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.label10, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.label11, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.txtChAf, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.txtEffectif, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtPrincipale, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtSecondaire, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtAncienne, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.lblErreur, 0);
            // 
            // txtEffectif
            // 
            this.txtEffectif.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtEffectif.Click += new System.EventHandler(this.txtEffectif_Click);
            this.txtEffectif.DoubleClick += new System.EventHandler(this.txtEffectif_DoubleClick);
            // 
            // txtChAf
            // 
            this.txtChAf.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtChAf.Click += new System.EventHandler(this.txtChAf_Click);
            this.txtChAf.TextChanged += new System.EventHandler(this.txtChAf_TextChanged);
            this.txtChAf.DoubleClick += new System.EventHandler(this.txtChAf_DoubleClick);
            // 
            // gbxCommentaires
            // 
            this.gbxCommentaires.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.gbxCommentaires.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.gbxCommentaires.Size = new System.Drawing.Size(912, 260);
            this.gbxCommentaires.Enter += new System.EventHandler(this.gbxCommentaires_Enter);
            // 
            // rtbxCommentaires
            // 
            this.rtbxCommentaires.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.rtbxCommentaires.Size = new System.Drawing.Size(785, 216);
            // 
            // lstContact
            // 
            this.lstContact.ItemHeight = 13;
            this.lstContact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lstContact.Size = new System.Drawing.Size(350, 199);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(857, 752);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(64, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(774, 752);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(64, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(54, 100);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(318, 16);
            this.lblErreur.TabIndex = 8;
            this.lblErreur.Text = "Le rapport Chiffre d\'affaire/Effectif n\'est pas cohérent.";
            // 
            // frmNewCli
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(947, 849);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuitter);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmNewCli";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau client";
            this.Load += new System.EventHandler(this.frmNewCli_Load);
            this.Controls.SetChildIndex(this.gbxCoordonnees, 0);
            this.Controls.SetChildIndex(this.gbxInfClient, 0);
            this.Controls.SetChildIndex(this.gbxContacts, 0);
            this.Controls.SetChildIndex(this.gbxCommentaires, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
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
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblErreur;
    }
}
