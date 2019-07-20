using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perroooo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa para hallar los valores de un triangulo rectangulo conociendo su altura y un angulo");

            Console.WriteLine("ingrese el valor de la altura");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del angulo");
            double c = double.Parse(Console.ReadLine());



            double y = z/(Math.Tan(c * (Math.PI / 180)));
            Console.WriteLine("el valor de la base es:" + y);

            double t = z/(Math.Sin(c * (Math.PI / 180)));
            Console.WriteLine("el valor de la hipotenusa es:" + t);

            double a = Math.Atan(y/z) * (180 / Math.PI);
            Console.WriteLine("el valor del angulo a es:" + a);
        }
    }
}
