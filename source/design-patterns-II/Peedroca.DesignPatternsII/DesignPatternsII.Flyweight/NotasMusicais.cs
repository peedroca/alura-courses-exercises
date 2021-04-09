using DesignPatternsII.Flyweight.Notas;
using System.Collections.Generic;

namespace DesignPatternsII.Flyweight
{
    public class NotasMusicais
    {
        private static Dictionary<string, INota> _notas = new Dictionary<string, INota>()
        {
            { "do", new Do() } ,
            { "re", new Re() } ,
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

        public INota Pegar(string nome) => _notas[nome];
    }
}
