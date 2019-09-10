using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                salida++;
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length - 1; i++)
        {
            for (int j = 0; j < notas.Length - 1; j++)
            {
                if (notas[j] > notas[j + 1])
                {
                    double tmp = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = tmp;

                    string tmp1 = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tmp1;
                }
            }
        }

        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        
      


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3.0)
            {
                salida.Add(nombres[i]);
            }
        }
        salida.Sort();

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        for (int i = 0; i < nombres.Length; i++)
        {
            string inicial = nombres[i];
            if (inicial[0] != 'A' && inicial[0] != 'E' && inicial[0] != 'I' && inicial[0] != 'O' && inicial[0] != 'U')
            {
                salida.Add(nombres[i]);
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


