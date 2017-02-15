using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Isp.Errado
{
 public   class PessoaFisica : IPessoa
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public IEnumerable<string> Telefones { get; set; }
        public void ValidaCpf()
        {
            //Valida Cpf
        }

        public void ValidaCnpj()
        {
            throw new NullReferenceException("Não possui Cnpj");
        }
    }
}
