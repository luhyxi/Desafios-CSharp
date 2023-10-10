using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Desafios
{
    public class SumPar
    {
        public static void RealizarCalculos()
        {
            List<int> parLista = new List<int>();
            do
            {
                Console.WriteLine($"Insira uma serie de numeros `integer` positivos, retornará a soma de todos os pares" +
                                  $"\n(Insira `exit` para sair");
                string[] input = Regex.Split(Console.ReadLine(), @"[, ]+");
                
                if (input.Contains("exit", StringComparer.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }
                
                // Parseando numeros um por um
                for (int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int numero) || numero < 0)
                    {
                        Console.WriteLine("Por favor, insira um numero `integer` positivo");
                        Console.ReadKey();
                        return;
                    }

                    if (numero % 2 == 0)
                    {
                        parLista.Add(numero);
                    }
                }
                
                // Resultado Excessão:
                if (parLista.Count == 0)
                {
                    Console.WriteLine("\nO input não possui nenhum conjunto de pares\n");
                    Console.ReadKey();
                    return;
                }
                
                // Resultado
                Console.WriteLine($"Os numeros pares do input são:{string.Join(", ", parLista)} \n" +
                                  $"A soma deles são: {parLista.Sum()} \n");
                Console.ReadKey();
                parLista.Clear();
            } while (true);
        }
    }
}