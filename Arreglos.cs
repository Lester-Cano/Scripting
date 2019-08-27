using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el numero de datos");
            int n = int.Parse(Console.ReadLine());

            int[] edades = new int[n];
            string[] nombres = new string[n];
            int maximo = edades[0];
            int minimo = 10000;
            string indice = "";
            string indicemin = "";
            double total = 0;
            double promedio = 0;
            double desv = 0;
            double numn = 0;

            for (int i = 0; i < edades.Length; i++)
            {

                Console.WriteLine("Escriba el nombre");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Escriba la edad");
                edades[i] = int.Parse(Console.ReadLine());

                if (edades[i] > maximo)
                {
                    maximo = edades[i];
                    indice = nombres[i];
                }

                else if (minimo > edades[i]) 
                {
                    minimo = edades[i];
                    indicemin = nombres[i];
                }

                total += edades[i];
                promedio = total / edades.Length;

                
            }

            
            for (int j = 0; j < n; j++)
            {
                numn += Math.Pow(edades[j] - promedio, 2);
                desv = Math.Sqrt(numn / n);
            }


            for (int y = 0; y < edades.Length; y++)
            {
                double[] dis = new double [n];

                for (int k = 0; k < n; k++)
                {
                    
                }

            }
                Console.WriteLine("la persona mayor es: " + indice + " con " + maximo + " años.");
            Console.WriteLine("la persona menor es: " + indicemin + " con " + minimo + " años.");
            Console.WriteLine("El promedio de las edades es: " + promedio);
            Console.WriteLine("desv: " + desv);

        }
    }
}
