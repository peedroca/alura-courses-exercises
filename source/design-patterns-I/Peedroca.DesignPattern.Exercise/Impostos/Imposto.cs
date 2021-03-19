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

        internal abstract bool DeveUsarMaiorImposto(Orcamento orcamento);
        internal abstract double CalcularMaiorImposto(Orcamento orcamento);
        internal abstract double CalcularMenorImposto(Orcamento orcamento);
    }
}
