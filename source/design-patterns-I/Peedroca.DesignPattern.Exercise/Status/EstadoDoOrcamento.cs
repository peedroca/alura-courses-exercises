using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Status
{
    public interface EstadoDoOrcamento
    {
        void AplicarDesconto(Orcamento orcamento);
        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
    }
}
