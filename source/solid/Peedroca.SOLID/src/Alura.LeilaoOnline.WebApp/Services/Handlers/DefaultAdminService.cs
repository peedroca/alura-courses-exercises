using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public sealed class DefaultAdminService : IAdminService
    {
        private readonly ILeilaoDao _leilaoDao;
        private readonly ICategoriaDao _categoriaDao;

        public DefaultAdminService(ILeilaoDao leilaoDao, ICategoriaDao categoriaDao)
        {
            _leilaoDao = leilaoDao;
            _categoriaDao = categoriaDao;
        }

        public void AlterarLeilao(Leilao leilao) =>
            _leilaoDao.Atualizar(leilao);

        public void CriarLeilao(Leilao leilao) =>
            _leilaoDao.Adicionar(leilao);

        public void FinalizarLeilao(int id)
        {
            throw new NotImplementedException();
        }

        public void IniciarLeilao(int id)
        {
            var leilao = _leilaoDao.Obter(id);

            if (leilao == null)
                throw new NullReferenceException();

            if (leilao.Situacao != SituacaoLeilao.Rascunho)
                throw new InvalidOperationException();

            leilao.Situacao = SituacaoLeilao.Pregao;
            leilao.Inicio = DateTime.Now;

            _leilaoDao.Atualizar(leilao);
        }

        public IEnumerable<Categoria> ListarCategoria()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> ListarLeilao()
        {
            throw new NotImplementedException();
        }

        public Leilao ObterLeilao(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> PesquisarLeilao(string termo)
        {
            throw new NotImplementedException();
        }

        public void RemoverLeilao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
