using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque.
            // Implemente um construtor e métodos para adicionar e remover itens do estoque.
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" ####### ESTOQUE DA LOJA ####### ");
            ControleEstoque estoque = new ControleEstoque();
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");

            Console.WriteLine("");

            Console.WriteLine(" 1 - Adicionar produto");
            Console.WriteLine(" 2 - Remover produto");
            Console.WriteLine(" 3 - Listar produtos");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair do estoque");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1: ControleEstoque.AdicionarProduto(); break;
                case 2: ControleEstoque.RemoverProduto(); break;
                case 3: ControleEstoque.ListarProdutos(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        public static void ProximaAcao()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");

            Console.WriteLine(" 1 - Adicionar produto");
            Console.WriteLine(" 2 - Remover produto");
            Console.WriteLine(" 3 - Voltar ao menu");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair do estoque");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: ControleEstoque.AdicionarProduto(); break;
                case 2: ControleEstoque.RemoverProduto(); break;
                case 3: Menu(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }
    }

}
