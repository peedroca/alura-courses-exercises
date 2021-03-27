using Peedroca.DesignPattern.Decorator.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Decorator.Filtros
{
    public sealed class AberturaMesAtual : Filtro
    {
        public AberturaMesAtual()
        {

        }

        public AberturaMesAtual(Filtro proximoFiltro) : base(proximoFiltro)
        {

        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var retorno = new List<Conta>();

            retorno.AddRange(contas.Where(w => w.Abertura.Month == DateTime.Now.Month));

            var maisContas = FiltrarComOutroFiltro(contas);

            if (maisContas != null && maisContas.Count > 0)
                retorno.AddRange(maisContas);

            return retorno;
        }
    }
}
