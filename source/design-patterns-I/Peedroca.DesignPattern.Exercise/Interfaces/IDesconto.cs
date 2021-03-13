using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Interfaces
{
    internal interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Descontar(Orcamento orcamento);
    }
}
