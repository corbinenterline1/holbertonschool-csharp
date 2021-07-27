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

///<summary>Decoration class that inherits from Base, Interactive, and Breakable.</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>Is it a quest item?</summary>
    public bool isQuestItem;

    ///<summary>Durability.</summary>
    public int durability {get; set; }

    ///<summary>Decoration constructor.</summary>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.isQuestItem = isQuestItem;
        this.durability = durability;
    }
    
    ///<summary>Interact implementation.</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    ///<summary>Break implementation.</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);
    }
}