using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersII.Exercise.Models
{
    public sealed class Historico
    {
        private IList<Estado> Estados;

        public Historico()
        {
            Estados = new List<Estado>();
        }

        public void Adicionar(Estado estado) =>
            Estados.Add(estado);

        public Estado Pegar(int index) =>
            Estados[index];
    }
}
