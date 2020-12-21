using System;

/// <summary>
/// Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if object is an Int.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        return false;
    }
}
