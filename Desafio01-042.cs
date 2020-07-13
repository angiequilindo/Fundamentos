using System;

namespace Desafio01042
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el angulo b, d y el lado y");
            double bgrados = double.Parse(Console.ReadLine());
            double dgrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Conversion de los angulos a radianes
            double b = bgrados * Math.PI / 180.0;
            double d = dgrados * Math.PI / 180.0;
            double anguloa = (90- bgrados - dgrados)* Math.PI / 180.0;

            double z = y /Math.Tan(anguloa);
            Console.WriteLine("El valor del lado z es:"+ z);


        }
    }
}
