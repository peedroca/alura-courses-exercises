using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersII.Exercise.Models
{
    public class ServicoSingleton
    {
        private static Servico servico = new Servico();

        public Servico Instance { get { return servico; } }
    }
}
