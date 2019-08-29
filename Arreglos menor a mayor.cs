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

            string[] nombres = { "s", "l", "m", "k", "m" };
            int[] notas = { 1, 2, 1, 5, 4 };
            string index;
            int pos;

            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = 0; j < notas.Length - 1; j++)
                {
                    if( notas[j+1]>notas[j])
                    {
                        pos = notas[j + 1];
                        notas[j + 1] = notas[j];
                        notas[j] = pos;

                        index = nombres[j + 1];
                        nombres[j + 1] = nombres[j];
                        nombres[j] = index;
                    }
                }
            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("posicion: " + notas[i] +" Nombres: "+nombres[i]);
            }

        }
    }
}
