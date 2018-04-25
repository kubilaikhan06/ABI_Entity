namespace ProjABI
{
    partial class frmUpdCli
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupCont2 = new System.Windows.Forms.Button();
            this.lblErreur2 = new System.Windows.Forms.Label();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxInfClient.SuspendLayout();
            this.gbxContacts.SuspendLayout();
            this.gbxCommentaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresse.Size = new System.Drawing.Size(361, 128);
            this.txtAdresse.Click += new System.EventHandler(this.txtAdresse_Click_1);
            // 
            // txtNumActi
            // 
            this.txtNumActi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumActi.Click += new System.EventHandler(this.txtNumActi_Click_1);
            // 
            // txtActivite
            // 
            this.txtActivite.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivite.Click += new System.EventHandler(this.txtActivite_Click_1);
            // 
            // txtRaisSoc
            // 
            this.txtRaisSoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaisSoc.Size = new System.Drawing.Size(361, 82);
            this.txtRaisSoc.Click += new System.EventHandler(this.txtRaisSoc_Click_1);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdClient.Click += new System.EventHandler(this.txtIdClient_Click_1);
            // 
            // txtTelCli
            // 
            this.txtTelCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelCli.Click += new System.EventHandler(this.txtTelCli_Click_1);
            // 
            // gbxInfClient
            // 
            this.gbxInfClient.Controls.Add(this.lblErreur2);
            this.gbxInfClient.Controls.SetChildIndex(this.label9, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.label10, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.label11, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.txtChAf, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.txtEffectif, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtPrincipale, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtSecondaire, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.rbtAncienne, 0);
            this.gbxInfClient.Controls.SetChildIndex(this.lblErreur2, 0);
            // 
            // txtEffectif
            // 
            this.txtEffectif.Margin = new System.Windows.Forms.Padding(4);
            this.txtEffectif.Click += new System.EventHandler(this.txtEffectif_Click_1);
            // 
            // txtChAf
            // 
            this.txtChAf.Margin = new System.Windows.Forms.Padding(4);
            this.txtChAf.Click += new System.EventHandler(this.txtChAf_Click_1);
            // 
            // gbxContacts
            // 
            this.gbxContacts.Controls.Add(this.btnSupCont2);
            this.gbxContacts.Controls.SetChildIndex(this.lstContact, 0);
            this.gbxContacts.Controls.SetChildIndex(this.btnSupCont2, 0);
            // 
            // gbxCommentaires
            // 
            this.gbxCommentaires.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCommentaires.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCommentaires.Size = new System.Drawing.Size(1216, 320);
            // 
            // rtbxCommentaires
            // 
            this.rtbxCommentaires.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxCommentaires.Size = new System.Drawing.Size(1172, 265);
            // 
            // lstContact
            // 
            this.lstContact.Margin = new System.Windows.Forms.Padding(4);
            this.lstContact.Size = new System.Drawing.Size(465, 244);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(1143, 924);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(85, 28);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(1035, 924);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(85, 28);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSupCont2
            // 
            this.btnSupCont2.Location = new System.Drawing.Point(507, 30);
            this.btnSupCont2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupCont2.Name = "btnSupCont2";
            this.btnSupCont2.Size = new System.Drawing.Size(85, 28);
            this.btnSupCont2.TabIndex = 1;
            this.btnSupCont2.Text = "Supprimer";
            this.btnSupCont2.UseVisualStyleBackColor = true;
            // 
            // lblErreur2
            // 
            this.lblErreur2.AutoSize = true;
            this.lblErreur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur2.ForeColor = System.Drawing.Color.Red;
            this.lblErreur2.Location = new System.Drawing.Point(53, 124);
            this.lblErreur2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur2.Name = "lblErreur2";
            this.lblErreur2.Size = new System.Drawing.Size(417, 20);
            this.lblErreur2.TabIndex = 8;
            this.lblErreur2.Text = "Le rapport Chiffre d\'affaire/Effectif n\'est pas cohérent.\"";
            // 
            // frmUpdCli
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(1263, 1045);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnQuitter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdCli";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier client";
            this.Load += new System.EventHandler(this.frmUpdCli_Load);
            this.Controls.SetChildIndex(this.gbxCoordonnees, 0);
            this.Controls.SetChildIndex(this.gbxInfClient, 0);
            this.Controls.SetChildIndex(this.gbxContacts, 0);
            this.Controls.SetChildIndex(this.gbxCommentaires, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnValider, 0);
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSupCont2;
        private System.Windows.Forms.Label lblErreur2;
    }
}
