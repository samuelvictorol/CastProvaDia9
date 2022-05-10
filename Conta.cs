using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTreino
{
    public class Conta
    {
        private string Login;
        private string Senha;
        private double Saldo = 0.0;
        Cliente cliente;
        public Conta(Cliente c)
        {
            this.cliente = c;
        }
        public void setSenha(string senha)
        {
            this.Senha = senha;
        }
        public string getSenha()
        {
            return this.Senha;
        }
        public void setLogin(string lg)
        {
            this.Login = lg; 
        }
        public string getLogin()
        {
            return this.Login;
        }
        public void setSaldo(double valor)
        {
            this.Saldo += valor;
        }
        public string getSaldo()
        {
            return this.Saldo.ToString();
        }
        public Cliente getCliente()
        {
            return this.cliente;
        }
        public string InfoConta()
        {
            return "\nLogin: " + this.Login
                 + "\nSaldo: " + this.Saldo;
        }

    }
}
