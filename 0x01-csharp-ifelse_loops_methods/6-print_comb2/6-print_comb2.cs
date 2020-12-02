using System;
class Program
{
    static void Main(string[] args)
    {
        int tenz = 0;
        int onez = 1;
        while (tenz < 9)
        {
            while (onez <= 9 && tenz != 8)
            {  
                if (onez != tenz)
                    Console.Write("{0}{1}, ", tenz, onez);
                onez++;
            }
            tenz++;
            onez = tenz;
        }
        Console.WriteLine("{0}{1}", tenz - 1, onez);
    }
}