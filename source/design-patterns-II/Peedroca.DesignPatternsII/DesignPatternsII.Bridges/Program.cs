using DesignPatternsII.Bridges.Models;
using DesignPatternsII.Bridges.Models.Interfaces;
using System;

namespace DesignPatternsII.Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnviador enviador = new EnviadorEmail();
            IMensagem mensagem = new MensagemAdministrativa("Pedro");
            
            mensagem.Enviador = enviador;
            mensagem.Enviar();

            Console.ReadKey();
        }
    }
}
