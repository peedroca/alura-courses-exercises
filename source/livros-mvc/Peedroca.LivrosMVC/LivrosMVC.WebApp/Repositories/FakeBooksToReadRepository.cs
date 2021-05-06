using LivrosMVC.WebApp.Entities;
using LivrosMVC.WebApp.Enums;
using System.Collections.Generic;
using System.Linq;

namespace LivrosMVC.WebApp.Repositories
{
    public sealed class FakeBooksToReadRepository : IBooksToReadRepository
    {
        public void Add(Book obj) =>
            FakeDB.AddNewBook(obj);

        public Book Get(int Id) =>
            FakeDB.Books.FirstOrDefault(w => w.Id == Id);

        public IEnumerable<Book> Get() =>
            FakeDB.Books
            .Where(w => w.Status == EStatus.ToRead)
            .ToList();
    }
}
