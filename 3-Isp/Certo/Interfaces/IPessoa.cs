using System.Collections.Generic;

namespace Solid.Isp.Certo.Interfaces

{
    public interface IPessoa
    {
        string Nome { get; set; }
        IEnumerable<string> Telefones { get; set; }
        bool IsValid();
    }
}