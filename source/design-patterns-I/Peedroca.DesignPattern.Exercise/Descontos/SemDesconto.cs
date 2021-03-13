using Peedroca.DesignPattern.Exercise.Interfaces;
using System.Linq;

namespace Peedroca.DesignPattern.Exercise.Descontos
{
    internal class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}
