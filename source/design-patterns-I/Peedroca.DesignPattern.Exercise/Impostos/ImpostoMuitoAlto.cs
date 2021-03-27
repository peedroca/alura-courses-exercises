using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Impostos
{
    public class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto()
        {

        }

        public ImpostoMuitoAlto(IImposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularOutroImposto(orcamento);
        }
    }
}
