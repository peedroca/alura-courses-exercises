using Peedroca.DesignPattern.State.Modelos;
using System;

namespace Peedroca.DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(300);
            conta.Sacar(300);
            conta.Depositar(100);

            Console.WriteLine(conta.Saldo);
            Console.ReadKey();
        }
    }
}
