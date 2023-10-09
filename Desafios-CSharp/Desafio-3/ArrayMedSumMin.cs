using System;
using System.Linq;

namespace Desafios
{
    public class ArrayMedSumMin
    {
        public static int[] GetElements(string[] input, int[] vetorParse)
        {
            if (input.Length != 10)
            {
                Console.WriteLine("O tamanho do array é diferente de 10, adicione mais números.");
                return null; // Erro
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out int intInput))
                {
                    Console.WriteLine("Os números passados não são `integers`.");
                    return null; // Erro
                }

                vetorParse[i] = intInput;
            }

            return vetorParse;
        }

        public static void RealizarCalculos()
        {
            do
            {
                Console.WriteLine("Insira um vetor de 10 valores, separados por espaços (Somente `integers`):");
                string[] input = Console.ReadLine().Split();
                int[] vetorParse = new int[10];

                int[] result = GetElements(input, vetorParse);

                if (result != null)
                {
                    Console.Clear();
                    Console.WriteLine($"O Vetor é: {string.Join(", ", result)}");
                    Console.WriteLine($"A soma dos Elementos do Vetor é: {result.Sum()}");
                    Console.WriteLine($"O menor elemento do vetor é: {result.Min()}");
                    Console.WriteLine($"A média do Array é: {result.Average()}");
                }
                
                // Método de saida:
                
                Console.WriteLine("\n\nAperte 'y' para recomeçar o cálculo, qualquer outra tecla para sair");
                char keyChar = Console.ReadKey().KeyChar;
                bool shouldContinue = (keyChar == 'y' || keyChar == 'Y');

                Console.Clear();
                if (!shouldContinue)
                {
                    break;
                }
            } while (true);
        }
    }
}
