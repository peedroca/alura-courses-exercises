using Peedroca.DesignPattern.Exercise.Interfaces;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal abstract class Imposto : IImposto
    {
        public Imposto()
        {

        }

        public Imposto(IImposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaiorImposto(orcamento))
                return CalcularMaiorImposto(orcamento);
            else
                return CalcularMenorImposto(orcamento);
        }

        protected abstract bool DeveUsarMaiorImposto(Orcamento orcamento);
        protected abstract double CalcularMaiorImposto(Orcamento orcamento);
        protected abstract double CalcularMenorImposto(Orcamento orcamento);
    }
}
