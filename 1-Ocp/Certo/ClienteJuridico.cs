namespace Solid.Ocp.Certo
{
    public class ClienteJuridico : Pessoa
    {
        public ClienteJuridico(IEmailService emailService):base(emailService)
        {
            
        }
        public ICnpj Cnpj { get; set; }

        public override bool IsValid(){
            return base.IsValid() && Cnpj.IsValid();
        }
    }
}