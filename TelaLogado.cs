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
    public partial class TelaLogado : Form
    {
        Conta conta;
        public TelaLogado(Conta c)
        {
            this.conta = c;
            InitializeComponent();
            lb_login.Text = c.getLogin();
            lb_saldo.Text = $"R$ {c.getSaldo()}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que sair?",
                         "Confirm Exit",
                         MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            bool check = verificaValor();
            if (check)
            {
                Program.banco.Depositar(this.conta, Double.Parse(txt_valor.Text));
                MessageBox.Show($"Deposito com sucesso no valor de R$ {txt_valor.Text}");
                atualizaSaldo();
            }
        }
        public void atualizaSaldo()
        {
            lb_saldo.Text = $"R$ {this.conta.getSaldo()}";
        }
        public bool verificaValor()
        {
            try
            {
                double val = Double.Parse(txt_valor.Text);
                    btn_sacar.Enabled = true;
                    btn_transferir.Enabled = true;
             }
            catch (Exception ex)
            {
                MessageBox.Show("Valor Inválido!\n");
                return false;
            }
            return true;
        }
        private void btn_sacar_Click(object sender, EventArgs e)
        {
            bool check = verificaValor();
            if (check)
            {
                if (Double.Parse(txt_valor.Text) > 0)
                {
                    Program.banco.Sacar(this.conta, Double.Parse(txt_valor.Text));
                    MessageBox.Show($"Saque efetuado com sucesso no valor de R$ {txt_valor.Text}");
                    atualizaSaldo();
                }
                if(Double.Parse(txt_valor.Text) < Double.Parse(lb_saldo.Text))
                {
                    Program.banco.Sacar(this.conta, Double.Parse(txt_valor.Text));
                    MessageBox.Show($"Saldo Indisponivel para saque");
                    atualizaSaldo();
                }
            }
        }

        private void TelaLogado_Load(object sender, EventArgs e)
        {

        }
    }
}
