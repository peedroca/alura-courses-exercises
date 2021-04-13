using DesignPattersII.Exercise.Factories;
using DesignPattersII.Exercise.Models;
using System;
using System.Collections.Generic;

namespace DesignPattersII.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var historico = new Historico();
            var contrato = new Contrato(DateTime.Now, "Pedro", Enums.ETipoContrato.Novo);
            historico.Adicionar(contrato.SalvarEstado());

            Console.ReadKey();
        }
    }
}
