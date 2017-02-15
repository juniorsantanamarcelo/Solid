using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Isp.Errado
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Cnpj { get; set; }
        string Cpf { get; set; }
        IEnumerable<string> Telefones { get; set; }
        void ValidaCpf();
        void ValidaCnpj();

    }
}
