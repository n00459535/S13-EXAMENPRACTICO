using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ArregloAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números aleatorios (n) a generar : ");
            int n = int.Parse(Console.ReadLine());

            // Crear objeto y generar los números aleatorios , llama a la clase  ArregloNumeros y usa (n) dado por el usuario
            ArregloNumeros arreglo = new ArregloNumeros(n);
            arreglo.GenerarAleatorios();

            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n----- MENÚ DE OPCIONES -----");
                Console.WriteLine("[1] Mostrar los elementos elevados a una potencia");
                Console.WriteLine("[2] Modificar un valor en una posición específica");
                Console.WriteLine("[3] Mostrar valores en orden inverso");
                Console.WriteLine("[0] Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcion)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("Ingrese la potencia: ");
                        int potencia = int.Parse(Console.ReadLine());
                        arreglo.MostrarElevados(potencia);
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Ingrese la posición a modificar (0 a {0}): ", n - 1);
                        int pos = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nuevo valor: ");
                        int nuevoValor = int.Parse(Console.ReadLine());
                        arreglo.ModificarValor(pos, nuevoValor);
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        arreglo.MostrarInversoBurbuja();
                        Console.ResetColor();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 0);
        }
    }

}
