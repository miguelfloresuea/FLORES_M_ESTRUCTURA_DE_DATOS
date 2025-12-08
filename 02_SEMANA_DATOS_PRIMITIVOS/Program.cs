using System;

namespace _02_SEMANA_DATOS_PRIMITIVOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================
            //   PROCESO PARA RECTÁNGULO
            // ============================
            Console.WriteLine("=== CÁLCULO PARA RECTÁNGULO ===");

            // Se crea un objeto de la clase Rectangulo
            Rectangulo rect = new Rectangulo();

            // Se piden los datos al usuario
            rect.LeerDatos();

            // Se calcula el área y el perímetro
            double areaRect = rect.CalcularArea();
            double perRect = rect.CalcularPerimetro();

            // Se muestran los resultados
            rect.Imprimir(areaRect, perRect);

            // ============================
            //      PROCESO PARA CÍRCULO
            // ============================
            Console.WriteLine("\n=== CÁLCULO PARA CÍRCULO ===");

            // Se crea el objeto de la clase Circulo
            Circulo cir = new Circulo();

            // Se leen los datos del usuario
            cir.LeerDatos();

            // Se calcula área y perímetro
            double areaCir = cir.CalcularArea();
            double perCir = cir.CalcularPerimetro();

            // Se imprimen los resultados
            cir.Imprimir(areaCir, perCir);
        }
    }
}
