using Peedroca.DesignPattern.State.Interfaces;
using Peedroca.DesignPattern.State.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peedroca.DesignPattern.State.Estados
{
    public sealed class Negativo : IEstadoConta
    {
        public void Deposito(Conta conta, decimal valor)
        {
            conta.AtualizarSaldo(decimal.Multiply(valor, 0.95m));
        }

        public void Negativar(Conta conta)
        {
            throw new ArgumentException("A conta já está negativada.");
        }

        public void Positivar(Conta conta)
        {
            conta.AtualizarEstado(new Positivo());
        }

        public void Saque(Conta conta, decimal valor)
        {
            throw new ArgumentException("Não é possível fazer saques em uma conta com saldo negativo.");
        }
    }
}
