using LivrosMVC.WebApp.Entities;
using LivrosMVC.WebApp.HTML;
using LivrosMVC.WebApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosMVC.WebApp.Controllers
{
    public static class CreateController
    {
        public static Task AddBookRecord(HttpContext context)
        {
            IBooksToReadRepository booksToRead = new FakeBooksToReadRepository();

            booksToRead.Add(new Book()
            {
                Autor = Convert.ToString(context.Request.Form["autor"]),
                Name = Convert.ToString(context.Request.Form["title"]),
                Status = Enums.EStatus.ToRead
            });

            return context.Response.WriteAsync("Livro criado com sucesso!");
        }

        public static Task CreateBookRecord(HttpContext context)
        {
            var content = HTMLUtil.GetHTMLContent("formulario");
            return context.Response.WriteAsync(content);
        }

        public static Task CreateBook(HttpContext context)
        {
            IBooksToReadRepository booksToRead = new FakeBooksToReadRepository();

            booksToRead.Add(new Book()
            {
                Autor = Convert.ToString(context.GetRouteValue("autor")),
                Name = Convert.ToString(context.GetRouteValue("name")),
                Status = Enums.EStatus.ToRead
            });

            return context.Response.WriteAsync("Livro criado com sucesso!");
        }
    }
}
