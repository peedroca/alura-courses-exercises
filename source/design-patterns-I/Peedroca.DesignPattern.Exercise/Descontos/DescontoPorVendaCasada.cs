using Peedroca.DesignPattern.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.Descontos
{
    internal class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (Existe(orcamento.Items, "Lapis") 
                && Existe(orcamento.Items, "Caneta"))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Descontar(orcamento);
        }

        private bool Existe(List<Item> items, string produto)
        {
            return items.Any(a => a.Nome.Equals(produto));
        }
    }
}
