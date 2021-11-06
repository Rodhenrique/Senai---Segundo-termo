using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Model;

namespace Xamarin
{
    public partial class FrmCadastro : Form
    {
        private Usuario usuario { get; set; }
        public bool IsEmailValid { get; set; }

        public FrmCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos de imagens(*.jpg, *.png)|*.jpg,*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foto.Image = Image.FromFile(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Nome_completo.Text;
            int posEspaco = input.IndexOf(" ", 0);
            if (input.IndexOf(" ", 0) > 1)
            {
                MessageBox.Show("Digite o seu nome com dois nomes composto");
                return;
            }
            else if (dataNascimento.Value == DateTime.Now)
            {
                MessageBox.Show("Digite Uma data de nascimeto para gerar o username");
                return;
            }
            else
            {
                string parte1 = input.Substring(0, posEspaco);
                string parte2 = input.Substring(posEspaco + 1, input.Length - (posEspaco + 1));
                string data = dataNascimento.Value.ToString();
                string num = data.Substring(6, 2);
                string userName = parte1 + parte2 + num;
                Username.Text = userName;
            }
        }

        private int contador = 1;
        private void SalvaBtn_Click(object sender, EventArgs e)
        {
            if (Util.CampoVazio(this))
            {

                MessageBox.Show("Dados Salvos", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int CalculaIdade()
        {
            int idade = 0;
            if(dataNascimento.Value < DateTime.Now)
            {
            }
            return idade;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";

            IsEmailValid = Regex.IsMatch(Email.Text, pattern);
            EmailInvalido.Visible = !IsEmailValid;
        }

        
    }
}
