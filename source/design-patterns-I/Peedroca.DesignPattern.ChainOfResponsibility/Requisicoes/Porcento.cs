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
    public class Porcento : IRequisicao
    {
        public Porcento(IRequisicao proximo)
        {
            Proximo = proximo;
        }

        public IRequisicao Proximo { get; private set; }

        public string Converter(Conta conta, EFormato formato)
        {
            if (formato == EFormato.PORCENTO)
                return $"{conta.Saldo}%{conta.Titular}";
            else
                return Proximo?.Converter(conta, formato);
        }
    }
}
