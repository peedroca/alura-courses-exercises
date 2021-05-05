using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    public sealed class FakeBooksToReadRepository : IBooksRepository
    {
        public IEnumerable<string> Get()
        {
            var response = new List<string>()
            {
                "Orgulho e Preconceito - Jane Austen.",
                "1984 - George Orwell.",
                "Dom Quixote de la Mancha - Miguel de Cervantes.",
                "O Pequeno Príncipe - Antoine de Saint-Exupéry.",
                "Dom Casmurro - Machado de Assis.",
                "O Bandolim do Capitão Corelli -Louis de Bernières.",
                "O Conde de Monte Cristo - Alexandre Dumas.",
                "Um Estudo em Vermelho -Arthur Conan Doyle."
            };

            return response;
        }
    }
}
