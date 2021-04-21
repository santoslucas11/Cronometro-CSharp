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

        static void Menu(){
            Console.Clear();

            Console.WriteLine("S = Contagem em segundos");
            Console.WriteLine("M = Contagem em minutos");
            Console.WriteLine("0 = Quit");

            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char   type = char.Parse(data.Substring(data.Length -1, 1));
            int    time = int.Parse(data.Substring(0, data.Length -1));
            
            int    multiplier = 1;

            if (type =='m'){
                multiplier = 60;
            }

            if(time == 0){
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciando Contagem ...");
            Thread.Sleep(2500);

            StartStopwatch(time);
        }
        static void StartStopwatch(int time){
            int currentTime = 0;

            while( currentTime != time){
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
