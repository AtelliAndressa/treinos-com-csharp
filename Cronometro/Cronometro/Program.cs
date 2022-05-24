using System;
using System.Threading;

namespace Cronometro
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Essa função captará o valor da contagem.
        /// ToLower converte a string em minúsculo.
        /// Substring pegará apenas um pedaço da string que está vindo dentro do parenteses(index, quantidade)
        /// </summary>
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("S = segundos => 10s");
            Console.WriteLine("M = minutos => 1m");
            Console.WriteLine("0 = sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string resp = Console.ReadLine().ToLower();
            char type = char.Parse(resp.Substring(resp.Length - 1, 1));
            int time = int.Parse(resp.Substring(0, resp.Length - 1));
            int multiplier = 1;

            if (type == 'm') { 
                multiplier = 60; 
            }

            if (time == -1) {
                System.Environment.Exit(0);
            }

            Start(time * multiplier);
        }

        /// <summary>
        /// Essa função dispara o cronomêtro.
        /// O tempo está sendo passado por parâmetro em uma variável int
        /// O thread é que realiza a execução do programa
        /// O sleep fará ele dormir por 1 seg para depois passar a próxima execução.
        /// </summary>
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime.ToString());
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado...");
            Thread.Sleep(2500);
            Menu();
        }



    }
}

