using System;

/// <summary>
/// Custom Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if object is an instance of, or an instance of a class
    /// that inherited from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}