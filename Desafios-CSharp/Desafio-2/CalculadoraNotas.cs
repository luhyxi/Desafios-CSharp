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
            List<double> valores = new List<double>();
            double valor;
            string userInput;
            
            do
            {
                Console.WriteLine("Adicione algum valor:\n");
                userInput = Console.ReadLine();

                if (double.TryParse(userInput, out valor) && valor >= 0 && valor <= 10)
                {
                    valores.Add(valor);
                }
                else
                {
                    Console.WriteLine("O valor inserido não é um valor `double` dentre 0 e 10");
                }
                
                Console.WriteLine("Gostaria de adicionar outro valor? [y/n]");
                userInput = Console.ReadLine();
            } while (userInput.Equals("y", StringComparison.OrdinalIgnoreCase));

            // Calculate and display the result
            Console.Clear();
            double average = valores.Average();
            string final = (average >= 7.0)
                ? $"Média: {average}"
                : $"Média {average}, Nota Mínima para Passar em Exame: {(average + 5.0) / 2}";
            Console.WriteLine(final);
        }
    }
}