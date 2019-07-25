using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            Console.WriteLine("Ingrese t, w y el angulo c");
            double t = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //calculos matematicos
            double e = 180 - c;
            double d = Math.Asin((t * Math.Sin(e * Math.PI / 180)) / (w)) * 180 / Math.PI;
            double b = 180 - d - e;
            double x = Math.Sqrt((t * t) + (w * w) - (2 * (t) * (w)) * (Math.Cos(b * Math.PI/180)));

            Console.WriteLine("El valor de x es: " + x);
        }
    }
}
