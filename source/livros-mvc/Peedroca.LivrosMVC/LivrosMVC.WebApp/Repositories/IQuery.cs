using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    interface IQuery<T>
    {
        IEnumerable<T> Get();
    }
}
