﻿﻿namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        Fundament fnd = new Fundament();
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

    }
    
}