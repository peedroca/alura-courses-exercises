using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        Leilao Obter(long id);
        IIncludableQueryable<Leilao, Categoria> Listar();
        void Adicionar(Leilao leilao);
        void Atualizar(Leilao leilao);
        void Deletar(Leilao leilao);
    }
}
