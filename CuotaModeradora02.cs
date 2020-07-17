using System;

namespace CuotaModeradora02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su regimen, (1) subsidiado, (2) contributivo ");
            int regimen = int.Parse(Console.ReadLine());

            if (regimen == 1)
            {
                Console.WriteLine("El valor de su cuota moderadora es 0 ");
            }
            else if (regimen == 2)
            {

                Console.WriteLine("Ingrese su salario: ");
                int salario = int.Parse(Console.ReadLine());

                int smmlv = 877803;

                if (salario < (2 * smmlv))

                {

                    Console.WriteLine("Su tarifa es A");
                    Console.WriteLine("El valor de la cuota moderadora es del 3400 ");

                }

                else if (salario >= (2 * smmlv) && salario <= (5 * smmlv))

                {

                    Console.WriteLine("Su tarifa es B ");
                    Console.WriteLine("El valor de la cuota moderadora es del 13500 ");

                }

                else if (salario > (5 * smmlv))

                {

                    Console.WriteLine("Su tarifa es C");
                    Console.WriteLine("El valor de la cuota moderadora es del 35600 ");
                }
            }

        }
    }
}
