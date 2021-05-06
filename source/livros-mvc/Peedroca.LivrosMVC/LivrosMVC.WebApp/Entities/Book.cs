using LivrosMVC.WebApp.Enums;

namespace LivrosMVC.WebApp.Entities
{
    public sealed class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public EStatus Status { get; set; }
    }
}
