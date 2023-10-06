using System;

namespace Desafios
{
    public class CategoriaNatacao
    {
        public static void RealizarCalculos()
        {
            Console.WriteLine("Insira a Idade do Nadador \n(Atenção: A Idade deve ser maior que 5 anos)");
            string strIdade= Console.ReadLine();

            if (int.TryParse(strIdade, out int intIdade) && intIdade > 4)
            {
                switch (intIdade)
                {
                    case var ia when ia >= 5 && ia <=7:
                        Console.WriteLine("Infantil A");
                        break;
                    case var ib when ib >= 8 && ib <=11:
                        Console.WriteLine("Infantil B");
                        break;
                    case var ja when ja >= 12 && ja <= 13:
                        Console.WriteLine("Juvenil A");
                        break; 
                    case var ib when ib >= 14 && ib <=17:
                        Console.WriteLine("Juvenil B");
                        break;
                    default:
                        Console.WriteLine("Adultos");
                        break;
                }
                Console.ReadLine(); // Aguardar pressionamento de tecla para sair
            }
            else
            {
                Console.WriteLine("A idade precisa ser em numeros `integers` e ser acima de 5 anos");
            }
            Console.ReadLine(); // Aguardar pressionamento de tecla para sair
        }
    }
}