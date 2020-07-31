using System;

namespace blackjack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random generadorAleatorio = new Random();
            int carta_inicial_uno = generadorAleatorio.Next(1, 11); // De 1 a 10
            int carta_inicial_dos = generadorAleatorio.Next(1, 11); // De 1 a 10

            Console.WriteLine("La primera carta recibida es " + carta_inicial_uno);
            Console.WriteLine("La segunda carta recibida es " + carta_inicial_dos);

            int total = carta_inicial_uno + carta_inicial_dos;

            Console.WriteLine("Su mano equivale a " + total);

            bool continuar = true;

            //Preguntar si quiere pararse
            Console.WriteLine("Desea parar? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                continuar = false;
            }
            else
            {
                continuar = true;
            }

            while (continuar)
            {

                //Pedir mano
                int nueva_carta = generadorAleatorio.Next(1, 11);
                Console.WriteLine("Recibio un " + nueva_carta);
                total = total + nueva_carta;

                Console.WriteLine("Su mano equivale a " + total);

                //Revisar que no se haya volado
                if (total == 21)
                {
                    continuar = false;
                    Console.WriteLine("Ganaste!!!!!!!");
                }
                else if (total > 21)
                {
                    continuar = false;
                    Console.WriteLine("Perdiste, te volaste");
                }
                else
                {
                    //Preguntar si quiere pararse
                    Console.WriteLine("Desea parar? (s/n)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s")
                    {
                        continuar = false;
                    }

                }
            }



        }
    }
}