using Peedroca.DesignPattern.TemplateMethod.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.TemplateMethod.Relatorios
{
    public abstract class Relatorio
    {
        public string GerarRelatorio(Banco banco, IList<Conta> contas)
        {
            string response = $"{Cabecalho(banco)}\n\n{Corpo(contas)}\n\n{Rodape(banco)}";
            return response;
        }

        protected abstract string Cabecalho(Banco banco);
        protected abstract string Corpo(IList<Conta> contas);
        protected abstract string Rodape(Banco banco);
    }
}
