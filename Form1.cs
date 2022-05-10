using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTreino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja Finalizar o Aplicativo??",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = Program.cr.findConta(txt_user.Text, txt_senha.Text);
            

            if (c == null)
            {
                MessageBox.Show("Login/Senha Inválido!\n");
                txt_senha.Clear();
                txt_user.Focus();
                
            }
            else
            {
                TelaLogado t1 = new TelaLogado(c);
                t1.ShowDialog();
                txt_senha.Clear();
                txt_user.Focus();
                this.Opacity = 0;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            TelaRegistrar tr = new TelaRegistrar();
            tr.ShowDialog();
            this.Opacity = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
