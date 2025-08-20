using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Compras
{
    public  class Caixa
    {
        static List<RegistroDeCompras> Compras = new List<RegistroDeCompras>();

        public static void RegistrarCompra()
        {
            Console.Clear();
            Console.WriteLine(" ------ REGISTRO DA COMPRA ------ ");
            Console.WriteLine("");
            Console.WriteLine("Informe os dados da compra:");
            Console.WriteLine("");
            Console.WriteLine("Qual produto foi comprado?");
            string produto = Console.ReadLine();
            if (string.IsNullOrEmpty(produto))
            {
                Console.WriteLine("Produto não pode ser vazio.");
                RegistrarCompra();
                return;
            } else
            {
                Console.WriteLine("Qual o preço do produto?");
                double preco = Convert.ToDouble(Console.ReadLine());
                if (preco <= 0) {
                    Console.WriteLine("Preço não pode ser menor ou igual a 0. Coloque um preço.");
                    RegistrarCompra();
                    return;
                    } else
                {
                    Console.WriteLine("Qual a data da compra?(dd/MM)");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    RegistroDeCompras compra1 = new RegistroDeCompras(produto, preco, data);
                    Compras.Add(compra1);
                    Console.WriteLine($"Produto: {produto}, Preço: {preco:F2}, Data: {data.ToString("dd/MM")}");
                    Console.WriteLine("");

                }
                  
            }
            Program.ProximaAcao();
        }

        public static void RemoverProduto()
        {

            Console.Clear();
            Console.WriteLine("------- REMOVER PRODUTO -------");
            Console.WriteLine("");
            Console.WriteLine(" ------ COMPRA ------ ");
            int contador = 1;
            foreach (RegistroDeCompras compra in Compras)
            {
                Console.WriteLine($"PRODUTO {contador}:");
                Console.WriteLine($"Nome do produto : {compra.Produto}");
                Console.WriteLine($"Preço do produto: {compra.Preco:F2}");
                Console.WriteLine($"Data da compra: {compra.Data}");
                Console.WriteLine("");
                contador++;
            }

            Console.WriteLine("");
            Console.WriteLine("Qual produto deseja remover?");
            int escolha = int.Parse(Console.ReadLine()) - 1;
            Compras.RemoveAt(escolha);

            Console.Write("Removendo...");
            Thread.Sleep(1000);
            Console.Write("...");
            Console.Write("");
            Console.WriteLine("Removido");
            Console.Clear();
            Program.ProximaAcao();
        }
        public static void ListarCompra()
        {
            Console.Clear();
            Console.WriteLine(" ------ COMPRA ------ ");
            int contador = 1;
            foreach (RegistroDeCompras compra in Compras) {
                Console.WriteLine($"PRODUTO {contador}:");
                Console.WriteLine($"Nome do produto : {compra.Produto}");
                Console.WriteLine($"Preço do produto: {compra.Preco:F2}");
                Console.WriteLine($"Data da compra: {compra.Data.ToString("dd/MM")}");
                Console.WriteLine("");
                contador++;
            }
            Program.ProximaAcao();
        }
    }
}
