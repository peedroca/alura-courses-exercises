using DesignPatternsII.Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Models
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao { get; }

        public RaizQuadrada(IExpressao expressao)
        {
            Expressao = expressao;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.Imprimir(this);
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Convert.ToDouble(Expressao.Avalia()));
        }
    }
}
