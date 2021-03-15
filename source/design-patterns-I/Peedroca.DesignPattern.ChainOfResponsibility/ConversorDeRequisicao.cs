using Peedroca.DesignPattern.ChainOfResponsibility.Enums;
using Peedroca.DesignPattern.ChainOfResponsibility.Modelos;
using Peedroca.DesignPattern.ChainOfResponsibility.Requisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.ChainOfResponsibility
{
    public static class ConversorDeRequisicao
    {
        public static void Converter(Conta conta, EFormato formato)
        {
            var r3 = new Porcento(null);
            var r2 = new XML(r3);
            var r1 = new CSV(r2);

            var conversao = r1.Converter(conta, formato);

            if(!string.IsNullOrEmpty(conversao))
                Console.WriteLine(conversao);
            else
                Console.WriteLine("Conversão não encontrada.");
        }
    }
}
