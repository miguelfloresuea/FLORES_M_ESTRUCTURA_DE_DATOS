using System;

namespace EjercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos las dos listas vacías
            ListaSimple lista1 = new ListaSimple();
            ListaSimple lista2 = new ListaSimple();

            Console.WriteLine("=== COMPARADOR DE LISTAS (Ejercicio 2) ===");

            // =========================================================
            // PASO 1: CARGA DE DATOS (LISTA 1)
            // =========================================================
            Console.WriteLine("\n--- DATOS LISTA 1 ---");
            while (true) // Bucle infinito hasta que el usuario escriba 'fin'
            {
                Console.Write("Ingrese número (o 'fin'): ");
                string entrada = Console.ReadLine();

                // Convertimos a minúsculas para aceptar 'FIN', 'Fin', 'fin'
                if (entrada.ToLower() == "fin") 
                {
                    break; // Rompe el ciclo y pasa a lo siguiente
                }

                // Intentamos convertir el texto a número entero
                if (int.TryParse(entrada, out int numero))
                {
                    lista1.InsertarInicio(numero);
                }
                else
                {
                    Console.WriteLine("Error: Eso no es un número entero.");
                }
            }

            // =========================================================
            // PASO 2: CARGA DE DATOS (LISTA 2)
            // =========================================================
            Console.WriteLine("\n--- DATOS LISTA 2 ---");
            // Repetimos la misma lógica para la segunda lista
            while (true)
            {
                Console.Write("Ingrese número (o 'fin'): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "fin") break;

                if (int.TryParse(entrada, out int numero))
                {
                    lista2.InsertarInicio(numero);
                }
                else
                {
                    Console.WriteLine("Error: Eso no es un número entero.");
                }
            }

            // Mostramos visualmente las listas para confirmar
            Console.WriteLine("\n--- ESTADO DE LAS LISTAS ---");
            Console.Write("Lista 1: "); lista1.DibujarLista();
            Console.Write("Lista 2: "); lista2.DibujarLista();

            // =========================================================
            // PASO 3: LÓGICA DE COMPARACIÓN (El corazón del ejercicio)
            // =========================================================
            
            // Primero obtenemos cuántos nodos tiene cada una
            int tamano1 = lista1.ContarNodos();
            int tamano2 = lista2.ContarNodos();

            // CASO C: Si los tamaños son diferentes, no tiene sentido comparar el contenido.
            // Directamente son diferentes en todo.
            if (tamano1 != tamano2)
            {
                Console.WriteLine("\nRESULTADO: c. No tienen el mismo tamaño ni contenido.");
            }
            else
            {
                // Si llegamos aquí, ES PORQUE TIENEN EL MISMO TAMAÑO.
                // Ahora debemos verificar si los números adentro son iguales y en el mismo orden.
                
                bool contenidoEsIgual = true; // Asumimos que son iguales hasta demostrar lo contrario

                // Obtenemos el inicio de ambas listas para recorrerlas a la par
                Nodo? actual1 = lista1.GetHead();
                Nodo? actual2 = lista2.GetHead();

                // Recorremos mientras existan nodos (sabemos que miden lo mismo)
                while (actual1 != null && actual2 != null)
                {
                    // Comparamos el dato del nodo actual de la lista 1 con el de la lista 2
                    if (actual1.Data != actual2.Data)
                    {
                        contenidoEsIgual = false; // Encontramos una diferencia
                        break; // No hace falta seguir buscando, salimos del bucle
                    }

                    // Avanzamos al siguiente vagón en ambas listas
                    actual1 = actual1.Next;
                    actual2 = actual2.Next;
                }

                // Evaluamos qué pasó después de la inspección:
                if (contenidoEsIgual)
                {
                    // CASO A: Mismo tamaño y nunca encontramos diferencias
                    Console.WriteLine("\nRESULTADO: a. Las listas son iguales en tamaño y en contenido.");
                }
                else
                {
                    // CASO B: Tenían el mismo tamaño, pero encontramos datos distintos
                    Console.WriteLine("\nRESULTADO: b. Las listas son iguales en tamaño pero no en contenido.");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}