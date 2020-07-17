using System;

namespace Desafio01CalculoDeTarifa
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());

            int smmlv = 877803;

            if (salario < (2 * smmlv))

            {

                Console.WriteLine("Su tarifa es A");

            }

            else if (salario >= (2 * smmlv) && salario < (4 * smmlv))

            {

                Console.WriteLine("Su tarifa es B ");

            }

            else if (salario >= (4 * smmlv))

            {

                Console.WriteLine("Su tarifa es C");
            }
        }

    }
}
