using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Status
{
    public sealed class Aprovado : EstadoDoOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            orcamento.AplicarDesconto(orcamento.Valor * 0.02);
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ArgumentException("Um orçamento aprovado não pode ser reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.AtualizarEstado(new Finalizado());
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ArgumentException("Um orçamento aprovado não pode ser reprovado.");
        }
    }
}
