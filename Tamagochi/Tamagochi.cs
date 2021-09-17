using System;
using System.Collections.Generic;

public class Tamagochi
{
    //Tamagochi's Hunger Meter
    public int hunger = 0;
    //Tamagochi's Hunger Meter
    public int boredom = 0;
    //Tamagochi's Name 
    public string name = "";
    //Tamagochi's Words
    public List<string> words = new List<string>();
    public Random generator = new Random();
    //Tamagochi Dead or Alive
    bool isAlive = true;

    // Increase Hunger & Boredom by 1 each Tick, & If Any them reach over 10 isALive = false
    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    //Decreases Hunger By 1
    public void Feed()
    {
        hunger--;
        Console.WriteLine(name + " was fed!");
    }

    //Decreases boredom by 1.
    public void ReduceBoredom()
    {
        boredom -= 1;
    }

    // Writes a random word from words, & runs ReduceBoredom.
    public void Hi()
    {
        int randomWord = generator.Next(words.Count);
        if (words.Count != 0)
        {
            Console.WriteLine(words[randomWord]);
        }
        else
        {
            System.Console.WriteLine(name + " doesn't know how to speak!");
        }
        ReduceBoredom();
    }

    // Add a word to words, & runs ReduceBoredom.
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    // skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
    public void PrintStats()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(name + "'s Status:");
        if (hunger >= 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (hunger == 10)
            {
                Console.WriteLine(name + " is Starving!");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.WriteLine("Hunger: " + hunger);
        if (boredom >= 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (boredom == 10)
            {
                Console.WriteLine(name + " is Depressed!");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.WriteLine("Boredom: " + boredom);
        Console.ForegroundColor = ConsoleColor.White;
    }
    // returnerar värdet som isAlive har.
    public bool GetAlive()
    {
        return isAlive;
    }
}