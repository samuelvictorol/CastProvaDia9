using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTreino
{
    public class Banco
    {

        public void Depositar(Conta c, double valor)
        {
            c.setSaldo(valor);
        }
        public void Sacar(Conta c, double valor)
        {
            double valSaque = valor - (2 * valor);
            c.setSaldo(valSaque);
        }

    }
}
