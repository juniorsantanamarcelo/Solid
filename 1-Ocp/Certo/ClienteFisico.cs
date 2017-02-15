namespace Solid.Ocp.Certo
{
    public class ClienteFisico :Pessoa
    {
        public ClienteFisico(IEmailService emailService) : base(emailService)
        {
        }

        public ICpf Cpf { get; set; }

        public override bool IsValid(){
            return base.IsValid() && Cpf.IsValid();
        }
      
    }
}   