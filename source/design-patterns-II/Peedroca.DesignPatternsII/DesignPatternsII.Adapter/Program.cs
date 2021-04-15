using DesignPatternsII.Adapter.Modelos;
using System;

namespace DesignPatternsII.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Pedro", "Av 1", new DateTime(2001, 02, 19));
            var xml = GeradorDeXML.Gerar(cliente);

            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
