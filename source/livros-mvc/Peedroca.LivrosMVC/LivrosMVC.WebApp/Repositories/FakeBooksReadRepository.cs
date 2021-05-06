using LivrosMVC.WebApp.Entities;
using LivrosMVC.WebApp.Enums;
using System.Collections.Generic;
using System.Linq;

namespace LivrosMVC.WebApp.Repositories
{
    public sealed class FakeBooksReadRepository : IBooksReadRepository
    {
        public IEnumerable<Book> Get() =>
            FakeDB.Books
            .Where(w => w.Status == EStatus.Read)
            .ToList();

        public Book Get(int Id) =>
            FakeDB.Books.FirstOrDefault(w => w.Id == Id);
    }
}
