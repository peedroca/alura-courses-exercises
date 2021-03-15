using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.ChainOfResponsibility.Modelos
{
    public class Conta
    {
        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public string Titular { get; private set; }

        public double Saldo { get; private set; }
    }
}
