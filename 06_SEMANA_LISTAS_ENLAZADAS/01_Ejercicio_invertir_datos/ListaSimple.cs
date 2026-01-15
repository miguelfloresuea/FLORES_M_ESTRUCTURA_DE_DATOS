using System;

namespace ListaInvertida
{
    public class ListaSimple
    {
        private Nodo? head;

        public ListaSimple()
        {
            head = null;
        }

        // Método para verificar si la lista tiene datos (útil para validaciones)
        public bool EstaVacia()
        {
            return head == null;
        }

        public void InsertarFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);

            if (head == null)
            {
                head = nuevoNodo;
            }
            else
            {
                Nodo actual = head;
                while (actual.Next != null)
                {
                    actual = actual.Next;
                }
                actual.Next = nuevoNodo;
            }
        }

        // --- MÉTODO INVERTIR (Tu ejercicio principal) ---
        public void InvertirLista()
        {
            Nodo? anterior = null;
            Nodo? actual = head;
            Nodo? siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Next; 
                actual.Next = anterior;  
                anterior = actual;       
                actual = siguiente;      
            }
            head = anterior;
        }

        // --- MÉTODO DIBUJAR (Modificado: Sin 'head' ni 'null') ---
        public void DibujarLista()
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo? actual = head;
            
            // Recorremos la lista
            while (actual != null)
            {
                Console.Write($"[{actual.Data}]");

                // Solo dibujamos la flecha si NO es el último elemento
                if (actual.Next != null)
                {
                    Console.Write(" -> ");
                }
                
                actual = actual.Next;
            }
            // Hacemos un salto de línea al final para que se vea ordenado
            Console.WriteLine(); 
        }
    }
}