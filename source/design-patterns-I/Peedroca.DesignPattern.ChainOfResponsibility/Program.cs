using Peedroca.DesignPattern.ChainOfResponsibility.Enums;
using Peedroca.DesignPattern.ChainOfResponsibility.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("Pedro", 500);
            ConversorDeRequisicao.Converter(conta, EFormato.TESTE);

            Console.ReadKey();
        }
    }
}
