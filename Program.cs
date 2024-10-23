﻿namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // I created an instance of the object Fundament so that i can call all the methods over to the main program
        Fundament fnd = new Fundament();
        // Called the "CheckOddOrEven" method over to program
        fnd.CheckOddOrEven(15);

        string fact = fnd.GetAInterestingFact("Having Yasuo on your team statistically increases your chances of certain defeat and loss of LP");
        
        Console.WriteLine(fact);
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

    }
    
}