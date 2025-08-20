using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal class GerenciadorDeTarefas
    {
        static List<Tarefa> Tarefas = new List<Tarefa>(); // cria a nossa listas de tarefas;

        public static void ListarTarefas()
        {
            Console.Clear();
            Console.WriteLine(" ##### LISTA DE AFAZERES ##### ");
            Console.WriteLine("");
            int contador = 1;
            foreach (Tarefa tarefa in Tarefas)
            {
                Console.WriteLine($"{contador} - {tarefa.NomeTarefa}");
    
                if (DateTime.Today == tarefa.DataVencimentoTarefa) {
                    Console.WriteLine($"Vence HOJE em : {tarefa.DataVencimentoTarefa.ToString("dd/MM/yyyy")}");
                } else
                {
                    Console.WriteLine($"Vence em : {tarefa.DataVencimentoTarefa.ToString("dd/MM/yyyy")}");
                }
                    Console.WriteLine($"{tarefa.DescricaoTarefa}");
                Console.WriteLine("");
                contador++;
            }
            Console.ReadKey();
            Program.ProximaAcao();
        }
        public static void AdicionarTarefa()
        {
            Console.Clear();
            Console.WriteLine(" ---------- ADICIONAR TAREFA ---------- ");
            Console.WriteLine("");
            Console.WriteLine("Nome  da Tarefa:");
            string nomeTarefa = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeTarefa)) {
                Console.WriteLine("");
                Console.WriteLine("Nome da tarefa não pode ser vazio. Digite um nome!");
                Console.ReadKey();
                AdicionarTarefa();
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("Descrição da Tarefa:");
                string descricaoTarefa = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Data de vencimento tarefa (dia/mês/ano) :");
                DateTime dataVencimentoTarefa = DateTime.Parse(Console.ReadLine());
                Tarefa novaTarefa = new Tarefa(nomeTarefa, descricaoTarefa, dataVencimentoTarefa);
                Tarefas.Add(novaTarefa);
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("Nova Tarefa adicionada!");
            }
            Console.ReadKey();
            Program.ProximaAcao();
        }

        public static void RemoverTarefa()
        {
            Console.Clear();
            Console.WriteLine(" ---------- REMOVER TAREFA ---------- ");
            Console.WriteLine("");

            int contador = 1;
            foreach (Tarefa tarefa in Tarefas)
            {
                Console.WriteLine($"{contador} - {tarefa.NomeTarefa}");
                Console.WriteLine($"Vence em : {tarefa.DataVencimentoTarefa.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"{tarefa.DescricaoTarefa}");
                Console.WriteLine("");
                contador++;
            }

            try
            {
                Console.WriteLine("Qual tarefa deseja remover?");
                int remocao = int.Parse(Console.ReadLine()) - 1;
                Tarefas.RemoveAt(remocao);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("");
                Console.WriteLine($"Tarefa inválida ou inexistente, digite apenas tarefas existentes!");
                Console.ReadKey();
                RemoverTarefa();
            }
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine($"Tarefa removida!");
            Console.Clear();
            Program.ProximaAcao();
        }
    }
}
