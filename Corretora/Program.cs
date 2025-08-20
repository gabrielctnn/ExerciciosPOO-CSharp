using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corretora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Crie uma classe CorretoraDeImoveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
            //Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
            //Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.
            //Insira os imoveis numa lista para facilitar o trabalho.

            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine(" ######## CORRETORA DE IMOVEIS ######## ");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar imóvel");
            Console.WriteLine("2 - Listar imóveis");
            Console.WriteLine("3 - Alterar preço imóvel");
            Console.WriteLine("4 - Valor médio dos imóveis");
            Console.WriteLine("");
            Console.WriteLine("0 - Fechar Corretora");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: CorretoraDeImoveis.AdicionarImovel(); break;
                case 2: CorretoraDeImoveis.ListarImoveis(); break;
                case 3: CorretoraDeImoveis.AlterarPrecoImovel(); break;
                case 4: CorretoraDeImoveis.ValorMedio(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        public static void ProximaAcao()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar imóvel");
            Console.WriteLine("2 - Listar imóveis");
            Console.WriteLine("3 - Alterar preço imóvel");
            Console.WriteLine("4 - Valor médio dos imóveis");
            Console.WriteLine("");
            Console.WriteLine("0 - Fechar Corretora");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: CorretoraDeImoveis.AdicionarImovel(); break;
                case 2: CorretoraDeImoveis.ListarImoveis(); break;
                case 3: CorretoraDeImoveis.AlterarPrecoImovel(); break;
                case 4: CorretoraDeImoveis.ValorMedio(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }
    }
}
