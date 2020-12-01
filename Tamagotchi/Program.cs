using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Namnge din tamagotchi:");
            String Namn = Console.ReadLine();

            tamagotchi t = new tamagotchi();
            t.name = Namn;

            Console.WriteLine("Lär din tamagotchi ett nytt ord: ");
            string word = Console.ReadLine();
            t.Teach(word);

            t.Hi();

            t.GetAlive();

            t.Tick();

             Console.WriteLine("Skriv 'print' för att kolla dina stats: ");
             string stats = Console.ReadLine();

            




            Console.ReadLine();

        }
    }
}
