using System;

/// <summary> Queue class</summary>
class Queue<T>
{
    /// <summary> Returns generic class</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}