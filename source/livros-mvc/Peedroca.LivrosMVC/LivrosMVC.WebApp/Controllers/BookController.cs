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
    public class BookController
    {
        public static Task GetBooksDetail(HttpContext context)
        {
            int id = Convert.ToInt32(context.GetRouteValue("id"));

            IBooksAllRepository booksAll = new FakeBooksAllRepository();
            var book = booksAll.Get(id);

            if (book == null)
            {
                context.Response.StatusCode = 404;
                return context.Response.WriteAsync("Livro não encontrado.");
            }

            var response = new StringBuilder()
                .AppendLine(" Detalhes do Livro ")
                .AppendLine(" ========================== ")
                .AppendLine($" Identificação: {book.Id} ")
                .AppendLine($" Nome: {book.Name} ")
                .AppendLine($" Autor: {book.Autor} ");

            return context.Response.WriteAsync(response.ToString());
        }

        public static Task GetBooksToRead(HttpContext context)
        {
            IBooksToReadRepository booksToRead = new FakeBooksToReadRepository();
            var content = HTMLUtil.GetHTMLContent("toread");

            foreach (var book in booksToRead.Get())
            {
                content = content.Replace("#NEWITEM#", $"<li>{book.Autor} - {book.Name}</li>#NEWITEM#");
            }

            content = content.Replace("#NEWITEM#", string.Empty);

            return context.Response.WriteAsync(content);
        }

        public static Task GetBooksRead(HttpContext context)
        {
            IBooksReadRepository booksToRead = new FakeBooksReadRepository();

            return context.Response
                .WriteAsync("Livros lidos\n\n" + string.Join("\n", booksToRead
                .Get()
                .Select(s => $"{s.Name} - {s.Autor}")
                .ToList()));
        }

        public string Reading()
        {
            IBooksReadingRepository booksToRead = new FakeBooksReadingRepository();

            return "Livros sendo lidos\n\n" + string.Join("\n", booksToRead
                .Get()
                .Select(s => $"{s.Name} - {s.Autor}")
                .ToList());
        }
    }
}
