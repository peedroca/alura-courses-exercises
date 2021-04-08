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

        public bool DescontoExtraConcedido { get; private set; }

        public void AtualizarEstado(EstadoDoOrcamento estado)
        {
            EstadoDoOrcamento = estado;
        }

        public void AplicaDescontoExtra() 
        {
            if (!DescontoExtraConcedido)
            {
                EstadoDoOrcamento.AplicarDesconto(this);
                DescontoExtraConcedido = true;
            }
            else
                throw new System.ArgumentException("Já foi aplicado um desconto extra a esse orcamento.");
        }
        
        public void Aprovar() 
        { 
            EstadoDoOrcamento.Aprovar(this);
            DescontoExtraConcedido = false;
        }

        public void Reprovar()
        {
            EstadoDoOrcamento.Reprovar(this);
            DescontoExtraConcedido = false;
        }

        public void Finalizar()
        {
            EstadoDoOrcamento.Finalizar(this);
            DescontoExtraConcedido = false;
        }

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
