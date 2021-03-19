using Peedroca.DesignPattern.Exercise.Interfaces;
using System;

namespace Peedroca.DesignPattern.Exercise
{
    internal sealed class CalculadoraDeImpostos
    {
        internal static void CalcularImposto(Orcamento orcamento, IImposto imposto)
        {
            var resultado = imposto.Calcular(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
