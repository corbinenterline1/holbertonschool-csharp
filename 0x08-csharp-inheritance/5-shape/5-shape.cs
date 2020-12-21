using System;


/// <summary>
/// Shape class. Shapely stuff.
/// </summary>
class Shape
{
    /// <summary>
    /// For now it throws a NotImplementedException with message.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}