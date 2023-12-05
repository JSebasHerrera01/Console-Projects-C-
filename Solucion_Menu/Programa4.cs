using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa4
    {
        public void programa()
        {
            int Lunes, martes, miercoles, jueves, viernes, sabado, ingresos, totalbono = 0;
            double promedio = 0;
            Double numero1 = 2.5;
            Double numero2 = 3.5;
            string continuar = "";
            do
            {
                Console.Clear();
                Console.WriteLine("4. Producción semanal\n");
                Console.WriteLine("ingresa la producción del dia lunes ");
                Lunes = int.Parse(Console.ReadLine());
                Console.WriteLine("ingresa la producción del dia Martes ");
                martes = int.Parse(Console.ReadLine());
                Console.WriteLine("ingresa la producción del dia Miercoles");
                miercoles = int.Parse(Console.ReadLine());
                Console.WriteLine("ingresa la producción del dia jueves ");
                jueves = int.Parse(Console.ReadLine());
                Console.WriteLine("ingresa la producción del dia viernes ");
                viernes = int.Parse(Console.ReadLine());
                Console.WriteLine("ingresa la producción del dia sabado ");
                sabado = int.Parse(Console.ReadLine());

                promedio = (Lunes + martes + miercoles + jueves + viernes + sabado) / 6;


                if ((promedio >= 0) && (promedio <= 99))
                {
                    ingresos = (int)(promedio * 2);
                    Console.WriteLine("no se le da incentivo");
                    Console.WriteLine("el total de ingresos es");
                    Console.WriteLine(ingresos);
                }
                else if ((promedio >= 100) && (promedio <= 199))
                {
                    ingresos = (int)(promedio * 2);
                    totalbono = (ingresos * 10) / 100;
                    Console.WriteLine("se le da incentivo del 10%");
                    Console.WriteLine("El total de ingresos sin incentivos es :");
                    Console.WriteLine(ingresos);
                    Console.WriteLine("El total con el incentivo es :");
                    Console.WriteLine(totalbono);
                }

                else if ((promedio >= 200) && (promedio <= 299))
                {
                    ingresos = (int)(promedio * numero1);
                    totalbono = (ingresos * 12) / 100;
                    Console.WriteLine("se le da incentivo del 12%");
                    Console.WriteLine("El total de ingresos sin incentivos es :");
                    Console.WriteLine(ingresos);
                    Console.WriteLine("El total con el incentivo es :");
                    Console.WriteLine(totalbono);
                }
                else if ((promedio >= 300) && (promedio <= 399))
                {
                    ingresos = (int)(promedio * 3);
                    totalbono = (ingresos * 14) / 100;
                    Console.WriteLine("se le da incentivo del 14%");
                    Console.WriteLine("El total de ingresos sin incentivos es :");
                    Console.WriteLine(ingresos);
                    Console.WriteLine("El total con el incentivo es :");
                    Console.WriteLine(totalbono);
                }
                else if ((promedio >= 400) && (promedio <= 400))
                {
                    ingresos = (int)(promedio * numero2);
                    totalbono = (ingresos * 16) / 100;
                    Console.WriteLine("se le da incentivo del 16%");
                    Console.WriteLine("El total de ingresos sin incentivos es :");
                    Console.WriteLine(ingresos);
                    Console.WriteLine("El total con el incentivo es :");
                    Console.WriteLine(totalbono);
                }
                else
                {
                    Console.WriteLine("no es valido");
                }

                Console.WriteLine("Desea Repetir el Programa de Produccion Semanal s / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");
        }
    }
}
