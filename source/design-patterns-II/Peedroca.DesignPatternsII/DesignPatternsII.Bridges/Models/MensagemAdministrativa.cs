using DesignPatternsII.Bridges.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Bridges.Models
{
    class MensagemAdministrativa : IMensagem
    {
        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public IEnviador Enviador { get; set; }

        public void Enviar()
        {
            Enviador.Enviar(this);
        }

        public string Formatar() =>
            string.Format("Mensagem enviado para administrador {0}", Nome);
    }
}
