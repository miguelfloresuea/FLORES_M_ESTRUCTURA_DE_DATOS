using System;

namespace RegistroEstudiante
{
    // Clase Estudiante que representa la información del estudiante
    class Estudiante
    {
        // Atributos del estudiante
        public int Id;
        public string Nombres;
        public string Apellidos;
        public string Direccion;

        // Array para almacenar los números de teléfono
        public string[] Telefonos;

        // Constructor para inicializar el array de teléfonos
        public Estudiante()
        {
            Telefonos = new string[3]; // Se definen exactamente 3 teléfonos
        }
    }
}
