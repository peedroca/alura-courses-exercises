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
            var orcamento = new Orcamento(300);
            orcamento.AdicionarItem(new[] 
            { 
                new Item("Lapis", 2),
                new Item("Caneta", 2),
                new Item("Toddy", 2),
                new Item("Biscoito", 1),
            });

            CalculadoraDeDesconto.Calcula(orcamento);
            Console.ReadKey();
        }
    }
}
