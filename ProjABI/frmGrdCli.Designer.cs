namespace ProjABI
{
    partial class frmGrdCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrdCli));
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRechEntr = new System.Windows.Forms.TextBox();
            this.btnRechEnt = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNbEntr = new System.Windows.Forms.Button();
            this.txtRechTyp = new System.Windows.Forms.TextBox();
            this.lblTypEntr = new System.Windows.Forms.Label();
            this.btnRechTyp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.AllowUserToOrderColumns = true;
            this.grdClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Location = new System.Drawing.Point(21, 107);
            this.grdClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.RowTemplate.Height = 24;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(924, 521);
            this.grdClient.TabIndex = 0;
            this.grdClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClient_CellContentClick);
            this.grdClient.Click += new System.EventHandler(this.grdClient_Click);
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom entreprise:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fenêtreToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // txtRechEntr
            // 
            this.txtRechEntr.Location = new System.Drawing.Point(112, 47);
            this.txtRechEntr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRechEntr.Name = "txtRechEntr";
            this.txtRechEntr.Size = new System.Drawing.Size(610, 20);
            this.txtRechEntr.TabIndex = 3;
            this.txtRechEntr.Click += new System.EventHandler(this.txtRechEntr_Click);
            // 
            // btnRechEnt
            // 
            this.btnRechEnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechEnt.Location = new System.Drawing.Point(752, 43);
            this.btnRechEnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechEnt.Name = "btnRechEnt";
            this.btnRechEnt.Size = new System.Drawing.Size(84, 27);
            this.btnRechEnt.TabIndex = 4;
            this.btnRechEnt.Text = "Rechercher";
            this.btnRechEnt.UseVisualStyleBackColor = true;
            this.btnRechEnt.Click += new System.EventHandler(this.btnRechEnt_Click);
            // 
            // btnTous
            // 
            this.btnTous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTous.Location = new System.Drawing.Point(860, 43);
            this.btnTous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(84, 27);
            this.btnTous.TabIndex = 5;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(880, 641);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(64, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(812, 641);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(64, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Location = new System.Drawing.Point(744, 641);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(64, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Location = new System.Drawing.Point(632, 641);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(64, 23);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNbEntr
            // 
            this.btnNbEntr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNbEntr.Location = new System.Drawing.Point(21, 644);
            this.btnNbEntr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNbEntr.Name = "btnNbEntr";
            this.btnNbEntr.Size = new System.Drawing.Size(136, 19);
            this.btnNbEntr.TabIndex = 12;
            this.btnNbEntr.Text = "Nombre d\'entreprises";
            this.btnNbEntr.UseVisualStyleBackColor = true;
            this.btnNbEntr.Click += new System.EventHandler(this.btnNbEntr_Click);
            // 
            // txtRechTyp
            // 
            this.txtRechTyp.Location = new System.Drawing.Point(112, 78);
            this.txtRechTyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRechTyp.Name = "txtRechTyp";
            this.txtRechTyp.Size = new System.Drawing.Size(203, 20);
            this.txtRechTyp.TabIndex = 13;
            this.txtRechTyp.Visible = false;
            this.txtRechTyp.Click += new System.EventHandler(this.txtRechTyp_Click);
            // 
            // lblTypEntr
            // 
            this.lblTypEntr.AutoSize = true;
            this.lblTypEntr.Location = new System.Drawing.Point(19, 80);
            this.lblTypEntr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypEntr.Name = "lblTypEntr";
            this.lblTypEntr.Size = new System.Drawing.Size(83, 13);
            this.lblTypEntr.TabIndex = 14;
            this.lblTypEntr.Text = "Type entreprise:";
            this.lblTypEntr.Visible = false;
            // 
            // btnRechTyp
            // 
            this.btnRechTyp.Location = new System.Drawing.Point(752, 74);
            this.btnRechTyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechTyp.Name = "btnRechTyp";
            this.btnRechTyp.Size = new System.Drawing.Size(84, 27);
            this.btnRechTyp.TabIndex = 15;
            this.btnRechTyp.Text = "Rechercher";
            this.btnRechTyp.UseVisualStyleBackColor = true;
            this.btnRechTyp.Visible = false;
            this.btnRechTyp.Click += new System.EventHandler(this.btnRechTyp_Click);
            // 
            // frmGrdCli
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(986, 680);
            this.Controls.Add(this.btnRechTyp);
            this.Controls.Add(this.lblTypEntr);
            this.Controls.Add(this.txtRechTyp);
            this.Controls.Add(this.btnNbEntr);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechEnt);
            this.Controls.Add(this.txtRechEntr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdClient);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGrdCli";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.frmGrdCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRechEntr;
        private System.Windows.Forms.Button btnRechEnt;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNbEntr;
        private System.Windows.Forms.TextBox txtRechTyp;
        private System.Windows.Forms.Label lblTypEntr;
        private System.Windows.Forms.Button btnRechTyp;
    }
}