using Peedroca.DesignPattern.Decorator.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peedroca.DesignPattern.Decorator
{
    public sealed class ComparadorContas : IEqualityComparer<Conta>
    {
        public bool Equals(Conta x, Conta y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Conta obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
