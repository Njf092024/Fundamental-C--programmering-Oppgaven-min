public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
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
        throw new NotImplementedException();
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        throw new NotImplementedException();
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

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