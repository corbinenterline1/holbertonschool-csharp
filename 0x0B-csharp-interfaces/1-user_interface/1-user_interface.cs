using System;

/// <summary>Abstract base class.</summary>
abstract class Base
{
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

///<summary>TestObject class that inherits from Base and all 3 interfaces.</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable {
    ///<summary>Durability.</summary>
    public int durability {get; set; }
    ///<summary>Property showing whether an object is collected.</summary>
    public bool isCollected {get; set; }   
    ///<summary>Interact method.</summary>
    public void Interact() {}
    ///<summary>Break.</summary>
    public void Break() {}
    ///<summary>Collect method.</summary>
    public void Collect() {}
}