using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    internal sealed class CalculadoraDeImpostos
    {
        internal void CalcularImposto(Orcamento orcamento, Imposto imposto)
        {
            var resultado = imposto.Calcular(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
