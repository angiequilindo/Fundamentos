using System;

namespace Desafio01IMC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su peso (kg) y su estatura (m)");
            double peso = double.Parse(Console.ReadLine());
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(estatura, 2);
            Console.WriteLine("Su imc es" + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Peso inferior al normal");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (25.0 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Peso superior al normal");
            }
            else if (imc >= 30.0)
            {

                Console.WriteLine("Obesidad");
            }



        }



    }
}
