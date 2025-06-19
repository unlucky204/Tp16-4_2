using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    internal interface Iequipable
    {
        public abstract void Equipar(Personaje personaje);

        public abstract void Desequipar(Personaje personaje);
        

    }
}
