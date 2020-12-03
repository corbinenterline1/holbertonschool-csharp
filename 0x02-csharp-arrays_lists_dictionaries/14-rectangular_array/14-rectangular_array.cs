using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr2d = new int[5, 5];
        for (int row = 0; row  < 5; row++)
        {
            for (int col = 0; col < 5; col++)
                Console.Write(string.Format("{0} ", arr2d[row, col]));
            Console.WriteLine();
        }
    }
}

