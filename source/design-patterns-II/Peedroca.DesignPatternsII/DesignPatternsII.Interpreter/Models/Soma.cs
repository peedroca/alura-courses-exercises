using DesignPatternsII.Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Models
{
    public class Soma : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }
    }
}
