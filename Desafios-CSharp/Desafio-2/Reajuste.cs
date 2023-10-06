using System;

namespace Desafios
{
    public class Reajuste
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira o seu Salario");
            string input = Console.ReadLine().Replace("R$", "").Trim();
            if (!decimal.TryParse(input, out decimal salarioAntes) || salarioAntes < 0)
            {
                Console.WriteLine("Input errado, cheque se o valor inserido é um numero positivo");
                return;
            }
            
            decimal salarioAgr;
            decimal percetualApl;
            
            if (salarioAntes <= 280)
            {
                percetualApl = 20.0m;
                salarioAgr = salarioAntes + (salarioAntes * percetualApl / 100.0m);
            }
            else if (salarioAntes <= 700)
            {
                percetualApl = 15.0m;
                salarioAgr = salarioAntes + (salarioAntes * percetualApl / 100.0m);
            }
            else if (salarioAntes < 1500)
            {
                percetualApl = 10.0m;
                salarioAgr = salarioAntes + (salarioAntes * percetualApl / 100.0m);
            }
            else
            {
                percetualApl = 5.0m;
                salarioAgr = salarioAntes + (salarioAntes * percetualApl / 100.0m);
            }
            Console.WriteLine($@"
Salário Antes do Ajuste: R${salarioAntes}
Percentual aplicado: {percetualApl}%
Valor do Aumento: R${salarioAntes*(percetualApl/100)}
Novo Salário: R${salarioAgr}");
            Console.ReadLine();
        }
    }
}