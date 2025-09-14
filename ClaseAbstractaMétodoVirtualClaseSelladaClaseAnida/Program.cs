using System;

namespace ClasesAvanzadas
{
    // Clase abstracta
    abstract class Figura
    {
        public abstract double Area(); // Método abstracto (debe implementarse en hijos)

        public virtual void Dibujar() // Método virtual (puede redefinirse o no)
        {
            Console.WriteLine("Dibujando figura genérica...");
        }
    }

    // Clase derivada que implementa abstracto y sobrescribe virtual
    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando círculo...");
        }

        // Clase anidada (definida dentro de otra)
        public class Informacion
        {
            public static void MostrarInfo()
            {
                Console.WriteLine("El círculo es una figura plana definida por un radio.");
            }
        }
    }

    // Clase sellada: no puede heredarse
    sealed class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;
        }

        // No sobrescribimos Dibujar, usa el de Figura
    }

    class Program
    {
        static void Main()
        {
            Figura f1 = new Circulo(5);
            Figura f2 = new Cuadrado(4);

            f1.Dibujar();
            Console.WriteLine($"Área círculo: {f1.Area()}");

            f2.Dibujar();
            Console.WriteLine($"Área cuadrado: {f2.Area()}");

            // Uso de clase anidada
            Circulo.Informacion.MostrarInfo();
        }
    }
}
