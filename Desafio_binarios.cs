using System;

namespace Desafio_binarios
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        // Aqui voy a escrubur variables...
        Console.WriteLine("Ingrese el valor de b4, b3, b2, b1 y b0: ");
        int b4 = int.Parse(Console.ReadLine());
        int b3 = int.Parse(Console.ReadLine());
        int b2 = int.Parse(Console.ReadLine());
        int b1 = int.Parse(Console.ReadLine());
        int b0 = int.Parse(Console.ReadLine());

           /*ejemplo:
            0
            0
            1
            0
            1
            (2^1) * 1 = 2
            (2^2) * 0 = 0
            (2^3) * 1 = 8
            (2^4) * 0 = 0
            (2^5) * 0 = 0
            Suma 10
            */

         //Aqui calculamos en valor decimal
         double valor_decimal = (Math.Pow(2.0, 1.0) * b0) + (Math.Pow(2.0, 2.0) * b1) +
         (Math.Pow(2.0, 3.0) * b2) + (Math.Pow(2.0, 4.0) * b3) + (Math.Pow(2.0, 5.0) * b4);

         Console.WriteLine("Para el binario: " + b4 + b3 + b2 + b1 + b0 + ", el valor decimal es: " + valor_decimal);
        }
    }
}
