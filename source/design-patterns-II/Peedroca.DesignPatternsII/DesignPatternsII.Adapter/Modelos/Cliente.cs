using System;
namespace DesignPatternsII.Adapter.Modelos
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(string nome, string endereco, DateTime aniversario)
        {
            Nome = nome;
            Endereco = endereco;
            Aniversario = aniversario;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime Aniversario { get; set; }
    }
}
