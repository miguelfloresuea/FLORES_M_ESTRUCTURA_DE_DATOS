using System;
using System.Collections.Generic;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una lista de tipo entero para almacenar los precios
            List<int> precios = new List<int>()
            {
                50, 75, 46, 22, 80, 65, 8
            };

            // Se inicializan las variables mayor y menor
            // Ambas comienzan con el primer valor de la lista
            int precioMenor = precios[0];
            int precioMayor = precios[0];

            // Se recorre la lista de precios
            foreach (int precio in precios)
            {
                // Si el precio actual es menor que el registrado, se actualiza
                if (precio < precioMenor)
                {
                    precioMenor = precio;
                }

                // Si el precio actual es mayor que el registrado, se actualiza
                if (precio > precioMayor)
                {
                    precioMayor = precio;
                }
            }

            // Se muestran los resultados por pantalla
            Console.WriteLine("El precio menor es: " + precioMenor);
            Console.WriteLine("El precio mayor es: " + precioMayor);

            // Pausa para que la consola no se cierre automáticamente
            Console.ReadKey();
        }
    }
}
