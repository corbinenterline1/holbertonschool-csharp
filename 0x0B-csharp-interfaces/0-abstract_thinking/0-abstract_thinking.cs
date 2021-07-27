using System;

/// <summary>Abstract base class.</summary>
public abstract class Base
{
    public string name {get; set;}

    /// <summary>ToString override.</summary>
    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}