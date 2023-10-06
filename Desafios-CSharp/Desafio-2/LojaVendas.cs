using System;
using System.Text;

namespace Desafios
{
    public class LojaVendas
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Olá! Bem vindo ao Gerenciamento de Vendas!");
            
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            string codigoProduto =
                BitConverter.ToString((Encoding.UTF8.GetBytes(nomeProduto))).Replace("-", "").ToLower();
            if (codigoProduto.Length > 7)
            {
                codigoProduto = codigoProduto.Substring(0,6);
            }

            
            Console.Write("Digite a quantidade comprada: ");
            int quantidadeComprada;
            
            //Try Parse ao contrário, com o if somente para erros específico
            if (!int.TryParse(Console.ReadLine(), out quantidadeComprada) || quantidadeComprada <= 0)
            {
                Console.WriteLine("Quantidade inválida. Certifique-se de inserir um número inteiro positivo.");
                return;
            }

            Console.Write("Digite o valor unitário do produto: ");
            double valorUnitario;
            if (!double.TryParse(Console.ReadLine(), out valorUnitario) || valorUnitario <= 0)
            {
                Console.WriteLine("Valor unitário inválido. Certifique-se de inserir um número positivo.");
                return;
            }
            Console.WriteLine($@"
Detalhes da Venda:
Código do Produto: {codigoProduto}
Nome do Produto: {nomeProduto}
Quantidade Comprada: {quantidadeComprada}
Valor Unitário: R$ {valorUnitario:F2}
Valor Total: R$ {quantidadeComprada * valorUnitario:F2}");
            Console.ReadLine(); // Aguardar pressionamento de tecla para sair
        }
    }
}