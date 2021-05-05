using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoEfCore : ILeilaoDao
    {
        private AppDbContext _context;

        public LeilaoDaoEfCore(AppDbContext context)
        {
            _context = context;
        }

        public Leilao Obter(long id) =>
            _context.Leiloes.Find(id);

        public IIncludableQueryable<Leilao, Categoria> Listar() =>
            _context.Leiloes.Include(l => l.Categoria);

        public void Adicionar(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Atualizar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Deletar(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
