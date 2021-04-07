using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    public class ItemDaNotaBuilder
    {
        private decimal _valor;
        private string _descricao;

        public ItemDaNotaBuilder()
        {
            _valor = 0;
            _descricao = string.Empty;
        }

        public ItemDaNotaBuilder ComValor(decimal valor)
        {
            _valor = valor;
            return this;
        }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public ItemDaNota Construir()
        {
            return new ItemDaNota(_descricao, _valor);
        }
    }
}
