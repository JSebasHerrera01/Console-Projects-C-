using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa7
    {
        public void programa()
        {
            String continuar;
            int x, y, edad, niño = 0, joven = 0, adulto = 0, viejo = 0;
            double peso, pniño = 0, pjoven = 0, padulto = 0, pviejo = 0, promn = 0, promj = 0, proma = 0, promv = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("7. Estadistica de Pesos\n");
                Console.WriteLine("Ingresa la cantidad de personas a evaluar: ");
                y = int.Parse(Console.ReadLine());

                for (x = 1; x <= y; x++)
                {
                    Console.WriteLine("Persona " + x);
                    Console.WriteLine("Ingresa tu edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa tu peso: ");
                    peso = double.Parse(Console.ReadLine());


                    if (edad < 0)
                    {
                        Console.WriteLine("Ingrese una edad correcta");
                    }
                    else if (edad < 14)
                    {
                        pniño = pniño + peso;
                        niño = niño + 1;
                        promn = pniño / niño;
                    }
                    else if (edad < 31)
                    {
                        pjoven = pjoven + peso;
                        joven = joven + 1;
                        promj = pjoven / joven;
                    }
                    else if (edad < 61)
                    {
                        padulto = padulto + peso;
                        adulto = adulto + 1;
                        proma = padulto / adulto;
                    }
                    else if (edad >= 61)
                    {
                        pviejo = pviejo + peso;
                        viejo = viejo + 1;
                        promv = pviejo / viejo;
                    }
                }
                Console.WriteLine("El promedio de los niños es: " + promn);
                Console.WriteLine("El promedio de los jovenes es: " + promj);
                Console.WriteLine("El promedio de los adultos es: " + proma);
                Console.WriteLine("El promedio de los viejos es: " + promv);

                Console.WriteLine("Desea Repetir el Programa de Estadistica de Pesos / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");
        }
    }
}
