using System;

namespace Desafio01043
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el angulo d,  y los lados w, x");
            double dgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            //Conversion de los angulos a radianes
            double d = dgrados * Math.PI / 180.0;

            double ladoy = (Math.Cos(d) * w) - x;
            Console.WriteLine("El valor del lado y es:" + ladoy);
        }
    }
}
