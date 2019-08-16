using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, turno = 0, win10 = 0;
            string continuar = "s";

            while (true)
            {
                dado = aleatorio.Next(1, 13);

                Console.WriteLine("Dado: " + dado);
                turno += 1;


                if (turno > 3 && (dado == 1 || dado == 1 || dado == 5 || dado == 7 || dado == 9 || dado == 11)) 
                {
                    total = 0;
                    Console.WriteLine("eliminado");
                    break;
                }
                else
                {
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                    if (continuar != "s") break;
                }

                if (dado == 10)
                {
                    win10 += 1;
                    if (win10 == 1 && dado == 12)
                    {
                        Console.WriteLine("Felicidades, ganaste por sacar 12 despues de 10 ;)");
                        break;
                    }
                }
                else
                {
                    win10 = 0;
                }

                if (total >= 100)
                {
                    Console.WriteLine("Ya ganaste :D");
                    break;
                }
                
            }
            Console.WriteLine("Gracias por participar. Su total fue: " + total);
        }
    }
}
