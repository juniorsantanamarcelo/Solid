
using System.Collections.Generic;
using Solid.Isp.Certo.Interfaces;

namespace Solid.Isp.Certo
{
 public   class PessoaFisica:IPessoaFisica
    {
        public string Nome { get; set; }
        public IEnumerable<string> Telefones { get; set; }
        public string Cpf { get; set; }


        public bool IsValid()
        {
           //valida cpf e campos;
            return true;
        }

    }
}
