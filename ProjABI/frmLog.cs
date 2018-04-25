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
    public partial class frmLog : Form
    {
        private string mdp = "moi";
        public frmLog()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //if (txtIdentifiant.Text == "remi")
            //{
            //    if (this.txtMdp.Text == "moi")
            //    {
            //        frmGrdCli frmLstCli = new frmGrdCli();
            //        frmLstCli.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Le mot de passe est incorrect.", "ERREUR!");
            //        this.txtMdp.Clear();
            //        this.txtMdp.Select();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Le nom utilisateur est incorrect.", "ERREUR!");
            //    this.txtIdentifiant.Clear();
            //    this.txtIdentifiant.Select();
            //}
            this.Hide();
            frmGrdCli frmLstCli = new frmGrdCli();
            frmLstCli.ShowDialog();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {

        }

        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rep;
            //rep = MessageBox.Show("Vous quitter?", "Terminer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rep == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
