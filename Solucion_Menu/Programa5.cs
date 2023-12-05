using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa5
    {
        public void programa()
        {
            double a;
            double b;
            int correctas = 0;
            int incorrectas = 0;
            double maxima = 0;
            double minima = 0;
            int x;
            x = 1;
            string continuar = "";
            do
            {
                Console.Clear();
                Console.WriteLine("5. Estación climatica\n");
                while (x != 0)
                {
                    Console.WriteLine("Ingresa 2 temperaturas");
                    a = Double.Parse(Console.ReadLine());
                    b = Double.Parse(Console.ReadLine());
                    if (a == 9 || b == 9)
                    {
                        incorrectas = incorrectas + 1;
                        Console.WriteLine("Las temperaturas son incorrectas");
                    }
                    else
                    {
                        correctas = correctas + 1;
                        if (a > b)
                        {
                            maxima = maxima + a;
                            minima = minima + b;
                        }
                        else
                        {
                            maxima = maxima + b;
                            minima = minima + a;
                        }
                        if (a == 0 && b == 0)
                        {
                            x = 0;
                        }
                    }
                }
                Console.WriteLine("El promedio de las temperaturas maximas es : " + maxima / correctas);
                Console.WriteLine("El promedio de las temperaturas minimas es : " + minima / correctas);
                Console.WriteLine(" El porcentaje de temperaturas con error es: " + (incorrectas / (incorrectas + correctas)) * 100);
                Console.WriteLine("El procentaje de temperaturas correctas es : " + (correctas / (incorrectas + correctas)) * 100);
                Console.WriteLine("Temperaturas correctas " + correctas);
                Console.WriteLine("Temperaturas incorrectas " + incorrectas);

               
                Console.WriteLine("Desea Repetir el Programa de Estación climatica / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");

        }
    }
}
