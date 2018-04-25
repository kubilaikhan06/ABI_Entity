using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjABI
{
    public partial class frmDspCont1 : ProjABI.frmContact
    {
        public frmDspCont1()
        {
            InitializeComponent();
        }

        private void grdDoc1_DoubleClick(object sender, EventArgs e)
        {
            frmDspDoc frmAfDoc = new frmDspDoc();
            frmAfDoc.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnModDoc_Click(object sender, EventArgs e)
        {
            frmUpdDoc frmModDoc = new frmUpdDoc();
            frmModDoc.ShowDialog();
        }

        private void btnAjouDoc_Click(object sender, EventArgs e)
        {
            frmNewDoc frmNvDoc = new frmNewDoc();
            frmNvDoc.ShowDialog();
        }
    }
}
