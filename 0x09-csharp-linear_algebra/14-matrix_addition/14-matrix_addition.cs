using System;

/// <summary>
/// Class MatrixMath for Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Add adds two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] retmat = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    retmat[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (retmat);
        }
        else if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
        {
            double[,] retmat = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    retmat[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (retmat);
        }
        else
        {
            double[,] retmat = new double[,] {{-1}};
            return (retmat);
        }
    }
}