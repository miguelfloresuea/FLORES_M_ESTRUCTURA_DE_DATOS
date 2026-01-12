using System;

namespace _08_PALINDROMO
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto de la clase Palindromo
            Palindromo palindromo = new Palindromo();

            // Se solicita al usuario ingresar una palabra
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            // Se verifica si la palabra es palíndroma
            if (palindromo.EsPalindromo(palabra))
            {
                Console.WriteLine("La palabra ES un palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra NO es un palíndromo.");
            }

            // Pausa para ver el resultado
            Console.ReadKey();
        }
    }
}
