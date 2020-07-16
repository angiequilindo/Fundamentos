using System;

namespace Desafio02EcuacionCuadratica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese a, b y c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminante = Math.Pow(b, 2) - (4 * a * c);

            double x1 = 0;
            double x2 = 0;

            if (discriminante > 0)

            {

                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);

                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine("Dos soluciones: ");
                Console.WriteLine("El valor de x1 es igual a " + x1);
                Console.WriteLine("El valor de x2 es igual a " + x2);

            }

            else if (discriminante == 0)

            {

                x1 = (-b) / (2 * a);

                Console.WriteLine("El valor de la solucion (unica) es ", x1);

            }

            else if (discriminante < 0)

            {

                Console.WriteLine("No es posible calcular la solucion");

            }

        }

    }
}
