using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Decorator.Modelos
{
    public sealed class Conta
    {
        public Conta()
        {
            Id = Guid.NewGuid();
            Abertura = DateTime.Now;
        }
        
        public Conta(double saldo, DateTime abertura)
        {
            Id = Guid.NewGuid();
            Saldo = saldo;
            Abertura = abertura;
        }

        /// <summary>
        /// Identificação da Conta
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Saldo
        /// </summary>
        public double Saldo { get; set; }

        /// <summary>
        /// Data de abertura
        /// </summary>
        public DateTime Abertura { get; set; }
    }
}
