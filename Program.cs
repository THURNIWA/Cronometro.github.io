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
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto Tempo deseja contar");
            
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