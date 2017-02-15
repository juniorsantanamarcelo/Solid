using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid
{
    public  class EmailService : IEmailService
    {
 

        public  void EnviarEmail(string emailSend, string body, string title)
        {
            throw new System.NotImplementedException();
        }

        bool IEmailService.IsValid(string email)
        {
            return true;
        }

       

    }
}