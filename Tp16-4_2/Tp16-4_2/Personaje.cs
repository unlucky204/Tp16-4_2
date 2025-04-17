using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    internal class Personaje
    {
        public string Color { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }

        public int DañoHecho { get; set; }

        public void Cargar ()
        {
            Console.WriteLine("ingrese su color");
            Color = Console.ReadLine();
            Console.WriteLine("ingrese su vida");
            Vida = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su defensa");
            Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su fuerza");
            Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su mana");
            Mana = int.Parse(Console.ReadLine());
        }
        public void CambiarColor(string nuevoColor)
        { 
            Color = nuevoColor;
        }

        public int RecibirDaño(int daño)
        {
            int dañoRecibido = daño;
            dañoRecibido = dañoRecibido - Defensa;
            if (dañoRecibido < 0)
            {
                dañoRecibido = 0;
            }
            Vida = Vida - dañoRecibido;
            return dañoRecibido;
        }
        public int Atacar(Personaje objetivo)
        {

            if (Mana >= 0)
            {
                int daño = Fuerza;
                Mana--;
                objetivo.RecibirDaño(daño);
            }
            else
            {
                DañoHecho = 0;
            }
            return DañoHecho;
        }
        public void muestra() 
        {
            Console.WriteLine($"el color es{Color}");
            Console.WriteLine($"la vida es{Vida}");
            Console.WriteLine($"el defensa es{Defensa}");
            Console.WriteLine($"el Fuerza es{Fuerza}");
            Console.WriteLine($"el Mana es{Mana}");
            Console.WriteLine($"el color es{Color}");
        }
    }
}
