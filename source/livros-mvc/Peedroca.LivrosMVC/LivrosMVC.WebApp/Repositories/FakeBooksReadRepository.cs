using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    public sealed class FakeBooksReadRepository : IBooksRepository
    {
        public IEnumerable<string> Get()
        {
            var response = new List<string>()
            {
                "1984 - George Orwell.",
                "Dom Casmurro - Machado de Assis.",
                "O Conde de Monte Cristo - Alexandre Dumas."
            };

            return response;
        }
    }
}
