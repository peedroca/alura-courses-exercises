﻿using Peedroca.DesignPattern.Exercise.Interfaces;
using System.Linq;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    internal sealed class IKCV : Imposto, IImposto
    {
        protected override double CalcularMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double CalcularMenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool DeveUsarMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.Items.Any(a => a.Valor > 100);
        }
    }
}
