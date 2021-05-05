using LivrosMVC.WebApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrosMVC.WebApp
{
    internal class Startup
    {
        public void Configure(IApplicationBuilder builder)
        {
            builder.Run(Routing);
        }

        public Task Routing(HttpContext context)
        {
            var routes = new Dictionary<string, RequestDelegate>()
            {
                { "/books/toread", GetBooksToRead },
                { "/books/read", GetBooksRead },
                { "/books/reading", GetBooksReading }
            };

            var path = Convert.ToString(context.Request.Path).ToLower();

            if (routes.ContainsKey(path))
            {
                var requestDelegate = routes[path];
                return requestDelegate.Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Rota não encontrada.");
        }

        public Task GetBooksToRead(HttpContext context)
        {
            IBooksRepository booksToRead = new FakeBooksToReadRepository();

            return context.Response
                .WriteAsync("Livros para Ler\n\n" + string.Join("\n", booksToRead.Get()));
        }

        public Task GetBooksRead(HttpContext context)
        {
            IBooksRepository booksToRead = new FakeBooksReadRepository();

            return context.Response
                .WriteAsync("Livros lidos\n\n" + string.Join("\n", booksToRead.Get()));
        }

        public Task GetBooksReading(HttpContext context)
        {
            IBooksRepository booksToRead = new FakeBooksReadingRepository();

            return context.Response
                .WriteAsync("Livros sendo lidos\n\n" + string.Join("\n", booksToRead.Get()));
        }
    }
}