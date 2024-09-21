using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário para digitar uma palavra
            Console.WriteLine("Escreva uma palavra ou frase:");
            string input = Console.ReadLine();

        
            int count = 0;

            // Verifica quantos caracteres são correspondentes a letra 'A' na palavra digitada
            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

           if (count > 0) 
            {
                Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) ocorre {count} vez(es) na string.");
            }
            else 
            {
                Console.WriteLine("A letra 'a' não foi encontrada na palavra digitada");
            }
            
        }
    }
}