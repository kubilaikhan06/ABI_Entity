namespace ProjABI
{
    partial class frmDspCont1
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
            this.grdDoc1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitre1 = new System.Windows.Forms.TextBox();
            this.btnTousDoc1 = new System.Windows.Forms.Button();
            this.btnCherchDoc1 = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModDoc = new System.Windows.Forms.Button();
            this.btnAjouDoc = new System.Windows.Forms.Button();
            this.btnSupDoc = new System.Windows.Forms.Button();
            this.gbxCoordCont.SuspendLayout();
            this.gbxInt.SuspendLayout();
            this.gbxDocu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoc1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDocu
            // 
            this.gbxDocu.Controls.Add(this.btnCherchDoc1);
            this.gbxDocu.Controls.Add(this.btnTousDoc1);
            this.gbxDocu.Controls.Add(this.txtTitre1);
            this.gbxDocu.Controls.Add(this.label8);
            this.gbxDocu.Controls.Add(this.grdDoc1);
            // 
            // grdDoc1
            // 
            this.grdDoc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoc1.Location = new System.Drawing.Point(14, 61);
            this.grdDoc1.Name = "grdDoc1";
            this.grdDoc1.Size = new System.Drawing.Size(898, 408);
            this.grdDoc1.TabIndex = 0;
            this.grdDoc1.DoubleClick += new System.EventHandler(this.grdDoc1_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Titre:";
            // 
            // txtTitre1
            // 
            this.txtTitre1.Location = new System.Drawing.Point(49, 25);
            this.txtTitre1.Name = "txtTitre1";
            this.txtTitre1.Size = new System.Drawing.Size(680, 20);
            this.txtTitre1.TabIndex = 2;
            // 
            // btnTousDoc1
            // 
            this.btnTousDoc1.Location = new System.Drawing.Point(837, 23);
            this.btnTousDoc1.Name = "btnTousDoc1";
            this.btnTousDoc1.Size = new System.Drawing.Size(75, 23);
            this.btnTousDoc1.TabIndex = 3;
            this.btnTousDoc1.Text = "Tous";
            this.btnTousDoc1.UseVisualStyleBackColor = true;
            // 
            // btnCherchDoc1
            // 
            this.btnCherchDoc1.Location = new System.Drawing.Point(747, 23);
            this.btnCherchDoc1.Name = "btnCherchDoc1";
            this.btnCherchDoc1.Size = new System.Drawing.Size(75, 23);
            this.btnCherchDoc1.TabIndex = 4;
            this.btnCherchDoc1.Text = "Chercher";
            this.btnCherchDoc1.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(849, 737);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModDoc
            // 
            this.btnModDoc.Location = new System.Drawing.Point(768, 737);
            this.btnModDoc.Name = "btnModDoc";
            this.btnModDoc.Size = new System.Drawing.Size(75, 23);
            this.btnModDoc.TabIndex = 5;
            this.btnModDoc.Text = "Modifier";
            this.btnModDoc.UseVisualStyleBackColor = true;
            this.btnModDoc.Click += new System.EventHandler(this.btnModDoc_Click);
            // 
            // btnAjouDoc
            // 
            this.btnAjouDoc.Location = new System.Drawing.Point(687, 737);
            this.btnAjouDoc.Name = "btnAjouDoc";
            this.btnAjouDoc.Size = new System.Drawing.Size(75, 23);
            this.btnAjouDoc.TabIndex = 6;
            this.btnAjouDoc.Text = "Ajouter";
            this.btnAjouDoc.UseVisualStyleBackColor = true;
            this.btnAjouDoc.Click += new System.EventHandler(this.btnAjouDoc_Click);
            // 
            // btnSupDoc
            // 
            this.btnSupDoc.Location = new System.Drawing.Point(570, 737);
            this.btnSupDoc.Name = "btnSupDoc";
            this.btnSupDoc.Size = new System.Drawing.Size(75, 23);
            this.btnSupDoc.TabIndex = 7;
            this.btnSupDoc.Text = "Supprimer";
            this.btnSupDoc.UseVisualStyleBackColor = true;
            // 
            // frmDspCont1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(946, 856);
            this.Controls.Add(this.btnSupDoc);
            this.Controls.Add(this.btnAjouDoc);
            this.Controls.Add(this.btnModDoc);
            this.Controls.Add(this.btnQuitter);
            this.Name = "frmDspCont1";
            this.Text = "Fiche contact";
            this.Controls.SetChildIndex(this.gbxCoordCont, 0);
            this.Controls.SetChildIndex(this.gbxInt, 0);
            this.Controls.SetChildIndex(this.gbxDocu, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.Controls.SetChildIndex(this.btnModDoc, 0);
            this.Controls.SetChildIndex(this.btnAjouDoc, 0);
            this.Controls.SetChildIndex(this.btnSupDoc, 0);
            this.gbxCoordCont.ResumeLayout(false);
            this.gbxCoordCont.PerformLayout();
            this.gbxInt.ResumeLayout(false);
            this.gbxInt.PerformLayout();
            this.gbxDocu.ResumeLayout(false);
            this.gbxDocu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDoc1;
        private System.Windows.Forms.Button btnCherchDoc1;
        private System.Windows.Forms.Button btnTousDoc1;
        private System.Windows.Forms.TextBox txtTitre1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModDoc;
        private System.Windows.Forms.Button btnAjouDoc;
        private System.Windows.Forms.Button btnSupDoc;
    }
}
