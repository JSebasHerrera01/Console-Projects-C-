using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa6
    {
        public void programa()
        {
            String continuar;
            int contnum, n, pos = 0, neg = 0, neu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("6. Caracteriacion de Numeros\n");
                Console.WriteLine("Digite la cantidad de numeros a categorizar");
                contnum = int.Parse(Console.ReadLine());
                for (int i = 0; i < contnum; i++)
                {
                    Console.WriteLine("Numero " + (i + 1));
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1)
                    {
                        pos = pos + 1;
                    }
                    else
                    {
                        if (n <= -1)
                        {
                            neg = neg + 1;

                        }
                        else
                        {
                            neu = neu + 1;
                        }
                    }

                }
                Console.WriteLine("Numeros positivos " + pos);
                Console.WriteLine("Numeros negativos " + neg);
                Console.WriteLine("Numeros neutros " + neu);

                Console.WriteLine("Desea Repetir el Programa de Caracteriacion de Numeros / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");
        }
    }
}
