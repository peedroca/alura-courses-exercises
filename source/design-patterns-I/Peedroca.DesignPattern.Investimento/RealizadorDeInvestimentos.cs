using Peedroca.DesignPattern.Investimento.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento
{
    internal sealed class RealizadorDeInvestimentos
    {
        public void Calcular(ContaBancaria contaBancaria, IInvestimento perfilInvestidor)
        {
            var resultado = perfilInvestidor.Calcular(contaBancaria);
            Console.WriteLine($"O novo saldo da conta é {resultado.ToString("C2", new CultureInfo("pt-br"))}");
        }
    }
}
