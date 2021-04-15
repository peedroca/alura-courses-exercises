using DesignPatternsII.Command.Interfaces;
using System;

namespace DesignPatternsII.Command.Modelos
{
    class FinalizaPedido : IComando
    {
        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public Pedido Pedido { get; }

        public void Executa()
        {
            Console.WriteLine("Finalizado pedido do cliente {0}", Pedido.Cliente);
            Pedido.Finaliza();
        }
    }
}
