using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjABI
{
    /// <summary>
    /// Formulaire qui affiche la fiche du client
    /// </summary>
    public partial class frmDspCli : ProjABI.frmClient
    {
        /// <summary>
        /// la référence du client à modifier
        /// </summary>
        protected MClient leClient;
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="UnClient"></param>
        public frmDspCli(MClient UnClient)
        {
            //créer une référence d'objet client
            //pointant vers le client reçu en paramètre
            this.leClient = UnClient;
            InitializeComponent();
        }
        /// <summary>
        /// ferme le formulaire en modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// affiche la fiche du contact sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {            
            frmDspCont1 frmAfCont = new frmDspCont1();
            frmAfCont.ShowDialog();
        }
        /// <summary>
        /// affiche la fiche de modification du contact sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModCont1_Click(object sender, EventArgs e)
        {
            FrmUpdCont1 frmModCont = new FrmUpdCont1();
            frmModCont.ShowDialog();
        }
        /// <summary>
        /// affiche une fiche de création d'un nouveau contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerCont1_Click(object sender, EventArgs e)
        {
            //frmNewCont frmNvCon = new frmNewCont();
            //frmNvCon.ShowDialog();
            frmNewCont1 frmNvCont = new frmNewCont1();
            frmNvCont.ShowDialog();
        }

        private void frmDspCli_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
            
        }
        /// <summary>
        /// remplissage des textbox du form 
        /// </summary>
        /// <param name="UnClient"></param>
        private void afficheClient(MClient UnClient)
        {
            this.txtIdClient.Text = UnClient.IdClient.ToString();
            this.txtRaisSoc.Text = UnClient.RaisonSociale;
            if (rbtPublic.Text==UnClient.TypeSociete.ToString())
            {
                rbtPublic.Checked = true;
            }
            else
            {
                rbtPrive.Checked = true;
            }
            this.txtActivite.Text = UnClient.Activite;
            this.txtNumActi.Text = UnClient.IdActiv.ToString();
            this.txtAdresse.Text = UnClient.Adresse;
            this.txtTelCli.Text = UnClient.TelephoneClient.ToString();
            this.txtEmailCli.Text = UnClient.EmailClient;

            if (rbtPrincipale.Text==UnClient.Nature.ToString())
            {
                rbtPrincipale.Checked = true;
            }
            else
            {
                if (rbtSecondaire.Text==UnClient.Nature.ToString())
                {
                    rbtSecondaire.Checked = true;
                }
                else
                {
                    rbtAncienne.Checked = true;
                }
            }
            this.txtChAf.Text = UnClient.ChAf.ToString();
            this.txtEffectif.Text = UnClient.Effectif.ToString();
            this.rtbxCommentaires.Text = UnClient.CommentComm;
        }
        /// <summary>
        /// supprime la fiche du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupCli1_Click(object sender, EventArgs e)
        {
            Client leClientEF = Donnees.DbClient.Client.Find(leClient.IdClient);
                       
            //ouverture d'une boîte de dialogue pour demander une confirmation de la suppression
            DialogResult r;
            r = MessageBox.Show("Voulez-vous supprimer ce client?", "SUPPRESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (r == DialogResult.Yes)
            {
                //supprimer de la collection EF
                Donnees.DbClient.Client.Remove(leClientEF);
                //impacter en BDD
                Donnees.DbClient.SaveChanges();
               
                DialogResult = DialogResult.OK;                
            }
        }
        /// <summary>
        /// supprime le contact sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupCont1_Click(object sender, EventArgs e)
        {

        }
    }
}
