using DesignPatternsII.Command.Interfaces;
using System;

namespace DesignPatternsII.Command.Modelos
{
    class PagaPedido : IComando
    {
        public PagaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public Pedido Pedido { get; }

        public void Executa()
        {
            Console.WriteLine("Pago, pedido do cliente {0}", Pedido.Cliente);
            Pedido.Finaliza();
        }
    }
}
