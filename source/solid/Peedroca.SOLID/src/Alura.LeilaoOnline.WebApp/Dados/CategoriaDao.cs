using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class CategoriaDao
    {
        private AppDbContext _context;

        public CategoriaDao()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> Listar() =>
            _context.Categorias.ToList();
    }
}
