using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(" Ingreese su salario");
            double salario = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese 1 si es trabajador dependiente o 2 si es independiente");
            int contrato = int.Parse(Console.ReadLine());

            double deducciones = salario * 0.4;







            switch (contrato)
            {
                case 1:

                    double Des = salario - (deducciones * 0.08);

                    Console.WriteLine(" Su salario mensual real es: " + Des + " Su salario anual con prima por ser dependiente es: " + (Des * 12 + salario));


                    break;

                case 2:


                    double Desc = (deducciones * 0.16);
                    double Des1 = (deducciones * 0.125);
                    double ARL;

                    Console.WriteLine("ingrese su acitivdad");
                    int entrada1 = int.Parse(Console.ReadLine());

                    double SalarioInd = salario - Desc - Des1;

                    switch (entrada1)
                    {

                        case 1:

                            ARL = deducciones * 0.005;

                            Console.WriteLine("Su Salario mensual real es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                            break;


                        case 2:

                            ARL = deducciones * 0.0052;


                            Console.WriteLine("Su Salario mensual real es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                            break;

                        case 3:

                            ARL = deducciones * 0.02436;

                            Console.WriteLine("Su Salario mensual real es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                            break;

                        case 4:

                            ARL = deducciones * 0.04350;

                            Console.WriteLine("Su Salario mensual real es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));


                            break;

                        case 5:

                            ARL = deducciones * 0.06960;

                            Console.WriteLine("Su Salario mensual real es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));

                            break;
                    }
                    break;
            }
        }
    }
}
