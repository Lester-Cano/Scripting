using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            Console.WriteLine("Ingrese x, w y el angulo");
            double x = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            //calculos matematicos
            double t = x / Math.Sin(d * Math.PI / 180);
            double z = Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(w, 2)) - 2 * x * w * Math.Cos(d * Math.PI / 180));
            double e = Math.Acos(((Math.Pow(w, 2)) + (Math.Pow(z, 2)) - (Math.Pow(x, 2))) / (2 * w * z)) * 180 / Math.PI;
            double c = 180 - e;
            double a = 180 - c;
            double y = z * Math.Sin(a * Math.PI / 180);

            Console.WriteLine("El valor de y es: " + y);
        }
    }
}
