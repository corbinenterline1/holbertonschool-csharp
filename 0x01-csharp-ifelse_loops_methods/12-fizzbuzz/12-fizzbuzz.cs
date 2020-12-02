using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i < 101)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.Write("FizzBuzz");
            else if (i % 3 == 0)
                Console.Write("Fizz");
            else if (i % 5 == 0)
                Console.Write("Buzz");
            else
                Console.Write("{0}", i);
            if (i < 100)
                Console.Write(" ");
            else
                Console.Write("\n");
            i++;
        }
    }
}