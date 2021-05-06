using LivrosMVC.WebApp.Entities;

namespace LivrosMVC.WebApp.Repositories
{
    interface IBooksToReadRepository : IQuery<Book>, ICommand<Book>
    {
    }
}
