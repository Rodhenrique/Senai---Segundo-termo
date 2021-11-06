using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xamarin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaUsuario frmLista = new FrmListaUsuario();

            frmLista.MdiParent = this;

            frmLista.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAviso frm = new FrmAviso();
            frm.MdiParent = this;

            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza quer sair?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza quer sair?","Confirmação", 
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
