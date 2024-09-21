using System;

namespace Desafio 
{

    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            if (pertenceFibonacci(n)) 
            {
                Console.WriteLine($"O número {n} pertence à sequência de Fibonacci");
            }
            else 
            {
                Console.WriteLine($"O número {n} não pertence a sequência de Fibonacci!");
            }
        }

        static bool pertenceFibonacci(int n) 
        {
            if(n == 0 || n == 1) 
            {
                return true;
            }

            int a = 0, b = 1, temp;

            while(b < n)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b == n;
        }
    }   
}