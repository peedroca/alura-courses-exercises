using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Status
{
    public sealed class Finalizado : EstadoDoOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            throw new ArgumentException("Não é possível aplicar desconto à um orçamento finalizado.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }
    }
}
