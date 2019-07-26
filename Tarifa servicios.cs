using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para calcular la tarifa en servicios que ud debe de pagar teniendo en cuenta su salario");
            Console.WriteLine("Porfavor ingrese su salaraio");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 828116;
            if (salario < (2 * smmlv)) 
            {
                Console.WriteLine("Su tarifa es la A");
            }
            else if ((2 * smmlv) <= salario && salario <= (4 * smmlv)) 
            {
                Console.WriteLine("Su tarifa es la B");
            }
            else
            {
                Console.WriteLine("Su tarifa es la C");
            }
        }
    }
}
