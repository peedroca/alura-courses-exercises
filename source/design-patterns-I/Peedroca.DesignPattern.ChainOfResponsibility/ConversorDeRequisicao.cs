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
            var r1 = new CSV();
            var r2 = new XML();
            var r3 = new Porcento();
            var r4 = new SemConversao();

            r1.Proximo = r2;
            r2.Proximo = r3;
            r3.Proximo = r4;

            var conversao = r1.Converter(conta, formato);
            Console.WriteLine(conversao);
        }
    }
}
