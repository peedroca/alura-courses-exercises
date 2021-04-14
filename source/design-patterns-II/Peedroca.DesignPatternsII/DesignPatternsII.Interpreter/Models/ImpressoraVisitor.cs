using DesignPatternsII.Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Models
{
    public sealed class ImpressoraVisitor : IVisitor
    {
        public void Imprimir(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void Imprimir(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void Imprimir(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void Imprimir(RaizQuadrada raizQuadrada)
        {
            Console.Write("R² ");
            raizQuadrada.Expressao.Aceita(this);
        }

        public void Imprimir(Divisao divisao)
        {
            Console.Write("(");
            divisao.Esquerda.Aceita(this);
            Console.Write(" / ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void Imprimir(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" * ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
