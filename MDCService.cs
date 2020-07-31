using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao6
{
    class MDCService
    {
        public void CalcularMDC()
        {
            int num1, dividendo;
            int num2, divisor, resto;

            Console.WriteLine("Digite o primeiro número");
            num1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = Convert.ToInt32(System.Console.ReadLine());

            if (num1 == 0 || num2 == 0)
                System.Console.WriteLine("Não são permitidos valores iguais a 0!");

            if (num1 > num2)
            {
                dividendo = num1;
                divisor = num2;
            }
            else
            {
                dividendo = num2;
                divisor = num1;
            }

            while (dividendo % divisor != 0)
            {
                resto = dividendo % divisor;
                dividendo = divisor;
                divisor = resto;
            }

            Console.WriteLine($"MDC = {divisor}");

        }
    }
}
