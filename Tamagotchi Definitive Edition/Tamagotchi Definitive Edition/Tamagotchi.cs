


namespace Tamagotchi_Definitive_Edition
{

    public class Tamagotchi
    {
        public int Hambre { get; private set; }
        public int Sed { get; private set; }
        public int Aburrimiento { get; private set; }
        public int Energia { get; private set; }
        public string Nombre { get; private set; }
        



        public Tamagotchi(string nombre)
        {
            Nombre = nombre;
            Hambre = 0;
            Sed = 0;
            Aburrimiento = 0;
            Energia = 100;

        }


        public void Alimentar()
        {

            Hambre -= 15;
            Sed += 5;
            Energia -= 5;
            Aburrimiento += 5;
            if (Hambre < 0)
            {
                Hambre = 0;
            }
           

        }

        public void Beber()
        {
            Sed -= 15;
            Hambre += 5;
            Energia -= 5;
            Aburrimiento += 5;
            if (Sed < 0)
            {
                Sed = 0;
            }
            if (Energia < 0)
            {
                Energia = 0;
            }
        }
        
        public void Jugar()
        {
            
            Aburrimiento -= 10;
            Hambre += 10;
            Sed += 10;
            Energia -= 25;
            if (Aburrimiento < 0)
            {
                Aburrimiento = 0;
            }
            if (Energia < 0)
            {
                Energia = 0;
            }
        }

        public void Dormir()
        {
            
            Energia = 100;
            Hambre += 5;
            Sed += 5;
            if (Energia > 100)
            {
                Energia = 100;
            }

        }
        public void PasarTiempo()
        {
           
            Hambre += 10;
            Sed += 10;
            Aburrimiento += 10;
            Energia -= 10;
            if (Energia < 0)
            {
                Energia = 0;
            }
        }
        public bool Isdead()
        {
            return Hambre == 100 || Energia == 0 || Sed == 100 || Aburrimiento == 100;
        }

        public void Hambiento()
        {
            if (Hambre > 50 && Hambre <= 79)
            {
                Console.WriteLine("Tú tamagotchi tiene hambre");
            }
            else if (Hambre >= 80 && Hambre <= 99)
            {
                Console.WriteLine("Tú tamagotchi tiene mucha hambre y está en estado crítico. ¡Dale de comer pronto!");
            }
            else if (Hambre == 100)
            {
                Console.Clear();
                Console.WriteLine("Tú tamagotchi ha muerto de hambre");
                
            }
        }


        public void Sediento()
        {
            if (Sed >= 50 && Sed < 80)
            {
                Console.WriteLine("Tú tamagotchi tiene sed");
            }
            else if (Sed >= 80 && Sed <= 99)
            {
                Console.WriteLine("Tú tamagotchi tiene mucha sed y está en estado crítico. ¡Dale de beber pronto!");
            }
            else if (Sed == 100)
            {
                Console.Clear();
                Console.WriteLine("Tú tamagotchi ha muerto de sed");
                
            }

        }

        public void Aburrirse()
        {

            if (Aburrimiento > 50 && Aburrimiento < 80)
            {
               
                Console.WriteLine("Tú tamagotchi está aburrido");
                
            }
            else if (Aburrimiento >= 80 && Aburrimiento <= 99)
            {
                Console.WriteLine("Tú tamagotchi está muy aburrido, juega con el");
            }
            else if (Aburrimiento == 100)
            {
                Console.Clear();
                Console.WriteLine("Tú tamagotchi se aburrió de ti y se fue con otro dueño");
                
            }

        }

        public void Cansancio()
        {
            if (Energia <= 50 && Energia > 30)
            {
                Console.WriteLine("Tú tamagochi se está cansando");
            }
            else if (Energia <= 30 && Energia >= 1)
            {
                Console.WriteLine("Tú tamagotchi está muy cansado. ¡Dejalo dormir!");
            }
            else if (Energia == 0)
            {
                Console.Clear();
                Console.WriteLine("Tú tamagotchi murió");
                
            }

        }


