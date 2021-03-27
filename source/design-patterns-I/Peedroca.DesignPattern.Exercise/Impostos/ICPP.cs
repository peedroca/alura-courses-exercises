using Peedroca.DesignPattern.Exercise.Interfaces;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICPP : Imposto
    {
        public ICPP()
        {

        }

        public ICPP(IImposto outroImposto) : base(outroImposto)
        {

        }

        protected override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalcularOutroImposto(orcamento);
        }

        protected override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalcularOutroImposto(orcamento);
        }

        protected override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}
