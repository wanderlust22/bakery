using System;
using System.Collections.Generic;
using System.Threading;
using Bakery;

class Program
{
    static void Main()
    {
            
        Console.WriteLine("Bon jour! I am Pierre, welcome to my bakery monsieur and madame.");
        Thread.Sleep(1000);
        Console.WriteLine("We have a lovely selection of bread and pastries to choose from.");
        Thread.Sleep(1500);
        Console.WriteLine("What will you be needing today? A loaf of bread is $5. And a Pastry is $2.");
        Thread.Sleep(2000);
        Console.WriteLine("The deals are as follows:");
        Thread.Sleep(1500);
        Console.WriteLine("If you buy two loaves of bread, you get the third one free!");
        Console.WriteLine("And it's buy 3 pastries for 5$!");
        Thread.Sleep(2000);
        Console.WriteLine("What can Pierre get for you today? How many loaves do you need?");
        string stringLoaves = Console.ReadLine();
        int loaves = int.Parse(stringLoaves);
        Console.WriteLine("Excellent. And how many pastries will you be needing?");
        string stringPastries = Console.ReadLine();
        int pastries = int.Parse(stringPastries);

        Bread breadOrder = new Bread(loaves, 5);
        Pastry pastryOrder = new Pastry(pastries, 2);
       
        int total = breadOrder.GetBreadPrice() + pastryOrder.GetPastryPrice();
        Console.WriteLine("You are Pierre's favorite customer! You owe me $" + breadOrder.GetBreadPrice() + " for your loaves of bread, and $" + pastryOrder.GetPastryPrice() + " for your pastries. Your total comes to $" + total + " See you soon!" );
        
    }
}