        public void MostrarAnimacionTamagorchi()
        {

            Console.WriteLine("Hola soy " + Nombre + " ¿que quieres hacer?");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( ^_^ )");
            Console.WriteLine("      /  -  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |    (o)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(500);

        }

        public void MostrarAnimacionComer()
        {
            Console.Clear();
            Console.WriteLine("Le haz dado de comer a " + Nombre);
            Console.WriteLine("Gracias por la comida");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( 0o0 )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (Y)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Le haz dado de comer a " + Nombre);
            Console.WriteLine("Gracias por la comida");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( ^v^ )");
            Console.WriteLine("      /  -  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |    (o)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Le haz dado de comer a " + Nombre);
            Console.WriteLine("Gracias por la comida");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( 0o0 )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (Y)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Le haz dado de comer a " + Nombre);
            Console.WriteLine("Gracias por la comida");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( ^v^ )");
            Console.WriteLine("      /  -  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |    (o)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);


        }

        public void MostrarAnimacionDormir()
        {
            Console.Clear();
            Console.WriteLine(Nombre + " Está durmiendo");
            Console.WriteLine("        /\\_/\\ Z"); 
            Console.WriteLine("       (-.- )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   ( z ) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está durmiendo");
            Console.WriteLine("        /\\_/\\ ZZ"); 
            Console.WriteLine("       (-.- )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   ( z ) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está durmiendo");
            Console.WriteLine("        /\\_/\\ ZZZ");
            Console.WriteLine("       (-.- )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   ( z ) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está durmiendo");
            Console.WriteLine("        /\\_/\\ ZZZZ");
            Console.WriteLine("       (-.- )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   ( z ) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
        }

        public void MostrarAnimacionJugar()
        {
            Console.Clear();
            Console.WriteLine(Nombre + " Está jugando con una pelota");
            Console.WriteLine("Que divertido");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( T.T )");
            Console.WriteLine("      /  -  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |    ( )  |");
            Console.WriteLine("     \\. ..  /--z 0");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está jugando con una pelota");
            Console.WriteLine("Que divertido");
            Console.WriteLine("           /\\_/\\");
            Console.WriteLine("          ( T.T )");
            Console.WriteLine("         /  -  \\");
            Console.WriteLine("        /  `---'\\");
            Console.WriteLine("       |    ( )  |");
            Console.WriteLine("  0 z--  \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está jugando con una pelota");
            Console.WriteLine("Que divertido");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( T.T )");
            Console.WriteLine("      /  -  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |    ( )  |");
            Console.WriteLine("     \\. ..  /--z 0");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(Nombre + " Está jugando con una pelota");
            Console.WriteLine("Que divertido");
            Console.WriteLine("           /\\_/\\");
            Console.WriteLine("          ( T.T )");
            Console.WriteLine("         /  -  \\");
            Console.WriteLine("        /  `---'\\");
            Console.WriteLine("       |    ( )  |");
            Console.WriteLine("  0 z--  \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1500);

        }
        public void MostrarAnimacionBeber()
        {
            Console.Clear();
            Console.WriteLine(Nombre + " Está tomando agua");
            Console.WriteLine("Gracias por darme agua");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( >.< )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (x_x) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está tomando agua");
            Console.WriteLine("Gracias por darme agua");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( 0w0 )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (x_x) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está tomando agua");
            Console.WriteLine("Gracias por darme agua");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( >.< )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (x_x) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está tomando agua");
            Console.WriteLine("Gracias por darme agua");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( 0w0 )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (x_x) |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
        }

        public void MostrarAnimacionPasarElTiempo()
        {
            Console.Clear();
            Console.WriteLine(Nombre + " Está caminando en su habitación");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( o.o )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (Y)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está caminando en su habitación");
            Console.WriteLine("          /\\_/\\");
            Console.WriteLine("         ( owo )");
            Console.WriteLine("        /  v  \\");
            Console.WriteLine("       /  `---'\\");
            Console.WriteLine("      |   (Y)  |");
            Console.WriteLine("       \\. ..  /");
            Console.WriteLine("       `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está caminando en su habitación");
            Console.WriteLine("             /\\_/\\");
            Console.WriteLine("            ( UwU)");
            Console.WriteLine("           /  v  \\");
            Console.WriteLine("          /  `---'\\");
            Console.WriteLine("         |   (Y)  |");
            Console.WriteLine("          \\. ..  /");
            Console.WriteLine("         `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está caminando en su habitación");
            Console.WriteLine("          /\\_/\\");
            Console.WriteLine("         ( owo )");
            Console.WriteLine("        /  v  \\");
            Console.WriteLine("       /  `---'\\");
            Console.WriteLine("      |   (Y)  |");
            Console.WriteLine("       \\. ..  /");
            Console.WriteLine("       `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(Nombre + " Está caminando en su habitación");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( o.o )");
            Console.WriteLine("      /  v  \\");
            Console.WriteLine("     /  `---'\\");
            Console.WriteLine("    |   (Y)  |");
            Console.WriteLine("     \\. ..  /");
            Console.WriteLine("      `\"\"\"\"\"\"`");
            Thread.Sleep(1000);
        }
    }
}
