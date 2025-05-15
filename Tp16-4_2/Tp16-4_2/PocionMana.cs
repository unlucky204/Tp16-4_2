﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public class PocionMana : Pocion
    {
        public override int Usar(Personaje personaje)
        {
            int ManaRestaurado = 0;
            if (personaje.Mana < personaje.ManaMax)
            {
                Random random = new Random();
                int NumeroRandom = random.Next(Minimo, Maximo);
                ManaRestaurado = personaje.Mana + NumeroRandom;
                if (ManaRestaurado > personaje.ManaMax)
                {
                    ManaRestaurado = personaje.ManaMax;
                }
            }
            personaje.Mana = ManaRestaurado;
            return ManaRestaurado;
        }
    }
}
