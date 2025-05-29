using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public abstract class Item
    {
        public int Id { get; set; }

        public abstract int Usar(Personaje Jugador);
    }
}
