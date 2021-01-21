using System;

/// <summary>
/// Class VectorMath for Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add mushes* vectors together. *technical term
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return (Math.Round(((vector1[0] * vector2[0]) + (vector1[1] * vector2[1])), 2));
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return (Math.Round(((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2])), 2));
        }
        else
        {
            return (-1);
        }
    }
}