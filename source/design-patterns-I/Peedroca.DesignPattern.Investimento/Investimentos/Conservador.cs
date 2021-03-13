using Peedroca.DesignPattern.Investimento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento.Investimentos
{
    internal sealed class Conservador : IInvestimento
    {
        public double Calcular(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Perfil Conservador.");

            double resultado = contaBancaria.Saldo * 0.008;
            return contaBancaria.Saldo + (resultado * 0.75);
        }
    }
}
