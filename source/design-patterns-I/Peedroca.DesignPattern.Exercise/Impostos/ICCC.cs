using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICCC : IImposto
    {
        public ICCC()
        {

        }

        public ICCC(IImposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05;
            else if (orcamento.Valor < 3000 && orcamento.Valor > 1000)
                return orcamento.Valor * 0.07;
            else 
                return orcamento.Valor * 0.08 + 30;
        }
    }
}
