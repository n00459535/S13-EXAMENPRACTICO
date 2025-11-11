using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class ArregloNumeros
    {
        private int[] numeros;
        private Random random;

        public ArregloNumeros(int tamaño)
        {
            numeros = new int[tamaño];
            random = new Random();
        }
        public void GenerarAleatorios()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 11); // entre 1 y 10
            }

            Console.WriteLine("\nArreglo generado:");
            Mostrar();
        }

        // Muestra los elementos del arreglo
        public void Mostrar()
        {
            Console.WriteLine(string.Join(" | ", numeros));
        }

        //opcion 1: Muestra los elementos elevados a una potencia
        public void MostrarElevados(int potencia)
        {
            Console.WriteLine($"\nElementos elevados a la potencia {potencia}:");
            foreach (int num in numeros)
            {
                double resultado = Math.Pow(num, potencia);
                Console.Write(resultado + " | ");
            }
            Console.WriteLine();
        }

        // opcion 2: Modifica el valor de una posición específica 
        public void ModificarValor(int posicion, int nuevoValor)
        {
            if (posicion >= 0 && posicion < numeros.Length)
            {
                numeros[posicion] = nuevoValor;
                Console.WriteLine("Valor modificado correctamente.");
                Mostrar();
            }
            else
            {
                Console.WriteLine("Posición fuera de rango.");
            }
        }

        // opcion 3: Ordena los valores en orden inverso (usando burbuja : usa dos bucles para ordenar de forma inversa)
        public void MostrarInversoBurbuja()
        {
            int[] copia = (int[])numeros.Clone();

            for (int i = 0; i < copia.Length - 1; i++)
            {
                for (int j = 0; j < copia.Length - i - 1; j++)
                {
                    if (copia[j] < copia[j + 1]) // orden descendente
                    {
                        int temp = copia[j];
                        copia[j] = copia[j + 1];
                        copia[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nArreglo en orden inverso:");
            Console.WriteLine(string.Join(" | ", copia));
        }
    }
}
