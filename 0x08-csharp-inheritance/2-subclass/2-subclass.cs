using System;

/// <summary>
/// Custom Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if object is an instance of a class that inherits from the specified class.
    /// Must be a subclass, not an instance of the base class. Returns true or false.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
