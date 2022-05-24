using System;
using System.Globalization;

namespace ConsultarProdutoNoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            //COLOCAR DADOS DO PRODUTO

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            //ADIÇÃO DE PRODUTO AO ESTOQUE
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            //ATUALIZAÇÃO DO ESTOQUE
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            //REDUÇÃO DO PRODUTO NO ESTOQUE
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            //ATUALIZAÇÃO DO ESTOQUE
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}