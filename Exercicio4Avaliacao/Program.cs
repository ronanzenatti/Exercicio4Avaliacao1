using System;
using System.Text;


namespace Exercicio4Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String nomeProduto;
                int quantidade;
                double valorProduto, valorTotal;

                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                valorTotal = quantidade * valorProduto;

                Console.Clear();
                Console.WriteLine(" ******* Venda do Produto ********");
                Console.WriteLine(" Produto: " + nomeProduto);
                Console.WriteLine(" Qtde: " + quantidade + " x Valor Unitário: " + valorProduto);
                //.toString() -> converte o numero para Texto, o "C" -> formata para moeda.
                Console.WriteLine(" Total da Venda: " + valorTotal.ToString("C"));
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Dados digitados inválidos!!!");
            }

            Console.ReadKey();
        }
    }
}
