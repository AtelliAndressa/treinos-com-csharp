using System;
using System.Threading;
using System.IO;

namespace TextEditor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("Opção 1 - Abrir um arquivo");
            Console.WriteLine("Opção 2 - Criar um arquivo");
            Console.WriteLine("Opção 0 - Sair da aplicação");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
                default: Menu(); break;
            }
        }

        /// <summary>
        /// Essa função lê o caminho do arquivo e o abre, fazendo sua leitura.
        /// </summary>
        static void Abrir() {   
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        
        }

        /// <summary>
        /// Essa função capta o objeto escrito e o salva.
        /// </summary>
        static void Criar()
        {

            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (Use ESC para sair)");
            Console.WriteLine("");

            string text = "";

            //Fará a captação da digitação enquanto o usuário não digitar ESC para sair do loop de repetição
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Thread.Sleep(1000);
            Salvar(text);

        }

        /// <summary>
        /// Essa função salva o caminho do arquivo
        /// </summary>
        /// <param name="text"></param>
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");

            var path = Console.ReadLine();

            //using serve para abrir e fechar qualquer objeto passado.
            //file.write salva dentro do caminho passado.
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Thread.Sleep(1000);
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Thread.Sleep(1000);
            Console.ReadLine();

            Menu();
        }
    }
}
