using System;

namespace Desafio0203
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Aqui se ingresan los valores...
            Console.WriteLine("Ingrese el valor de z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de c en grados: ");
            double c = double.Parse(Console.ReadLine());

            //Aqui calculamos el angulo a
            double anguloa = 90.0 - c;
            Console.WriteLine("El valor del angulo a es: " + anguloa);

            //Aqui calculamos el lado y
            double ladoy = z / Math.Tan(Math.PI * c / 180.0);
            Console.WriteLine("El valor del lado y es: " + ladoy);

            //Aqui calculamos el lado t
            double ladot = z/Math.Sin(Math.PI * c / 180.0);
            Console.WriteLine("El valor del lado t es: " + ladot);


        }
    }
}
