using System;

namespace _02_SEMANA_DATOS_PRIMITIVOS
{
    internal class Rectangulo
    {
        // --------------------------------------------------
        // Atributos privados (encapsulación)
        // --------------------------------------------------
        private double baseRect;
        private double altura;

        // --------------------------------------------------
        // Método para solicitar los datos al usuario
        // --------------------------------------------------
        public void LeerDatos()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
        }

        // --------------------------------------------------
        // Método que calcula el área del rectángulo
        // Fórmula: base * altura
        // --------------------------------------------------
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // --------------------------------------------------
        // Método que calcula el perímetro del rectángulo
        // Fórmula: 2 * (base + altura)
        // --------------------------------------------------
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }

        // --------------------------------------------------
        // Método para mostrar los resultados al usuario
        // --------------------------------------------------
        public void Imprimir(double area, double perimetro)
        {
            Console.WriteLine($"Área del rectángulo: {area}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetro}");
        }
    }
}
