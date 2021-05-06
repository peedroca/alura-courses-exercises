using LivrosMVC.WebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosMVC.WebApp.Repositories
{
    class FakeBooksAllRepository : IBooksAllRepository
    {
        public IEnumerable<Book> Get() =>
            FakeDB.Books;

        public Book Get(int id) =>
            FakeDB.Books.FirstOrDefault(f => f.Id == id);
    }
}
