using Peedroca.DesignPattern.Exercise.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    internal static class CalculadoraDeDesconto
    {
        public static void Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoMaisCincoItems();
            var d2 = new DescontoValorMaiorQuinhentos();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            var desconto = d1.Descontar(orcamento);
            Console.WriteLine($"O desconto total é {desconto.ToString("C2")}");
        }
    }
}
