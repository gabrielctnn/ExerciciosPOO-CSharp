using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Estoque;

namespace Estoque
{
    class ControleEstoque
    {
        static List<Produto> EstoqueLoja = new List<Produto>();
        public static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("------- ADICIONAR PRODUTO -------");
            Console.WriteLine("");
            Console.WriteLine("Nome : ");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Preço : ");
            float preco = float.Parse(Console.ReadLine());
            if (preco <= 0)
            {
                Console.WriteLine("Preço não pode ser negativo!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                AdicionarProduto();
                return;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Quantidade em Estoque : ");
                int qtdEstoque = int.Parse(Console.ReadLine());
                if (qtdEstoque <= 0)
                {
                    Console.WriteLine("Quantidade em estoque não pode ser negativa!");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    AdicionarProduto();
                    return;
                }
                else
                {
                    Produto produto1 = new Produto(nome, preco, qtdEstoque);
                    EstoqueLoja.Add(produto1);
                    Console.WriteLine("");
                    Console.WriteLine($"Produto:{nome}, custando R${preco}, com {qtdEstoque} no estoque, adicionado!");
                    Console.WriteLine("");
                    Program.ProximaAcao();
                }
            }
        }

        public static void RemoverProduto()
        {

            Console.Clear();
            Console.WriteLine("------- REMOVER PRODUTO -------");
            Console.WriteLine("");
            Console.WriteLine("------- ESTOQUE -------");
            int contador = 1;
            foreach (Produto produto in EstoqueLoja)
            {
                Console.WriteLine($"PRODUTO {contador}: "); // achar o index para mostrar tipo produto 1, 2 e etc
                Console.WriteLine($"Nome : {produto.Nome}");
                Console.WriteLine($"Preço : {produto.Preco}");
                Console.WriteLine($"Quantidade : {produto.QtdEstoque}");
                Console.WriteLine("");
                contador++;
            }

            Console.WriteLine("Qual produto deseja remover?");
            int escolha = int.Parse(Console.ReadLine()) - 1;
            EstoqueLoja.RemoveAt(escolha);

            Console.Write("Removendo...");
            Thread.Sleep(1000);
            Console.Write("...");
            Console.Write("");
            Console.WriteLine("Removido");
            Console.Clear();
            Program.ProximaAcao();
        }

        public static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("------- ESTOQUE -------");
            int contador = 1;
            foreach (Produto produto in EstoqueLoja)
            {
                Console.WriteLine($"PRODUTO {contador}: "); // achar o index para mostrar tipo produto 1, 2 e etc
                Console.WriteLine($"Nome : {produto.Nome}");
                Console.WriteLine($"Preço : {produto.Preco:F2}");
                Console.WriteLine($"Quantidade : {produto.QtdEstoque}");
                Console.WriteLine("");
                contador++;
            }
            Program.ProximaAcao();

        }
    }
}
