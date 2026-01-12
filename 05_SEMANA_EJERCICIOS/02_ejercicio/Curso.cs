using System;
using System.Collections.Generic;

namespace _01_EJERCICIO_ASIGNATURAS_2
{
    // Clase que representa un curso académico
    class Curso
    {
        // Lista simple que almacena las asignaturas
        private List<string> asignaturas;

        // Constructor: se ejecuta automáticamente al crear el objeto Curso
        public Curso()
        {
            // Inicialización de la lista
            asignaturas = new List<string>();
        }

        // Método para agregar una asignatura a la lista
        public void AgregarAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        // Método que recorre la lista y muestra cada asignatura
        public void MostrarAsignaturas()
        {
            // foreach permite recorrer cada elemento de la lista
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("Yo estudio " + asignatura);
            }
        }
    }
}
