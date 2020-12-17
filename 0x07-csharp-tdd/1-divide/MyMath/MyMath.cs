using System;

namespace MyMath
{
    /// <summary>
    /// Class containing methods pertaining to matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix.
        /// </summary>
        public static int[,]  Divide(int[,] matrix, int num)
        {
            try
            {
                int x = matrix.GetLength(0);
                int y = matrix.GetLength(1);
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}
