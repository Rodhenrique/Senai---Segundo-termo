﻿namespace Xamarin
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome_completo = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SalvaBtn = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.EmailInvalido = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome_completo
            // 
            this.Nome_completo.Location = new System.Drawing.Point(274, 111);
            this.Nome_completo.Name = "Nome_completo";
            this.Nome_completo.Size = new System.Drawing.Size(255, 20);
            this.Nome_completo.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(274, 165);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(255, 20);
            this.Email.TabIndex = 1;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(274, 268);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(255, 20);
            this.Username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(319, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastra-se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(176, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(176, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(176, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(176, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(557, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerar Aleatótorio\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(176, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de nascimento:";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Location = new System.Drawing.Point(358, 320);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(230, 20);
            this.dataNascimento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(176, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Foto:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(410, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Seleciona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalvaBtn
            // 
            this.SalvaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.SalvaBtn.Location = new System.Drawing.Point(358, 522);
            this.SalvaBtn.Name = "SalvaBtn";
            this.SalvaBtn.Size = new System.Drawing.Size(136, 38);
            this.SalvaBtn.TabIndex = 14;
            this.SalvaBtn.Text = "Salvar";
            this.SalvaBtn.UseVisualStyleBackColor = true;
            this.SalvaBtn.Click += new System.EventHandler(this.SalvaBtn_Click);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(247, 365);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(146, 151);
            this.foto.TabIndex = 15;
            this.foto.TabStop = false;
            // 
            // EmailInvalido
            // 
            this.EmailInvalido.AutoSize = true;
            this.EmailInvalido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmailInvalido.ForeColor = System.Drawing.Color.Gold;
            this.EmailInvalido.Location = new System.Drawing.Point(552, 171);
            this.EmailInvalido.Name = "EmailInvalido";
            this.EmailInvalido.Size = new System.Drawing.Size(112, 20);
            this.EmailInvalido.TabIndex = 16;
            this.EmailInvalido.Text = "Email Invalido";
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lista.Location = new System.Drawing.Point(557, 491);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(132, 25);
            this.Lista.TabIndex = 17;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(839, 570);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.EmailInvalido);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.SalvaBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome_completo);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome_completo;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SalvaBtn;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label EmailInvalido;
        private System.Windows.Forms.Button Lista;
    }
}