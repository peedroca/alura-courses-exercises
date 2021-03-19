using Peedroca.DesignPattern.Exercise.Interfaces;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICPP : Imposto, IImposto
    {
        protected override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}
