using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Spr.Certo
{
    public class FileLogger
    {
        public static void Handle(string handler)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", handler);

        }
    }
}
