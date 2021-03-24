using System;

namespace Guia_1___5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            
            bool igualdad = false;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Apreta Control + F para salir, sino mientras te quedas acá.");
            do
            {
                cki = Console.ReadKey();
                
                Console.Write(" Apretaste: ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) 
                {
                    Console.Write("CTL+");
                    string cosa = cki.Key.ToString();
                    igualdad = string.Equals(cosa, "F");
                }
                        
                        Console.WriteLine(cki.Key.ToString());
            } while (igualdad == false);

        }
    }
}
