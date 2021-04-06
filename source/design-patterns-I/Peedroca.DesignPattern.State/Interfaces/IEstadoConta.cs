using Peedroca.DesignPattern.State.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peedroca.DesignPattern.State.Interfaces
{
    public interface IEstadoConta
    {
        void Saque(Conta conta, decimal valor);
        void Deposito(Conta conta, decimal valor);
        void Negativar(Conta conta);
        void Positivar(Conta conta);
    }
}
