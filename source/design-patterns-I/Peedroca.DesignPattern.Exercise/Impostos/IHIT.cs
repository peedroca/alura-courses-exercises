using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class IHIT : Imposto
    {
        public IHIT()
        {

        }

        public IHIT(IImposto outroImposto) : base(outroImposto)
        {

        }

        protected override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100 + CalcularOutroImposto(orcamento);
        }

        protected override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Items.Count()) + CalcularOutroImposto(orcamento);
        }

        protected override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Items.GroupBy(g => g.Nome).Any(a => a.Count() >= 2);
        }
    }
}
