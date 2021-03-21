using Peedroca.DesignPattern.TemplateMethod.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.TemplateMethod.Relatorios
{
    public sealed class Complexo : Relatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return $"{banco.Nome} - {banco.Endereco} - {banco.Telefone}";
        }

        protected override string Corpo(IList<Conta> contas)
        {
            return string.Join("\n", contas.Select(s => $"{s.Titular} - {s.Saldo} - Agência: {s.Agencia} Conta: {s.Numero}"));
        }

        protected override string Rodape(Banco banco)
        {
            return $"{banco.Email} - {DateTime.Now}";
        }
    }
}
