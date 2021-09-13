using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Tamagochi tamagochi = new Tamagochi();
        bool nameGiven = false;
        while (!nameGiven)
        {
            Console.WriteLine("What Is YOUR Tamagochi Called?");
            tamagochi.name = Console.ReadLine();

            if (tamagochi.name == "2")
            {
                Console.WriteLine("gay");
            }
        }
    }
}