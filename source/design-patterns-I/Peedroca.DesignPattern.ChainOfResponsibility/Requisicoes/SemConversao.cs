using Peedroca.DesignPattern.ChainOfResponsibility.Enums;
using Peedroca.DesignPattern.ChainOfResponsibility.Interfaces;
using Peedroca.DesignPattern.ChainOfResponsibility.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.ChainOfResponsibility.Requisicoes
{
    public class SemConversao : IRequisicao
    {
        public IRequisicao Proximo { get; set; }

        public string Converter(Conta conta, EFormato formato)
        {
            return "Conversão não encontrada.";
        }
    }
}
