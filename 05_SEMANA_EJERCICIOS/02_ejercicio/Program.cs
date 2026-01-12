using System;

namespace _01_EJERCICIO_ASIGNATURAS_2
{
    // Clase principal donde inicia la ejecución del programa
    class Program
    {
        // Método Main: punto de entrada de toda aplicación en C#
        static void Main(string[] args)
        {
            // Se crea un objeto de la clase Curso
            Curso curso = new Curso();

            // Se agregan las asignaturas a la lista
            curso.AgregarAsignatura("Matemáticas");
            curso.AgregarAsignatura("Física");
            curso.AgregarAsignatura("Química");
            curso.AgregarAsignatura("Historia");
            curso.AgregarAsignatura("Lengua");

            // Se muestran las asignaturas almacenadas en la lista
            curso.MostrarAsignaturas();

            // Pausa la consola para ver el resultado
            Console.ReadKey();
        }
    }
}
