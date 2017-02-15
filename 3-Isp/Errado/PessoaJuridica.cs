using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Isp.Errado
{
   public class PessoaJuridica:IPessoa
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public IEnumerable<string> Telefones { get; set; }
        public void ValidaCpf()
        {
            throw new NullReferenceException("Não possui Cpf");
        }

        public void ValidaCnpj()
        {
           //valida Cnpj
        }
    }
}
