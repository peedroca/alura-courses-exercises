using Peedroca.DesignPattern.Exercise.AposGerarNota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    public class NotaFiscalBuilder
    {
        private string RazaoSocial;
        private string CNPJ;
        private DateTime Emissao;
        private decimal Impostos;
        private decimal ValorBruto;
        private string Observacoes;
        private List<ItemDaNota> _itens;
        private List<IAposGerarNota> _aposGerarNota;

        public NotaFiscalBuilder(List<IAposGerarNota> acoes)
        {
            _itens = new List<ItemDaNota>();
            _aposGerarNota = acoes;
            Emissao = DateTime.Now;
        }

        public NotaFiscal Construir()
        {
            var nf = new NotaFiscal(RazaoSocial
                , CNPJ
                , Emissao
                , Impostos
                , ValorBruto
                , Observacoes
                , _itens);

            _aposGerarNota.ForEach(f => f.Executa(nf));

            return nf;
        }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime? emissao)
        {
            Emissao = emissao.Value;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota itemDaNota)
        {
            ValorBruto += itemDaNota.Valor;
            Impostos += itemDaNota.Valor * 0.05m;
            _itens.Add(itemDaNota);
            return this;
        }
    }
}
