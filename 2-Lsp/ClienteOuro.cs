using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Lsp;

namespace Solid.Lsp
{
    public class ClienteOuro: Cliente
    {
        public override double Disconto()
        {
            return ValorTotal - 100;
        }
    }
}
