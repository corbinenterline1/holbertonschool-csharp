using System;

/// <summary>Abstract base class.</summary>
public abstract class Base
{
    ///<summary>Base class name.</summary>
    public string name {get; set;}

    /// <summary>ToString override.</summary>
    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}

/// <summary>Interactive interface.</summary>
public interface IInteractive {
    /// <summary>Interact method.</summary>
    void Interact();
}

/// <summary>Breakable interface.</summary>
public interface IBreakable {
    ///<summary>Durability.</summary>
    int durability {get; set;}

    ///<summary>Break.</summary>
    void Break();
}

/// <summary>Collectable interface.</summary>
public interface ICollectable {
    ///<summary>Property showing whether an object is collected.</summary>
    bool isCollected {get; set;}

    ///<summary>Collect method.</summary>
    void Collect();
}

///<summary>Door class that inherits from Base and IInteractive.</summary>
public class Door : Base, IInteractive
{
    ///<summary>Door constructor.</summary>
    public Door(string d="Door")
    {
        this.name = d;
    }

    ///<summary>Interact method.</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}