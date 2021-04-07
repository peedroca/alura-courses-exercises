namespace Peedroca.DesignPattern.Exercise
{
    public class ItemDaNota
    {
        public ItemDaNota(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; private set; }

        public decimal Valor { get; private set; }
    }
}