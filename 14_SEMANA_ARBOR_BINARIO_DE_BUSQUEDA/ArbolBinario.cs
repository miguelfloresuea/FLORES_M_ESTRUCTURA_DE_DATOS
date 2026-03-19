using System;

namespace ArbolBinarioBusqueda
{
    // Clase que gestiona el Árbol Binario de Búsqueda (BST)
    public class ArbolBinario
    {
        // Raíz del árbol
        public Nodo Raiz;

        // Constructor
        public ArbolBinario()
        {
            Raiz = null;
        }

        // =========================
        // INSERTAR UN NODO
        // =========================
        public void Insertar(int valor)
        {
            Raiz = InsertarRec(Raiz, valor);
        }

        private Nodo InsertarRec(Nodo raiz, int valor)
        {
            // Si el árbol está vacío, se crea un nuevo nodo
            if (raiz == null)
                return new Nodo(valor);

            // Si el valor es menor, va al subárbol izquierdo
            if (valor < raiz.Valor)
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
            else
                // Si es mayor, va al derecho
                raiz.Derecho = InsertarRec(raiz.Derecho, valor);

            return raiz;
        }

        // =========================
        // BUSCAR UN NODO
        // =========================
        public bool Buscar(int valor)
        {
            return BuscarRec(Raiz, valor);
        }

        private bool BuscarRec(Nodo raiz, int valor)
        {
            // Si no existe
            if (raiz == null)
                return false;

            // Si se encuentra
            if (raiz.Valor == valor)
                return true;

            // Buscar en subárbol correspondiente
            if (valor < raiz.Valor)
                return BuscarRec(raiz.Izquierdo, valor);
            else
                return BuscarRec(raiz.Derecho, valor);
        }

        // =========================
        // ELIMINAR UN NODO
        // =========================
        public void Eliminar(int valor)
        {
            Raiz = EliminarRec(Raiz, valor);
        }

        private Nodo EliminarRec(Nodo raiz, int valor)
        {
            if (raiz == null)
                return raiz;

            // Buscar el nodo
            if (valor < raiz.Valor)
                raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor);
            else if (valor > raiz.Valor)
                raiz.Derecho = EliminarRec(raiz.Derecho, valor);
            else
            {
                // Caso 1: sin hijos
                if (raiz.Izquierdo == null && raiz.Derecho == null)
                    return null;

                // Caso 2: un solo hijo
                if (raiz.Izquierdo == null)
                    return raiz.Derecho;
                else if (raiz.Derecho == null)
                    return raiz.Izquierdo;

                // Caso 3: dos hijos
                // Se obtiene el menor del subárbol derecho
                raiz.Valor = Minimo(raiz.Derecho);

                // Eliminar el nodo duplicado
                raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
            }

            return raiz;
        }

        // =========================
        // RECORRIDOS
        // =========================

        public void InOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                InOrden(raiz.Izquierdo);
                Console.Write(raiz.Valor + " ");
                InOrden(raiz.Derecho);
            }
        }

        public void PreOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.Valor + " ");
                PreOrden(raiz.Izquierdo);
                PreOrden(raiz.Derecho);
            }
        }

        public void PostOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                PostOrden(raiz.Izquierdo);
                PostOrden(raiz.Derecho);
                Console.Write(raiz.Valor + " ");
            }
        }

        // =========================
        // VALOR MÍNIMO
        // =========================
        public int Minimo(Nodo raiz)
        {
            while (raiz.Izquierdo != null)
                raiz = raiz.Izquierdo;

            return raiz.Valor;
        }

        // =========================
        // VALOR MÁXIMO
        // =========================
        public int Maximo(Nodo raiz)
        {
            while (raiz.Derecho != null)
                raiz = raiz.Derecho;

            return raiz.Valor;
        }

        // =========================
        // ALTURA DEL ÁRBOL
        // =========================
        public int Altura(Nodo raiz)
        {
            if (raiz == null)
                return -1;

            int izq = Altura(raiz.Izquierdo);
            int der = Altura(raiz.Derecho);

            return Math.Max(izq, der) + 1;
        }

        // =========================
        // LIMPIAR ÁRBOL
        // =========================
        public void Limpiar()
        {
            Raiz = null;
        }
    }
}