using LivrosMVC.WebApp.Entities;
using LivrosMVC.WebApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosMVC.WebApp
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var routesBuilder = new RouteBuilder(app)
                .MapRoute("books/toread", GetBooksToRead)
                .MapRoute("books/read", GetBooksRead)
                .MapRoute("books/reading", GetBooksReading)
                .MapRoute("books/create/{name}/{autor}", CreateBook)
                .MapRoute("books/detail/{id:int}", GetBooksDetail)
                .Build();

            app.UseRouter(routesBuilder);
        }

        private Task GetBooksDetail(HttpContext context)
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

        private Task CreateBook(HttpContext context)
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

        public Task GetBooksToRead(HttpContext context)
        {
            IBooksToReadRepository booksToRead = new FakeBooksToReadRepository();

            return context.Response
                .WriteAsync("Livros para Ler\n\n" + string.Join("\n", booksToRead
                .Get()
                .Select(s => $"{s.Name} - {s.Autor}")
                .ToList()));
        }

        public Task GetBooksRead(HttpContext context)
        {
            IBooksReadRepository booksToRead = new FakeBooksReadRepository();

            return context.Response
                .WriteAsync("Livros lidos\n\n" + string.Join("\n", booksToRead
                .Get()
                .Select(s => $"{s.Name} - {s.Autor}")
                .ToList()));
        }

        public Task GetBooksReading(HttpContext context)
        {
            IBooksReadingRepository booksToRead = new FakeBooksReadingRepository();

            return context.Response
                .WriteAsync("Livros sendo lidos\n\n" + string.Join("\n", booksToRead
                .Get()
                .Select(s => $"{s.Name} - {s.Autor}")
                .ToList()));
        }
    }
}