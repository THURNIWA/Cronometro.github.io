﻿using System;
using  System.Threading;

namespace Cronometro
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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto Tempo deseja contar?");
            
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length -1 ,1 ));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int mult = 1;

            if (type == 'm')
            {
                mult = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart (time * mult);

        }

            static void PreStart(int time)
            {
                Console.Clear();
                Console.WriteLine("Read....");
                Thread.Sleep(1000);
                Console.WriteLine("Set...");
                Thread.Sleep(1000);
                Console.WriteLine("Go..");
                Thread.Sleep(2500);

                Start(time);
            }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);            
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }   
}