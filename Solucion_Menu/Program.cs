using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definicion de Variables
            int opcion;
            String ope="";
          do
           {
            Console.Clear();
            Console.WriteLine("Universidad Ecci");
            Console.WriteLine("Seminario de Programacion en .Net y SQL Server\n\n");
            Console.WriteLine("Menu de Programas\n");
            Console.WriteLine("1. Operaciones Matematicas");
            Console.WriteLine("2. Funciones Matematicas");
            Console.WriteLine("3  Validacion de Respuestas");
            Console.WriteLine("4. Produccion Semanal");
            Console.WriteLine("5. Estacion Climatica");
            Console.WriteLine("6. Caracteriacion de Numeros");
            Console.WriteLine("7. Promedio de Pesos");
            Console.WriteLine("8. Sistema de Produccion Avicola");
            Console.WriteLine("9. Sistema de Notas U. Ecci");
            Console.WriteLine("10. Nomina Universidad Ecci");
            Console.WriteLine("\n\nDigite la operacion a realizar: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
                           {
                            case 1:
                                   Programa1 m = new Programa1();
                                   m.programa();
                                   break;
                            case 2:
                                   Programa2 n = new Programa2();
                                   n.programa();
                                   break;
                            case 3:
                                   Programa3 o = new Programa3();
                                   o.programa();
                                   break;
                            case 4:
                                   Programa4 p = new Programa4();
                                   p.programa();
                                   break;
                            case 5:
                                   Programa5 q = new Programa5();
                                   q.programa();
                                   break;
                            case 6:
                                   Programa6 r = new Programa6();
                                   r.programa();
                                   break;
                            case 7:
                                   Programa7 s = new Programa7();
                                   s.programa();
                                   break;
                            case 8:
                                   Programa8 t = new Programa8();
                                   t.programa();
                                   break;
                            case 9:
                                   Programa9 u = new Programa9();
                                   u.programa();
                                   break;
                            case 10:
                                   Programa10 v = new Programa10();
                                   v.programa();
                                   break;
                    default:                 
                                    Console.WriteLine("No selecciono ninguna operacion");
                                    break;
                          }//cierre del switch



            Console.WriteLine("Desea repetir la ejecucion de los programas s / n");
            ope = Console.ReadLine();
            }while(ope.Equals("s") || ope.Equals("S") || ope.Equals("si") || ope.Equals("SI"));
            
                            
        }
    }//cierre del metodo main
}//cierre del namespace
