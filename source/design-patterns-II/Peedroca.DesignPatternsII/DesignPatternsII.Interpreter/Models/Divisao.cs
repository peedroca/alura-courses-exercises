﻿using DesignPatternsII.Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Interpreter.Models
{
    public class Divisao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }
    }
}
