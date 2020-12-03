using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row_l = myMatrix.GetLength(0);
        int col_l = myMatrix.GetLength(1);
        int[,] arr2d = new int[row_l, col_l];
        for (int i = 0; i < row_l; i++)
        {
            for (int j = 0; j < col_l; j++)
                arr2d[i, j] = myMatrix[i, j] * myMatrix[i, j];
        }
        return arr2d;
    }
}