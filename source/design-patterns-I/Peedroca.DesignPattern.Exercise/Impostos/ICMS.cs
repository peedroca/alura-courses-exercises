using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICMS : IImposto
    {
        public ICMS()
        {

        }

        public ICMS(IImposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.5) + 50 + CalcularOutroImposto(orcamento);
        }
    }
}
