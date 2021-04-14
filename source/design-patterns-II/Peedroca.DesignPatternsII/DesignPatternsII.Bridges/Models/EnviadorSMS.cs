using DesignPatternsII.Bridges.Models.Interfaces;
using System;

namespace DesignPatternsII.Bridges.Models
{
    class EnviadorSMS : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Mensagem enviado por sms.");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
