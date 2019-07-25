using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            Console.WriteLine("Ingrese el angulo d, el angulo b y la y");
            double d = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //calculos matematicos
            double e = 90 - d;
            double a = e - b;
            double c = 90 - a;
            double z = (((Math.Sin(c * Math.PI / 180)) * y) / (Math.Sin(a * Math.PI / 180)));

            Console.WriteLine ("El valor de la altura es: "+z);
        }
    }
}
