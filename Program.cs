using System;
using  System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto Tempo deseja contar?");
            
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length -1 ,1 ));
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine("" + currentTime);
                Thread.Sleep(1000);            
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
        }
    }   
}