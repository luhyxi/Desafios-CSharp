using System;

namespace Desafios
{
    public class Gorjeta
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o valor total da Conta");
            string num1Str = Console.ReadLine();
            Console.WriteLine("Insira a porcentagem(e.g 15% ou 20%)");
            string num2Str = Console.ReadLine();
            num2Str = num2Str.Replace("%", "").Trim();
            
            if (double.TryParse(num1Str, out double num1) && double.TryParse(num2Str, out double num2))
            {
                if (num2 >= 0 && num2 <= 100)
                {
                    double valGorjeta = num1 * num2;
                    valGorjeta = valGorjeta / 100.0d;
                    Console.WriteLine($"A gorjeta desejada é {valGorjeta}");
                }
                else
                {
                    Console.WriteLine("Porcentagem inválida, por favor insira um valor dentre 0% e 100%");
                }
            }
            else
            {
                Console.WriteLine("Input inválido, Por favor insira 'doubles' validos");
            }
        }
    }
}