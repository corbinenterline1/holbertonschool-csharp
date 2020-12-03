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
            {
                if (row == 2 && col == 2)
                    arr2d[row, col] = 1;
                else
                    arr2d[row, col] = 0;
                
                if (col == 4)
                    Console.Write(string.Format("{0}", arr2d[row, col]));
                else
                    Console.Write(string.Format("{0} ", arr2d[row, col]));
            }
            Console.WriteLine();
        }
    }
}

