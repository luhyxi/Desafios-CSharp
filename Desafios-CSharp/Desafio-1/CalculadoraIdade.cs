using System;

namespace Desafios
{
    public class CalculadoraIdade
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o ano atual");
            string num1Str = Console.ReadLine();
            Console.WriteLine("Insira o ano de nascimento");
            string num2Str = Console.ReadLine();

            if (int.TryParse(num1Str, out int num1) && int.TryParse(num2Str, out int num2))
            {
                int result = num1 - num2;
                Console.WriteLine($"A idade calculada é {result}");
            }
            else Console.WriteLine("Input inválido, Por favor insira 'integers' validos");
        }
    }
}