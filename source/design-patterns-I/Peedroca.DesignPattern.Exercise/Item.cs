using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    internal class Item
    {
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }

        public double Valor { get; set; }
    }
}
