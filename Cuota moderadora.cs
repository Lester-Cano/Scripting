using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular la tarifa de la eps y la cuota moderadora con base en su salario y si posee sisben");
            Console.WriteLine("Porfavor ingrese su salaraio sin los puntos del mil");
            int salario = int.Parse(Console.ReadLine());
            int smmlv = 828116;

            if (salario < smmlv)
            {
                Console.WriteLine("marque 1 si ud posee sisben, marque 2 si no");
                int sisben = int.Parse(Console.ReadLine());
               
                if (sisben == 1)
                {
                    Console.WriteLine("Su tarifa es la A y no tiene que pagar cuota moderadora");
                }
                else if (sisben == 2)
                {
                    Console.WriteLine("Su tarifa es la A y el valor de su cuota moderadora es $ 3.200");
                }
            }
            else if (salario < (2 * smmlv))
            {
                Console.WriteLine("Su tarifa es la A y el valor de su cuota moderadora es $ 3.200");
            }
            else if ((2 * smmlv) <= salario && salario <= (5 * smmlv))
            {
                Console.WriteLine("Su tarifa es la B y el valor de su cuota moderadora es $ 12.700");
            }
            else
            {
                Console.WriteLine("Su tarifa es la C y el valor de su cuota moderadora es $ 33.500");
            }
        }
    }
}
