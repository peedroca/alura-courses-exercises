using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    internal sealed class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
        }

        public double Valor { get; private set; }

        public List<Item> Items { get; private set; }

        public void AdicionarItem(params Item[] items)
        {
            Items.AddRange(items);
        }
    }
}
