using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDeMusica
{
    public class Playlist
    {
        public string NomeCriadorPlayList { get; private set; }
        static List<Musica> minhaPlaylist = new List<Musica>();
        public Playlist(string nomeCriadorPlayList)
        {

            NomeCriadorPlayList = nomeCriadorPlayList;
        }

        public static void AdicionarMusica()
        {
            Console.Clear();
            Console.WriteLine(" ----- Adicionar Musica -----");

            Console.WriteLine("");
            string nome;
            do
            {
                Console.WriteLine("Qual o nome da música?");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("O nome da música não pode ser vazio! Digite um nome!");
                }
            } while (string.IsNullOrEmpty(nome));



            Console.WriteLine("");
            string autor;
            do
            {
                Console.WriteLine("Qual o autor(a) da música?");
                autor = Console.ReadLine();
                if (string.IsNullOrEmpty(autor))
                {
                    Console.WriteLine("O autor da música não pode ser vazio! Digite um nome!");
                }
            } while (string.IsNullOrEmpty(autor));

            Console.WriteLine("");
            Console.WriteLine("Música adicionada!");
            Musica novaMusica = new Musica(nome, autor);
            minhaPlaylist.Add(novaMusica);
            Console.WriteLine($"{novaMusica.Nome} feita pelo(a) {novaMusica.Autor}.");
            Console.ReadKey();
            Console.Clear();
            Program.Menu();

        }

        public static void ReproduzirMusica()
        {
            Console.Clear();
            Console.WriteLine("Qual música deseja tocar?");
            int escolha = int.Parse(Console.ReadLine()) - 1 ;
            if (escolha < 0  || escolha >= minhaPlaylist.Count)
            {
                Console.WriteLine("Música não encontrada, por favor digite uma música existente na playlist");
                Console.ReadKey();
                Console.Clear();
                Program.Menu();
            } else
            {
                Console.Clear();
                Console.WriteLine("Música tocando:");
                Console.WriteLine($"{minhaPlaylist[escolha].Nome} - {minhaPlaylist[escolha].Autor}");
            
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }


            
        }

        public static void MostrarPLaylist()
        {
            Console.Clear();
            Console.WriteLine("SUA PLAYLIST:");
            Console.WriteLine("");
            int contador = 1;
            if(minhaPlaylist.Count >= contador) { 
                foreach (Musica musica in minhaPlaylist)
                {
                Console.WriteLine($"{contador} -   {musica.Nome} - {musica.Autor}");
                Console.WriteLine("");
                contador++;
                }
                Console.ReadKey();
                Console.Clear();
                Program.Menu();
            } else
            {
                Console.Clear();
                Console.WriteLine("A playlist não contém nenhuma música, adicione para poder visualizar.");
                
            }
        }

        public static void ReproducaoAleatoria()
        {
            int contador = 1;
            if (minhaPlaylist.Count >= contador)
            {
                Random random = new Random(); // cria um objeto random
                int indiceAleatorio = random.Next(minhaPlaylist.Count);
                Musica musicaAleatoria = minhaPlaylist[indiceAleatorio];
                Console.Clear();
                Console.WriteLine($"Música aleatória tocando: {musicaAleatoria.Nome}, {musicaAleatoria.Autor}");
                Console.ReadKey();
                Program.Menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("A playlist não contém nenhuma música, adicione para poder visualizar.");
                Console.ReadKey();
                Console.Clear();
                Program.Menu();
            }
        }
    }
}