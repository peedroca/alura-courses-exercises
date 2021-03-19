using Peedroca.DesignPattern.Exercise.Interfaces;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class ICPP : Imposto, IImposto
    {
        internal override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        internal override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        internal override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}
