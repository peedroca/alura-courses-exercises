using Peedroca.DesignPattern.Exercise.Status;
using System.Collections.Generic;

namespace Peedroca.DesignPattern.Exercise
{
    public sealed class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
            EstadoDoOrcamento = new EmAprovacao();
        }

        public double Valor { get; private set; }

        public List<Item> Items { get; private set; }

        public EstadoDoOrcamento EstadoDoOrcamento { get; private set; }

        public void AtualizarEstado(EstadoDoOrcamento estado)
        {
            EstadoDoOrcamento = estado;
        }

        public void AplicaDescontoExtra() => EstadoDoOrcamento.AplicarDesconto(this);
        public void Aprovar() => EstadoDoOrcamento.Aprovar(this);
        public void Reprovar() => EstadoDoOrcamento.Reprovar(this);
        public void Finalizar() => EstadoDoOrcamento.Finalizar(this);

        public void AplicarDesconto(double valor)
        {
            Valor -= valor;
        }

        public void AdicionarItem(params Item[] items)
        {
            Items.AddRange(items);
        }
    }
}
