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
    public class XML : IRequisicao
    {
        public IRequisicao Proximo { get; set; }

        public string Converter(Conta conta, EFormato formato)
        {
            if (formato == EFormato.XML)
                return $"Arquivo XML... {conta.Saldo} - {conta.Titular}";
            else
                return Proximo.Converter(conta, formato);
        }
    }
}
