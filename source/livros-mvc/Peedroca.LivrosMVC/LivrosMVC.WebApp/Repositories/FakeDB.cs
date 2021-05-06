using LivrosMVC.WebApp.Entities;
using LivrosMVC.WebApp.Enums;
using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    public static class FakeDB
    {
        private static List<Book> _books = new List<Book>()
        {
            new Book() { Id = 1, Name = "Orgulho e Preconceito", Autor = "Jane Austen.", Status = EStatus.Read },
            new Book() { Id = 2, Name = "1984", Autor = "George Orwell.", Status = EStatus.Read },
            new Book() { Id = 3, Name = "Dom Quixote de la Mancha", Autor = "Miguel de Cervantes.", Status = EStatus.Read },
            new Book() { Id = 4, Name = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry.", Status = EStatus.Reading },
            new Book() { Id = 5, Name = "Dom Casmurro", Autor = "Machado de Assis.", Status = EStatus.ToRead },
            new Book() { Id = 6, Name = "O Bandolim do Capitão Corelli", Autor = "Louis de Bernières.", Status = EStatus.ToRead },
            new Book() { Id = 7, Name = "O Conde de Monte Cristo", Autor = "Alexandre Dumas.", Status = EStatus.ToRead },
            new Book() { Id = 8, Name = "Um Estudo em Vermelho", Autor = "Arthur Conan Doyle.", Status = EStatus.ToRead },
        };

        public static IReadOnlyCollection<Book> Books { get { return _books.AsReadOnly(); } }

        public static void AddNewBook(Book newBook) => _books.Add(newBook);
    }
}
