using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa1
    {
        public void programa()
        {
            String continuar, ope = "1";
            int opcion = 0, cocienteEntero = 0;
            double numero1, numero2, operacion = 0;
            decimal divDecimal = 0.0m;
            do
            {
                Console.Clear();
                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Seminario de Programacion en .Net y SQL Server\n\n");
                Console.WriteLine("1. Operaciones Matematicas\n");
                Console.WriteLine("Digite el Primer Numero: "); numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el Segundo Numero: "); numero2 = int.Parse(Console.ReadLine());
                while (numero2 == 0)
                {
                    Console.WriteLine("Numero 2 debe ser diferente de Cero");
                    Console.WriteLine("Digite Nuevamente el Segundo Numero");
                    numero2 = int.Parse(Console.ReadLine());
                }
                while (opcion <= 0 || opcion >= 6)
                {
                    Console.WriteLine("Operaciones");
                    Console.WriteLine("1.Suma");
                    Console.WriteLine("2.Resta");
                    Console.WriteLine("3.Producto");
                    Console.WriteLine("4.División entera");
                    Console.WriteLine("5.División real");
                    Console.WriteLine("6.Residuo");
                    Console.WriteLine("7.Potencia");
                    Console.WriteLine("Seleccione la Operacion:");
                    Console.WriteLine("Seleccione una operacion entre 1 y 7");
                    opcion = int.Parse(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        operacion = numero1 + numero2;
                        ope = "suma";
                        break;

                    case 2:
                        operacion = numero1 - numero2;
                        ope = "resta";
                        break;

                    case 3:
                        operacion = numero1 * numero2;
                        ope = "producto";
                        break;

                    case 4:
                        cocienteEntero = Convert.ToInt32(numero1) / Convert.ToInt32(numero2);
                        operacion = cocienteEntero;

                        ope = "división entera";
                        break;

                    case 5:
                        operacion = numero1 / numero2;
                        ope = "división real";
                        break;

                    case 6:
                        Convert.ToInt32(numero1);
                        Convert.ToInt32(numero2);
                        operacion = numero1 % numero2;
                        ope = "residuo";
                        break;

                    case 7:
                        operacion = Math.Pow(numero1, numero2);
                        ope = "potencia";
                        break;

                    default:
                        Console.WriteLine("No selecciono ninguna opción");

                        break;

                }
                Console.WriteLine("************************************************");
                Console.WriteLine("************ Numero 1 = " + numero1 + " ************");
                Console.WriteLine("************ Numero 2 = " + numero2 + " ************");
                Console.WriteLine("************ Resultado= " + operacion + " ************");

                Console.WriteLine("Desea Repetir el Progrma de Operaciones Matematicas s / n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();
            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");
        }
    }
    //cierre del metodo main
}

