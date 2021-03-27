using Peedroca.DesignPattern.Decorator.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Decorator.Filtros
{
    public abstract class Filtro
    {
        public Filtro ProximoFiltro { get; set; }

        public Filtro()
        {

        }

        public Filtro(Filtro proximoFiltro)
        {
            ProximoFiltro = proximoFiltro;
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta> FiltrarComOutroFiltro(IList<Conta> contas)
        {
            return ProximoFiltro?.Filtrar(contas) ?? null;
        }
    }
}
