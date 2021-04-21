using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDaoEfCore : ICategoriaDao
    {
        private AppDbContext _context;

        public CategoriaDaoEfCore()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> Listar() =>
            _context.Categorias.ToList();
    }
}
