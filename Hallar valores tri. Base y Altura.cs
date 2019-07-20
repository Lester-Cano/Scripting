using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("programa para hallar los valores de un triangulo rectangulo conociendo su base y altura");

            Console.WriteLine("ingrese la base");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((y*y) + (z*z));
            Console.WriteLine("el valor de la hipotenusa es:"); Console.WriteLine(t);

            double c =Math.Acos(y / t)*(180/Math.PI);
            Console.WriteLine("el valor del angulo c es:"); Console.WriteLine(c);

            double a = Math.Asin(y / t) * (180 / Math.PI);
            Console.WriteLine("el valor del angulo a es:"); Console.WriteLine(a);

        }
    }
}