using Tp16_4_2;
Personaje personaje = new Personaje();
Console.WriteLine("Bienvenido");
Cargar(personaje);
Personaje personaje2 = new Personaje();
Cargar(personaje2);
Console.Clear();
PocionVida PocionVida = new PocionVida();
PocionMana PocionMana = new PocionMana();

while (true)
{
    Muestra(personaje);
    Muestra(personaje2);
    menu();
}

void menu()
{
    char op;
    Console.WriteLine("=====================================");
    Console.WriteLine("ingrese que accion quiere hacer");
    Console.WriteLine("1) Cambiar color");
    Console.WriteLine("2) Recibir daño");
    Console.WriteLine("3) Atacar");
    op = Char.Parse(Console.ReadLine());
    switch (op) 
    { 
        case'1':
            Console.WriteLine("=====================================");
            Console.WriteLine("ingrese nuevo color");
            string nuevoColor = Console.ReadLine();
            personaje.CambiarColor(nuevoColor);
            break;
        case '2':
            Console.WriteLine("=====================================");
            Console.WriteLine("ingrese el daño que va a recibir");
            int Daño = int.Parse(Console.ReadLine());
            personaje.RecibirDaño(Daño);
            break;
        case '3':
            Console.WriteLine("=====================================");
            Console.WriteLine("ingrese el a que pesonaje quiere atacar");
            Console.WriteLine("1) Objetivo");
            personaje.Atacar(personaje2);
            break;
        case '4':
            Console.WriteLine("1 - Poción De Vida / 2 - Poción De Maná");
            int op2 = int.Parse(Console.ReadLine());
            if (op2 == 1)
            {
                Console.WriteLine("Ingrese El Valor Mínimo Para La Vida");
                PocionVida.Minimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese El Valor Máximo Para La Vida");
                PocionVida.Maximo = int.Parse(Console.ReadLine());
                PocionVida.Usar(personaje);
            }
            else if (op2 == 2)
            {
                Console.WriteLine("Ingrese El Valor Mínimo Para El Maná");
                PocionMana.Minimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese El Valor Máximo Para El Maná");
                PocionMana.Maximo = int.Parse(Console.ReadLine());
                PocionMana.Usar(personaje);
            }
            break;
    }
}
void Cargar(Personaje personaje)
{
    Personaje Jugador = new Personaje();
    Jugador = personaje;
    Console.WriteLine("=====================================");
    Console.WriteLine("Ingrese los datos del jugador");
    Console.WriteLine("ingrese su color");
    Jugador.Color = Console.ReadLine();
    Console.WriteLine("ingrese su vida");
    Jugador.Vida = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su defensa");
    Jugador.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su fuerza");
    Jugador.Fuerza = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su mana");
    Jugador.Mana = int.Parse(Console.ReadLine());

}


void Muestra(Personaje personaje)
{
    Personaje Jugador = new Personaje();
    Jugador = personaje;
    Console.WriteLine($"==========================================");
    Console.WriteLine($"el color es {Jugador.Color}");
    Console.WriteLine($"la vida es {Jugador.Vida}");
    Console.WriteLine($"el defensa es {Jugador.Defensa}");
    Console.WriteLine($"el Fuerza es {Jugador.Fuerza}");
    Console.WriteLine($"el Mana es {Jugador.Mana}");
    Console.WriteLine($"el color es {Jugador.Color}");
}


