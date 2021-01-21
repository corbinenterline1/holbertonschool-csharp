using System;

/// <summary>
/// Class VectorMath for Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector and a scalar, returns resulting vector.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            if (vector.Length == 2)
            {
                double[] retvect = new double[] {0, 0};
            }
            else
            {
                double[] retvect = new double[] {0, 0, 0};
            }
            for (int i = 0; i <= vector.Length - 1; i++)
            {
                retvect[i] = Math.Round((vector1[i] * scalar), 2);
            return (retvect);
        }
        }
        else
        {
            double[] retvect = new double[] {-1};
            return (retvect)
    }
}
