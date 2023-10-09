using System;

namespace Desafios
{
    public class IntBuilder
    {
        public static void RealizarCalculos()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"A soma de todos os numeros de 1 a 100: {sum}");
            
        }
    }
}

/* Existe também a `formula aritmética`
int n = 100; // Limite
int sum = (n * (n + 1)) / 2; // Calculo direto

Console.WriteLine("A soma de 1 a 100: {sum}");
*/