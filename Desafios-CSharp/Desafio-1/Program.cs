using System;

namespace Desafios
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine($@"
Olá! Qual programa você deseja utilizar?
1 - Calculadora
2 - Calculadora de Idade
3 - Calculadora de Gorjeta
4 - Conversor de Moedas");
            
            string inputStr = (Console.ReadLine());
            
            switch(inputStr) 
            {
                case "1":
                    Calculadora.RealizarCalculos();
                    break;
                case "2":
                    CalculadoraIdade.RealizarCalculos();
                    break;
                case "3":
                    Gorjeta.RealizarCalculos();
                    break;
                case "4":
                    ConversorMoedas.RealizarCalculos();
                    break;
                default:
                    Console.WriteLine("Por valor, insira algum numero da lista");
                    break;
            }
            
        }
    }
}