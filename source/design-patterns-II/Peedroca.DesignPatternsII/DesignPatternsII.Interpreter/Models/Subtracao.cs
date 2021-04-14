using DesignPatternsII.Interpreter.Interfaces;

namespace DesignPatternsII.Interpreter.Models
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.Imprimir(this);
        }

        public int Avalia()
        {
            return Esquerda.Avalia() - Direita.Avalia();
        }
    }
}
