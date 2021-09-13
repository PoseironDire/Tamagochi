using System;
using System.Collections.Generic;

public class Tamagochi
{
    //Tamagochi's Hunger Meter
    public int hunger;
    //Tamagochi's Hunger Meter
    public int boredom;
    //Tamagochi's Name 
    public string name;
    //Tamagochi's Words
    public List<string> words = new List<string>();
    public Random generator = new Random();
    //Tamagochi Dead or Alive?
    public bool isAlive;

    // Increase Hunger & Boredom by 1 each Tick, & If Any them reach over 10 isALive = false
    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger >= 10 || boredom >= 10)
        {
            isAlive = false;
        }
    }

    //Decreases Hunger By 1
    public void Feed()
    {
        hunger--;
    }

    // skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
    public void Hi()
    {

    }

    // lägger till ett ord i words, och anropar ReduceBoredom.
    public void Teach(string word)
    {

    }

    // skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
    public void PrintStats()
    {

    }

    // returnerar värdet som isAlive har.
    public void GetAlive()
    {

    }

    //Decreases boredom.
    public void ReduceBoredom()
    {
        boredom--;
    }
}