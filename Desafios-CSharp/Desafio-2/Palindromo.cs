using System;
using System.Linq;

namespace Desafios
{
    public class Palindromo
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Inserir palavra");
            string palavra = Console.ReadLine().Replace(" ","").ToLower();
            if (palavra.Any((char.IsDigit)))
            {
                Console.WriteLine("Só são aceitas palavras nesse programa, nenhum digito.");
                return;
            }
            string reverse = new string(palavra.Reverse().ToArray());
            string message = (palavra == reverse) ? "A palavra é um palindromo " : "A palavra não é um palindromo";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}