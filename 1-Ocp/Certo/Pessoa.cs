using System.Collections.Generic;
using System.Linq;

namespace Solid.Ocp.Certo
{
    public abstract class Pessoa
    {
        private IEmailService _emailService;
        public Pessoa(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public string Nome { get; set; }

        public string Email { get; set; }

        public IEnumerable<string> Telefones { get; set; }

        public virtual bool IsValid(){
            return !string.IsNullOrEmpty(Nome) && _emailService.IsValid() && Telefones.Any();
        }
        
    }
}