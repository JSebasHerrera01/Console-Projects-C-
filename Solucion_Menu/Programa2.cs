using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa2
    {
        public void programa()
        {

            String continuar;
            int opcion = 0;
            int num, total = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("2. Funciones Matematicas\n");
                Console.WriteLine("Digite el numero a evaluar");
                num = int.Parse(Console.ReadLine());
                while (opcion <= 0 || opcion >= 11)
                {
                    Console.WriteLine("Funciones");
                    Console.WriteLine("1. Valor Absoluto");
                    Console.WriteLine("2. Arco coseno");
                    Console.WriteLine("3. Coseno");
                    Console.WriteLine("4. Tangente");
                    Console.WriteLine("5. Raiz Cuadrada");
                    Console.WriteLine("6. Seno");
                    Console.WriteLine("7. Exponencial");
                    Console.WriteLine("8. Logaritmo Natural");
                    Console.WriteLine("9. Tangente Hiperbolica");
                    Console.WriteLine("10. Coseno Hiperbolico");
                    Console.WriteLine("Seleccione la funcion a realizar");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            total = Math.Abs(num);
                            break;
                        case 2:
                            total = (int)Math.Acos(num);
                            break;
                        case 3:
                            total = (int)Math.Cos(num);
                            break;
                        case 4:
                            total = (int)Math.Tan(num);
                            break;
                        case 5:
                            total = (int)Math.Sqrt(num);
                            break;
                        case 6:
                            total = (int)Math.Sin(num);
                            break;
                        case 7:
                            total = (int)Math.Exp(num);
                            break;
                        case 8:
                            total = (int)Math.Log(num);
                            break;
                        case 9:
                            total = (int)Math.Tanh(num);
                            break;
                        case 10:
                            total = (int)Math.Cosh(num);
                            break;
                    }
                }
                Console.WriteLine("Resultado: " + total);

                Console.WriteLine("Desea Repetir el Programa de Funciones Matematicas s / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();
            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");


        }
    }//cierre del metodo main
}

