using System;
using System.Collections.Generic;

namespace _06_ASIGNATURAS_REPETIR
{
    // Clase que representa un curso académico
    class Curso
    {
        // Lista que almacena las asignaturas
        private List<string> asignaturas;

        // Diccionario para almacenar la nota de cada asignatura
        private Dictionary<string, double> notas;

        // Constructor: inicializa las estructuras de datos
        public Curso()
        {
            asignaturas = new List<string>();
            notas = new Dictionary<string, double>();
        }

        // Método para agregar asignaturas a la lista
        public void AgregarAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        // Método para registrar las notas ingresadas por el usuario
        public void RegistrarNotas()
        {
            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Nota de {asignatura}: ");
                double nota = double.Parse(Console.ReadLine());

                // Se guarda la nota asociada a la asignatura
                notas[asignatura] = nota;
            }
        }

        // Método que elimina de la lista las asignaturas aprobadas
        public void EliminarAprobadas()
        {
            // Se eliminan las asignaturas con nota mayor o igual a 7
            asignaturas.RemoveAll(asignatura => notas[asignatura] >= 7);
        }

        // Método que muestra las asignaturas que se deben repetir
        public void MostrarAsignaturasRepetir()
        {
            Console.WriteLine("\nAsignaturas que debe repetir:");

            if (asignaturas.Count == 0)
            {
                Console.WriteLine("Ninguna. Todas las asignaturas están aprobadas.");
            }
            else
            {
                foreach (string asignatura in asignaturas)
                {
                    Console.WriteLine("- " + asignatura);
                }
            }
        }
    }
}
