using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento.Interfaces
{
    internal interface IInvestimento
    {
        double Calcular(ContaBancaria contaBancaria);
    }
}
