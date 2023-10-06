using System;

namespace Desafios
{
    public class ExcessoPeixe
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o kilo do peixe pescado");
            string pescado = Console.ReadLine();

            if (double.TryParse(pescado, out double doublePescado) && doublePescado >= 0)
            {
                // Não sei se esta formula aritmétrica é a melhor, talvez armazenar
                // o valor do pescado (uintPescado-50) seria mais performática
                string message = (doublePescado > 50) ? $"Excesso: {doublePescado - 50}Kg, Multa: R$:{(doublePescado - 50) * 4}" : "Execesso: 0, Multa: 0";
                Console.WriteLine(message);
                Console.ReadLine(); // Aguardar pressionamento de tecla para sair
            }
            else
            {
                {Console.WriteLine("O Kilo do pescado deve ser um valor numérico `double` positivo");}
            }
        }
    }
}
