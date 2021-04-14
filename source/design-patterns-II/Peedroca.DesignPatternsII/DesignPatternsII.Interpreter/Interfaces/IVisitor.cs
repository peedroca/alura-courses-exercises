using DesignPatternsII.Interpreter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Interfaces
{
    public interface IVisitor
    {
        void Imprimir(Soma soma);
        void Imprimir(Subtracao subtracao);
        void Imprimir(Numero numero);
        void Imprimir(RaizQuadrada raizQuadrada);
        void Imprimir(Divisao divisao);
        void Imprimir(Multiplicacao multiplicacao);
    }
}
