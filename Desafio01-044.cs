using System;

namespace Desafio01044
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el angulo c,  y los lados w, t");
            double cgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            //Conversion de los angulos a radianes
            double c = cgrados * Math.PI / 180.0;

            //Lados del triangulo pequeno
            double z = t * Math.Sin(c); 
            double y = t * Math.Cos(c); 

            //Angulo d
            double d = Math.Asin(z / w); //no paso a radianes porque son dos lados 

            //Lado x
            double x = ((Math.Cos(d) * w) - y);

            Console.WriteLine("El valor del lado x es:" + x);

                
        }
    }
}
