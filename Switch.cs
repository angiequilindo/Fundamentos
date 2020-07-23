using System;

namespace switchC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato, (1) dependiente, (2) independiente ");
            int contrato = int.Parse(Console.ReadLine());

            int smmlv = 877803;

            double base_cotizacion = salario * 0.4;

            if (base_cotizacion < smmlv)
            {
                base_cotizacion = smmlv;
            }

            double deduccion_arl = 0;
            double deduccion_eps = 0;
            double deduccion_pension = 0;

            switch (contrato)
            {

                case 1:
                    deduccion_arl = 0;
                    deduccion_eps = base_cotizacion * 0.04;
                    deduccion_pension = base_cotizacion * 0.04;
                    break;
                case 2:
                    // Calculemos la deduccion arl
                    Console.WriteLine("Ingrese un numero de 1 a 5 equivalente a la clase del riesgo: ");
                    int clase_riesgo = int.Parse(Console.ReadLine());

                    switch (clase_riesgo)
                    {
                        case 1:
                            deduccion_arl = base_cotizacion * 0.00522;
                            break;
                        case 2:
                            deduccion_arl = base_cotizacion * 0.01044;
                            break;
                        case 3:
                            deduccion_arl = base_cotizacion * 0.02436;
                            break;
                        case 4:
                            deduccion_arl = base_cotizacion * 0.0435;
                            break;
                        case 5:
                            deduccion_arl = base_cotizacion * 0.0696;
                            break;
                    }

                    //Calculemos las otras dos deducciones (eps y pension)
                    deduccion_eps = base_cotizacion * 0.125;
                    deduccion_pension = base_cotizacion * 0.16;
                    break;
            }

            double total_deducciones = deduccion_arl + deduccion_eps + deduccion_pension;
            double salario_real = salario - total_deducciones;
            double salario_anual = salario_real * 12;

            if (contrato == 1)
            {
                // La prima es igual a un salario sin deducciones
                // La prima solo se adiciona si es trabajador dependiente
                salario_anual = salario_anual + salario; // salario_anual += salario;
            }

            Console.WriteLine("El salario real mensual es: " + salario_real);
            Console.WriteLine("El salario anual total es: " + salario_anual);

        }
    }
}
