using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Váriaveis");

            int idade = 23;
            double peso = 62.5;


            Console.WriteLine("minha idade é  " + idade + " e tenho " + peso + " quilos.");

            //conversor
            double comprimento = 20.5;
            int metro = (int)comprimento;

            //character usar aspas simples
            char umaLetra = 'a';


            umaLetra = (char)65; // return "A" 

            umaLetra = (char)(umaLetra + 1); // return "B"


            string texto = "texto";

            //if (condição)  || = or
            //{                 && = and
            //    comando;
            //}
            //else
            //{
            //    comando;
            //}

            bool boolean = idade >= 20;

            //while (condição)
            //{
            //    comando;

            //    condição++;
            //}






        }
    }
}
