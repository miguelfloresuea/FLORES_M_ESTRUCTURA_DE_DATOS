using System;
using System.Collections.Generic; // Necesario para usar Stack<T>

namespace BalanceoParentesis
{
    public class VerificadorBalanceo
    {
        // Declaramos la pila de caracteres
        private Stack<char> _pila;

        public VerificadorBalanceo()
        {
            // Inicializamos la pila. En C# usamos la clase genérica Stack<T>
            _pila = new Stack<char>();
        }

        public bool EsFormulaBalanceada(string formula)
        {
            _pila.Clear(); // Aseguramos que la pila inicie vacía

            foreach (char caracter in formula)
            {
                // Si es apertura, hacemos PUSH (Insertar)
                if (caracter == '(' || caracter == '{' || caracter == '[')
                {
                    _pila.Push(caracter);
                }
                // Si es cierre, verificamos y hacemos POP (Sacar)
                else if (caracter == ')' || caracter == '}' || caracter == ']')
                {
                    // isEmpty: Si la pila está vacía y llega un cierre, es error
                    if (_pila.Count == 0)
                    {
                        return false;
                    }

                    // Sacamos el último elemento (LIFO) para comparar
                    char ultimoAbierto = _pila.Pop();

                    if (!SonPareja(ultimoAbierto, caracter))
                    {
                        return false;
                    }
                }
            }

            // Si la pila queda vacía, todo está balanceado
            return _pila.Count == 0;
        }

        private bool SonPareja(char apertura, char cierre)
        {
            if (apertura == '(' && cierre == ')') return true;
            if (apertura == '{' && cierre == '}') return true;
            if (apertura == '[' && cierre == ']') return true;
            return false;
        }
    }
}