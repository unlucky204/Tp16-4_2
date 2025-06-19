using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public class Casco : Equipo
    {
        public override void Equipar(Personaje personaje)
        {
            if (equipado == false)
            {
                personaje.Defensa += 5;
                equipado = true;
                Console.WriteLine("Casco equipado correctamente");
            }
            else
            {
                Console.WriteLine("el objeto  ya esta equipado");
            }
        }
        public override void Desequipar(Personaje personaje)
        {
            if (equipado == true)
            {
                personaje.Defensa -= 5;
                equipado = false;
            }
            else
            {
                Console.WriteLine("el objeto ya esta desequipado");
            }
        }
        public override string ToString()
        {
            return "Casco";
        }
    }
}
