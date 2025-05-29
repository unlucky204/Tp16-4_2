using Tp16_4_2;

List<Personaje> Personajes = new List<Personaje>();
Console.WriteLine("Bienvenido");
Cargar();
Cargar();

while (true)
{
    Console.Clear();
    Muestra(Personajes.ElementAt(0));
    Muestra(Personajes.ElementAt(1));
    menu();
}

void menu()
{
    Personaje personaje = Personajes.ElementAt(0);
    char op;
    Console.WriteLine("=====================================");
    Console.WriteLine("ingrese que accion quiere hacer");
    Console.WriteLine("1) Cambiar color");
    Console.WriteLine("2) Recibir daño");
    Console.WriteLine("3) Atacar");
    Console.WriteLine("4) inventario");
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
            personaje.Atacar(personaje);
            break;
        case '4':
            
            Console.WriteLine("Que pesonaje quiere usar la pocion");
            Console.WriteLine("1) Personaje 1");
            Console.WriteLine("2) Personaje 2");
            char opP = Char.Parse(Console.ReadLine());
            switch (opP)
            {
                case '1':
                    personaje = Personajes.ElementAt(0);
                    break;
                case '2':
                    personaje = Personajes.ElementAt(1);
                    break;
            }
            Console.WriteLine("Que pocion quiere usar");
            Console.WriteLine("1 - Poción De Vida / 2 - Poción De Maná");
            int op2 = int.Parse(Console.ReadLine());
            switch (op2)
            {
                case 1:
                    {
                        PocionVida PocionVida = new PocionVida();
                        if (personaje.inventario.ItemList.Contains(PocionVida))
                        {
                            PocionVida.Usar(personaje);
                            personaje.inventario.borrarItem(PocionVida);
                        }
                        else
                        {
                            Console.WriteLine("No hay pociones de vida");
                        }
                    }
                    break;
                case 2:
                    {
                        PocionMana PocionMana = new PocionMana();
                        if (personaje.inventario.ItemList.Contains(PocionMana))
                        {
                           
                            PocionMana.Usar(personaje);
                            personaje.inventario.borrarItem(PocionMana);
                        }
                        else
                        {
                            Console.WriteLine("No hay pociones de mana");
                        }
                    }
                    break;
            }
        
         break;

    }
}


void Cargar()
{
    Personaje Personaje = new Personaje();
    PocionVida PocionVida = new PocionVida();
    PocionMana PocionMana = new PocionMana();
    Console.WriteLine("=====================================");
    Console.WriteLine("Ingrese los datos del jugador");
    Console.WriteLine("ingrese su color");
    Personaje.Color = Console.ReadLine();
    Console.WriteLine("ingrese su vida");
    Personaje.Vida = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su defensa");
    Personaje.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su fuerza");
    Personaje.Fuerza = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su mana");
    Personaje.Mana = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese El Valor Mínimo Para El Maná");
    PocionMana.Minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese El Valor Máximo Para El Maná");
    PocionMana.Maximo = int.Parse(Console.ReadLine());
    Console.WriteLine("Añadida una pocion de mana");
    Personaje.inventario.AñadirItem(PocionMana);
    Console.WriteLine("Ingrese El Valor Mínimo Para La Vida");
    PocionVida.Minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese El Valor Máximo Para La Vida");
    PocionVida.Maximo = int.Parse(Console.ReadLine());
    Console.WriteLine("Añadida una pocion de Vida");
    Personaje.inventario.AñadirItem(PocionVida);
    Console.WriteLine("Añadida una pocion de mana");
    Personaje.inventario.AñadirItem(PocionMana);
    Personaje.ManaMax = Personaje.Mana;
    Personaje.VidaMax = Personaje.Vida;
    Personajes.Add(Personaje);
    Console.WriteLine($"Jugador {Personajes.} creado correctamente");
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
    foreach (var i in personaje.inventario.ItemList)
    {
        Console.WriteLine($"-{i.ToString()}");
    }
}


