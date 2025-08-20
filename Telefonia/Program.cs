using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia
{
    class Program
    {
        AgendaTelefonica agendaTelefonica = new AgendaTelefonica();
        public static void Main(string[] args)
        {
            // 7 - Crie uma classe AgendaTelefonica com atributos
            // para armazenar contatos (nome, telefone, e-mail).
            // Implemente um construtor e métodos para adicionar numa lista,
            // remover e buscar contatos.
            AgendaTelefonica agendaTelefonica = new AgendaTelefonica();
           
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" ###### SISTEMA TELEFONICO DA VIVO - MAIS MORTO DO QUE VIVO ###### ");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Remover contato");
            Console.WriteLine("3 - Buscar contato");
            Console.WriteLine("4 - Listar todos os contatos");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: AgendaTelefonica.AdicionarContato(); break;
                case 2: AgendaTelefonica.RemoverContato(); break;
                case 3: AgendaTelefonica.BuscarContato(); break;
                case 4: AgendaTelefonica.ListarContatos(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        public static void ProximaAcao()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja continuar fazer?");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Remover contato");
            Console.WriteLine("3 - Buscar contato");
            Console.WriteLine("4 - Listar todos os contatos");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: AgendaTelefonica.AdicionarContato(); break;
                case 2: AgendaTelefonica.RemoverContato(); break;
                case 3: AgendaTelefonica.BuscarContato(); break;
                case 4: AgendaTelefonica.ListarContatos(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }


}
