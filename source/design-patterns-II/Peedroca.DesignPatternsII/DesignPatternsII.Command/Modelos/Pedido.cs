using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Command.Modelos
{
    class Pedido
    {
        public Pedido(string cliente, decimal valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = EStatus.Novo;
            Finalizacao = null;
        }

        public string Cliente { get; private set; }
        public decimal Valor { get; private set; }
        public EStatus Status { get; private set; }
        public DateTime? Finalizacao { get; private set; }

        public void Paga()
        {
            Status = EStatus.Pago;
        }

        public void Finaliza()
        {
            Status = EStatus.Entregue;
            Finalizacao = DateTime.Now;
        }
    }
}
