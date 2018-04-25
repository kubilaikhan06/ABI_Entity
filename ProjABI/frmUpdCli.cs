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
    /// Formulaire de modification d'un client
    /// </summary>
    public partial class frmUpdCli : ProjABI.frmClient
    {
        /// <summary>
        /// la référence du client à modifier
        /// </summary>
        protected MClient leclientM;
        protected Client nouveauClientEF;
        /// <summary>
        /// constructeur adapté: mémorise le client à traiter
        /// </summary>
        /// <param name="UnClientM">la référence de l'objet MClient à gérer dans ce form</param>
        public frmUpdCli(MClient UnClientM,Client c)
        {
            //créer une référence d'objet client
            //pointant vers le client reçu en paramètre
            this.leclientM = UnClientM;
            InitializeComponent();
            this.lblErreur2.Visible = false;
            nouveauClientEF = c;
        }
        /// <summary>
        /// ferme le formulaire modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// affiche les coordonnées et renseignements du client à modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUpdCli_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leclientM);
        }
        /// <summary>
        /// remplissage des textbox du form
        /// </summary>
        /// <param name="UnClientM"></param>
        private void afficheClient(MClient UnClientM)
        {
            this.txtIdClient.Text = leclientM.IdClient.ToString();
            this.txtRaisSoc.Text = leclientM.RaisonSociale;
            if (rbtPublic.Text == leclientM.TypeSociete.ToString())
            {
                rbtPublic.Checked = true;
            }
            else
            {
                rbtPrive.Checked = true;
            }
            this.txtActivite.Text = leclientM.Activite;
            this.txtNumActi.Text = leclientM.IdActiv.ToString();
            this.txtAdresse.Text = leclientM.Adresse;
            this.txtTelCli.Text = leclientM.TelephoneClient.ToString();
            this.txtEmailCli.Text = leclientM.EmailClient;

            if (rbtPrincipale.Text == leclientM.Nature.ToString())
            {
                rbtPrincipale.Checked = true;
            }
            else
            {
                if (rbtSecondaire.Text == leclientM.Nature.ToString())
                {
                    rbtSecondaire.Checked = true;
                }
                else
                {
                    rbtAncienne.Checked = true;
                }
            }
            this.txtChAf.Text = leclientM.ChAf.ToString();
            this.txtEffectif.Text = leclientM.Effectif.ToString();
            this.rtbxCommentaires.Text = leclientM.CommentComm;
        }
        /// <summary>
        /// valide la modification du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            //contrôle vraisemblance des données saisies sur le form
            if (this.Controle())
            {
                if (this.Instancie())
                {
                    //cas général: si l'instanciation client et
                    //son ajout à la collection est ok:
                    //-incrémentation du compteur de clients
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
            if (!(Outils.EstEntier(this.txtIdClient.Text)) || this.txtIdClient.Text == "")
            {
                code = false;
                this.txtIdClient.ForeColor = Color.Red;
                this.txtIdClient.Text = "La saisie n'est pas correcte, veuillez n'entrer que des chiffres.";
            }
            //si l'activité n'est pas composée que de lettres
            if (!(Outils.EstUneChaine(this.txtActivite.Text)))
            {
                code = false;
                this.txtActivite.ForeColor = Color.Red;
                this.txtActivite.Text = "La saisie n'est pas correcte, veuillez n'entrer que des lettres.";
            }
            //si le numéro d'activité n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtNumActi.Text)))
            {
                code = false;
                this.txtNumActi.ForeColor = Color.Red;
                this.txtNumActi.Text = "La saisie n'est pas correcte, veuillez n'entrer que des chiffres.";
            }
            //si l'effectif n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtEffectif.Text)))
            {
                code = false;
                this.txtEffectif.ForeColor = Color.Red;
                this.txtEffectif.Text = "La saisie n'est pas correcte, veuillez n'entrer que des chiffres.";
            }
            //si le chiffre d'affaire n'est pas composé que de chiffres
            if (!(Outils.EstEntier(this.txtChAf.Text)))
            {
                code = false;
                this.txtChAf.ForeColor = Color.Red;
                this.txtChAf.Text = "La saisie n'est pas correcte, veuillez n'entrer que des chiffres.";
            }
            //si le champ n'est pas rempli
            if (txtRaisSoc.Text == "")
            {
                code = false;
                this.txtRaisSoc.ForeColor = Color.Red;
                this.txtRaisSoc.Text = "Veuillez entrer une raison sociale.";
            }
            //si le champ n'est pas rempli
            if (txtAdresse.Text == "")
            {
                code = false;
                this.txtAdresse.ForeColor = Color.Red;
                this.txtAdresse.Text = "Veuillez entrer une adresse.";
            }
            //si le champ n'est pas rempli
            if (txtTelCli.Text == "")
            {
                code = false;
                this.txtTelCli.ForeColor = Color.Red;
                this.txtTelCli.Text = "Veuillez entre un numéro de téléphone.";
            }
            //si le rapport chiffre d'affaire/effectif dépasse le million
            if ((Outils.EstEntier(this.txtChAf.Text)) && (Outils.EstEntier(this.txtEffectif.Text)) && int.Parse(txtChAf.Text) / int.Parse(txtEffectif.Text) > 1000000)
            {
                code = false;
                this.lblErreur2.Visible = true;
            }

            return code;
        }

        /// <summary>
        /// fonction qui instancie un nouvel objet MStagiaire
        /// puis tente d'affecter ses membres (var. ou prop.)
        /// avec interception erreur éventuelle levée par la classe MStagiaire
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
                //Client nouveauClientEF = new Client();

                nouveauClientEF.IdentifiantClient = int.Parse(base.txtIdClient.Text.Trim());
                nouveauClientEF.RaisonSociale = base.txtRaisSoc.Text;
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

                //insertion en DbContext
               // Donnees.DbClient.Client.Add(nouveauClientEF);
                //MAJ BDD
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

        private void txtIdClient_Click_1(object sender, EventArgs e)
        {
            base.txtIdClient.ForeColor = Color.Black;
        }

        private void txtRaisSoc_Click_1(object sender, EventArgs e)
        {
            base.txtRaisSoc.ForeColor = Color.Black;
        }

        private void txtActivite_Click_1(object sender, EventArgs e)
        {
            base.txtActivite.ForeColor = Color.Black;
        }

        private void txtNumActi_Click_1(object sender, EventArgs e)
        {
            base.txtNumActi.ForeColor = Color.Black;
        }

        private void txtAdresse_Click_1(object sender, EventArgs e)
        {
            base.txtAdresse.ForeColor = Color.Black;
        }

        private void txtTelCli_Click_1(object sender, EventArgs e)
        {
            base.txtTelCli.ForeColor = Color.Black;
        }

        private void txtChAf_Click_1(object sender, EventArgs e)
        {
            base.txtChAf.ForeColor = Color.Black;
            this.lblErreur2.Visible = false;
        }

        private void txtEffectif_Click_1(object sender, EventArgs e)
        {
            
            base.txtEffectif.ForeColor = Color.Black;
            this.lblErreur2.Visible = false;
        }
    }
}
