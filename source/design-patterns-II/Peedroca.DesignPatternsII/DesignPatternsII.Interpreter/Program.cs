using DesignPatternsII.Interpreter.Interfaces;
using DesignPatternsII.Interpreter.Models;
using System;

namespace DesignPatternsII.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new RaizQuadrada(new Soma(new Numero(120), new Numero(24)));
            IVisitor visitor = new PreFixaVisitor();
            visitor.Imprimir(conta);

            Console.WriteLine();
            Console.WriteLine(conta.Avalia());
            Console.ReadKey();
        }
    }
}
