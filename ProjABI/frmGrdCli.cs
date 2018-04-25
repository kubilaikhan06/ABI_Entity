using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjABI
{
    /// <summary>
    /// formulaire de la liste des clients, présente un DataGridview
    /// </summary>
    public partial class frmGrdCli : Form
    {
        /// <summary>
        /// constructeur du form
        /// </summary>
        public frmGrdCli()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ouvre la fiche de création d'un client en mode modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //on instancie une fiche de nouveau client
            frmNewCli frmNCli = new frmNewCli();
            if (frmNCli.ShowDialog() == DialogResult.OK)
            {
                AfficheClient();
            }            
            GestionBoutons();
        }
        /// <summary>
        /// ouvre la fiche de modification client sélectionné en mode modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            //recherhcer le stagiaire correspondant à la ligne double-cliquée
            int idClient;//id du client dans la collection 
            idClient = (int)this.grdClient.CurrentRow.Cells[0].Value;
            //rechercher l'objet Entity
            Client leClientEF = Donnees.DbClient.Client.Find(idClient);
            //instancier un objet métier MClient et le renseigner à partir de l'Entity
            MClient leClient = new MClient();

            leClient.IdClient = leClientEF.IdentifiantClient;
            leClient.RaisonSociale = leClientEF.RaisonSociale;
            leClient.TypeSociete = leClientEF.Type;
            leClient.Activite = leClientEF.Activite;
            leClient.IdActiv = leClientEF.NumeroActivite;
            leClient.Adresse = leClientEF.Adresse;
            leClient.TelephoneClient = leClientEF.TelephoneClient;
            leClient.EmailClient = leClientEF.EmailClient;
            leClient.Nature = leClientEF.Nature;
            leClient.ChAf = (decimal)leClientEF.ChiffreAffaire;
            leClient.Effectif = (int)leClientEF.Effectif;
            leClient.CommentComm = leClientEF.Commentaires;

            //instancier un form de modification pour ce client
            //et l'ouvre en mode modal
            frmUpdCli frmModCli = new frmUpdCli(leClient, leClientEF);
            frmModCli.ShowDialog();
            this.AfficheClient();            
        }
        /// <summary>
        /// ouvre la fiche de visualisation du client sélectionné en mode modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            //recherhcer le stagiaire correspondant à la ligne double-cliquée
            int idClient;//id du client dans la collection 
            idClient=(int) this.grdClient.CurrentRow.Cells[0].Value;
            //rechercher l'objet Entity
            Client leClientEF = Donnees.DbClient.Client.Find(idClient);
            //instancier un objet métier MClient et le renseigner à partir de l'Entity
            MClient leClient = new MClient();

            leClient.IdClient = leClientEF.IdentifiantClient;
            leClient.RaisonSociale = leClientEF.RaisonSociale;
            leClient.TypeSociete = leClientEF.Type;
            leClient.Activite = leClientEF.Activite;
            leClient.IdActiv = leClientEF.NumeroActivite;
            leClient.Adresse = leClientEF.Adresse;
            leClient.TelephoneClient = leClientEF.TelephoneClient;
            leClient.EmailClient = leClientEF.EmailClient;
            leClient.Nature = leClientEF.Nature;
            leClient.ChAf = (decimal)leClientEF.ChiffreAffaire;
            leClient.Effectif = (int)leClientEF.Effectif;
            leClient.CommentComm = leClientEF.Commentaires;
            
            //instancier un form détail pour ce client
            //et l'ouvre en mode modal
            frmDspCli frmAffCli = new frmDspCli(leClient);
            frmAffCli.ShowDialog();
            this.AfficheClient();
        }
        /// <summary>
        /// fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }

        private void frmGrdCli_Load(object sender, EventArgs e)
        {          
            AfficheClient();
            //le bouton Ajouter est pré-sélectionné au chargement de la page
            this.btnAjouter.Select();
            GestionBoutons();
        }

        private void grdClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// rétablit la source de données de la DataGridView
        /// et rafraîchit son affichage
        /// </summary>
        private void AfficheClient()
        {
            //DataTable: pour recopier les stagiaires
            //(stockés en collection);
            //à relier au DataGV pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr; //ligne de la datatable

            //création de 8 colonnes personnalisées dans la Datatable           
            dt.Columns.Add(new DataColumn("Identifiant entreprise", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Entreprise", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Email", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Chiffre d'affaire", typeof(System.Decimal)));

            //boucle de remplissage de la DataTable à partir de la collection en DbContext
            //le DbContext peut générer une liste typée d'objets Entity Client
            foreach (Client unClientEF in Donnees.DbClient.Client.ToList())
            {
                //instanciation DataRow(=ligne du DataTable)
                dr = dt.NewRow();
                //affectation des colonnes à partir de l'Entity
                dr[0] = unClientEF.IdentifiantClient;
                dr["Entreprise"] = unClientEF.RaisonSociale ;
                dr["Type"] = unClientEF.Type;
                dr["Adresse"] = unClientEF.Adresse;
                dr["Téléphone"] = unClientEF.TelephoneClient;
                dr["Email"] = unClientEF.EmailClient;
                dr["Nature"] = unClientEF.Nature;
                dr["Chiffre d'affaire"] = unClientEF.ChiffreAffaire;
                //ajout de la ligne à la DataTable
                dt.Rows.Add(dr);
            }           
            //déterminer l'origine des données à afficher en DataGV
            this.grdClient.DataSource = dt.DefaultView;
            //rafraîchir l'affichage 
            this.grdClient.Refresh();
            dt = null;
            dr = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// supprime la ligne/le client sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Int32 idClient; //id du client dans la collection
                            //récupérer id du client cliqué en DataGV
            idClient = (int)this.grdClient.CurrentRow.Cells[0].Value;
            //retrouver l'objet EF Client dans la collection dbContext
            Client leClientEF = Donnees.DbClient.Client.Find(idClient);
            //ouverture d'une boîte de dialogue pour demander une confirmation de la suppression
            DialogResult r;
            r = MessageBox.Show("Voulez-vous supprimer le client: "+ leClientEF.RaisonSociale.Trim() +" - identifiant: "+leClientEF.IdentifiantClient.ToString()+" ?", "confirmer");
            if (r == DialogResult.OK)
            {
                //supprimer de la collection EF
                Donnees.DbClient.Client.Remove(leClientEF);
                //impacter en BDD
                Donnees.DbClient.SaveChanges();
                this.AfficheClient();
                //le client sélectionné est effacé de la DataGridView
                //grdClient.Rows.Remove(grdClient.SelectedRows[idClient]);
            }
            GestionBoutons();
            this.btnAjouter.Select();
        }
        /// <summary>
        /// rechercher un client/une entreprise en entrant sa raison sociale (les premières lettres du nom de l'entreprise suffisent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechEnt_Click(object sender, EventArgs e)
        {
            ((DataView)(this.grdClient.DataSource)).RowFilter = "Entreprise like '%" + this.txtRechEntr.Text + "%'";
        }
        /// <summary>
        /// affiche la Datatable en entier avec tous les clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTous_Click(object sender, EventArgs e)
        {
            this.txtRechEntr.Text = null;
            this.txtRechTyp.Text = null;
            ((DataView)(this.grdClient.DataSource)).RowFilter = null;            
        }
        /// <summary>
        /// méthode de gestion des boutons du formulaire
        /// </summary>
        private void GestionBoutons()
        {
            if (Donnees.DbClient.Client.Count() == 0)
            {
                this.btnRechEnt.Enabled = false;
                this.btnTous.Enabled = false;
                this.btnSupprimer.Visible = false;
                this.btnModifier.Visible = false;
            }
            else
            {
                this.btnRechEnt.Enabled = true;
                this.btnTous.Enabled = true;
                if (grdClient.SelectedRows.Count == 0)
                {
                    this.btnSupprimer.Visible = false;
                    this.btnModifier.Visible = false;
                }
                else
                {
                    this.btnSupprimer.Visible = true;
                    this.btnModifier.Visible = true;
                }
            }
        }

        private void grdClient_Click(object sender, EventArgs e)
        {
            this.GestionBoutons();            
        }
        /// <summary>
        /// ouvre une fenêtre de dialogue qui affiche le nombre de clients contenus
        /// dans la collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNbEntr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il y a: "+ Donnees.DbClient.Client.Count().ToString()+" entreprises");
        }

        private void btnRechTyp_Click(object sender, EventArgs e)
        {
        }

        private void txtRechTyp_Click(object sender, EventArgs e)
        {
            this.txtRechTyp.Text = null;
        }

        private void txtRechEntr_Click(object sender, EventArgs e)
        {
            this.txtRechEntr.Text = null;
        }
    }
}
