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
                Console.WriteLine("Adicione Numeros até 0, separados por espaços");
                string[] input = Console.ReadLine().Split();
                List<int> serieNum = new List<int>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int intInput))
                    {
                        Console.WriteLine("Os números passados não são `integers`.");
                        return;
                    }
                    serieNum.Add(intInput);
                }

                List<int> subList = serieNum.TakeWhile(i => i != 0).ToList();

                if (!subList.Any())
                {
                    Console.WriteLine("Não existe zero (0) no seu input, tente novamente.");
                }
                else
                {
                    Console.WriteLine($"A serie de numeros lidos: {string.Join(", ", subList)}");
                    Console.WriteLine($"A quantidade de numeros lidos: {subList.Count}");
                    Console.WriteLine($"A Soma dos numeros lidos: {subList.Sum()}");
                    Console.WriteLine(
                        $"A quantidade de pares: {subList.Where(num => num % 2 == 0).Count()}");
                    
                    // Exit Method:
                    Console.WriteLine("\n\nAperte 'y' para recomeçar o cálculo, qualquer outra tecla para sair");
                    char keyChar = Console.ReadKey().KeyChar;
                    bool shouldContinue = (keyChar == 'y' || keyChar == 'Y');

                    if (!shouldContinue)
                    {
                        return; // Sai do programa
                    }
                }
            } while (true);
        }
    }
}
