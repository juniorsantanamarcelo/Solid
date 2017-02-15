using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid
{
    public interface IEmailService
    {
        void EnviarEmail(string emailSend, string body, string title);
        bool IsValid(string email);
    }
}