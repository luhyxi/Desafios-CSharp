using System;

namespace Desafios
{
    public class AlgoritVet
    {
        public static int[] CalcularVetor(string[] vetorA)
        {
            if (vetorA.Length != 10)
            {
                Console.WriteLine("O array deve conter 10 valores.\n");
                return null;
            }
            int[] serieNum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (!int.TryParse(vetorA[i], out int intInput))
                {
                    Console.WriteLine("Alguns dos valores não são inteiros.\n");
                    return null;
                }
                serieNum[i] = intInput;
            }
            return serieNum;
        }

        public static void RealizarCalculos()
        {
            do
            {
                // Input e Output 'a' e 'b'
                Console.WriteLine("Insira o primeiro vetor de 10 valores separados por espaços (Somente inteiros):");
                string[] inputA = Console.ReadLine().Split();
                int[] outA = CalcularVetor(inputA);

                if (outA == null)
                    continue;

                Console.WriteLine("Insira o segundo vetor de 10 valores separados por espaços (Somente inteiros):");
                string[] inputB = Console.ReadLine().Split();
                int[] outB = CalcularVetor(inputB);

                if (outB == null)
                    continue;

                if (outA != null && outB != null)
                {
                    // Soma das coisitas:
                    int[] Sum = new int[outA.Length];
                    for (int i = 0; i < outA.Length; i++)
                    {
                        Sum[i] = outA[i] + outB[outB.Length - 1 - i];
                    }

                    Console.WriteLine($"Vetor A é: {string.Join(", ", outA)}\n");
                    Console.WriteLine($"Vetor B é: {string.Join(", ", outB)}\n");

                    Console.WriteLine("A soma dos arrays e seus valores correspondentes é:");

                    for (int i = 0; i < Sum.Length; i++)
                    {
                        Console.WriteLine($"Soma:[{i + 1}] = A[{i + 1}] + B[{outB.Length - i}] = {Sum[i]}\n");
                    }
                }

                // Exit Method:
                Console.WriteLine("\n\nAperte 'y' para recomeçar o cálculo, qualquer outra tecla para sair");
                char keyChar = Console.ReadKey().KeyChar;
                bool shouldContinue = (keyChar == 'y' || keyChar == 'Y');

                if (!shouldContinue)
                {
                    return; // Sai do programa
                }
            } while (true);
        }
    }
}
