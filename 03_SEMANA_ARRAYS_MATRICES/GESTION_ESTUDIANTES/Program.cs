using System;

namespace RegistroEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Estudiante
            Estudiante estudiante = new Estudiante();

            // Solicitar y leer el ID del estudiante
            Console.Write("Ingrese el número de cédula del estudiante: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            // Solicitar y leer los nombres
            Console.Write("Ingrese los nombres del estudiante: ");
            estudiante.Nombres = Console.ReadLine();

            // Solicitar y leer los apellidos
            Console.Write("Ingrese los apellidos del estudiante: ");
            estudiante.Apellidos = Console.ReadLine();

            // Solicitar y leer la dirección
            Console.Write("Ingrese la dirección del estudiante: ");
            estudiante.Direccion = Console.ReadLine();

            // Ingreso de los teléfonos usando un ciclo for y un array
            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            // Mostrar los datos del estudiante
            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE REGISTRADO ---");
            Console.WriteLine($"Cédula: {estudiante.Id}");
            Console.WriteLine($"Nombres: {estudiante.Nombres}");
            Console.WriteLine($"Apellidos: {estudiante.Apellidos}");
            Console.WriteLine($"Dirección: {estudiante.Direccion}");

            // Mostrar los teléfonos almacenados en el array
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {estudiante.Telefonos[i]}");
            }

            // Pausa para evitar que la consola se cierre
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
