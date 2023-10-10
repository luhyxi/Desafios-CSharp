using System;

namespace Desafios
{
    public class Fibonacci
    {
        public static void RealizarCalculos()
        {
            do
            {
                long a = 0, b = 1; //Termos do Fib
            
                Console.WriteLine("Insira o Termo ´N´ ou digite `exit` para sair." +
                                  "\n(Somente serão aceitos `integers` positivos no input)");
                string input = Console.ReadLine();
                
                // Excessões
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }
                if (!int.TryParse(input, out int nTermo) || nTermo <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor insira um `integer` positivo.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

                for (int i = 2; i <= nTermo; i++)
                {
                    long n = a + b;
                    a = b;
                    b = n;
                } Console.WriteLine($"\nO termo N[{nTermo}] da sequencia de fibonacci é: {b}" +
                                    $"\nPrecione qualquer tecla para continuar a contar");
                Console.ReadKey();
                Console.Clear();
                
            } while (true);

        }
    }
}