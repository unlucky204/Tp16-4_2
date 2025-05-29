using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public abstract class Pocion:Item
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }

        
    }
}
