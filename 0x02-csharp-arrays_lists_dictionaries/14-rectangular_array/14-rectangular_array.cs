using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr2d = new int[5, 5]{
                                        {0, 0, 0, 0, 0},
                                        {0, 0, 0, 0, 0},
                                        {0, 0, 1, 0, 0},
                                        {0, 0, 0, 0, 0},
                                        {0, 0, 0, 0, 0}

                                    };
        int row_l = arr2d.GetLength(0);
        int col_l = arr2d.GetLength(1);
        for (int row = 0; row  < row_l; row++)
        {
            for (int col = 0; col < col_l; col++)
                Console.Write(string.Format("{0} ", arr2d[row, col]));
            Console.WriteLine();
        }
    }
}

