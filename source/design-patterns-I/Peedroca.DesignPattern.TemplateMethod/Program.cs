using Peedroca.DesignPattern.TemplateMethod.Modelos;
using Peedroca.DesignPattern.TemplateMethod.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Complexo();

            var banco = new Banco()
            {
                Nome = "Banco Brasil",
                Email = "banco@banco.com",
                Telefone = "11 91234-5678",
                Endereco = "Rua abc brasil"
            };

            var contas = new List<Conta>()
            {
                new Conta() 
                { 
                    Titular = "Pedro",
                    Numero = "0001",
                    Agencia = "0102-1",
                    Saldo = 100
                },
                new Conta()
                {
                    Titular = "Henrique",
                    Numero = "0002",
                    Agencia = "0102-1",
                    Saldo = 150
                }
            };

            var relatorioImpresso = relatorio.GerarRelatorio(banco, contas);
            
            Console.WriteLine(relatorioImpresso);
            Console.ReadKey();
        }
    }
}
