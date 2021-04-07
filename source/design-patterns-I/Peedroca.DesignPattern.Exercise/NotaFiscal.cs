using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial
            , string cNPJ
            , DateTime emissao
            , decimal impostos
            , decimal valorBruto
            , string observacoes
            , List<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Emissao = emissao;
            Impostos = impostos;
            ValorBruto = valorBruto;
            Observacoes = observacoes;
            Itens = itens;
        }

        public string RazaoSocial { get; private set; }

        public string CNPJ { get; private set; }

        public DateTime Emissao { get; private set; }

        public decimal Impostos { get; private set; }

        public decimal ValorBruto { get; private set; }

        public string Observacoes { get; private set; }

        public List<ItemDaNota> Itens { get; private set; }
    }
}
