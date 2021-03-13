using Peedroca.DesignPattern.Exercise.Interfaces;
using System.Linq;

namespace Peedroca.DesignPattern.Exercise.Descontos
{
    internal class DescontoMaisCincoItems : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Items.Count() > 5)
                return orcamento.Valor * 0.1;

            return Proximo.Descontar(orcamento);
        }
    }
}
