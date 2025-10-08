using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: El sistema debe manejar un catálogo entero (vector).
            string[] catalogo = { "Café", "Chifrijo", "Casado", "Empanada", "Pepsi" };
            int[] precio = { 1200, 3500, 5000, 1500, 1000 };
            int[] estado = { 0, 1, 2 };

            //TODO: Matriz de transacciones
            int[,] transacciones = new int[5, 3];

            for (int i = 0; i < catalogo.Length; i++)
            {
                transacciones[i, 0] = i;

                transacciones[i, 1] = precio[i];

                transacciones[i, 2] = estado[1];
            }

            Console.WriteLine("\n------------------------------------");

            // Títulos: Solo 3 marcadores de posición para las 3 columnas de la matriz
            Console.WriteLine("{0,-8} | {1,-8} | {2,-8}",
                              "POSICIÓN", "PRECIO", "ESTADO");

            Console.WriteLine("------------------------------------");

            for (int i = 0; i < transacciones.GetLength(0); i++)
            {
                
                for (int j = 0; j < transacciones.GetLength(1); j++)
                {
                    Console.Write(" {0,-8} |", transacciones[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}