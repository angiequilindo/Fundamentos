using System;

namespace Desafio0202
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Aqui se ingresan los valores...
            Console.WriteLine("Ingrese el valor de t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de a en grados: ");
            double a = double.Parse(Console.ReadLine());

            //Aqui calculamos el angulo c
            double anguloc = 90.0 - a;
            Console.WriteLine("El valor del angulo c es: " + anguloc);

            //Aqui calculamos el lado y
            double ladoy = Math.Sin(Math.PI * a / 180.0) * t; 
            Console.WriteLine("El valor del lado y es: " + ladoy);

            //Aqui calculamos el lado z
            double ladoz = Math.Cos(Math.PI * a / 180.0) * t; 
            Console.WriteLine("El valor del lado z es: " + ladoz);


        }
    }
}
