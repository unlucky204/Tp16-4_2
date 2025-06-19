using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public class PocionVida : Pocion
    {
        
        public override int Usar(Personaje personaje)
        {
            
            int VidaRestaurada = 0;
            if (personaje.Vida < personaje.VidaMax)
            {
                Random random = new Random();
                int NumeroRandom = random.Next(Minimo, Maximo);
                VidaRestaurada = personaje.Vida + NumeroRandom;
                if (VidaRestaurada > personaje.VidaMax)
                {
                    VidaRestaurada = personaje.VidaMax;
                }
                personaje.Vida = VidaRestaurada;
            }
            Console.WriteLine($"Vida restaurada: {VidaRestaurada}");
            return VidaRestaurada;
        }
        public override string ToString()
        {

           return "Pocion de vida";
            
        }
    }
}
