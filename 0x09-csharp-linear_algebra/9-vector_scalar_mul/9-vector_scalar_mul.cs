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
        if (vector.Length == 2)
        {
            double[] retvect = new double[] {0, 0};
            retvect[0] = Math.Round((vector[0] * scalar), 2);
            retvect[1] = Math.Round((vector[1] * scalar), 2);
            return (retvect);
        }
        else if (vector.Length == 3)
        {
            double[] retvect = new double[] {0, 0, 0};
            retvect[0] = Math.Round((vector[0] * scalar), 2);
            retvect[1] = Math.Round((vector[1] * scalar), 2);
            retvect[2] = Math.Round((vector[2] * scalar), 2);
            return (retvect);
        }
        else
        {
            double[] retvect = new double[] {-1};
            return (retvect);
        }
    }
}
