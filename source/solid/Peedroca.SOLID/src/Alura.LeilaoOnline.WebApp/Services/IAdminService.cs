using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        void IniciarLeilao(int id);
        void FinalizarLeilao(int id);
        void RemoverLeilao(int id);
        void CriarLeilao(Leilao leilao);
        void AlterarLeilao(Leilao leilao);
        IEnumerable<Categoria> ListarCategoria();
        IEnumerable<Leilao> ListarLeilao();
        Leilao ObterLeilao(int id);
        IEnumerable<Leilao> PesquisarLeilao(string termo);
    }
}
