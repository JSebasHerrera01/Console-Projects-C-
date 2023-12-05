using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Menu
{
    class Programa9
    {
        public void programa()
        {
         //Dimensionar Dos Vectores materia y estudiante vacios
         String[] materia;
         String[] estudiante;
         String continuar;
            //Dimensionar una Matriz de Notas Vacia
         double[,] notas;
         double suma=0, promedio;
         int materias, estudiantes,i,j;


            do
            {
                Console.Clear();
                Console.WriteLine("9. Sistema de Notas U. Ecci\n");
                // Entradas
                Console.Write("Digite el Numero de Materias=");
                materias = int.Parse(Console.ReadLine());
                Console.Write("Digite el Numero de Estudiantes=");
                estudiantes = int.Parse(Console.ReadLine());
                //Definir Vector materia con el numero de materias a Insertar
                materia = new String[materias];
                //Definir Vector estudiantes con el numero de estudiantes a Insertar
                estudiante = new String[estudiantes];
                //Definir Matriz de Notas con filas:No. materias, columnas: No.estudiantes
                notas = new double[materias, estudiantes];
                // Ciclo for para cargar las materias
                for (i = 0; i < materias; i++)
                {
                    Console.Write("Digite la Materia No. " + (i + 1) + " a ingresar en la BD=");
                    materia[i] = Console.ReadLine();
                }
                for (i = 0; i < estudiantes; i++)
                {
                    Console.Write("Digite el estudiante No. " + (i + 1) + " a ingresar en la BD=");
                    estudiante[i] = Console.ReadLine();
                }
                //Llenar la matriz de notas
                for (i = 0; i < materias; i++)
                {
                    for (j = 0; j < estudiantes; j++)
                    {
                        Console.WriteLine("Digite la Nota del Estudiante " + estudiante[j] +
                                          " en la Materia " + materia[i] + "=");
                        notas[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                //Ciclo for para imprimir materias
                Console.WriteLine("Materias Almacenadas en la Base de Datos");
                for (i = 0; i < materias; i++)
                {
                    Console.WriteLine("Materia No. " + (i + 1) + "=" + materia[i]);
                }
                //Ciclo for para imprimir materias
                Console.WriteLine("Estudiantes Almacenados en la Base de Datos");
                for (i = 0; i < estudiantes; i++)
                {
                    Console.WriteLine("Estudiante No. " + (i + 1) + "=" + estudiante[i]);
                }
                //Mostrar la matriz de notas almacenada en la Base de Datos
                Console.WriteLine("Notas Almacenadas en la Base de Datos");
                for (i = 0; i < materias; i++)
                {
                    for (j = 0; j < estudiantes; j++)
                    {
                        Console.Write(notas[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //Promedio de Notas por Materia 
                Console.WriteLine("Notas Almacenadas en la Base de Datos");
                for (i = 0; i < materias; i++)
                {
                    for (j = 0; j < estudiantes; j++)
                    {
                        suma = suma + notas[i, j];
                    }
                    promedio = suma / estudiantes;
                    Console.WriteLine("Promedio de Materia " + materia[i] + "=" + promedio);
                    suma = 0;
                }
                //Promedio de Notas por Estudiante
                for (i = 0; i < estudiantes; i++)
                {
                    for (j = 0; j < materias; j++)
                    {
                        suma = suma + notas[j, i];
                    }
                    promedio = suma / estudiantes;
                    Console.WriteLine("El Promedio del estudiante " + estudiante[i] + "=" + promedio);
                    suma = 0;
                }

                Console.WriteLine("Desea Repetir el Programa de Sistema de Notas U. Ecci/ n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu principal");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S" || continuar == "si" || continuar == "SI");

        }
    }
}
