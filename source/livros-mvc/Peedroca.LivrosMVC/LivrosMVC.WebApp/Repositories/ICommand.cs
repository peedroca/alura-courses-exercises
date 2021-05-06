using System.Collections.Generic;

namespace LivrosMVC.WebApp.Repositories
{
    interface ICommand<T>
    {
        void Add(T obj);
    }
}
