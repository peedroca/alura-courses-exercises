using Peedroca.DesignPattern.TemplateMethod.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.TemplateMethod.Relatorios
{
    public sealed class Simples : Relatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"{banco.Nome} - {banco.Telefone}";
        }

        protected override string Corpo(IList<Conta> contas)
        {
            return string.Join("\n", contas.Select(s => $"{s.Titular} - {s.Saldo}"));
        }

        protected override string Rodape(Banco banco)
        {
            return $"{banco.Nome} - {banco.Telefone}";
        }
    }
}
