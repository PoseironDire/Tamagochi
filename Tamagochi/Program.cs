using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //Tamagochis
        List<Tamagochi> players = new List<Tamagochi>();
        players = CreateNew(players);
        Console.ReadLine();
        Console.Clear();
        bool playing = true;
        while (playing)
        {
            for (int i = players.Count - 1; i >= 0; i--)
            {
                if (players[i].GetAlive())
                {
                    players[i].PrintStats();

                    Console.ReadLine();

                    Console.WriteLine("What do you want to do with " + players[i].name + "?:");
                    Console.WriteLine("1. Teach " + players[i].name + "...");
                    Console.WriteLine("2. Greet " + players[i].name + "...");
                    Console.WriteLine("3. Feed " + players[i].name + "...");
                    Console.WriteLine("4. Breed New Tamagochi");
                    Console.WriteLine("5. Do Nothing.");

                    string Choice = Console.ReadLine().ToLower();
                    if (Choice == "1" || Choice == "teach it" || Choice == "teach")
                    {
                        System.Console.WriteLine("What word do you want to teach " + players[i].name + "?");
                        players[i].Teach(Console.ReadLine());
                        Console.WriteLine(players[i].name + " was taught: '" + players[i].words[players[i].words.Count - 1] + "'");
                    }
                    else if (Choice == "2" || Choice == "greet it" || Choice == "greet")
                    {
                        players[i].Hi();
                    }
                    else if (Choice == "3" || Choice == "feed it" || Choice == "feed")
                    {
                        players[i].Feed();
                    }
                    else if (Choice == "4" || Choice == "breed tamagochi" || Choice == "breed")
                    {
                        players = CreateNew(players);
                    }
                    else
                    {
                        Console.WriteLine("Nothing Happened!");
                        Console.WriteLine("");
                    }
                    players[i].Tick();

                    Console.ReadLine();
                    Console.Clear();
                }
                players.RemoveAll(t => !t.GetAlive());
                if (players.Count <= 0)
                {
                    Console.WriteLine("You messed up! All Tamagocis are dead! Do you want to retry?");
                    string retry = Console.ReadLine().ToLower();
                    if (retry == "yes")
                    {
                        players = CreateNew(players);
                        Console.Clear();
                    }
                    else
                    {
                        playing = false;
                    }
                }
            }
        }
        foreach (Tamagochi item in players)
        {
            item.PrintStats();
            for (int i = 0; i < players.Count - 1; i++)
            {
                Console.WriteLine("");
            }
        }
        Console.WriteLine("Game Over!");
        Console.ReadLine();
    }
    //Breed a Tamagochi
    static List<Tamagochi> CreateNew(List<Tamagochi> tamagochis)
    {
        Tamagochi tamagochi = new Tamagochi();
        if (tamagochis.Count > 0)
        {
            Console.WriteLine("What should your new Tamagochi be called?");
        }
        else
        {
            Console.WriteLine("What should your Tamagochi be called?");
        }
        tamagochi.name = Console.ReadLine();
        if (tamagochi.name == "")
        {
            tamagochi.name = "None";
        }
        Console.WriteLine("Your Tamagochi's name is: " + tamagochi.name);
        tamagochis.Add(tamagochi);
        return tamagochis;
    }
}