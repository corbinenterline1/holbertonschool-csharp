using System;

///<summary>Player class.</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Player class constructor.</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }
    ///<summary>Prints health of player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    ///<summary>Method to calculate Player's damage taken.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        float newHp = hp - damage;
        ValidateHP(newHp);
        Console.WriteLine("{0} takes {1} damage!", name, damage);
    }

    ///<summary>Method to calculate Player's health restored.</summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0f)
            heal = 0f;
        float newHp = hp + heal;
        ValidateHP(newHp);
        Console.WriteLine("{0} heals {1} HP!", name, heal);
    }

    ///<summary>Method to validate the HP of the player.  HP can't be below 0 or above maxHp.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp >= maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    ///<summary>Method to apply the modifier.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);
        else if (modifier == Modifier.Base)
            return (baseValue);
        else
            return (baseValue * 1.5f);
    }
}

///<summary>Value Modifier.</summary>
public enum Modifier
{
    ///<summary>Half of base value.</summary>
    Weak,
    ///<summary>Base value.</summary>
    Base,
    ///<summary>1.5 times base value.</summary>
    Strong
}

///<summary>Delegate to calculate Player's health.</summary>
public delegate void CalculateHealth(float damage);

///<summary>Delegate to calculate Modifier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);