using System;

namespace Desafios
{
    internal class Calculadora
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o primeiro número");
            string num1Str = Console.ReadLine();
            Console.WriteLine("Insira o segundo número");
            string num2Str = Console.ReadLine();

            if (int.TryParse(num1Str, out int num1) && int.TryParse(num2Str, out int num2))
            {
                int soma = num1 + num2, sub = num1 - num2, mult = num1 * num2, div = num1 / num2;
                Console.WriteLine($@"
A Soma dos dois números é {soma}
A Subtração dos dois números é {sub} 
A Multiplicação dos dois números é {mult}
A Divisão dos dois números é {div}");
            }
            else
            {
                Console.WriteLine("Input inválido, Por favor insira 'integers' válidos");
            }
        }
    }
}