using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    interface IQuery<T>
    {
        IEnumerable<T> Get();
        T Get(int Id);
    }
}
