using DesignPattersII.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersII.Exercise.Models
{
    public sealed class Contrato
    {
        public Contrato(DateTime criado, string cliente, ETipoContrato tipoContrato)
        {
            Criado = criado;
            Cliente = cliente;
            TipoContrato = tipoContrato;
        }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime Criado { get; private set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Cliente { get; private set; }

        /// <summary>
        /// Tipo do contrato
        /// </summary>
        public ETipoContrato TipoContrato { get; private set; }

        public void Avancar()
        {
            if (TipoContrato == ETipoContrato.Novo) TipoContrato = ETipoContrato.EmAndamento;
            else if (TipoContrato == ETipoContrato.EmAndamento) TipoContrato = ETipoContrato.Acertado;
            else if (TipoContrato == ETipoContrato.Acertado) TipoContrato = ETipoContrato.Concluido;
        }

        public Estado SalvarEstado()
        {
            return new Estado(new Contrato(Criado, Cliente, TipoContrato));
        }
    }
}
