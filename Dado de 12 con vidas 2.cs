using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOOOOO
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int vidas = 3, turno = 0, puntos = 0;
            Console.WriteLine("Vidas Iniciales: " + vidas);
            while (true)
            {
                turno++;
                int dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado1);
                puntos += dado1;
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Turno: " + turno);

                if (turno % 2 == 0)
                {
                    Console.WriteLine("Has Perdido Una Vida");
                    vidas -= 1;
                    Console.WriteLine("Vidas: " + vidas);
                }

                if (turno % 3 == 0)
                {
                    int dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Nuevo Dado: " + dado2);
                    Console.WriteLine("Dado: " + dado1);

                    if (dado2 == dado1)
                    {
                        Console.WriteLine("Has Ganado Una Vida");
                        vidas += 1;
                        Console.WriteLine("Vidas: " + vidas);
                    }
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Perdiste al quedarte sin vidas :c");
                    break;
                }

                Console.WriteLine("Desea Continuar (s/n) ");
                if (Console.ReadLine() != "s") break;
            }

            Console.WriteLine("Puntos: " + puntos);
            Console.WriteLine("Gracias Por Jugar");

        }
    }
}