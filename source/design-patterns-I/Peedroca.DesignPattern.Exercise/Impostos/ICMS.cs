using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.5) + 50;
        }
    }
}
