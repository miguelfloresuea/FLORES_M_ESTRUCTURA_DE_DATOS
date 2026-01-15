using System;

namespace ListaInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple miLista = new ListaSimple();
            string entrada = "";

            Console.WriteLine("=== EJERCICIO: INVERTIR LISTA ENLAZADA ===");
            Console.WriteLine("Ingresa los números para tu lista.");
            Console.WriteLine("Escribe 'fin' cuando termines de agregar números.");
            Console.WriteLine("-------------------------------------------------");

            // BUCLE PARA INGRESO MANUAL DE DATOS
            while (true)
            {
                Console.Write("Ingrese un número: ");
                entrada = Console.ReadLine();

                // Condición de salida
                if (entrada.ToLower() == "fin")
                {
                    break;
                }

                // Validamos que sea un número válido antes de insertar
                if (int.TryParse(entrada, out int numero))
                {
                    miLista.InsertarFinal(numero);
                }
                else
                {
                    Console.WriteLine("Error: Por favor ingrese solo números enteros.");
                }
            }

            // Validamos que se haya ingresado al menos un dato
            if (!miLista.EstaVacia())
            {
                Console.WriteLine("\n1. Lista ingresada:");
                miLista.DibujarLista();

                Console.WriteLine("\n... Invirtiendo ...");
                miLista.InvertirLista();

                Console.WriteLine("\n2. Lista invertida:");
                miLista.DibujarLista();
            }
            else
            {
                Console.WriteLine("\nNo ingresaste ningún número.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}