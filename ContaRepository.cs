using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ProvaTreino
{
    public class ContaRepository
    {
        ArrayList contas;

        public ContaRepository()
        {
            this.contas = new ArrayList();
        }

        public void addConta(Conta c)
        {
            contas.Add(c);
        }
        public Cliente findCliente(string cpf, string login)
        {
            foreach (Conta conta in contas)
            {
                if (conta.getCliente().getCpf().Equals(cpf))
                {
                    return conta.getCliente();
                }
                if (conta.getLogin().Equals(login))
                {
                    return conta.getCliente();
                }
            }
            return null;
        }
        public Conta findConta(string user, string senha)
        {
            foreach(Conta conta in contas)
            {
                if (conta.getLogin().Equals(user) && conta.getSenha().Equals(senha)) return conta;
            }

            return null;
        }
    }
}
