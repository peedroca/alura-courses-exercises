using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Status
{
    public sealed class Reprovado : EstadoDoOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            throw new ArgumentException("Não é possível aplicar desconto à um orçamento reprovado.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ArgumentException("Um orçamento reprovado não pode ser aprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.AtualizarEstado(new Finalizado());
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ArgumentException("Um orçamento reprovado não pode ser reprovado.");
        }
    }
}
