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
    /// formulaire de création d'un nouveau client
    /// </summary>
    public partial class frmNewCli : ProjABI.frmClient
    {
        /// <summary>
        /// constructeur du form
        /// </summary>
        public frmNewCli()
        {
            InitializeComponent();
            //rendre invisibles la liste des contacts (combobox) et le message d'erreur (si rapport Chiffre d'affaire/effectif>1 000 000)
            base.gbxContacts.Visible = false;
            this.lblErreur.Visible = false;
        }
        /// <summary>
        /// fermeture de la fenêtre modale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// méthode déclenchée par le bouton Valider:
        /// instancie un objet MStagiaire et le renseigne
        /// puis le référencie dans la collection d'objets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {            
            //contrôle vraisemblance des données saisies sur le form
            if (this.Controle())
            {
                if (this.Instancie())
                {
                    MClient.nbClients += 1;
                    //-fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        /// <summary>
        /// fonction de controle de vraisemblance des différents champs du form:
        /// (appelée avant d'instancier un objet MStagiaire et d'affecter ses membres)
        /// </summary>
        /// <returns>booléen: true=OK, false= erreur</returns>
        private Boolean Controle()
        {            
            Boolean code = true;
            //contrôler la vraisemblance des entrées
            //si l'identifiant client n'est pas composé que de chiffres ou si le champ n'est pas rempli
            if (!(Outils.EstEntier(this.txtIdClient.Text))||this.txtIdClient.Text =="")
            {
                code = false;
                this.txtIdClient.ForeColor = Color.Red;
                this.txtIdClient.Text= "Veuillez n'entrer que des chiffres.";
            }
            //si l'activité n'est pas composée que de lettres
            if (!(Outils.EstUneChaine(this.txtActivite.Text)))
            {
                code = false;
                this.txtActivite.ForeColor = Color.Red;
                this.txtActivite.Text = "Veuillez n'entrer que des lettres.";
            }
            //si le numéro d'activité n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtNumActi.Text)))
            {
                code = false;
                this.txtNumActi.ForeColor = Color.Red;
                this.txtNumActi.Text = "Veuillez n'entrer que des chiffres.";
            }
            //si l'effectif n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtEffectif.Text)))
            {
                code = false;
                this.txtEffectif.ForeColor = Color.Red;
                this.txtEffectif.Text = "Veuillez n'entrer que des chiffres.";
            }
            //si le chiffre d'affaire n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtChAf.Text)))
            {
                code = false;
                this.txtChAf.ForeColor = Color.Red;
                this.txtChAf.Text = "Veuillez n'entrer que des chiffres.";
            }
            //si le champ "Raison sociale" n'est pas rempli
            if (txtRaisSoc.Text=="")
            {
                code = false;
                this.txtRaisSoc.ForeColor = Color.Red;
                this.txtRaisSoc.Text = "Veuillez entrer une raison sociale.";
            }
            //si le champ "Adress" n'est pas rempli
            if (txtAdresse.Text=="")
            {
                code = false;
                this.txtAdresse.ForeColor = Color.Red;
                this.txtAdresse.Text = "Veuillez entrer une adresse.";
            }
            //si le champ "Téléphone client" n'est pas rempli
            if (txtTelCli.Text=="")
            {
                code = false;
                this.txtTelCli.ForeColor = Color.Red;
                this.txtTelCli.Text = "Veuillez entrer un numéro de téléphone.";
            }
            //si le rapport chiffre d'affaire/effectif dépasse le million        
            if ((Outils.EstEntier(this.txtChAf.Text))&& (Outils.EstEntier(this.txtEffectif.Text))&&int.Parse(txtChAf.Text)/int.Parse(txtEffectif.Text)>1000000)
            {
                code = false;
                this.lblErreur.Visible = true;
            }           

            return code;
        }
        /// <summary>
        /// fonction qui instancie un nouvel objet MStagiaire        
        /// </summary>
        /// <returns>booléen: true=OK, false= erreur</returns>
        private Boolean Instancie()
        {

            //créer une référence d'objet Client
            MClient nouveauClient = new MClient();
            try
            {
                string reTyp;
                string reNat;
                if (rbtPublic.Checked == true)
                {
                    reTyp = "Public";
                }
                else
                {
                    reTyp = "Privé";
                }
                if (rbtPrincipale.Checked == true)
                {
                    reNat = "Principale";
                }
                else
                {
                    if (rbtSecondaire.Checked == true)
                    {
                        reNat = "Secondaire";
                    }
                    else
                    {
                        reNat = "Ancienne";
                    }
                }
                nouveauClient = new MClient(int.Parse(txtIdClient.Text), txtRaisSoc.Text, reTyp, txtActivite.Text, int.Parse(txtNumActi.Text), txtAdresse.Text, txtTelCli.Text, txtEmailCli.Text, reNat, decimal.Parse(txtChAf.Text), int.Parse(txtEffectif.Text), rtbxCommentaires.Text);
                //impact sur la BDD
                //-------------------------------------------------------------------------------------------------------
                //création et renseignement Entity Client
                Client nouveauClientEF = new Client();

                nouveauClientEF.IdentifiantClient = int.Parse(base.txtIdClient.Text.Trim());
                nouveauClientEF.RaisonSociale = base.txtRaisSoc.Text.ToUpper();
                nouveauClientEF.Type = reTyp;
                nouveauClientEF.Activite = base.txtActivite.Text;
                nouveauClientEF.NumeroActivite = int.Parse(base.txtNumActi.Text);
                nouveauClientEF.Adresse = base.txtAdresse.Text;
                nouveauClientEF.TelephoneClient = base.txtTelCli.Text;
                nouveauClientEF.EmailClient = base.txtEmailCli.Text;
                nouveauClientEF.Nature = reNat;
                nouveauClientEF.ChiffreAffaire = decimal.Parse(base.txtChAf.Text);
                nouveauClientEF.Effectif = int.Parse(base.txtEffectif.Text);
                nouveauClientEF.Commentaires = base.rtbxCommentaires.Text;

                ////insertion en DbContext
                Donnees.DbClient.Client.Add(nouveauClientEF);
                ////MAJ BDD
                Donnees.DbClient.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur: \n" + ex.Message, "Ajout de client");
                return false;
            }

        }

        private void txtChAf_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxCommentaires_Enter(object sender, EventArgs e)
        {

        }

        private void frmNewCli_Load(object sender, EventArgs e)
        {
            this.rbtPublic.Checked = true;
            this.rbtPrincipale.Checked = true;

            this.txtIdClient.Text = "2775";
            this.txtRaisSoc.Text = "coradin";
            rbtPrive.Checked = true;
            this.txtActivite.Text = "alimentaire";
            this.txtNumActi.Text = "22";
            this.txtAdresse.Text = "25 avenue de la rue 06 600 Antibes";
            this.txtTelCli.Text = "0494939291";
            this.txtEmailCli.Text = "coradin@coradin.com";
            this.rtbxCommentaires.Text = "à remplir";
            rbtSecondaire.Checked = true;
            this.txtChAf.Text = "750000";
            this.txtEffectif.Text = "24";
        }

        private void txtIdClient_Click(object sender, EventArgs e)
        {
            base.txtIdClient.Text = "";
            base.txtIdClient.ForeColor = Color.Black;
        }

        private void txtActivite_Click(object sender, EventArgs e)
        {
            base.txtActivite.Text = "";
            base.txtActivite.ForeColor = Color.Black;
        }

        private void txtNumActi_Click(object sender, EventArgs e)
        {
            base.txtNumActi.Text = "";
            base.txtNumActi.ForeColor = Color.Black;
        }

        private void txtEffectif_Click(object sender, EventArgs e)
        {
            base.txtEffectif.ForeColor = Color.Black;
            this.lblErreur.Visible = false;
        }

        private void txtChAf_Click(object sender, EventArgs e)
        {
            base.txtEffectif.ForeColor = Color.Black;
            this.lblErreur.Visible = false;
        }

        private void txtRaisSoc_Click(object sender, EventArgs e)
        {
            base.txtRaisSoc.Text = "";
            base.txtRaisSoc.ForeColor = Color.Black;
        }

        private void txtAdresse_Click(object sender, EventArgs e)
        {
            base.txtAdresse.Text = "";
            base.txtAdresse.ForeColor = Color.Black;
        }

        private void txtTelCli_Click(object sender, EventArgs e)
        {
            base.txtTelCli.Text = "";
            base.txtTelCli.ForeColor = Color.Black;
        }

        private void txtChAf_DoubleClick(object sender, EventArgs e)
        {
            base.txtChAf.Text = "";
            base.txtChAf.ForeColor = Color.Black;
            this.lblErreur.Visible = false;
        }

        private void txtEffectif_DoubleClick(object sender, EventArgs e)
        {
            base.txtEffectif.Text = "";
            base.txtEffectif.ForeColor = Color.Black;
            this.lblErreur.Visible = false;
        }
    }
}
