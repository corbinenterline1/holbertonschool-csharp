using System;

/// <summary>
/// Class MatrixMath for Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] retmat = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    retmat[i, j] = matrix[i, j] * scalar;
                }
            }
            return (retmat);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3 && matrix.GetLength(2) == 3)
        {
            double[,] retmat = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    retmat[i, j] = matrix[i, j] * scalar;
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