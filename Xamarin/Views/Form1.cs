using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xamarin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capsLock.Visible = IscapsLockAtivado();
            tbxUsuario.ShortcutsEnabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxUsuario.Text.Length == 0)
            {
                MessageBox.Show("Digite o usuario.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem vindo", "Entrada");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmCadastro().ShowDialog();
        }

        private void capsLock_Click(object sender, EventArgs e)
        {
            capsLock.Visible = false;
        }

        private void Entrar(object sender, EventArgs e)
        {
            capsLock.Visible = IscapsLockAtivado();
        }

        private bool IscapsLockAtivado()
        {
            return Control.IsKeyLocked(Keys.CapsLock); 
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            capsLock.Visible = IscapsLockAtivado();
        }

        private void Teclado_Click(object sender, EventArgs e)
        {
            Process.Start("osk.exe");
        }
    }
}
