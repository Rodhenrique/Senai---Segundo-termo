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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = Data.Rows[e.RowIndex];

            string nome = row.Cells[1].Value.ToString();
        }
    }
}
