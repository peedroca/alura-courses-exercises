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
            var orcamento = new Orcamento(501);
            orcamento.AdicionarItem(new[] 
            { 
                new Item("Lapis", 101),
                new Item("Lapis", 101),
                new Item("Caneta", 2),
                new Item("Toddy", 2),
                new Item("Biscoito", 1),
            });

            CalculadoraDeImpostos.CalcularImposto(orcamento, new IHIT());
            Console.ReadKey();
        }
    }
}
