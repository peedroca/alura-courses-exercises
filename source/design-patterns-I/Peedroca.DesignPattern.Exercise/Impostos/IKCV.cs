using Peedroca.DesignPattern.Exercise.Interfaces;
using System.Linq;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class IKCV : Imposto
    {
        public IKCV()
        {

        }

        public IKCV(IImposto outroImposto) : base(outroImposto)
        {

        }

        protected override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalcularOutroImposto(orcamento);
        }

        protected override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalcularOutroImposto(orcamento);
        }

        protected override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.Items.Any(a => a.Valor > 100);
        }
    }
}
