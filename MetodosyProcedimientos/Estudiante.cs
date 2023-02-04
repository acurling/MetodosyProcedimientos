﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
    internal class Estudiante
    {
        static string[] nombre = new string[3];  // variable global
        static float[] notas = new float[3];     // variabl global
        static byte indice = 0;                 // variable global para la posicion del arreglo

        private static void CrearEstudiantes()
        {
            string continuar = "s";
            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0}):",(indice+1));
                nombre[indice] = Console.ReadLine();
                indice++;
                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();
            } while (!continuar.Equals("n"));
        }

        private static void BuscarEstudiante() 
        {
            Console.WriteLine("Digite el nombre:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Estudiante Existe");
                }
            }
        }
        public static void menu()
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiante");
                Console.WriteLine("3 - Asignar nota al estudiante");
                Console.WriteLine("4 - Imprimir Estudiante con sus notas");
                Console.WriteLine("5 - salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;
                    case 2:
                        BuscarEstudiante();
                        break;
                    case 3:
                        Console.WriteLine("Imprimir Estudiantes");
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 4); // true

        }


    }
}
