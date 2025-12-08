using System;

namespace _02_SEMANA_DATOS_PRIMITIVOS
{
    internal class Circulo
    {
        // ----------------------------------------------
        // Atributo privado (encapsulación)
        // ----------------------------------------------
        private double radio;

        // ----------------------------------------------
        // Método para leer el radio ingresado por el usuario
        // ----------------------------------------------
        public void LeerDatos()
        {
            Console.Write("Ingrese el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());
        }

        // ----------------------------------------------
        // Método para calcular el área
        // Fórmula: π * radio^2
        // ----------------------------------------------
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // ----------------------------------------------
        // Método para calcular el perímetro (circunferencia)
        // Fórmula: 2 * π * radio
        // ----------------------------------------------
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        // ----------------------------------------------
        // Método para imprimir resultados
        // ----------------------------------------------
        public void Imprimir(double area, double perimetro)
        {
            Console.WriteLine($"Área del círculo: {area}");
            Console.WriteLine($"Perímetro del círculo: {perimetro}");
        }
    }
}
