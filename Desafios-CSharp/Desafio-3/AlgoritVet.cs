using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{

    public class AlgoritVet
    {


        public static void RealizarCalculos()
        {
            do
            {
                Console.WriteLine("Insira o primeiro vetor de até 10 valores, separado por espaços\n(Somente `somente integers`)");
                string input = Console.ReadLine();
                if (!int.TryParse(input.Trim(), out int intInput))
                {
                    Console.WriteLine("Os numeros passados não são integers");
                    continue;
                }
                int[] valuesA = intInput;
                Array.Resize(ref valuesA, 10);
                
                Console.Clear();
                Console.WriteLine("Insira o Segundo vetor de até 10 valores, separado por espaços\n(Somente `somente integers`)");
                

            } while (true);
        }
    }
}