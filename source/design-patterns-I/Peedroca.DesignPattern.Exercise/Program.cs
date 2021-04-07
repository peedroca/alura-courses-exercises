using Peedroca.DesignPattern.Exercise.AposGerarNota;
using Peedroca.DesignPattern.Exercise.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new ItemDaNotaBuilder()
                .ComDescricao("Açucar")
                .ComValor(10)
                .Construir();

            var item2 = new ItemDaNotaBuilder()
                .ComDescricao("Arroz")
                .ComValor(20)
                .Construir();

            var builder = new NotaFiscalBuilder(new List<IAposGerarNota>(){ new EnviarPorEmail(), new GuardaNoBanco(), new Multiplicador(10) })
                .ComRazaoSocial("Peedroca")
                .ComObservacoes("obs da nota")
                .Com(item1)
                .Com(item2);

            var notaFiscal = builder.Construir();

            Console.WriteLine(notaFiscal.ValorBruto);
            Console.WriteLine(notaFiscal.Impostos);
            Console.ReadKey();
        }
    }
}
