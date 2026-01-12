using System;

namespace _06_ASIGNATURAS_REPETIR
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto de la clase Curso
            Curso curso = new Curso();

            // Se agregan las asignaturas al curso
            curso.AgregarAsignatura("Matemáticas");
            curso.AgregarAsignatura("Física");
            curso.AgregarAsignatura("Química");
            curso.AgregarAsignatura("Historia");
            curso.AgregarAsignatura("Lengua");

            Console.WriteLine("Ingrese las notas de cada asignatura:\n");

            // Se solicitan las notas al usuario
            curso.RegistrarNotas();

            // Se eliminan las asignaturas aprobadas
            curso.EliminarAprobadas();

            // Se muestran las asignaturas que debe repetir
            curso.MostrarAsignaturasRepetir();

            Console.ReadKey();
        }
    }
}
