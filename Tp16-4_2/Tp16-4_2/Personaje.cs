using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public class Personaje
    {
        //public Personaje(string color, int vida, int defensa, int fuerza, 
        //    int mana)
        //{
        //    Color = color;
        //    Vida = vida;
        //    Defensa = defensa;
        //    Fuerza = fuerza;
        //    Mana = mana;
        //    Dmg = false;
        //}

        public string Color { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }
        public bool Dmg { get; set; }

       
        public void CambiarColor(string nuevoColor)
        { 
            if (nuevoColor != Color)
            {
                Color = nuevoColor;
            }
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
        public bool Atacar(Personaje objetivo)
        {

            if (Mana >= 0)
            {
                int daño = Fuerza;
                Mana--;
                objetivo.RecibirDaño(daño);
                Dmg = true;
            }
            else
            {
                Dmg = false;
            }
            return Dmg;
        }
      
    }
}
