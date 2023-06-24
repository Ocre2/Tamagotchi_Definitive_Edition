using Tamagotchi_Definitive_Edition;


bool salir = false;
while (!salir)
{
    Console.WriteLine("¡Bienvenido a tu Tamagotchi!");

    Console.Write("Ingresa el nombre de tu Tamagotchi: ");
    string nombre = Console.ReadLine();

    Tamagotchi miTamagotchi = new Tamagotchi(nombre);
    miTamagotchi.MostrarAnimacionTamagorchi();




    while (!miTamagotchi.Isdead())
    {


        Console.WriteLine("------------");
        Console.WriteLine("Hambre :" + miTamagotchi.Hambre);
        Console.WriteLine("Sed :" + miTamagotchi.Sed);
        Console.WriteLine("Aburrimiento :" + miTamagotchi.Aburrimiento);
        Console.WriteLine("Energia :" + miTamagotchi.Energia);
        Console.WriteLine("------------");

        Console.WriteLine("\nElige una acción:");
        Console.WriteLine("1. Alimentar");
        Console.WriteLine("2. Dar de beber");
        Console.WriteLine("3. Jugar");
        Console.WriteLine("4. Dormir");
        Console.WriteLine("5. Pasar el tiempo");
        Console.WriteLine("6. Salir");

        Console.Write("Opción: ");
        string opcion = Console.ReadLine();



        switch (opcion)
        {
            case "1": Eat(); break;
            case "2": Drink(); break;
            case "3": Play(); break;
            case "4": Sleep(); break;
            case "5": HangOut(); break;
            case "6": GoOut(); return;
            default: Console.WriteLine("Opción inválida. Intenta de nuevo."); break;
        }
        Console.Clear();

        miTamagotchi.Cansancio();
        miTamagotchi.Aburrirse();
        miTamagotchi.Sediento();
        miTamagotchi.Hambiento();

        if (miTamagotchi.Isdead())
        {
            Console.WriteLine("Tu Tamagotchi ha muerto. ¿Deseas crear un nuevo Tamagotchi? (s/n)");

            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                salir = true;
                break;
            }

        }
    }


    void Eat()
    {
        miTamagotchi.MostrarAnimacionComer();
        miTamagotchi.Alimentar();

    }

    void Drink()
    {
        miTamagotchi.MostrarAnimacionBeber();
        miTamagotchi.Beber();

    }
    void Play()
    {
        miTamagotchi.MostrarAnimacionJugar();
        miTamagotchi.Jugar();

    }

    void Sleep()
    {
        miTamagotchi.MostrarAnimacionDormir();
        miTamagotchi.Dormir();

    }
    void HangOut()
    {
        miTamagotchi.MostrarAnimacionPasarElTiempo();
        miTamagotchi.PasarTiempo();

    }
    void GoOut()
    {
        Console.WriteLine("¡Hasta luego!");
    }
}

