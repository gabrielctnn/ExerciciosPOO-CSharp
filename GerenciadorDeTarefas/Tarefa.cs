using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    public class Tarefa
    {
        public string NomeTarefa { get; private set; }
        public string DescricaoTarefa { get; private set; }
        public DateTime DataVencimentoTarefa { get; private set; }

        public Tarefa(string nomeTarefa, string descricaoTarefa, DateTime dataVencimentoTarefa) {
            NomeTarefa = nomeTarefa;
            DescricaoTarefa = descricaoTarefa;
            DataVencimentoTarefa = dataVencimentoTarefa;
            }
    }
}
