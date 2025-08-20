using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor).
            // Implemente um construtor e métodos para adicionar e listar compras.
            Menu();

        }

        public static void Menu()
        {
            Console.WriteLine(" ####### CAIXA REGISTORADA ####### ");
            Caixa registro = new Caixa();
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Registrar uma compra");
            Console.WriteLine("2 - Listar compra");
            Console.WriteLine("3 - Remover um produto");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do caixa");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Caixa.RegistrarCompra(); break;
                case 2: Caixa.ListarCompra(); break;
                case 3: Caixa.RemoverProduto();break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }
        public static void ProximaAcao()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Registrar uma compra");
            Console.WriteLine("2 - Listar compra");
            Console.WriteLine("3 - Remover um produto");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do caixa");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Caixa.RegistrarCompra(); break;
                case 2: Caixa.ListarCompra(); break;
                case 3: Caixa.RemoverProduto(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

    }
}
