using System;

namespace Desafios
{
    public class CursosEscolha
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine($@"
Olá! Bem vinde a UniÉpica Qual curso você deseja adentrar?

Tecnologia:
1 - Ciências da Computação
2 - Engenharia de Software

Humanas:
3 - Psicologia
4 - Filosofia

Exatas:
5 - Física");
            string inputStr = (Console.ReadLine());

            switch (inputStr)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Você escolheu `Ciências da Computação`");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Você escolheu `Engenharia de Software`");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Você escolheu `Psicologia`");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Você escolheu `Filosofia`");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Você escolheu `Fisica`");
                    break;
                default:
                    Console.WriteLine("Por valor, insira algum numero da lista");
                    break;
            }
            Console.ReadLine();
        }
    }
}