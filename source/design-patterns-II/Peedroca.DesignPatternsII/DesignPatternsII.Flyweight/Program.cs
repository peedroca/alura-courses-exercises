using DesignPatternsII.Flyweight.Notas;
using System;
using System.Collections.Generic;

namespace DesignPatternsII.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var notasMusicais = new NotasMusicais();

            List<INota> notas = new List<INota>()
            {
                notasMusicais.Pegar("do"),
                notasMusicais.Pegar("re"),
                notasMusicais.Pegar("mi"),
                notasMusicais.Pegar("fa"),
                notasMusicais.Pegar("fa"),
                notasMusicais.Pegar("fa"),

                notasMusicais.Pegar("do"),
                notasMusicais.Pegar("re"),
                notasMusicais.Pegar("do"),
                notasMusicais.Pegar("re"),
                notasMusicais.Pegar("re"),
                notasMusicais.Pegar("re"),

                notasMusicais.Pegar("do"),
                notasMusicais.Pegar("sol"),
                notasMusicais.Pegar("fa"),
                notasMusicais.Pegar("mi"),
                notasMusicais.Pegar("mi"),
                notasMusicais.Pegar("mi"),

                notasMusicais.Pegar("do"),
                notasMusicais.Pegar("re"),
                notasMusicais.Pegar("mi"),
                notasMusicais.Pegar("fa"),
                notasMusicais.Pegar("fa"),
                notasMusicais.Pegar("fa"),
            };

            new Piano().Toca(notas);
            Console.ReadKey();
        }
    }
}
