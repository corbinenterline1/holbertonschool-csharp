using System;
class Program
{
    static void Main(string[] args)
    {
        for (char iterletter = 'a'; iterletter <= 'z'; iterletter++)
            if (iterletter != 'q' && iterletter != 'e')
                Console.Write(iterletter);
    }
}