using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Lsp
{
  public  class ClientePrata : Cliente
    {
        public override double Disconto()
        {
            return ValorTotal - 50;
        }
    }
}
