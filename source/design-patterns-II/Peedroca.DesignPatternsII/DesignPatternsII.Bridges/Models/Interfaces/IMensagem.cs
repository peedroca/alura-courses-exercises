using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Bridges.Models.Interfaces
{
    interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Enviar();
        string Formatar();
    }
}
