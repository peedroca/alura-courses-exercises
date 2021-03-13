using Peedroca.DesignPattern.Investimento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Investimento.Investimentos
{
    internal sealed class Arrojado : IInvestimento
    {
        public double Calcular(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Perfil Moderado.");

            var chance = new Random().Next(101);
            double resultado = 0;

            if (chance < 20)
                resultado = contaBancaria.Saldo * 0.05;
            else if (chance < 50)
                resultado = contaBancaria.Saldo * 0.03;
            else
                resultado = contaBancaria.Saldo * 0.06;

            return contaBancaria.Saldo + (resultado * 0.75);
        }
    }
}
