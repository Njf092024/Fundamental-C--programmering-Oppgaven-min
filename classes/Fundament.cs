public class Fundament : IFundament
{
    public void CheckOddOrEven(double a = 10)
    {
        // Checking if "a" aka the number is divisble by 2 to see if its even
        if (a % 2 == 0)
        {
            // if the condition is true, "a" will be printed as even
            Console.WriteLine($"{a} is even.");
        }
        else
        {
            // If the condition is false, meaning its not divisble by 2, 'a' will be printed as odd
            Console.WriteLine($"{a} is odd.");
        }
    }

    public string GetAInterestingFact(string fact)
    {
        // Returns the string "interesting fact:" along with whatever fact the user provided
        return $"Interesting fact: {fact}";
    }

    public void SumTwoNumbers()
    {
        // Pretty self-explanatory, i did what the name of the method suggests which is to take two numbers and sum it
        int a = 5;
        int b = 10;
        int sum = a + b;
        
        //  Printing out the result to the console
        Console.WriteLine($"sum of {a} and {b} is: {sum}");
    }


    public double SumTwoNumbersOfGivenType(double a = 15, double b = 20)
    {
        // Hadde aldri klart dinna uten energidrikken min.. tok altfor lang tid
        double sum = a + b;
        Console.WriteLine($"sum of {a} and {b} is: {sum}");
        // I took the already established numbers "a and b", added them together and returned the result
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        // int a = 0;
        // int b = 1;
        // int c;

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        return "";
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}