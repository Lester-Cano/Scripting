using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor ingrese los votos del partido a");
            int votosa = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor ingrese los votos del partido b");
            int votosb = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor ingrese los votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor ingrese los votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor ingrese la poblacion");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Porfavor ingrese el porcentaje de la poblacion mayor de edad");
            double percent = double.Parse(Console.ReadLine());

            bool a = (votosa + votosb + blancos + anulados) > poblacion;
            bool b = (votosa - votosb) < (0.1 * poblacion);
            bool c = (votosa + votosb + blancos + anulados) < (0.3 * poblacion);

            if ((a||b)&&c)
            {
                Console.WriteLine("Las votaciones deben ser realizadas nuevamente");
            }
            else
            {
                if (votosa > votosb) Console.WriteLine("el ganador es a con un total de votos de: " + votosa);
                if (votosb > votosa) Console.WriteLine("el ganador es b con un total de votos de: " + votosb);
            }
        }
    }
}
