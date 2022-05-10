using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTreino
{
    public class Cliente
    {
        private string Nome;
        private string Cpf;

        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }
        public string getCpf()
        {
            return this.Cpf;
        }


    }
}
