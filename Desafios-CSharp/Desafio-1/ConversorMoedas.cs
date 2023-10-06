using System;

namespace Desafios
{
    public class ConversorMoedas
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o valor desejado em reais");
            string num1Str = Console.ReadLine();

            if (double.TryParse(num1Str, out double num1))
            {
                double valDolar = 5.50d, valEuro = 6.50d;
                Console.WriteLine($@"
Valor Original em Reais: {num1}
Valor em Dolares é {valDolar * num1} ($5.50)
Valor em Euros é {valEuro * num1} (€6.50)");
            }
            else
            {
                Console.WriteLine("Input inválido, Por favor insira 'doubles' válidos");
            }
        }
    }
}

/*
String substring = value.Substring(startIndex, length);
string string_ = "Isso é uma string";
string substring = string_.Substring(0,4);

*/