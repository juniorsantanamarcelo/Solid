using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Lsp
{
    public abstract class Cliente
    {
        public double ValorTotal { get; set; }
        public virtual double Disconto()
        {
            return ValorTotal;
        }
    }
}
