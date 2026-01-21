using System;

namespace BalanceoParentesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciar la clase lógica
            // La lógica LIFO se mantiene encapsulada aquí [cite: 43]
            VerificadorBalanceo verificador = new VerificadorBalanceo();

            Console.WriteLine("--- Verificación de Expresiones Matemáticas (Pilas) ---");
            
            // 2. Solicitar entrada manual al usuario
            Console.Write("Por favor, ingrese la expresión matemática a evaluar: ");
            string entrada = Console.ReadLine(); // Captura lo que escribe el usuario

            // Validamos que no esté vacío
            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Error: No ingresó ninguna expresión.");
            }
            else
            {
                // 3. Llamar al método de validación
                bool resultado = verificador.EsFormulaBalanceada(entrada);

                // 4. Mostrar resultado
                if (resultado)
                {
                    Console.WriteLine("\nResultado: Fórmula BALANCEADA.");
                }
                else
                {
                    Console.WriteLine("\nResultado: Fórmula NO balanceada.");
                }
            }

            // Evitar que se cierre la consola inmediatamente
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}