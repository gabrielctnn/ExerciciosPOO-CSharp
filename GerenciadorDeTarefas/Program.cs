using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento).
            // Implemente um construtor e métodos para adicionar, remover e listar tarefas.
            // Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje.
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" ##### LISTA DE AFAZERES ##### ");
            GerenciadorDeTarefas listaTarefas = new GerenciadorDeTarefas();
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Ver todas as tarefas");
            Console.WriteLine("2 - Adicionar tarefa");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("");


            try //try = tenta fazer isso se n for, devolve o erro/solução no catch, usado para tratar exceções de codigo e erros.
            {
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: GerenciadorDeTarefas.ListarTarefas(); break;
                    case 2: GerenciadorDeTarefas.AdicionarTarefa(); break;
                    case 3: GerenciadorDeTarefas.RemoverTarefa(); break;
                    case 0: System.Environment.Exit(0); break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine($"Opção: {escolha}, inválida. Por favor, selecione uma das opções listadas no menu.");
                        Console.ReadKey();
                        Menu(); break;
                }
            } catch (FormatException) // format exception é um erro de exceção de formato no caso string no lugar de int.
            {
                Console.WriteLine("");
                Console.WriteLine($"Entrada inválida, digite apenas números!");
                Console.ReadKey();
                Menu();
            }
        }

        public static void ProximaAcao()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Ver todas as tarefas");
            Console.WriteLine("2 - Adicionar tarefa");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do sistema");
            Console.WriteLine("");


            try
            {
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: GerenciadorDeTarefas.ListarTarefas(); break;
                    case 2: GerenciadorDeTarefas.AdicionarTarefa(); break;
                    case 3: GerenciadorDeTarefas.RemoverTarefa(); break;
                    case 0: System.Environment.Exit(0); break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine($"Opção: {escolha}, inválida. Por favor, selecione uma das opções listadas no menu.");
                        Console.ReadKey();
                        Menu(); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine($"Entrada inválida, digite apenas números!");
                Console.ReadKey();
                Menu();
            }
        }
    }
}
