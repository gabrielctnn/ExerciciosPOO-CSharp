using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDeMusica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
            // Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist.
            // Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música).
            // Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.
            Console.WriteLine("Qual seu nome? (dono da playlist)");
            string nomeCriadorPlaylist = Console.ReadLine();
            Playlist minhaPlaylist = new Playlist(nomeCriadorPlaylist);
            Console.Title = $"PLAYLIST do {minhaPlaylist.}";
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("1 - Adicionar música");
            Console.WriteLine("2 - Reproduzir uma música");
            Console.WriteLine("3 - Mostrar playlist");
            Console.WriteLine("4 - Reproduzir aleatoriamente");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");


            try
            {
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: Playlist.AdicionarMusica(); break;
                    case 2: Playlist.ReproduzirMusica(); break;
                    case 3: Playlist.MostrarPLaylist(); break;
                    case 4: Playlist.ReproducaoAleatoria(); break;
                    case 0: System.Environment.Exit(0); break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine($"Opção: {escolha}, inválida. Por favor, selecione uma das opções listadas no menu.");
                        Console.ReadKey();
                        Menu(); break;
                }
            }
            catch(FormatException) 
            {
                Console.WriteLine("");
                Console.WriteLine($"Entrada inválida, digite apenas números!");
                Console.ReadKey();
                Menu();
            }
        }
    }
}
