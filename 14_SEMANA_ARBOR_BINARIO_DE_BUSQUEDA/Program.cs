using System;

namespace ArbolBinarioBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia del árbol binario
            ArbolBinario arbol = new ArbolBinario();

            // Variables para almacenar la opción del menú y valores ingresados
            int opcion, valor;

            // Bucle principal del menú (se repite hasta que el usuario elija salir)
            do
            {
                // Mostrar menú de opciones
                Console.WriteLine("\n--- MENÚ ÁRBOL BINARIO DE BÚSQUEDA ---");
                Console.WriteLine("1. Insertar valor en el árbol");
                Console.WriteLine("2. Buscar un valor en el árbol");
                Console.WriteLine("3. Eliminar un valor del árbol");
                Console.WriteLine("4. Mostrar recorridos (Preorden, Inorden y Postorden)");
                Console.WriteLine("5. Mostrar valor mínimo, máximo y altura del árbol");
                Console.WriteLine("6. Limpiar completamente el árbol");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                // Se lee la opción ingresada por el usuario
                opcion = int.Parse(Console.ReadLine());

                // Estructura de control para ejecutar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        // Insertar un nuevo valor en el árbol
                        Console.Write("Ingrese el valor a insertar: ");
                        valor = int.Parse(Console.ReadLine());

                        arbol.Insertar(valor);
                        Console.WriteLine("Valor insertado correctamente");
                        break;

                    case 2:
                        // Buscar un valor en el árbol
                        Console.Write("Ingrese el valor a buscar: ");
                        valor = int.Parse(Console.ReadLine());

                        // Se muestra si el valor existe o no
                        if (arbol.Buscar(valor))
                            Console.WriteLine("El valor existe en el árbol");
                        else
                            Console.WriteLine("El valor no existe en el árbol");
                        break;

                    case 3:
                        // Eliminar un valor del árbol
                        Console.Write("Ingrese el valor a eliminar: ");
                        valor = int.Parse(Console.ReadLine());

                        arbol.Eliminar(valor);
                        Console.WriteLine("Operación de eliminación realizada");
                        break;

                    case 4:
                        // Mostrar los diferentes recorridos del árbol

                        Console.WriteLine("\nRecorrido Inorden:");
                        arbol.InOrden(arbol.Raiz); // Izquierda - Raíz - Derecha

                        Console.WriteLine("\nRecorrido Preorden:");
                        arbol.PreOrden(arbol.Raiz); // Raíz - Izquierda - Derecha

                        Console.WriteLine("\nRecorrido Postorden:");
                        arbol.PostOrden(arbol.Raiz); // Izquierda - Derecha - Raíz

                        Console.WriteLine(); // Salto de línea final
                        break;

                    case 5:
                        // Mostrar información adicional del árbol (mínimo, máximo y altura)
                        if (arbol.Raiz != null)
                        {
                            Console.WriteLine("\nValor mínimo del árbol: " + arbol.Minimo(arbol.Raiz));
                            Console.WriteLine("Valor máximo del árbol: " + arbol.Maximo(arbol.Raiz));
                            Console.WriteLine("Altura del árbol: " + arbol.Altura(arbol.Raiz));
                        }
                        else
                        {
                            Console.WriteLine("El árbol está vacío");
                        }
                        break;

                    case 6:
                        // Limpiar completamente el árbol
                        arbol.Limpiar();
                        Console.WriteLine("El árbol ha sido eliminado completamente");
                        break;

                    case 0:
                        // Opción para salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        // Manejo de opción inválida
                        Console.WriteLine("Opción inválida, intente nuevamente");
                        break;
                }

            } while (opcion != 0); // El ciclo continúa hasta que el usuario elija salir
        }
    }
}