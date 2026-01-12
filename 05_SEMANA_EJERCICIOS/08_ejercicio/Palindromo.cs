using System;

namespace _08_PALINDROMO
{
    // Clase que contiene los métodos para verificar palíndromos
    class Palindromo
    {
        // Método que determina si una palabra es palíndroma
        public bool EsPalindromo(string palabra)
        {
            // Se convierte la palabra a minúsculas para evitar errores por mayúsculas
            palabra = palabra.ToLower();

            // Se obtienen los caracteres de la palabra
            char[] caracteres = palabra.ToCharArray();

            // Se invierte el arreglo de caracteres
            Array.Reverse(caracteres);

            // Se crea la palabra invertida
            string palabraInvertida = new string(caracteres);

            // Se compara la palabra original con la invertida
            return palabra == palabraInvertida;
        }
    }
}
