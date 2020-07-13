using System;

namespace Desafiio0104
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el angulo b y los lados z, y");
            double bgrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Conversion de los angulos a radianes
            double b = bgrados * Math.PI / 180.0;

            //Hallamos angulo a
            double a = Math.Atan2(y, z);

            double x = (Math.Tan(b + a) * z) - y;

            Console.WriteLine("El valor del lado x es:" + x);


        }
    }
}
