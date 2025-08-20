using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corretora
{
    public  class CorretoraDeImoveis
    {
        public static List<Imovel> Imoveis = new List<Imovel>();

        public static void AdicionarImovel ()
        {
            Console.Clear();
            Console.WriteLine(" --------- ADICIONAR IMOVEL --------- ");
            Console.WriteLine("");
            Console.WriteLine("Endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Tipo do Imóvel:");
            string tipo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Adicionado!");
            Imovel novoImovel = new Imovel(endereco, preco, tipo);
            Imoveis.Add(novoImovel);
            Console.WriteLine("");
            Console.ReadKey();
            Program.ProximaAcao();
        }

        public static  void ListarImoveis() {
            Console.Clear();
            Console.WriteLine(" --------- IMÓVEIS--------- ");
            Console.WriteLine("");
            int contador = 1;
            foreach (Imovel imovel in Imoveis) {
                Console.WriteLine($"IMOVEL {contador}:");
                Console.WriteLine($"Endereço:  {imovel.Endereco}");
                Console.WriteLine($"Tipo:  {imovel.Tipo}"); 
                Console.WriteLine($"Preço:  {imovel.Preco:C}");
                Console.WriteLine("");
                contador++;
            }
            Console.WriteLine("");
            Console.ReadKey();
            Program.ProximaAcao();
        }

        public static void ValorMedio()
        {
            Console.Clear();
            double soma = 0;
            foreach (Imovel imovel in Imoveis)
            {
                soma += imovel.Preco;
            }
            
            Console.WriteLine($"O valor médio dos imóveis é: {soma / Imoveis.Count:C}");
        }

        public static void AlterarPrecoImovel()
        {
            Console.Clear();

            Console.WriteLine(" --------- ALTERAR PREÇO IMOVEL --------- ");
            Console.WriteLine("");
            int contador = 1;
            foreach (Imovel imovel in Imoveis)
            {
                Console.WriteLine($"IMOVEL {contador}:");
                Console.WriteLine($"Endereço:  {imovel.Endereco}");
                Console.WriteLine($"Tipo:  {imovel.Tipo}");
                Console.WriteLine($"Preço:  {imovel.Preco:C}");
                Console.WriteLine("");
                contador++;
            }
            Console.WriteLine("");
            Console.WriteLine("Qual imóvel deseja alterar o preço?");
            int escolha = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Qual o novo valor do imóvel?");
            double preco = double.Parse(Console.ReadLine());
            Imoveis[escolha].AlterarPreco(preco);
            Console.WriteLine("");
            Console.WriteLine("Novo preço do imóvel alterado!");




            Console.ReadKey();
            Program.ProximaAcao();
        }
    }
}
