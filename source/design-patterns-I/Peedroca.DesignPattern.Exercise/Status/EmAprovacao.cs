using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Status
{
    public sealed class EmAprovacao : EstadoDoOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            orcamento.AplicarDesconto(orcamento.Valor * 0.05);
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.AtualizarEstado(new Aprovado());
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.AtualizarEstado(new Finalizado());
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.AtualizarEstado(new Reprovado());
        }
    }
}
