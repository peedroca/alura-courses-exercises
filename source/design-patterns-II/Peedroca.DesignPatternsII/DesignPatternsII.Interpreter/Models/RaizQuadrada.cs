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
        private IExpressao Expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            Expressao = expressao;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Convert.ToDouble(Expressao.Avalia()));
        }
    }
}
