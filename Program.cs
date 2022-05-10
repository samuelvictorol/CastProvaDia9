using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTreino
{
    internal static class Program
    {
        public static string SetValueLogin;
        public static string SetValueSenha;
        public static string SetValueCpf;
        public static ContaRepository cr;
        public static Banco banco;
        [STAThread]
        static void Main()
        {
            banco = new Banco();    
            cr = new ContaRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
