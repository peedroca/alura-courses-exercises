using Peedroca.DesignPattern.ChainOfResponsibility.Enums;
using Peedroca.DesignPattern.ChainOfResponsibility.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.ChainOfResponsibility.Interfaces
{
    public interface IRequisicao
    {
        IRequisicao Proximo { get; set; }

        string Converter(Conta conta, EFormato formato);
    }
}
