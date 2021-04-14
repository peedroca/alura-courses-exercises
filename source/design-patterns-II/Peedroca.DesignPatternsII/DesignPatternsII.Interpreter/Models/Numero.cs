using DesignPatternsII.Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Models
{
    public class Numero : IExpressao
    {
        public int Valor { get; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.Imprimir(this);
        }

        public int Avalia()
        {
            return Valor;
        }
    }
}
