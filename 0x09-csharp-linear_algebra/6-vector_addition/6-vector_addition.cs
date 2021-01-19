using System;

/// <summary>
/// Class VectorMath for Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add mushes* vectors together. *technical term
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] retvect = new double[] {0, 0};
            retvect[0] = Math.Round((vector1[0] + vector2[0]), 2);
            retvect[1] = Math.Round((vector1[1] + vector2[1]), 2);
            return (retvect);
        }
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] retvect = new double[] {0, 0, 0};
            retvect[0] = Math.Round((vector1[0] + vector2[0]), 2);
            retvect[1] = Math.Round((vector1[1] + vector2[1]), 2);
            retvect[2] = Math.Round((vector1[2] + vector2[2]), 2);
            return (retvect);
        }
        double[] retvect = new double[] {-1};
        return (retvect);
    }
}