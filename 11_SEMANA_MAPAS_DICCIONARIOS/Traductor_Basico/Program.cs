using System;

namespace TraductorPOO
{
    // Clase principal que maneja la interfaz de consola
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos el objeto de la clase Traductor
            Traductor miTraductor = new Traductor();
            int opcion = -1;

            // Ciclo while para mantener el menú activo hasta que el usuario ingrese 0
            while (opcion != 0)
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();

                // Validamos que el usuario ingrese un número
                if (int.TryParse(entrada, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            EjecutarTraduccion(miTraductor);
                            break;
                        case 2:
                            EjecutarAgregado(miTraductor);
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }

        // Método que pide la frase e invoca la lógica de traducción
        static void EjecutarTraduccion(Traductor traductor)
        {
            Console.Write("\nIngrese la frase a traducir: ");
            string frase = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(frase))
            {
                // Llamamos al método TraducirFrase del objeto traductor
                string resultado = traductor.TraducirFrase(frase);
                Console.WriteLine("\nTraducción esperada (parcial):");
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("La frase ingresada no es válida.");
            }
        }

        // Método que pide los datos e invoca la lógica para agregar al diccionario
        static void EjecutarAgregado(Traductor traductor)
        {
            Console.Write("\nIngrese la palabra en español: ");
            string espanol = Console.ReadLine().Trim();

            Console.Write("Ingrese la traducción en inglés: ");
            string ingles = Console.ReadLine().Trim();

            if (!string.IsNullOrWhiteSpace(espanol) && !string.IsNullOrWhiteSpace(ingles))
            {
                // Llamamos al método AgregarPalabra y verificamos si tuvo éxito
                bool exito = traductor.AgregarPalabra(espanol, ingles);

                if (exito)
                {
                    Console.WriteLine($"Palabra '{espanol}' agregada correctamente.");
                }
                else
                {
                    Console.WriteLine("Esa palabra ya se encuentra registrada en el diccionario.");
                }
            }
            else
            {
                Console.WriteLine("Las palabras no pueden estar vacías.");
            }
        }
    }
}