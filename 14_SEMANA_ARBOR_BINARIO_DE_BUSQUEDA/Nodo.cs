using System;

namespace ArbolBinarioBusqueda
{
    // Clase Nodo: representa cada elemento del árbol
    public class Nodo
    {
        // Valor que almacena el nodo
        public int Valor;

        // Referencia al hijo izquierdo
        public Nodo Izquierdo;

        // Referencia al hijo derecho
        public Nodo Derecho;

        // Constructor: inicializa el nodo con un valor
        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }
}