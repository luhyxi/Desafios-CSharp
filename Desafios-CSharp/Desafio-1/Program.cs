using System;

namespace Desafios
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine($@"
Olá! Qual programa você deseja utilizar?

(Dia 04/10)
1 - Calculadora
2 - Calculadora de Idade
3 - Calculadora de Gorjeta
4 - Conversor de Moedas

(Dia 05/10)
5 - Calculadora de Excesso de Peixes
6 - Categorias de Natação
7 - Sistema de Loja de Vendas
8 - Caculadora Notas");

            string inputStr = (Console.ReadLine());

            switch (inputStr)
            {
                case "1":
                    Console.Clear();
                    Calculadora.RealizarCalculos();
                    break;
                case "2":
                    Console.Clear();
                    CalculadoraIdade.RealizarCalculos();
                    break;
                case "3":
                    Console.Clear();
                    Gorjeta.RealizarCalculos();
                    break;
                case "4":
                    Console.Clear();
                    ConversorMoedas.RealizarCalculos();
                    break;
                case "5":
                    Console.Clear();
                    ExcessoPeixe.RealizarCalculos();
                    break;
                case "6":
                    Console.Clear();
                    CategoriaNatacao.RealizarCalculos();
                    break;
                case "7":
                    Console.Clear();
                    LojaVendas.RealizarCalculos();
                    break;
                case "8":
                    Console.Clear();
                    CalculadoraNotas.RealizarCalculos();
                    break;
                default:
                    Console.WriteLine("Por valor, insira algum numero da lista");
                    break;
            }

        }
    }
}