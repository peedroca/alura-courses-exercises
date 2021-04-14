using DesignPatternsII.Bridges.Models.Interfaces;
using System;

namespace DesignPatternsII.Bridges.Models
{
    class EnviadorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Mensagem enviado por email.");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
