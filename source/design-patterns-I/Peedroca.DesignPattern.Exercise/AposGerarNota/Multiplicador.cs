using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Exercise.AposGerarNota
{
    public class Multiplicador : IAposGerarNota
    {
        public decimal Fator { get; private set; }

        public Multiplicador(decimal fator)
        {
            Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}
