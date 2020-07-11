using System;

namespace Desafios1y2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// Entrada del usuario de las variables
			Console.WriteLine("Ingrese x1, y1, x2, y2 ");
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			//Hallamos la pendiente
			double pendiente = (y2 - y1) / (x2 - x1);
			Console.WriteLine("La pendiente es: " + pendiente);

			//Hallamos el intercepto
			double intercepto = y1 - (pendiente * x1);
			Console.WriteLine("El intercepto es: " + intercepto);

			//Hallamos la distancia 
			double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			Console.WriteLine("la distancia es: " + distancia);

			
		}
	}
}
