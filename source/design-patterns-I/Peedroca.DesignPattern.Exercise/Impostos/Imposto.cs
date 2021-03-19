namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal abstract class Imposto
    {
        public double Calcular(Orcamento orcamento)
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
