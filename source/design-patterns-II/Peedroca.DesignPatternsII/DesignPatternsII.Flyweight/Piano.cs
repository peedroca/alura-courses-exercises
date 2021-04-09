using DesignPatternsII.Flyweight.Notas;
using System;
using System.Collections.Generic;

namespace DesignPatternsII.Flyweight
{
    public class Piano
    {
        public void Toca(List<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 100);
            }
        }
    }
}
