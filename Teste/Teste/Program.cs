using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contAno = 1; contAno <= 5; contAno++)
            {
                for (int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;

                    Console.WriteLine("Você ja tem poupando R$" + valorInvestido);
                }
                
            }

            fatorRendimento += 0.0010;           

        }
    }
}
