using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            Console.WriteLine("Ingrese el angulo b, la altura y la base");
            double b = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //calculos matematicos
            double t = Math.Sqrt((y * y) + (z * z));
            double a = Math.Asin(y / t) * (180 / Math.PI);
            double c = (90 - a);
            double e = 180 - c;
            double d = 180 - b - e;
            double x = (((Math.Sin(b *  Math.PI/180) ) * t) / (Math.Sin(d*Math.PI/180 ) ));

            Console.Writeline("El valor del lado x es:" + x);
        }
    }
}
