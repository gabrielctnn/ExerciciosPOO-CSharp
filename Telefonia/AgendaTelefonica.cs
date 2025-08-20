using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Telefonia
{
    class AgendaTelefonica
    {
        public static List<Contato> listaContatos = new List<Contato>();

        public static void AdicionarContato()
        {
            Console.Clear();
            Console.WriteLine(" ###### ADICIONAR CONTATO ###### ");
            Console.WriteLine("");
            Console.WriteLine("Nome do contato: ");
            string nome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Telefone (Por favor digite todos os numeros juntos, sem qualquer separação ou sinal)");
            string telefone = Console.ReadLine();
            telefone = String.Format("{0:(##) #####-####}", Convert.ToInt64(telefone));
            Console.WriteLine("");

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Contato adicionado!");
            Contato contatoNovo = new Contato(nome, telefone, email);
            listaContatos.Add(contatoNovo);
            Console.WriteLine("");
            Program.ProximaAcao();
            

        }

        public static void RemoverContato()
        {
            Console.Clear();
            Console.WriteLine("Lista de contatos atuais: ");
            int contador = 1;
            foreach (Contato contato in listaContatos)
            {
                Console.WriteLine($"Contado {contador}");
                Console.WriteLine($"Nome: {contato.Nome}");
                Console.WriteLine($"Telefone: {contato.Telefone}");
                Console.WriteLine($"Email: {contato.Email}");
                Console.WriteLine($"");
                contador++;
            }
            Console.WriteLine("Qual contato deseja remover?");
            int escolha = int.Parse(Console.ReadLine()) - 1; 

            listaContatos.RemoveAt(escolha);
            Console.Write("Removendo...");
            Thread.Sleep(1000);
            Console.Write("...");
            Console.Write("");
            Console.WriteLine("Removido");
            Console.Clear();
            Program.ProximaAcao();

        }

        public static void BuscarContato()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do contato que está buscando: ");
            string busca = Console.ReadLine();
            Console.WriteLine("");
            bool encontrado = false;

            foreach (Contato contato in listaContatos)
            {
                if (contato.Nome.ToLower() == busca.ToLower())
                {
                    Console.WriteLine($"Nome: {contato.Nome}");
                    Console.WriteLine($"Telefone: {contato.Telefone}");
                    Console.WriteLine($"Email: {contato.Email}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contato não encontrado!");
            }

            Program.ProximaAcao();


            Program.ProximaAcao();

        }
        public static void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("Lista de contatos atuais: ");
            int contador = 1;
            foreach (Contato contato in listaContatos)
            {
                Console.WriteLine($"Contado {contador}");
                Console.WriteLine($"Nome: {contato.Nome}");
                Console.WriteLine($"Telefone: {contato.Telefone}");
                Console.WriteLine($"Email: {contato.Email}");
                Console.WriteLine($"");
                contador++;
            }
            Program.ProximaAcao() ;

        }
    }
}