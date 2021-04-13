using DesignPatternsII.Interpreter.Models;
using System;

namespace DesignPatternsII.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new RaizQuadrada(new Numero(144));

            Console.WriteLine(conta.Avalia());
            Console.ReadKey();
        }
    }
}
