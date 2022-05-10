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
    public partial class TelaRegistrar : Form
    {
        public TelaRegistrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja cancelar o Registro ?",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool verifica = verificarLogin();
            if (verifica)
            {
                Cliente x = new Cliente();
                x.setNome(txt_nome.Text);
                x.setCpf(txt_cpf.Text);
                Conta c = new Conta(x);
                c.setLogin(txt_login.Text);
                c.setSenha(txt_senha.Text);
                Program.cr.addConta(c);
                MessageBox.Show("Senhor(a) " + x.getNome() + " Cadastrado com Sucesso!");
                TelaLogado tc = new TelaLogado(c);
                this.Opacity = 0;
                tc.ShowDialog();
            }
            this.Close();
        }

        public bool verificarLogin()
        {
            bool check = Valida(txt_cpf.Text);
            if (check == false)
            {
                MessageBox.Show("CPF Inválido!");
                txt_cpf.Focus();
                return false;
            }
           Cliente c = Program.cr.findCliente(txt_cpf.Text, txt_login.Text);
           if(c != null)
            {
                MessageBox.Show("CPF ou Login Já cadastrado no sistema!");
                txt_login.Focus();
                return false;
            }

           if(txt_login.Text == "" || txt_cpf.Text == "" || txt_nome.Text == "" || txt_senha.Text == "") {
                MessageBox.Show("Campo(s) Vazio, Preencha todos os Campos!");
                txt_login.Focus();
                return false;
            }
            return true;

        }

        public bool Valida(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
    }
}
