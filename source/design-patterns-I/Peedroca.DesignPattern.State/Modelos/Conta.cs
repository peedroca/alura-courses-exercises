using Peedroca.DesignPattern.State.Estados;
using Peedroca.DesignPattern.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peedroca.DesignPattern.State.Modelos
{
    public sealed class Conta
    {
        public Conta(decimal saldo)
        {
            Estado = new Positivo();
            AtualizarSaldo(saldo);
        }

        public decimal Saldo { get; private set; }

        public IEstadoConta Estado { get; private set; }

        public void AtualizarEstado(IEstadoConta estado)
        {
            Estado = estado;
        }

        public void Sacar(decimal valor) => Estado.Saque(this, valor); 
        public void Depositar(decimal valor) => Estado.Deposito(this, valor);

        public void AtualizarSaldo(decimal novoSaldo)
        {
            Saldo = novoSaldo;

            if (Saldo < 0 && Estado.GetType() == typeof(Positivo))
                Estado.Negativar(this);
            else if (Estado.GetType() == typeof(Negativo))
                Estado.Positivar(this);
        }
    }
}
