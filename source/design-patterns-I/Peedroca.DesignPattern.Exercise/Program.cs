using Peedroca.DesignPattern.Exercise.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento1 = new Orcamento(900);
            var orcamento2 = new Orcamento(1100);
            var orcamento3 = new Orcamento(3200);

            var iccc = new ICCC();

            new CalculadoraDeImpostos().CalcularImposto(orcamento1, iccc);
            new CalculadoraDeImpostos().CalcularImposto(orcamento2, iccc);
            new CalculadoraDeImpostos().CalcularImposto(orcamento3, iccc);
            Console.ReadKey();
        }
    }
}
