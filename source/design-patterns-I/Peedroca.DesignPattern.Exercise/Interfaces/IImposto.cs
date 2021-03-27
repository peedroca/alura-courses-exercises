using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Interfaces
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }

        public IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public IImposto()
        {

        }

        public abstract double Calcular(Orcamento orcamento);

        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcular(orcamento);
        }
    }
}
