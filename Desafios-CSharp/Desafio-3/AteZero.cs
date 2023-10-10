using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    public class AteZero
    {
        public static void RealizarCalculos()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Adicione Numeros até 0, separados por espaços, ou escreva 'exit' para sair:");
                string[] input = Console.ReadLine().Split();

                if (input.Contains("exit", StringComparer.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }

                List<int> serieNum = new List<int>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int intInput))
                    {
                        Console.WriteLine("Os números passados não são `integers`.");
                        Console.ReadKey();
                        return;
                    }
                    serieNum.Add(intInput);
                }

                if (!serieNum.Contains(0))
                {
                    Console.WriteLine("O seu input não contem 0.");
                    Console.ReadKey();
                    break;
                }

                List<int> subList = serieNum.TakeWhile(i => i != 0).ToList();

                Console.WriteLine($"A serie de numeros lidos: {string.Join(", ", subList)}");
                Console.WriteLine($"A quantidade de numeros lidos: {subList.Count}");
                Console.WriteLine($"A Soma dos numeros lidos: {subList.Sum()}");
                Console.WriteLine(
                    $"A quantidade de pares: {subList.Count(num => num % 2 == 0)}");
                Console.ReadKey();
            } while (true);
        }
    }
}