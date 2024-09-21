using System;

namespace Desafio3
{
   class Program 
   {

        static void Main(string[] args) 
        {

            int index = 12;
            int soma = 0;
            int k = 1;

            while (k < index) 
            {
                k = k + 1;
                soma = soma + k;

                Console.WriteLine(soma);
            }
        }
   
    }
}
