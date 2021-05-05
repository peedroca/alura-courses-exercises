using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    public sealed class FakeBooksReadingRepository : IBooksRepository
    {
        public IEnumerable<string> Get()
        {
            var response = new List<string>()
            {
                "O Bandolim do Capitão Corelli -Louis de Bernières.",
                "Um Estudo em Vermelho -Arthur Conan Doyle."
            };

            return response;
        }
    }
}
