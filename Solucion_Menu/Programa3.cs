using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa3
    {
        public void programa()
        {
            String continuar;
            int correcto, incorrecto, blanco, total;
            do
            {
                Console.Clear();
                Console.WriteLine("3. Validador de respuestas\n");
                Console.WriteLine("Digite la cantidad de respuestas correctas");
                correcto = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de respuestas incorrectas");
                incorrecto = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de respuestas en blanco");
                blanco = int.Parse(Console.ReadLine());

                total = (correcto * 4) + (incorrecto * (-1)) + (blanco * 0);

                Console.WriteLine("Resultado: " + total);

                Console.WriteLine("Desea Repetir el Programa de Validacion de Respuestas s / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");
        }
}
}
