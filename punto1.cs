// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Serialization.Formatters;

public class punto1 {
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese un número entero, por favor: ");
        int N = Convert.ToInt32(Console.ReadLine());//ingreso de posible número hexagonal centrado
        int space = 0;

        static float getKNumber (int n) {
            float k = (float)(-3 + Math.Sqrt(12 * n - 3)) / 6;
            return k;
        }

        static bool isCenteredHexagonal(float k)//funcion que verifica si el número ingresado es número hexagonal centrado
        {
            return (k - (int)k) == 0;
        }
                float k = getKNumber(N);
        string[] lineas = new string[((int)k*2)+1];//se cre arrewglo con el numero de capas del hexagono


        if (isCenteredHexagonal(k))
        {

            int capas = (int)(2 * k) + 1;//número de capas de hexagono
            int auxUp = (int)k - 1;
            int auxDown= (int)k + 1;
            for (int i = capas; i >= (capas - k); i--) {
                string linea = "";
                for (int x = 0; x < space; x++) {
                    linea += " ";
                }
                for (int j = i; j > 0; j--) {
                    linea += " ";
                    linea += "°";
                }

                if (i == capas)
                {
                    lineas[(int)k] = linea;//ingreso linea del medio
                }
                else
                {
                    lineas[auxUp] = linea; // como el hexagono es simetrico se hace el guardado de la linea tanto arriba como abajo en el arreglo
                    lineas[auxDown] = linea;
                    auxUp--;
                    auxDown++;
                }
                space++;
            }

            for (int i = 0; i < lineas.Length; i++) {
                Console.WriteLine(lineas[i]);
            }
        }
        else {
            Console.WriteLine("No válido");
        }


     
    }

}
