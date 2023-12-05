using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa8
    {
        static double factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public void programa()
        {
            String continuar;
            int dias, gallinas;
            double produccion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("8. Produccion avicola\n");
                Console.WriteLine("Ingrese el numero de dias: ");
                dias = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de gallinas");
                gallinas = int.Parse(Console.ReadLine());

                for (int i = 0; i < dias; i++)
                {
                    int acum = 1;
                    acum = (int)(acum + Math.Pow(gallinas, i) / factorial(i));
                    produccion = acum;
                }
                Console.WriteLine("La producción total es: " + produccion);

                Console.WriteLine("Desea Repetir el Programa de Produccion avicola / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");

        }
    }
}
