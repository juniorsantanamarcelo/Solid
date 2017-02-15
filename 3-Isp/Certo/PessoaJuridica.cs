using System;
using System.Collections.Generic;

using Solid.Isp.Certo.Interfaces;

namespace Solid.Isp.Certo

{
    public class PessoaJuridica:IPessoaJuridica
    {
        public string Nome { get; set; }
        public IEnumerable<string> Telefones { get; set; }
        public string Cnpj { get; set; }

        public bool IsValid()
        {
          //valida cnpj
          return true;
            
        }

    }
}
