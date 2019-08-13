using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();

            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            Console.WriteLine("Carta 1: " + carta1);
            Console.WriteLine("Carta 2: " + carta2);

            int cartaextra = 0;
            int total = carta1 + carta2;
            string pedir = "s";

            while (pedir == "s" && total < 21)
            {
                Console.WriteLine("Total: " + total);
                Console.Write("Pedir carta (s): ");
                pedir = Console.ReadLine();

                if (total <= 21)
                {
                    cartaextra = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta extra: " + cartaextra);
                    total += cartaextra;
                }
            }
            if (total > 21) Console.WriteLine("Perdiste con un total de: "+ total);
            Console.WriteLine("Gracias por participar ");
        }
    }
}



