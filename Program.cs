﻿using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Transactions;

namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // I created an instance of the object Fundament so that i can call all the methods over to the main program
        Fundament fnd = new Fundament();
        // Called the "CheckOddOrEven" method over to program
        fnd.CheckOddOrEven(15);

        // Called the "GetAInterestingFact" method over to program
        string fact = fnd.GetAInterestingFact("Having Yasuo on your team statistically increases your chances of certain defeat and loss of LP.");
        
        Console.WriteLine(fact);

        // Called the "SumTwoNumbers" method over to programm
        fnd.SumTwoNumbers();

        // called the "SumTwoNumbersOfGivenType" method over to program
        fnd.SumTwoNumbersOfGivenType();

        // Olivers versjon / rettelse
        // Console.WriteLine($"the sum of 15 + 20 = {fnd.SumTwoNumbersOfGivenType(15,20)}");
        
        // Called the "PrintFibonnaciSeries" method over to program
        fnd.PrintFibonnaciSeries();

        string original = "hsart si ousaY";
        string reversed = fnd.ReverseString(original);

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Reversed: {reversed}");

        
    
        

        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

    }
    
}