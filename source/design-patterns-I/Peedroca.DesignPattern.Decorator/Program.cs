using Peedroca.DesignPattern.Decorator.Filtros;
using Peedroca.DesignPattern.Decorator.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtro filtro = new SaldoMenorQueCem(new AberturaMesAtual());

            var contas = new List<Conta>()
            {
                new Conta(30, DateTime.Now),
                new Conta(110, DateTime.Now)
            };

            var contasFiltradas = filtro.Filtrar(contas).Distinct(new ComparadorContas());
            Console.WriteLine(string.Join("\n", contasFiltradas
                .Select(s => $"Abertura: {s.Abertura.ToShortDateString()} Saldo: {s.Saldo.ToString("C2")}")));

            Console.ReadKey();     
        }
    }
}
