using System;

namespace Desafio0201
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Aqui voy a escrubir las variables...
            Console.WriteLine("Ingrese el valor de y, z: ");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());


            //Aqui calculamos el angulo c
            double anguloc = Math.Atan2(z, y) * (180.0 / Math.PI);
            Console.WriteLine("El valor del angulo c es: " + anguloc);

            //Aqui calculamos el angulo a
            double anguloa = Math.Atan2(y, z) * (180.0 / Math.PI);
            Console.WriteLine("El valor del angulo a es: " + anguloa);

            //Aqui calculamos el lado t
            double ladot = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            Console.WriteLine("El valor del lado t es: " + ladot);
        }
    }
}
