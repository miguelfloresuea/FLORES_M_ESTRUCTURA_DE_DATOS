using System;

namespace EjercicioListas
{
    // Clase Nodo: Representa cada "vagón" de nuestro tren (la lista).
    public class Nodo
    {
        public int Data; // Aquí guardamos el número entero.
        
        // El signo de interrogación '?' indica que este campo puede ser 'null'.
        // Es necesario porque el último nodo de la lista no apunta a nadie (apunta a null).
        public Nodo? Next; 

        // Constructor: Se ejecuta cuando creamos un "new Nodo(5)".
        public Nodo(int data)
        {
            this.Data = data;
            this.Next = null; // Por defecto, un nodo nuevo no está conectado a nada.
        }
    }
}