using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento
{
    internal sealed class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }
    }
}
