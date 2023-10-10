using System;

namespace Desafios
{
    public class NumSecreto
    {
        public static void RealizarCalculos()
        {
            // Criar random
            Random random = new Random();
            int randNum = random.Next(1, 101);
            bool cond = true;
            

                // Inputs
                Console.WriteLine("Advinhe o numero" +
                                  "\n(Somente numeros `integers` positivos de 0 a 100)");
                do
                {
                // Excessão
                if (!int.TryParse(Console.ReadLine(), out int userNum) || userNum < 0 || userNum > 100)
                {
                    Console.WriteLine("Somente numeros `integers` positivos de 0 a 100");
                    continue;
                }

                // Comparing userNum and randNum
                if (userNum > randNum)
                {
                    Console.WriteLine("O numero do usuário é maior que o número aleatório");
                }
                else if (userNum < randNum)
                {
                    Console.WriteLine("O numero do usuário é menor que o número aleatório");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O numero do usuário é igual, o usuário acertou.\n");
                    cond = false;
                }
                } while (cond == true);
            Console.ReadKey();
        }
    }
}