using System;

namespace _02_LOTERIA_PRIMITIVA
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto de la clase Loteria
            Loteria loteria = new Loteria();

            Console.WriteLine("Ingrese los números ganadores de la lotería primitiva");
            Console.WriteLine("Ingrese 6 números:");

            // Se solicita al usuario ingresar 6 números
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                // Se agrega el número a la lista
                loteria.AgregarNumero(numero);
            }

            // Se ordenan los números de menor a mayor
            loteria.OrdenarNumeros();

            // Se muestran los números ordenados
            loteria.MostrarNumeros();

            // Pausa para ver los resultados
            Console.ReadKey();
        }
    }
}

