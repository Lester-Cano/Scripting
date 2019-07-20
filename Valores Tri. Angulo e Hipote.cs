using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hijueptaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa para hallar los valores de un triangulo rectangulo conociendo su hipotenusa y un angulo");

            Console.WriteLine("ingrese el valor de la hipotenusa");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del angulo");
            double a = double.Parse(Console.ReadLine());



            double y = (Math.Sin(a * (Math.PI / 180)) * t);
            Console.WriteLine("el valor de la base es:" + y);

            double z = (Math.Cos(a * (Math.PI / 180)) * t);
            Console.WriteLine("el valor de la altura es:" + z);

            double c = Math.Acos(y / t) * (180 / Math.PI);
            Console.WriteLine("el valor del angulo c es:"); Console.WriteLine(c);

        }
    }
}
