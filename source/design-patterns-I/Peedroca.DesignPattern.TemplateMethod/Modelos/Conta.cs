using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.TemplateMethod.Modelos
{
    public sealed class Conta
    {
        public string Titular { get; set; }

        public double Saldo { get; set; }

        public string Agencia { get; set; }

        public string Numero { get; set; }
    }
}
