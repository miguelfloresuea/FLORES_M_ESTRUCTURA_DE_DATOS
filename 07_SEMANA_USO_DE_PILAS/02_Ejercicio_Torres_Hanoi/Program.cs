using System;

namespace TorresHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            JuegoHanoi juego = new JuegoHanoi();

            Console.WriteLine("--- Resolución Torres de Hanoi con PILAS (Stacks) ---");
            Console.Write("Ingrese el número de discos (ej. 3): ");
            
            if (int.TryParse(Console.ReadLine(), out int numDiscos) && numDiscos > 0)
            {
                juego.IniciarJuego(numDiscos);
            }
            else
            {
                Console.WriteLine("Por favor ingrese un número entero válido mayor a 0.");
            }

            Console.WriteLine("\nJuego terminado. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}