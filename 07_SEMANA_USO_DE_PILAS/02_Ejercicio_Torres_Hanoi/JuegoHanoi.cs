using System;
using System.Collections.Generic; // Necesario para Stack<T>

namespace TorresHanoi
{
    public class JuegoHanoi
    {
        // Representamos las 3 torres como Pilas de enteros
        // Fuente: "Java proporciona una clase llamada Stack... C# Stack<int>" [cite: 109, 105]
        private Stack<int> _torreA;
        private Stack<int> _torreB;
        private Stack<int> _torreC;

        public JuegoHanoi()
        {
            _torreA = new Stack<int>();
            _torreB = new Stack<int>();
            _torreC = new Stack<int>();
        }

        public void IniciarJuego(int n)
        {
            // 1. Llenamos la torre A (Origen)
            // Insertamos los discos del más grande al más pequeño
            // para que el pequeño quede en el Top (cima).
            for (int i = n; i >= 1; i--)
            {
                _torreA.Push(i); // Push: Agrega elemento a la parte superior 
            }

            Console.WriteLine($"Estado inicial con {n} discos en Torre A.");
            MostrarEstado();

            // 2. Iniciamos el algoritmo recursivo
            MoverDiscos(n, _torreA, _torreC, _torreB, 'A', 'C', 'B');
        }

        // Algoritmo recursivo que manipula las Pilas reales
        private void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, char nombreOrigen, char nombreDestino, char nombreAux)
        {
            // Caso base: Si n es 0, no hay nada que mover
            if (n == 0) return;

            // Paso 1: Mover n-1 discos de Origen a Auxiliar
            // Las llamadas recursivas se agregan a la pila del sistema [cite: 68]
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAux, nombreDestino);

            // Paso 2: Mover el disco n de Origen a Destino
            // Operación POP: Elimina el elemento superior 
            int disco = origen.Pop();
            
            // Operación PUSH: Agrega el elemento a la nueva torre 
            destino.Push(disco);

            Console.WriteLine($"\n>> Mover disco {disco} de Torre {nombreOrigen} a Torre {nombreDestino}");
            MostrarEstado(); // Mostramos visualmente cómo quedan las pilas

            // Paso 3: Mover los n-1 discos de Auxiliar a Destino
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAux, nombreDestino, nombreOrigen);
        }

        // Método auxiliar para visualizar el contenido de las pilas (solo para fines educativos)
        private void MostrarEstado()
        {
            Console.WriteLine($"   Torre A: {String.Join(", ", _torreA)}");
            Console.WriteLine($"   Torre B: {String.Join(", ", _torreB)}");
            Console.WriteLine($"   Torre C: {String.Join(", ", _torreC)}");
        }
    }
}