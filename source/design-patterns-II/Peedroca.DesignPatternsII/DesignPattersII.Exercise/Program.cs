using DesignPattersII.Exercise.Factories;
using System;

namespace DesignPattersII.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new ConnectionFactory().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "select * from tabela";

            Console.WriteLine("Hello World!");
        }
    }
}
