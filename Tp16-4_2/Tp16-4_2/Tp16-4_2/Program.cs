using Tp16_4_2;

List<Personaje> Personajes = new List<Personaje>();
PocionVida PocionVida = new PocionVida();
PocionMana PocionMana = new PocionMana();
Espada espada = new Espada();
Chaleco chaleco = new Chaleco();
Casco casco = new Casco();
Console.WriteLine("Bienvenido");
Cargar();
Cargar();

while (true)
{
    
    Muestra(Personajes.ElementAt(0));
    Muestra(Personajes.ElementAt(1));
    menu(Personajes.ElementAt(0));
}

void menu(Personaje personaje)
{
    char op;
    Console.WriteLine("=====================================");
    Console.WriteLine("ingrese que accion quiere hacer");
    Console.WriteLine("1) Cambiar color");
    Console.WriteLine("2) Recibir daño");
    Console.WriteLine("3) Atacar");
    Console.WriteLine("4) Inventario");
    op = Char.Parse(Console.ReadLine());
    switch (op)
    {
        case '1':
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
            Console.WriteLine("1- Usar item");
            Console.WriteLine("2- Equipar item");
            Console.WriteLine("3- Desequipar item");
            char op2 = char.Parse(Console.ReadLine());
            switch (op2)
            {
                case '1':
                    Console.WriteLine("que pocion quiere usar");
                    Console.WriteLine("1) Pocion de vida");
                    Console.WriteLine("2) Pocion de mana");
                    int op3 = int.Parse(Console.ReadLine());
                    switch (op3)
                    {
                        case 1:
                            {
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
                case '2':
                    Console.WriteLine("que item quiere equipar");
                    Console.WriteLine("1) Chaleco");
                    Console.WriteLine("2) Espada");
                    Console.WriteLine("3) Casco");
                    int op4 = int.Parse(Console.ReadLine());
                    switch (op4)
                    {
                        case 1:
                            {
                                if (personaje.inventario.ItemList.Contains(chaleco))
                                {
                                    chaleco.Equipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay chaleco en el inventario");
                                }
                            }
                            break;
                        case 2:
                            {
                                if (personaje.inventario.ItemList.Contains(espada))
                                {
                                    espada.Equipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay espada en el inventario");
                                }
                            }
                            break;
                        case 3:
                            {
                                if (personaje.inventario.ItemList.Contains(casco))
                                {
                                    casco.Equipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay casco en el inventario");
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case '3':
                    Console.WriteLine("que item quiere desequipar");
                    Console.WriteLine("1) Chaleco");
                    Console.WriteLine("2) Espada");
                    Console.WriteLine("3) Casco");
                    int op5 = int.Parse(Console.ReadLine());
                    switch (op5)
                    {
                        case 1:
                            {
                                if (personaje.inventario.ItemList.Contains(chaleco))
                                {
                                    chaleco.Desequipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay chaleco en el inventario");
                                }
                            }
                            break;
                        case 2:
                            {
                                if (personaje.inventario.ItemList.Contains(espada))
                                {
                                    espada.Desequipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay espada en el inventario");
                                }
                            }
                            break;
                        case 3:
                            {
                                if (personaje.inventario.ItemList.Contains(casco))
                                {
                                    casco.Desequipar(personaje);
                                }
                                else
                                {
                                    Console.WriteLine("No hay casco en el inventario");
                                }
                            }
                            break;
                        default:
                            break;
                            

                    }
                 break;
            }
            break;
    }
}


    void Cargar()
    {
        Personaje Personaje = new Personaje();
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
        Personaje.inventario.AñadirItem(espada);
        Personaje.inventario.AñadirItem(chaleco);
        Personaje.inventario.AñadirItem(casco);
        Personaje.ManaMax = Personaje.Mana;
        Personaje.VidaMax = Personaje.Vida;
        Personajes.Add(Personaje);
        Console.WriteLine($"Jugador {Personaje.Color} creado correctamente");
    }


    void Muestra(Personaje personaje)
    {
        Personaje Jugador = new Personaje();
        Jugador = personaje;
        Console.WriteLine($"==========================================");
        Console.WriteLine($"el color es {Jugador.Color}");
        Console.WriteLine($"la vida es {Jugador.Vida} / {Jugador.VidaMax}");
        Console.WriteLine($"el defensa es {Jugador.Defensa}");
        Console.WriteLine($"el Fuerza es {Jugador.Fuerza}");
        Console.WriteLine($"el Mana es {Jugador.Mana} / {Jugador.ManaMax}");
        foreach (var i in personaje.inventario.ItemList)
        {
            Console.WriteLine($"-{i.ToString()}");
        }
    }


