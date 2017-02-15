using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Lsp
{
    public class ClienteService
    {
        public IEnumerable<Cliente> Clientes = new List<Cliente>
        {
            new ClienteOuro {ValorTotal = 300},
            new ClientePrata() {ValorTotal = 200}
        };

        public double SomaTodos()
        {
          var valores=  Clientes.Select(x => x.Disconto()).Sum();

            return valores;
        }
    }
}
