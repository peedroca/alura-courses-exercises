using Peedroca.DesignPattern.State.Interfaces;
using Peedroca.DesignPattern.State.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peedroca.DesignPattern.State.Estados
{
    public sealed class Positivo : IEstadoConta
    {
        public void Deposito(Conta conta, decimal valor)
        {
            conta.AtualizarSaldo(decimal.Add(conta.Saldo, decimal.Multiply(valor, 0.98m)));
        }

        public void Negativar(Conta conta)
        {
            conta.AtualizarEstado(new Negativo());
        }

        public void Positivar(Conta conta)
        {
            throw new ArgumentException("A conta já está positiva");
        }

        public void Saque(Conta conta, decimal valor)
        {
            conta.AtualizarSaldo(decimal.Subtract(conta.Saldo, valor));
        }
    }
}
