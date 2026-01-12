using System;
using System.Collections.Generic;

namespace _02_LOTERIA_PRIMITIVA
{
    // Clase que representa la Lotería Primitiva
    class Loteria
    {
        // Lista simple que almacena los números ganadores
        private List<int> numeros;

        // Constructor: inicializa la lista
        public Loteria()
        {
            numeros = new List<int>();
        }

        // Método para agregar un número a la lista
        public void AgregarNumero(int numero)
        {
            numeros.Add(numero);
        }

        // Método que ordena los números de menor a mayor
        public void OrdenarNumeros()
        {
            // El método Sort ordena automáticamente la lista
            numeros.Sort();
        }

        // Método que muestra los números por pantalla
        public void MostrarNumeros()
        {
            Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");

            // Se recorre la lista y se muestran los valores
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}
