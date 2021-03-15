using Peedroca.DesignPattern.Investimento.Investimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaBancaria(1000);

            new RealizadorDeInvestimentos().Calcular(conta, new Conservador());
            new RealizadorDeInvestimentos().Calcular(conta, new Moderado());
            new RealizadorDeInvestimentos().Calcular(conta, new Arrojado());
            Console.ReadKey();
        }
    }
}
