using System;

namespace EjercicioListas
{
    public class ListaSimple
    {
        // 'head' es la referencia al primer nodo de la lista.
        // Si head es null, la lista está vacía.
        private Nodo? head;

        public ListaSimple()
        {
            head = null;
        }

        // --- MÉTODO CLAVE: INSERTAR POR EL INICIO ---
        // Al insertar al inicio, el último dato que ingreses será el primero de la lista.
        // Esto funciona como una Pila.
        public void InsertarInicio(int dato)
        {
            // 1. Creamos el nuevo nodo con el dato recibido.
            Nodo nuevoNodo = new Nodo(dato);
            
            // 2. Conectamos el nuevo nodo al nodo que actualmente es head.
            // Si la lista estaba vacía, nuevoNodo.Next apuntará a null.
            nuevoNodo.Next = head;
            
            // 3. Movemos la etiqueta 'head' al nuevo nodo.
            // Ahora el nuevo nodo es oficialmente el primero de la lista.
            head = nuevoNodo;
        }

        // --- MÉTODO PARA CONTAR ELEMENTOS ---
        // Necesitamos esto para saber si las listas tienen el "mismo tamaño".
        public int ContarNodos()
        {
            int contador = 0;
            Nodo? actual = head; // Empezamos desde el principio

            // Recorremos toda la lista hasta llegar al final (null)
            while (actual != null)
            {
                contador++;          // Contamos 1
                actual = actual.Next; // Saltamos al siguiente nodo
            }
            return contador; // Devolvemos el total
        }

        // --- MÉTODO AUXILIAR PARA OBTENER EL INICIO ---
        // Esto permite que desde el "Program.cs" podamos acceder al primer nodo
        // para empezar a comparar dato por dato.
        public Nodo? GetHead()
        {
            return head;
        }

        // --- MÉTODO PARA DIBUJAR ---
        // Muestra la lista limpia, sin palabras técnicas.
        public void DibujarLista()
        {
            if (head == null)
            {
                Console.WriteLine("(Vacía)");
                return;
            }

            Nodo? actual = head;
            while (actual != null)
            {
                Console.Write($"[{actual.Data}]");
                
                // Solo dibujamos la flecha si NO es el último nodo
                if (actual.Next != null) 
                {
                    Console.Write(" -> ");
                }
                
                actual = actual.Next;
            }
            Console.WriteLine(); // Salto de línea al terminar
        }
    }
}