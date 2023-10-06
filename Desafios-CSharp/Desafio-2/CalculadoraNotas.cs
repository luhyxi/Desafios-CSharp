using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafios
{
    public class CalculadoraNotas
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Inserir Valores das Notas: " +
                              "\n (As notas deverão ser em números `double`)");
            ReceberInputs();
            
            
            Console.ReadLine(); // Aguardar pressionamento de tecla para sair
        }

        public static void ReceberInputs()
        {
            List<double> valores = new List<double>(); //Case de valores negativos e strings
            if (!double.TryParse(Console.ReadLine(), out double valor) || valor < 0  && valor > 10)
            {
                Console.WriteLine("O valor inserido não é um valor `double` dentre 0 e 10");
                ReceberInputs();
            }
            
            valores.Add(valor);
            Console.WriteLine($"Numeros atuais:");
            Console.WriteLine("Gostaria de adicionar outro valor? [y/n]");
            string userInput = Console.ReadLine();
            
            // Escolha de valores
            if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase)) // Recursão
            {
                Console.WriteLine("Adicione algum valor:\n");
                ReceberInputs();
            }
            else if (userInput.Equals("n", StringComparison.OrdinalIgnoreCase)) //Calculo
            {
                Console.Clear();
                double average = valores.Average();
                string final = (average >= 7.0)
                    ? $"Média: {average}"
                    : $"Média {average}, Nota Mínima para Passar em Exame: {(average + 5.0) / 2}";
                Console.WriteLine(final);
            }
            else //input inválido
            {
                Console.WriteLine("Input inválido. Por favor insira `y` ou `n`");
            }
        }
    }
}